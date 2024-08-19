using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;
using ExcelFuncs;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using CustomShape;
using WindowsFormsApp2;
using Learn_App; 
namespace WinFormsApp2
{
    public partial class RegisterForm : Form
    {
        private string excelFilePath = @"C:\Users\Malik\Desktop\sce_excel.xlsx";
        private UserManager userManager;

        public RegisterForm(UserManager userManager)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Customize.ApplyRoundCorners(this, 30);
            this.userManager = userManager;

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void Register_Click(object sender, EventArgs e)
        {
            DialogResult result = registerDialog.Show();
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (string.IsNullOrEmpty(usernameBox.Text) || string.IsNullOrEmpty(passwordBox.Text) || string.IsNullOrEmpty(emailBox.Text)
                    || string.IsNullOrEmpty(idBox.Text))

                    {
                        MessageBox.Show("All info should be provided!");
                        return;
                    }
                    String message = "";
                    message += ExcelFunctions.checkValidity(usernameBox.Text, passwordBox.Text, emailBox.Text, idBox.Text);


                    if (message != "")
                    {
                        MessageBox.Show(message, "Invalid Info", MessageBoxButtons.OK);
                        return;
                    }

                    userManager.RegisterUser(usernameBox.Text, passwordBox.Text, idBox.Text, emailBox.Text, maleButton.Checked ? "Male" : "Female");
                    this.Close();
                    WelcomeForm welcome = new WelcomeForm();
                    welcome.Show();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("An error occurred while saving to Excel.");
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.PasswordChar == '*')
            {
                ShowButton.Visible = false;
                HideButton.Visible = true;
                passwordBox.PasswordChar = '\0';
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.PasswordChar == '\0')
            {
                HideButton.Visible = false;
                ShowButton.Visible = true;
                passwordBox.PasswordChar = '*';
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = closeDialog.Show();
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = returnDialog.Show();

            if (result == DialogResult.Yes)
            {
                WelcomeForm welcomeForm = new WelcomeForm();
                this.Hide();


                welcomeForm.Show();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
