using System;
using System.Linq; // Add this line
using System.Windows.Forms;

namespace Learn_App
{
    public partial class UbdatePr : Form
    {
        private User currentUser;
        private UserManager userManager;

        public UbdatePr(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user; // Initialize currentUser first
            this.userManager = userManager;
        }

        private void UbdatePr_Load(object sender, EventArgs e)
        {
            // Load current user information if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // If needed, handle label2 click event here
        }

        private void BN_Click(object sender, EventArgs e)
        {
            string newName = txtN.Text; // Corrected from txtE to txtN
            if (ValidateUsername(newName))
            {
                currentUser.Username = newName;
                userManager.SaveAllUsers();
                MessageBox.Show("Profile updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid name (6-8 characters, alphanumeric, max 2 digits).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BE_Click(object sender, EventArgs e)
        {
            string newEmail = txtE.Text;
            if (!string.IsNullOrEmpty(newEmail))
            {
                currentUser.Email = newEmail;
                userManager.SaveAllUsers();
                MessageBox.Show("Profile updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BP_Click(object sender, EventArgs e)
        {
            string newPassword = txtP.Text; // Corrected from commented code
            if (ValidatePassword(newPassword))
            {
                currentUser.Password = newPassword;
                userManager.SaveAllUsers();
                MessageBox.Show("Profile updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid password (8-10 characters, including letters, digits, and special characters).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new ProfilePage(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private bool ValidateUsername(string username)
        {
            return username.Length >= 6 && username.Length <= 8 &&
                   username.All(char.IsLetterOrDigit) && username.Count(char.IsDigit) <= 2;
        }

        private bool ValidatePassword(string password)
        {
            return password.Length >= 8 && password.Length <= 10 &&
                   password.Any(char.IsLetter) && password.Any(char.IsDigit) &&
                   password.Any(c => "!#$".Contains(c));
        }
    }
}
