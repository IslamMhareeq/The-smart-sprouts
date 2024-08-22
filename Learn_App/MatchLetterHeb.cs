using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class MatchLetterHeb : Form
    {
        private User currentUser;
        private UserManager userManager;
        int score = 0;

        public MatchLetterHeb(User user, UserManager userManager)
        {

            InitializeComponent();
            currentUser = user ?? throw new ArgumentNullException(nameof(user)); // Ensure non-null user
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager)); // Ensure non-null userManager

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            userManager.UpdateUserPoints(currentUser, score);
            var form = new HebrewGames(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCharacter.Location = GetNewPoint();
            lblCharacter.Text = GetRandomCharacter().ToString();
            gameTimer.Start();
            btnStart.Enabled = false;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            lblCharacter.Top += 5;

            if (lblCharacter.Top >= gamePanel.Height)
            {
                // Character has passed the bottom of the panel without user input
                ResetCharacterPosition();
                score = Math.Max(0, score - 1); // Deduct score but ensure it doesn't go below 0
                UpdateScore();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char userPress = e.KeyChar;

            if (userPress.ToString() == lblCharacter.Text)
            {
                score += 1;
            }
            else
            {
                score = Math.Max(0, score - 1); // Deduct score but ensure it doesn't go below 0
            }

            ResetCharacterPosition();
            UpdateScore();
        }

        private Point GetNewPoint()
        {
            Random xLocation = new Random();
            int x = xLocation.Next(0, gamePanel.Width - lblCharacter.Width);
            return new Point(x, 0);
        }

        private char GetRandomCharacter()
        {
            Random randomCharacter = new Random();
            return (char)randomCharacter.Next(0x05D0, 0x05EA + 1); // Hebrew letters range
        }

        private void ResetCharacterPosition()
        {
            lblCharacter.Location = GetNewPoint();
            lblCharacter.Text = GetRandomCharacter().ToString();
        }

        private void UpdateScore()
        {
            lblScore.Text = "Score: " + score.ToString();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

       
    }
}
