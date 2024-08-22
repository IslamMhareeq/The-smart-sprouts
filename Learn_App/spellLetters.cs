using Learn_App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class spellLetters : Form
    {
        private User currentUser;
        private UserManager userManager;
        private Random random = new Random();
        private string currentQuestion;
        private string correctAnswer;
        private List<string> wrongAnswers = new List<string>();

        public spellLetters(User user, UserManager userManager)
        {
            currentUser = user;
            this.userManager = userManager;
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            GenerateRandomQuestion();
        }

        private void GenerateRandomQuestion()
        {
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(GenerateRandomQuestion));
                    return;
                }

                char start = (char)random.Next('A', 'Z');
                char end;

                // Ensure end is always greater than start
                do
                {
                    end = (char)random.Next(start + 1, 'Z' + 1); // Start from start+1 to ensure a valid range
                } while (end <= start);

                char[] sequence = Enumerable.Range(start, end - start + 1)
                                            .Select(i => (char)i)
                                            .ToArray();
                correctAnswer = new string(sequence);

                currentQuestion = $"{start} - {end}";
                questionLetter.Text = $"Spell the letters in order: {currentQuestion}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the question: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Exception: {ex}");
            }
        }



        private string GenerateRandomSequence(int length)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] sequence = new char[length];

            for (int i = 0; i < length; i++)
            {
                sequence[i] = letters[random.Next(letters.Length)];
            }

            Array.Sort(sequence);
            return new string(sequence);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userAnswer = userInputTextBox.Text;
            Debug.WriteLine(userAnswer);
            Debug.WriteLine(correctAnswer);

            if (userAnswer.ToLower() == correctAnswer.ToLower())
            {
                userManager.UpdateUserPoints(currentUser, 1);
                guna2MessageDialog1.Show();
                userInputTextBox.Clear();
                GenerateRandomQuestion();
            }
            else
            {
                guna2MessageDialog2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                userInputTextBox.Clear();
                GenerateRandomQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Exception: {ex}");
            }
        }


        private void userInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new EnglishForm(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void spellLetters_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
