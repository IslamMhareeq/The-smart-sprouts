using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_App
{

    public partial class Store : Form
    {
        private User currentUser;
        private UserManager userManager;
        public Store(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userManager = userManager;
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }
    }
}
