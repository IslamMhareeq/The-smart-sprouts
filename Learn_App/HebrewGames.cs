﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class HebrewGames : Form
    {
        private User currentUser;
        private UserManager userManager;
        public HebrewGames(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userManager = userManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new MatchLetterHeb(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new Hebrew(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
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
