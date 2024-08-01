namespace WindowsFormsApp2
{
    partial class WelcomeForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label4 = new Label();
            button1 = new Button();
            LoginButton = new Guna.UI2.WinForms.Guna2GradientButton();
            label5 = new Label();
            label6 = new Label();
            usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            HideButton = new Guna.UI2.WinForms.Guna2ImageButton();
            ShowButton = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Andalus", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 1555);
            label4.Margin = new Padding(9, 0, 9, 0);
            label4.Name = "label4";
            label4.Size = new Size(330, 46);
            label4.TabIndex = 8;
            label4.Text = "Don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Andalus", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(487, 1538);
            button1.Margin = new Padding(9, 7, 9, 7);
            button1.Name = "button1";
            button1.Size = new Size(163, 96);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginButton
            // 
            LoginButton.Animated = true;
            LoginButton.BorderRadius = 15;
            LoginButton.BorderThickness = 1;
            LoginButton.CustomizableEdges = customizableEdges1;
            LoginButton.DisabledState.BorderColor = Color.DarkGray;
            LoginButton.DisabledState.CustomBorderColor = Color.DarkGray;
            LoginButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            LoginButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            LoginButton.FillColor = Color.FromArgb(255, 224, 192);
            LoginButton.FillColor2 = Color.RosyBrown;
            LoginButton.Font = new Font("Andalus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            LoginButton.Location = new Point(320, 1775);
            LoginButton.Margin = new Padding(4, 7, 4, 7);
            LoginButton.Name = "LoginButton";
            LoginButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            LoginButton.Size = new Size(456, 168);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Log in";
            LoginButton.Click += Login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 820);
            label5.Margin = new Padding(9, 0, 9, 0);
            label5.Name = "label5";
            label5.Size = new Size(363, 110);
            label5.TabIndex = 13;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(130, 1227);
            label6.Margin = new Padding(9, 0, 9, 0);
            label6.Name = "label6";
            label6.Size = new Size(342, 110);
            label6.TabIndex = 14;
            label6.Text = "Password:";
            // 
            // usernameBox
            // 
            usernameBox.Animated = true;
            usernameBox.BorderRadius = 10;
            usernameBox.BorderThickness = 2;
            usernameBox.CustomizableEdges = customizableEdges3;
            usernameBox.DefaultText = "";
            usernameBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usernameBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usernameBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usernameBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usernameBox.FocusedState.BorderColor = Color.DodgerBlue;
            usernameBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.ForeColor = Color.Black;
            usernameBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            usernameBox.Location = new Point(151, 991);
            usernameBox.Margin = new Padding(11, 15, 11, 15);
            usernameBox.Name = "usernameBox";
            usernameBox.PasswordChar = '\0';
            usernameBox.PlaceholderText = "";
            usernameBox.SelectedText = "";
            usernameBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            usernameBox.Size = new Size(804, 165);
            usernameBox.TabIndex = 11;
            // 
            // passwordBox
            // 
            passwordBox.Animated = true;
            passwordBox.BorderRadius = 10;
            passwordBox.BorderThickness = 2;
            passwordBox.CustomizableEdges = customizableEdges5;
            passwordBox.DefaultText = "";
            passwordBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.FocusedState.BorderColor = Color.DodgerBlue;
            passwordBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.ForeColor = Color.Black;
            passwordBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordBox.Location = new Point(151, 1365);
            passwordBox.Margin = new Padding(11, 15, 11, 15);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "";
            passwordBox.SelectedText = "";
            passwordBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            passwordBox.Size = new Size(804, 150);
            passwordBox.TabIndex = 15;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(373, 412);
            guna2CirclePictureBox1.Margin = new Padding(4, 7, 4, 7);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(403, 414);
            guna2CirclePictureBox1.TabIndex = 16;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(373, 252);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(441, 110);
            label1.TabIndex = 17;
            label1.Text = "{APP NAME}";
            label1.Click += label1_Click;
            // 
            // HideButton
            // 
            HideButton.AnimatedGIF = true;
            HideButton.CheckedState.ImageSize = new Size(64, 64);
            HideButton.HoverState.ImageSize = new Size(70, 30);
            HideButton.Image = (Image)resources.GetObject("HideButton.Image");
            HideButton.ImageOffset = new Point(0, 0);
            HideButton.ImageRotate = 0F;
            HideButton.ImageSize = new Size(70, 30);
            HideButton.Location = new Point(959, 1402);
            HideButton.Margin = new Padding(4, 7, 4, 7);
            HideButton.Name = "HideButton";
            HideButton.PressedState.ImageSize = new Size(70, 30);
            HideButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            HideButton.Size = new Size(137, 79);
            HideButton.TabIndex = 18;
            HideButton.Click += hideButton_Click;
            // 
            // ShowButton
            // 
            ShowButton.AnimatedGIF = true;
            ShowButton.CheckedState.ImageSize = new Size(64, 64);
            ShowButton.HoverState.ImageSize = new Size(70, 30);
            ShowButton.Image = (Image)resources.GetObject("ShowButton.Image");
            ShowButton.ImageOffset = new Point(0, 0);
            ShowButton.ImageRotate = 0F;
            ShowButton.ImageSize = new Size(70, 30);
            ShowButton.Location = new Point(959, 1402);
            ShowButton.Margin = new Padding(4, 7, 4, 7);
            ShowButton.Name = "ShowButton";
            ShowButton.PressedState.ImageSize = new Size(70, 30);
            ShowButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            ShowButton.Size = new Size(137, 79);
            ShowButton.TabIndex = 19;
            ShowButton.Click += showButton_Click;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2AnimateWindow2
            // 
            guna2AnimateWindow2.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HIDE;
            guna2AnimateWindow2.TargetForm = this;
            // 
            // closeButton
            // 
            closeButton.Animated = true;
            closeButton.BackColor = Color.Transparent;
            closeButton.Checked = true;
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.FillColor = Color.Red;
            closeButton.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1007, 32);
            closeButton.Margin = new Padding(4, 7, 4, 7);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeButton.Size = new Size(88, 101);
            closeButton.TabIndex = 35;
            closeButton.Text = "X";
            closeButton.TextOffset = new Point(1, 0);
            closeButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            closeButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            closeButton.Click += CloseButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1167, 2113);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(passwordBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(usernameBox);
            Controls.Add(LoginButton);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(ShowButton);
            Controls.Add(HideButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9, 7, 9, 7);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += WelcomeForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2GradientButton LoginButton;
        private Label label5;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton HideButton;
        private Guna.UI2.WinForms.Guna2ImageButton ShowButton;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
    }
}

