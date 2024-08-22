using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class AdditionForm : Form
    {
        private System.Windows.Forms.Timer colorResetTimer = new System.Windows.Forms.Timer(); // Initialize here
        private Random random = new Random();
        private int number1;
        private int number2;
        private User currentUser;
        private UserManager userManager;

        public AdditionForm(User user, UserManager userManager)
        {
            InitializeComponent();
            InitializeTimer();
            currentUser = user ?? throw new ArgumentNullException(nameof(user));
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        private void AdditionForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void InitializeTimer()
        {
            colorResetTimer.Interval = 1200; // 1.2 seconds
            colorResetTimer.Tick += ColorResetTimer_Tick;
        }

        private void ColorResetTimer_Tick(object sender, EventArgs e) // Match signature with EventHandler
        {
            trfl.BackColor = System.Drawing.Color.White;
            colorResetTimer.Stop();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int answer;
            if (int.TryParse(txtAnswer.Text, out answer) && answer == number1 + number2)
            {
                trfl.BackColor = System.Drawing.Color.Green;
                userManager.UpdateUserPoints(currentUser, 1);
                GenerateNewQuestion();
            }
            else
            {
                trfl.BackColor = System.Drawing.Color.Red;
                GenerateNewQuestion();
            }

            colorResetTimer.Start(); // Start the timer
            txtAnswer.Clear();
        }

        private void GenerateNewQuestion()
        {
            number1 = random.Next(1, 21); // Generates a number between 1 and 20
            number2 = random.Next(1, 21); // Generates a number between 1 and 20
            lblQuestion.Text = $"What is {number1} + {number2}?";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            // Optional: Enable the submit button only if input is not empty
            btnSubmit.Enabled = !string.IsNullOrWhiteSpace(txtAnswer.Text);
        }

        private void trfl_Click(object sender, EventArgs e)
        {
            // If needed, handle trfl click event here
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                colorResetTimer?.Dispose(); // Properly dispose of the timer
            }
            base.Dispose(disposing);
        }
    }
}
