using Learn_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class EnglishForm : Form
    {
        private User currentUser;
        private UserManager userManager;
        public EnglishForm(User user, UserManager userManager)
        {
            currentUser = user;
            this.userManager = userManager;
            InitializeComponent();
        }

        private void English_Load(object sender, EventArgs e)
        {

        }
        private void letterOrder_Click(object sender, EventArgs e)
        {
            spellLetters form = new spellLetters(currentUser, userManager);
            form.Show();

        }
        private void letterMatch_Click(object sender, EventArgs e)
        {
            MatchingLetters form = new MatchingLetters(currentUser, userManager);
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
