namespace WinFormsApp2
{
    partial class spellLetters
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
            button2 = new Button();
            userInputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            questionLetter = new Label();
            submitButton = new Button();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(443, 67);
            button2.Name = "button2";
            button2.Size = new Size(107, 44);
            button2.TabIndex = 36;
            button2.Text = "Shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userInputTextBox
            // 
            userInputTextBox.Animated = true;
            userInputTextBox.BackColor = Color.PaleTurquoise;
            userInputTextBox.BorderColor = Color.Black;
            userInputTextBox.BorderRadius = 20;
            userInputTextBox.BorderThickness = 5;
            userInputTextBox.CustomizableEdges = customizableEdges1;
            userInputTextBox.DefaultText = "";
            userInputTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userInputTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userInputTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.FillColor = Color.FromArgb(234, 251, 252);
            userInputTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInputTextBox.ForeColor = Color.Black;
            userInputTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Location = new Point(82, 271);
            userInputTextBox.Margin = new Padding(14, 13, 14, 13);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.PasswordChar = '\0';
            userInputTextBox.PlaceholderText = "abcde , ABCDE , abCdE (A-E)";
            userInputTextBox.SelectedText = "";
            userInputTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userInputTextBox.Size = new Size(397, 62);
            userInputTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            userInputTextBox.TabIndex = 39;
            userInputTextBox.TextChanged += userInputTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 226);
            label2.Name = "label2";
            label2.Size = new Size(116, 27);
            label2.TabIndex = 40;
            label2.Text = "Answer:";
            // 
            // questionLetter
            // 
            questionLetter.AutoSize = true;
            questionLetter.BackColor = Color.White;
            questionLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionLetter.ForeColor = Color.Black;
            questionLetter.Location = new Point(33, 77);
            questionLetter.Name = "questionLetter";
            questionLetter.Size = new Size(59, 32);
            questionLetter.TabIndex = 33;
            questionLetter.Text = "test";
            // 
            // submitButton
            // 
            submitButton.BackColor = SystemColors.ActiveCaption;
            submitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(198, 366);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(186, 68);
            submitButton.TabIndex = 41;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = "Correct answer, you've earned 1 point!";
            // 
            // guna2MessageDialog2
            // 
            guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog2.Caption = null;
            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog2.Parent = this;
            guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog2.Text = "Invalid, try again.";
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
            panel1.TabIndex = 42;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(198, 8);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 27);
            label1.TabIndex = 5;
            label1.Text = "The smart sprouts";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1, 6);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 31);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // spellLetters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = Learn_App.Properties.Resources.WhatsApp_Image_2024_08_19_at_14_28_18_1225e67a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(609, 466);
            Controls.Add(panel1);
            Controls.Add(submitButton);
            Controls.Add(questionLetter);
            Controls.Add(label2);
            Controls.Add(userInputTextBox);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "spellLetters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "spellLetters";
            Load += spellLetters_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Guna.UI2.WinForms.Guna2TextBox userInputTextBox;
        private Label label2;
        private Label questionLetter;
        private Button submitButton;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        private Panel panel1;
        private Label label6;
        private Label label1;
    }
}