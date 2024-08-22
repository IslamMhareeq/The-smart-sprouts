using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class MathGames : Form
    {
        private User currentUser;
        private UserManager userManager;
        public MathGames(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userManager = userManager;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        private void BtnGameA_Click(object sender, EventArgs e)
        {
            var form = new WriteNumbersInOrderForm(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void BtnGameB_Click(object sender, EventArgs e)
        {
            var form = new CompleteSequencesForm(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void BtnGameC_Click(object sender, EventArgs e)
        {
            var form = new AdditionForm(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void BtnGameD_Click(object sender, EventArgs e)
        {
            var form = new SubtractionForm(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close(); ;
        }

        private void BtnGameE_Click(object sender, EventArgs e)
        {
            var form = new MultiplicationForm(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.Color.FromArgb(78, 180, 180); // Lighter yellow background color on hover
            button.FlatAppearance.BorderSize = 0; // Slight border on hover
            button.FlatAppearance.BorderColor = System.Drawing.Color.Black; // Border color on hover
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.Color.FromArgb(0, 180, 180); // Original yellow background color
            button.FlatAppearance.BorderSize = 0; // Remove border
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser,userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}