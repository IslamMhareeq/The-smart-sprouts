﻿using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class SubtractionForm : Form
    {
        private Random random = new Random();
        private int number1;
        private int number2;
        private System.Windows.Forms.Timer colorResetTimer = new System.Windows.Forms.Timer(); // Initialize here
        private User currentUser;
        private UserManager userManager;

        public SubtractionForm(User user, UserManager userManager)
        {
            InitializeComponent();
            InitializeTimer();
            currentUser = user ?? throw new ArgumentNullException(nameof(user));
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
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

        private void SubtractionForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {

            int answer;
            if (int.TryParse(txtAnswer.Text, out answer) && answer == number1 - number2)
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
            txtAnswer.Clear();
        }

        private void GenerateNewQuestion()
        {
            number1 = random.Next(1, 21); // Generates a number between 1 and 20
            number2 = random.Next(1, number1 + 1); // Generates a number between 1 and number1
            lblQuestion.Text = $"What is {number1} - {number2}?";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
        }

        private void SubtractionForm_Load_1(object sender, EventArgs e)
        {
        }

        private void trfl_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
