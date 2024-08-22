namespace WinFormsApp2
{
    partial class EnglishForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            letterOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            letterMatch = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // letterOrder
            // 
            letterOrder.Animated = true;
            letterOrder.BackColor = Color.Transparent;
            letterOrder.BorderRadius = 15;
            letterOrder.BorderThickness = 1;
            letterOrder.CustomizableEdges = customizableEdges1;
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
            letterOrder.Location = new Point(48, 185);
            letterOrder.Margin = new Padding(2, 3, 2, 3);
            letterOrder.Name = "letterOrder";
            letterOrder.ShadowDecoration.CustomizableEdges = customizableEdges2;
            letterOrder.Size = new Size(240, 250);
            letterOrder.TabIndex = 19;
            letterOrder.Text = "Letters in order";
            letterOrder.Click += letterOrder_Click;
            // 
            // letterMatch
            // 
            letterMatch.Animated = true;
            letterMatch.BackColor = Color.Transparent;
            letterMatch.BorderRadius = 15;
            letterMatch.BorderThickness = 1;
            letterMatch.CustomizableEdges = customizableEdges3;
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
            letterMatch.Location = new Point(323, 185);
            letterMatch.Margin = new Padding(2, 3, 2, 3);
            letterMatch.Name = "letterMatch";
            letterMatch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            letterMatch.Size = new Size(240, 250);
            letterMatch.TabIndex = 20;
            letterMatch.Text = "Matching letters";
            letterMatch.Click += letterMatch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 50);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(196, 9);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 27);
            label1.TabIndex = 4;
            label1.Text = "The smart sprouts";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(4, 3);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 31);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(365, 34);
            label2.TabIndex = 22;
            label2.Text = "Choose an english game:";
            // 
            // EnglishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Learn_App.Properties.Resources.WhatsApp_Image_2024_08_19_at_14_28_18_1225e67a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(609, 500);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(letterMatch);
            Controls.Add(letterOrder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EnglishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "English";
            Load += English_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton letterOrder;
        private Guna.UI2.WinForms.Guna2GradientButton letterMatch;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label2;
    }
}