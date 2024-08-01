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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spellLetters));
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
            button2.Location = new Point(1417, 139);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(199, 94);
            button2.TabIndex = 36;
            button2.Text = "Shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // userInputTextBox
            // 
            userInputTextBox.Animated = true;
            userInputTextBox.CustomizableEdges = customizableEdges1;
            userInputTextBox.DefaultText = "";
            userInputTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userInputTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userInputTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userInputTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userInputTextBox.ForeColor = Color.Black;
            userInputTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userInputTextBox.Location = new Point(587, 514);
            userInputTextBox.Margin = new Padding(26, 28, 26, 28);
            userInputTextBox.Name = "userInputTextBox";
            userInputTextBox.PasswordChar = '\0';
            userInputTextBox.PlaceholderText = "abcde , ABCDE , abCdE (A-E)";
            userInputTextBox.SelectedText = "";
            userInputTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            userInputTextBox.Size = new Size(979, 160);
            userInputTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            userInputTextBox.TabIndex = 39;
            userInputTextBox.TextChanged += userInputTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(351, 540);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 65);
            label2.TabIndex = 40;
            label2.Text = "Answer:";
            // 
            // questionLetter
            // 
            questionLetter.AutoSize = true;
            questionLetter.BackColor = Color.Transparent;
            questionLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionLetter.ForeColor = SystemColors.Control;
            questionLetter.Location = new Point(490, 164);
            questionLetter.Margin = new Padding(6, 0, 6, 0);
            questionLetter.Name = "questionLetter";
            questionLetter.Size = new Size(118, 65);
            questionLetter.TabIndex = 33;
            questionLetter.Text = "test";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(717, 736);
            submitButton.Margin = new Padding(6);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(345, 145);
            submitButton.TabIndex = 41;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = null;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = "Correct answer, you've earned {x} points!";
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
            panel1.BackColor = Color.FromArgb(20, 42, 46);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1837, 106);
            panel1.TabIndex = 42;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(783, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 5;
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
            // spellLetters
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1837, 1109);
            Controls.Add(panel1);
            Controls.Add(submitButton);
            Controls.Add(questionLetter);
            Controls.Add(label2);
            Controls.Add(userInputTextBox);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6);
            Name = "spellLetters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "spellLetters";
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