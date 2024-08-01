using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelFuncs;
using System.Drawing.Drawing2D;
using CustomShape;
using Learn_App;
using WinFormsApp2;
using Microsoft.VisualBasic.ApplicationServices;
using DocumentFormat.OpenXml.Spreadsheet;
namespace WindowsFormsApp2

{


    public partial class WelcomeForm : Form
    {
        private UserManager userManager = new UserManager();

        private const int CornerRadius = 30;

        public WelcomeForm()
        {
            InitializeComponent();
            Customize.ApplyRoundCorners(this, 30);

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;




        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, CornerRadius, CornerRadius), 180, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, 0, CornerRadius, CornerRadius), 270, 90);
            path.AddArc(new Rectangle(this.Width - CornerRadius, this.Height - CornerRadius, CornerRadius, CornerRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - CornerRadius, CornerRadius, CornerRadius), 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            using (Pen pen = new Pen(System.Drawing.Color.DarkBlue, 1.0f))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private void showButton_Click(object sender, EventArgs e) //VisibleButton
        {
            if (passwordBox.PasswordChar == '*')
            {
                ShowButton.Visible = false;
                HideButton.Visible = true;
                passwordBox.PasswordChar = '\0';
                Console.WriteLine("showButton.");
            }
        }
        private void hideButton_Click(object sender, EventArgs e) //HiddenButton
        {
            if (passwordBox.PasswordChar == '\0')
            {
                HideButton.Visible = false;
                ShowButton.Visible = true;
                passwordBox.PasswordChar = '*';
                Console.WriteLine("hideButton.");

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async void Login_Click(object sender, EventArgs e)
        {

            if (ExcelFunctions.SearchInExcel(usernameBox.Text, passwordBox.Text))
            {
                ExcelFunctions.SaveLoginState(usernameBox.Text, true);
                Learn_App.User user = userManager.AuthenticateUser(usernameBox.Text, passwordBox.Text);
                this.Hide();
                await Task.Delay(1000);
                var form = new MainPage(user, userManager);
                form.Show();
            }
            else
            {
                MessageBox.Show("Login failed!");

            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(userManager);
            registerForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
