using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class CompleteSequencesForm : Form
    {
        private Random random = new Random();
        private int start, step, missing1, missing2;
        private System.Windows.Forms.Timer colorResetTimer;
        private User currentUser;
        private UserManager userManager;

        public CompleteSequencesForm(User user, UserManager userManager)
        {
            InitializeComponent();
            InitializeTimer();
            currentUser = user;
            this.userManager = userManager;
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
        }

        private void trfl_Click(object sender, EventArgs e)
        {
        }

        private void CompleteSequencesForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void InitializeTimer()
        {
            colorResetTimer = new System.Windows.Forms.Timer();
            colorResetTimer.Interval = 1200; // 1.2 seconds
            colorResetTimer.Tick += ColorResetTimer_Tick;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void ColorResetTimer_Tick(object sender, EventArgs e)
        {
            trfl.BackColor = System.Drawing.Color.White;
            colorResetTimer.Stop();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int number1, number2;
            bool isNumber1Valid = int.TryParse(txtNumber1.Text, out number1);
            bool isNumber2Valid = int.TryParse(txtNumber2.Text, out number2);

            if (isNumber1Valid && isNumber2Valid && number1 == missing1 && number2 == missing2)
            {
                trfl.BackColor = System.Drawing.Color.Green;
                userManager.UpdateUserPoints(currentUser, 1);
            }
            else
            {
                trfl.BackColor = System.Drawing.Color.Red;
            }

            colorResetTimer.Start(); // Start the timer

            GenerateNewQuestion();
            txtNumber1.Clear();
            txtNumber2.Clear();
        }

        private void GenerateNewQuestion()
        {
            start = random.Next(1, 10);
            step = random.Next(2, 5);
            missing1 = start + step * 2;
            missing2 = start + step * 3;
            lblInstruction.Text = $"Complete the sequence: {start}, {start + step}, _, _, {start + step * 4}";
        }
    }
}
