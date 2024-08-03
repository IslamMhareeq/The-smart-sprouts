using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Learn_App
{
    public partial class Store : Form
    {
        private User currentUser;
        private UserManager userManager;
        private List<Category> categories;

        public Store(User user, UserManager userManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userManager = userManager;
            categories = new List<Category>();

            // Example categories and products
            Category stickers = new Category("Stickers");
            stickers.Products.Add(new Product("Star Sticker", 5));
            stickers.Products.Add(new Product("Heart Sticker", 7));

            Category toys = new Category("Toys");
            toys.Products.Add(new Product("Toy Car", 20));
            toys.Products.Add(new Product("Doll", 25));

            categories.Add(stickers);
            categories.Add(toys);
        }

        private void Store_Load(object sender, EventArgs e)
        {
            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category.Name);
            }
            if (categoryComboBox.Items.Count > 0)
            {
                categoryComboBox.SelectedIndex = 0;
            }

            coinsLabel.Text = $"Points: {currentUser.Points}";
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productListBox.Items.Clear();
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            var category = categories.Find(c => c.Name == selectedCategory);
            foreach (var product in category.Products)
            {
                productListBox.Items.Add($"{product.Name} - {product.Price} points");
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedItem == null) return;
            string selectedItem = productListBox.SelectedItem.ToString();
            string productName = selectedItem.Split('-')[0].Trim();
            var category = categories.Find(c => c.Name == categoryComboBox.SelectedItem.ToString());
            var product = category.Products.Find(p => p.Name == productName);

            if (currentUser.Points >= product.Price)
            {
                currentUser.Points -= product.Price;
                currentUser.AddProduct(new Product(product.Name, product.Price));
                userManager.UpdateUser(currentUser);
                MessageBox.Show($"You have purchased {product.Name}!", "Purchase Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                coinsLabel.Text = $"Points: {currentUser.Points}";
            }
            else
            {
                MessageBox.Show("You do not have enough points.", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            var form = new MainPage(currentUser, userManager);
            this.Hide();
            form.Show();
            form.FormClosed += (s, args) => this.Close();
        }

        private void coinsLabel_Click(object sender, EventArgs e)
        {

        }

        private void productListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
