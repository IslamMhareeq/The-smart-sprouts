
namespace Learn_App
{
    partial class Store
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            categoryComboBox = new ComboBox();
            productListBox = new ListBox();
            buyButton = new Button();
            coinsLabel = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Stencil", 12F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(429, 283);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(524, 55);
            categoryComboBox.TabIndex = 0;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // productListBox
            // 
            productListBox.Font = new Font("Stencil", 12F);
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 47;
            productListBox.Location = new Point(429, 351);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(524, 333);
            productListBox.TabIndex = 1;
            productListBox.SelectedIndexChanged += productListBox_SelectedIndexChanged_1;
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Stencil", 12F);
            buyButton.Location = new Point(522, 749);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(340, 72);
            buyButton.TabIndex = 2;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += BuyButton_Click;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Font = new Font("Stencil", 12F);
            coinsLabel.Location = new Point(1198, 31);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(182, 47);
            coinsLabel.TabIndex = 3;
            coinsLabel.Text = "Points: ";
            coinsLabel.Click += coinsLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(coinsLabel);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 100);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(409, 9);
            label2.Name = "label2";
            label2.Size = new Size(591, 69);
            label2.TabIndex = 6;
            label2.Text = "The smart sprouts";
            // 
            // label6
            // 
            label6.Font = new Font("Cooper Black", 18F);
            label6.Location = new Point(12, 7);
            label6.Name = "label6";
            label6.Size = new Size(219, 93);
            label6.TabIndex = 7;
            label6.Text = "Back";
            label6.Click += label6_Click_1;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 1514);
            Controls.Add(panel1);
            Controls.Add(buyButton);
            Controls.Add(productListBox);
            Controls.Add(categoryComboBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Store";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            Load += Store_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox categoryComboBox;
        private ListBox productListBox;
        private Button buyButton;
        private Label coinsLabel;
        private Panel panel1;
        private Label label2;
        private Label label6;
    }
}
