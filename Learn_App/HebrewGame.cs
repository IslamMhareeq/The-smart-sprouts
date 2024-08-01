using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class Hebrew : Form
    {
        private User currentUser;
        private UserManager userManager;
        private int index = 0;
        private int score = 0;
        private Random random = new Random();
        private System.Windows.Forms.Timer colorResetTimer = new System.Windows.Forms.Timer(); // Initialize here
        private string[] words = {
            "שלום", "תודה", "כן", "לא", "בבקשה", "אהבה", "משפחה",
            "חבר", "חברה", "בית", "ספר", "ילד", "ילדה", "אוכל", "מים"
        };
        private System.ComponentModel.IContainer? components = null; // Allow null for initialization

        public Hebrew(User user, UserManager userManager)
        {
            InitializeComponent();
            InitializeTimer();
            label_word.RightToLeft = RightToLeft.Yes;
            textBox1_Guess.RightToLeft = RightToLeft.Yes;
            label_result.RightToLeft = RightToLeft.Yes;
            label_score.RightToLeft = RightToLeft.Yes;
            currentUser = user ?? throw new ArgumentNullException(nameof(user)); // Ensure non-null user
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager)); // Ensure non-null userManager
        }

        private void Hebrew_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void InitializeTimer()
        {
            colorResetTimer.Interval = 1200; // 1.2 seconds
            colorResetTimer.Tick += ColorResetTimer_Tick;
        }

        private void ColorResetTimer_Tick(object? sender, EventArgs e) // Mark sender as nullable
        {
            label_result.BackColor = Color.White;
            colorResetTimer.Stop();
        }

        private void button2_start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button1_next_Click(object sender, EventArgs e)
        {
            CheckWord();
            if (index < words.Length - 1)
            {
                index++;
                DisplayWord();
            }
            else
            {
                EndGame();
            }
        }

        private void StartGame()
        {
            index = 0;
            score = 0;
            label_result.BackColor = Color.Peru;
            label_score.Text = "00";
            DisplayWord();
            button1_next.Enabled = true;
            button2_start.Enabled = false;
        }

        private void DisplayWord()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);

            string word = words[index];
            word = word.Remove(pos1, 1).Insert(pos1, "_ ");
            word = word.Remove(pos2, 1).Insert(pos2, "_ ");
            word = word.Remove(pos3, 1).Insert(pos3, "_ ");

            label_word.Text = word;
        }

        private void CheckWord()
        {
            if (textBox1_Guess.Text.Equals(words[index], StringComparison.OrdinalIgnoreCase))
            {
                label_result.Text = "נכון";
                label_result.BackColor = Color.Green;
                score++;
                userManager.UpdateUserPoints(currentUser, 1);
            }
            else
            {
                label_result.Text = "לא נכון";
                label_result.BackColor = Color.Red;
            }
            textBox1_Guess.Clear();
            label_score.Text = $"{score} / {words.Length}";

            colorResetTimer.Start();
        }

        private void EndGame()
        {
            label_result.Text = "Game Over!";
            label_result.BackColor = Color.Blue;
            button2_start.Enabled = true;
            button1_next.Enabled = false;
        }

        private void textBox1_Guess_TextChanged(object sender, EventArgs e)
        {
            button1_next.Enabled = !string.IsNullOrWhiteSpace(textBox1_Guess.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser, userManager);
            this.Hide();
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

        private void label_word_Click(object sender, EventArgs e)
        {
        }

        private void label_result_Click(object sender, EventArgs e)
        {
        }

        private void label_score_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
