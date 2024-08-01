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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishForm));
            letterOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            letterMatch = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // letterOrder
            // 
            letterOrder.Animated = true;
            letterOrder.BorderRadius = 15;
            letterOrder.BorderThickness = 1;
            letterOrder.CustomizableEdges = customizableEdges1;
            letterOrder.DisabledState.BorderColor = Color.DarkGray;
            letterOrder.DisabledState.CustomBorderColor = Color.DarkGray;
            letterOrder.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            letterOrder.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            letterOrder.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            letterOrder.FillColor = Color.White;
            letterOrder.FillColor2 = Color.RosyBrown;
            letterOrder.Font = new Font("Andalus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            letterOrder.ForeColor = Color.Black;
            letterOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            letterOrder.Location = new Point(271, 452);
            letterOrder.Margin = new Padding(4, 6, 4, 6);
            letterOrder.Name = "letterOrder";
            letterOrder.ShadowDecoration.CustomizableEdges = customizableEdges2;
            letterOrder.Size = new Size(494, 531);
            letterOrder.TabIndex = 19;
            letterOrder.Text = "Letters in order";
            letterOrder.Click += letterOrder_Click;
            // 
            // letterMatch
            // 
            letterMatch.Animated = true;
            letterMatch.BorderRadius = 15;
            letterMatch.BorderThickness = 1;
            letterMatch.CustomizableEdges = customizableEdges3;
            letterMatch.DisabledState.BorderColor = Color.DarkGray;
            letterMatch.DisabledState.CustomBorderColor = Color.DarkGray;
            letterMatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            letterMatch.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            letterMatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            letterMatch.FillColor = Color.White;
            letterMatch.FillColor2 = Color.RosyBrown;
            letterMatch.Font = new Font("Andalus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            letterMatch.ForeColor = Color.Black;
            letterMatch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            letterMatch.Location = new Point(1129, 452);
            letterMatch.Margin = new Padding(4, 6, 4, 6);
            letterMatch.Name = "letterMatch";
            letterMatch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            letterMatch.Size = new Size(464, 531);
            letterMatch.TabIndex = 20;
            letterMatch.Text = "Matching letters";
            letterMatch.Click += letterMatch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 42, 46);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1943, 106);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(858, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 4;
            label1.Text = "Learn App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 20F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(8, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 87);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // EnglishForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1943, 1463);
            Controls.Add(panel1);
            Controls.Add(letterMatch);
            Controls.Add(letterOrder);
            Margin = new Padding(6);
            Name = "EnglishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "English";
            Load += English_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton letterOrder;
        private Guna.UI2.WinForms.Guna2GradientButton letterMatch;
        private Panel panel1;
        private Label label6;
        private Label label1;
    }
}