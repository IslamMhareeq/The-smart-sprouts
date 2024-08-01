using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;

namespace Learn_App
{
    public class UserManager
    {
        private readonly string filePath = "users.xlsx";
        private readonly List<User> users;

        public UserManager()
        {
            users = LoadUsers();
        }

        // Save all users to file
        public void SaveAllUsers()
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Users");
                    worksheet.Cell(1, 1).Value = "Username";
                    worksheet.Cell(1, 2).Value = "Password";
                    worksheet.Cell(1, 3).Value = "ID";
                    worksheet.Cell(1, 4).Value = "Email";
                    worksheet.Cell(1, 5).Value = "Gender";
                    worksheet.Cell(1, 6).Value = "Points";

                    for (int i = 0; i < users.Count; i++)
                    {
                        worksheet.Cell(i + 2, 1).Value = users[i].Username;
                        worksheet.Cell(i + 2, 2).Value = users[i].Password;
                        worksheet.Cell(i + 2, 3).Value = users[i].ID;
                        worksheet.Cell(i + 2, 4).Value = users[i].Email;
                        worksheet.Cell(i + 2, 5).Value = users[i].Gender;
                        worksheet.Cell(i + 2, 6).Value = users[i].Points;
                    }

                    workbook.SaveAs(filePath);
                }
            }
            catch (IOException ex)
            {
                // Log the exception (implementation depends on your logging framework)
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        // Load users from file
        private List<User> LoadUsers()
        {
            List<User> loadedUsers = new List<User>();
            if (File.Exists(filePath))
            {
                try
                {
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet("Users");
                        var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Skip header row

                        foreach (var row in rows)
                        {
                            string username = row.Cell(1).GetValue<string>();
                            string password = row.Cell(2).GetValue<string>();
                            string id = row.Cell(3).GetValue<string>();
                            string email = row.Cell(4).GetValue<string>();
                            string gender = row.Cell(5).GetValue<string>();
                            int points = row.Cell(6).GetValue<int>();

                            User user = new User(username, password, id, email, gender, points);
                            loadedUsers.Add(user);
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Log the exception (implementation depends on your logging framework)
                    Console.WriteLine("Error reading from file: " + ex.Message);
                }
            }
            return loadedUsers;
        }

        // Register a new user
        public void RegisterUser(string username, string password, string id, string email, string gender = null, int points = 0)
        {
            ValidateUsername(username);
            ValidatePassword(password);
            ValidateId(id);
            ValidateEmail(email);
            ValidateGender(gender);

            // Check if user already exists
            if (users.Any(u => u.Username == username))
            {
                throw new ArgumentException("Username already exists");
            }

            // Save the new user
            User newUser = new User(username, password, id, email, gender, points);
            users.Add(newUser);
            SaveAllUsers();
        }

        private void ValidateUsername(string username)
        {
            if (username.Length < 6 || username.Length > 8 || !username.All(char.IsLetterOrDigit) || username.Count(char.IsDigit) > 2)
            {
                throw new ArgumentException("Invalid username");
            }
        }

        private void ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 10 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit) || !password.Any(c => "!#$".Contains(c)))
            {
                throw new ArgumentException("Invalid password");
            }
        }

        private void ValidateId(string id)
        {
            if (id.Length != 9)
            {
                throw new ArgumentException("Invalid ID");
            }
        }

        private void ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Invalid email");
            }
        }

        private void ValidateGender(string gender)
        {
            if (!string.IsNullOrEmpty(gender) && gender != "Male" && gender != "Female" )
            {
                throw new ArgumentException("Invalid gender");
            }
        }

        // Authenticate an existing user
        public User AuthenticateUser(string username, string password)
        {
            // Check if the user exists based on the username
            User user = users.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username");
            }
            if (!user.VerifyPassword(password))
            {
                throw new UnauthorizedAccessException("Invalid password");
            }

            return user;
        }

        // Update user's points
        public void UpdateUserPoints(User user, int pointsToAdd)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                existingUser.Points += pointsToAdd;
                SaveAllUsers();
            }
        }

        // Update user details
        public void UpdateUser(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Username == user.Username);
            if (existingUser != null)
            {
                existingUser.Password = user.Password;
                existingUser.Email = user.Email;
                existingUser.Gender = user.Gender;
                existingUser.Points = user.Points;
                SaveAllUsers();
            }
        }


    }
}
