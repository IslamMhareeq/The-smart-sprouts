﻿using System;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class ProfilePage : Form
    {
        private User currentUser;
        private UserManager userManager;

        public ProfilePage(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user; // Initialize currentUser first
            this.userManager = userManager;
            DisplayUserName();
            DisplayPurchasedItems();
        }

        private void DisplayUserName()
        {
            label1.Text = $"Username: {currentUser.Username}";
            label8.Text = $"Points: {currentUser.Points}";
            label3.Text = $"Email: {currentUser.Email}";
            label7.Text = $"Password: {currentUser.Password}";
            label2.Text = $"ID: {currentUser.ID}";
            label4.Text = $"Gender: {currentUser.Gender}";
        }

        private void DisplayPurchasedItems()
        {
            foreach (var item in currentUser.PurchasedItems)
            {
                purchasedItemsListBox.Items.Add($"{item.Name} - Quantity: {item.Quantity}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var form = new UbdatePr(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // If needed, handle label1 click event here
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser, userManager);
            this.Close();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
