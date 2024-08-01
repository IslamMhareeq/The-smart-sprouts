using System;
using System.Linq;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class WriteNumbersInOrderForm : Form
    {
        private Random random = new Random();
        private int[] shuffledNumbers;
        private System.Windows.Forms.Timer colorResetTimer = new System.Windows.Forms.Timer(); // Initialize here
        private User currentUser;
        private UserManager userManager;

        public WriteNumbersInOrderForm(User user, UserManager userManager)
        {
            InitializeComponent();
            InitializeTimer();
            currentUser = user ?? throw new ArgumentNullException(nameof(user));
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        private void WriteNumbersInOrderForm_Load(object sender, EventArgs e)
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
            string[] inputNumbers = txtNumbers.Text.Split(' ');
            bool isCorrect = inputNumbers.Length == shuffledNumbers.Length &&
                             inputNumbers.Select(int.Parse).SequenceEqual(shuffledNumbers.OrderBy(n => n));

            if (isCorrect)
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
            txtNumbers.Clear();
        }

        private void GenerateNewQuestion()
        {
            int start = random.Next(1, 20);
            int count = random.Next(5, 11); // Generates a count between 5 and 10
            shuffledNumbers = Enumerable.Range(start, count).OrderBy(x => random.Next()).ToArray();
            lblInstruction.Text = $"Arrange these numbers in ascending order: {string.Join(" ", shuffledNumbers)}";
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {
        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {
        }

        private void trfl_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MathGames(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
