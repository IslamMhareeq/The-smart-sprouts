namespace Learn_App
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }

        // Constructor for new user
        public User(string username, string password, string id, string email, string gender = null, int points = 0)
        {
            Username = username;
            Password = password;
            ID = id;
            Email = email;
            Gender = gender;
            Points = points;
        }

        public bool VerifyPassword(string password)
        {
            return Password == password;
        }
    }
}
