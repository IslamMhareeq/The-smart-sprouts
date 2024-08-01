using Learn_App;

namespace WinFormsApp2
{
    public partial class MatchingLetters : Form
    {
        private Random random = new Random();
        private User currentUser;
        private UserManager userManager;
        private char smallLetter;
        private string selectedLetter;

        public MatchingLetters(User user, UserManager userManager)
        {
            currentUser = user;
            this.userManager = userManager;
            InitializeComponent();
            GenerateLetters();
        }

        private void GenerateLetters()
        {
            smallLetter = (char)random.Next('a', 'z' + 1);

            List<char> capitalLetters = new List<char>();
            while (capitalLetters.Count < 4)
            {
                char capitalLetter = (char)random.Next('A', 'Z' + 1);
                if (!capitalLetters.Contains(capitalLetter))
                {
                    capitalLetters.Add(capitalLetter);
                }
            }
            int replaceIndex = random.Next(0, capitalLetters.Count);
            capitalLetters[replaceIndex] = (char)(smallLetter - 'a' + 'A');

            capitalLetters = capitalLetters.OrderBy(x => random.Next()).ToList();

            aLetter.Text = capitalLetters[0].ToString();
            bLetter.Text = capitalLetters[1].ToString();
            cLetter.Text = capitalLetters[2].ToString();
            dLetter.Text = capitalLetters[3].ToString();

            questionLetter.Text = smallLetter.ToString();
            selectedLetter = null;
            Console.WriteLine($"Small Letter: {smallLetter}");
            Console.WriteLine("Capital Letters: " + string.Join(", ", capitalLetters));
            aLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            bLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            cLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            dLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateLetters();
            aLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            bLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            cLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            dLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedLetter))
            {
                guna2MessageDialog1.Show();
                return;
            }

            if (questionLetter.Text == selectedLetter.ToLower())
            {
                if (selectedLetter == aLetter.Text)
                {
                    userManager.UpdateUserPoints(currentUser, 1);
                    aLetter.BackColor = Color.Green;
                    bLetter.BackColor = Color.Red;
                    cLetter.BackColor = Color.Red;
                    dLetter.BackColor = Color.Red;

                }
                if (selectedLetter == bLetter.Text)
                {
                    userManager.UpdateUserPoints(currentUser, 1);
                    bLetter.BackColor = Color.Green;
                    aLetter.BackColor = Color.Red;
                    cLetter.BackColor = Color.Red;
                    dLetter.BackColor = Color.Red;

                }
                if (selectedLetter == cLetter.Text)
                {
                    userManager.UpdateUserPoints(currentUser, 1);
                    cLetter.BackColor = Color.Green;
                    aLetter.BackColor = Color.Red;
                    bLetter.BackColor = Color.Red;
                    dLetter.BackColor = Color.Red;

                }
                if (selectedLetter == dLetter.Text)
                {
                    userManager.UpdateUserPoints(currentUser, 1);
                    dLetter.BackColor = Color.Green;
                    aLetter.BackColor = Color.Red;
                    bLetter.BackColor = Color.Red;
                    cLetter.BackColor = Color.Red;

                }
                DialogResult r = guna2MessageDialog2.Show();
                if (r == DialogResult.OK)
                {
                    GenerateLetters();
                }
            }
            else
            {
                guna2MessageDialog1.Show();
            }
        }

        private void aLetter_Click(object sender, EventArgs e)
        {
            selectedLetter = aLetter.Text;
            HighlightSelectedButton(aLetter);
        }

        private void bLetter_Click(object sender, EventArgs e)
        {
            selectedLetter = bLetter.Text;
            HighlightSelectedButton(bLetter);
        }

        private void cLetter_Click(object sender, EventArgs e)
        {
            selectedLetter = cLetter.Text;
            HighlightSelectedButton(cLetter);
        }

        private void dLetter_Click(object sender, EventArgs e)
        {
            selectedLetter = dLetter.Text;
            HighlightSelectedButton(dLetter);
        }

        private void HighlightSelectedButton(Button selectedButton)
        {
            // Reset the appearance of all buttons
            aLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            bLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            cLetter.BackColor = Color.FromKnownColor(KnownColor.Control);
            dLetter.BackColor = Color.FromKnownColor(KnownColor.Control);

            // Highlight the selected button
            selectedButton.BackColor = Color.LightBlue; // Example highlight color
        }

        private void MatchingLetters_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new EnglishForm(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
