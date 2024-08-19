namespace Learn_App
{
    partial class HebrewGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            letterMatch = new Guna.UI2.WinForms.Guna2GradientButton();
            letterOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1479, 101);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(477, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(591, 69);
            label2.TabIndex = 6;
            label2.Text = "The smart sprouts";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 18F);
            label6.Location = new Point(10, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(183, 69);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 365);
            label3.Margin = new Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new Size(894, 84);
            label3.TabIndex = 23;
            label3.Text = "Choose a hebrew game:";
            // 
            // letterMatch
            // 
            letterMatch.Animated = true;
            letterMatch.BackColor = Color.Transparent;
            letterMatch.BorderRadius = 15;
            letterMatch.BorderThickness = 1;
            letterMatch.CustomizableEdges = customizableEdges33;
            letterMatch.DisabledState.BorderColor = Color.DarkGray;
            letterMatch.DisabledState.CustomBorderColor = Color.DarkGray;
            letterMatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            letterMatch.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            letterMatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            letterMatch.FillColor = Color.LightCyan;
            letterMatch.FillColor2 = Color.White;
            letterMatch.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            letterMatch.ForeColor = Color.Black;
            letterMatch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            letterMatch.Location = new Point(812, 622);
            letterMatch.Margin = new Padding(5, 8, 5, 8);
            letterMatch.Name = "letterMatch";
            letterMatch.ShadowDecoration.CustomizableEdges = customizableEdges34;
            letterMatch.Size = new Size(583, 683);
            letterMatch.TabIndex = 25;
            letterMatch.Text = "Complete The Words";
            letterMatch.Click += letterMatch_Click;
            // 
            // letterOrder
            // 
            letterOrder.Animated = true;
            letterOrder.BackColor = Color.Transparent;
            letterOrder.BorderRadius = 15;
            letterOrder.BorderThickness = 1;
            letterOrder.CustomizableEdges = customizableEdges35;
            letterOrder.DisabledState.BorderColor = Color.DarkGray;
            letterOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            letterOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            letterOrder.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            letterOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            letterOrder.FillColor = Color.LightCyan;
            letterOrder.FillColor2 = Color.White;
            letterOrder.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            letterOrder.ForeColor = Color.Black;
            letterOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            letterOrder.Location = new Point(54, 622);
            letterOrder.Margin = new Padding(5, 8, 5, 8);
            letterOrder.Name = "letterOrder";
            letterOrder.ShadowDecoration.CustomizableEdges = customizableEdges36;
            letterOrder.Size = new Size(583, 683);
            letterOrder.TabIndex = 24;
            letterOrder.Text = "Match Letters";
            letterOrder.Click += letterOrder_Click;
            // 
            // HebrewGames
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_08_19_at_14_28_18_1225e67a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1479, 1602);
            Controls.Add(letterMatch);
            Controls.Add(letterOrder);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "HebrewGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HebrewGames";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label6;
        private Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton letterMatch;
        private Guna.UI2.WinForms.Guna2GradientButton letterOrder;
    }
}