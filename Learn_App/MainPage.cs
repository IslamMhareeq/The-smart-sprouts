using ExcelFuncs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using WinFormsApp2;

namespace Learn_App
{
    public partial class MainPage : Form
    {
        private User currentUser;
        private UserManager userManager;

        public MainPage(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userManager = userManager;
            DisplayUserName();

        }

        private void DisplayUserName()
        {
            labelLibrary.Text = $"Welcome, {currentUser.Username}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser,userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Hebrew(currentUser,userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();

        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            var form = new EnglishForm(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(78, 180, 180);
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = Color.FromArgb(0, 180, 180);
                button.FlatAppearance.BorderSize = 0;
            }
        }

        private bool sidex = false;
        private void sidebartran_Tick(object sender, EventArgs e)
        {
            if (sidex)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width <= 0)
                {
                    sidex = false;
                    sidebartran.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width >= 322)
                {
                    sidex = true;
                    sidebartran.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartran.Start();
        }

        private void labelLibrary_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Logged in user: {currentUser.Username}");
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            var form = new WelcomeForm();
            ExcelFunctions.SaveLoginState(currentUser.Username, false);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            sidebartran.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser,userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void MainP_Load(object sender, EventArgs e)
        {
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            var form = new ProfilePage(currentUser,userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var form = new Store(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }


        private void label2_Click_1(object sender, EventArgs e)
        {
            var form = new WelcomeForm();
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}