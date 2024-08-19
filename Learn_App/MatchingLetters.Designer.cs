namespace WinFormsApp2
{
    partial class MatchingLetters
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
            label1 = new Label();
            submitButton = new Button();
            button2 = new Button();
            aLetter = new Button();
            bLetter = new Button();
            cLetter = new Button();
            dLetter = new Button();
            questionLetter = new Label();
            panel1 = new Panel();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            panel2 = new Panel();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(193, 85);
            label1.Name = "label1";
            label1.Size = new Size(270, 45);
            label1.TabIndex = 25;
            label1.Text = "Match the letter:";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(169, 595);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(226, 67);
            submitButton.TabIndex = 26;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(520, 86);
            button2.Name = "button2";
            button2.Size = new Size(107, 44);
            button2.TabIndex = 27;
            button2.Text = "Shuffle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // aLetter
            // 
            aLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aLetter.Location = new Point(403, 450);
            aLetter.Name = "aLetter";
            aLetter.Size = new Size(180, 124);
            aLetter.TabIndex = 29;
            aLetter.UseVisualStyleBackColor = true;
            aLetter.Click += aLetter_Click;
            // 
            // bLetter
            // 
            bLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bLetter.Location = new Point(50, 450);
            bLetter.Name = "bLetter";
            bLetter.Size = new Size(180, 124);
            bLetter.TabIndex = 30;
            bLetter.UseVisualStyleBackColor = true;
            bLetter.Click += bLetter_Click;
            // 
            // cLetter
            // 
            cLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cLetter.Location = new Point(403, 292);
            cLetter.Name = "cLetter";
            cLetter.Size = new Size(180, 124);
            cLetter.TabIndex = 31;
            cLetter.UseVisualStyleBackColor = true;
            cLetter.Click += cLetter_Click;
            // 
            // dLetter
            // 
            dLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dLetter.Location = new Point(50, 292);
            dLetter.Name = "dLetter";
            dLetter.Size = new Size(180, 124);
            dLetter.TabIndex = 32;
            dLetter.UseVisualStyleBackColor = true;
            dLetter.Click += dLetter_Click;
            // 
            // questionLetter
            // 
            questionLetter.AutoSize = true;
            questionLetter.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionLetter.Location = new Point(80, 33);
            questionLetter.Name = "questionLetter";
            questionLetter.Size = new Size(0, 32);
            questionLetter.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(questionLetter);
            panel1.Location = new Point(226, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 98);
            panel1.TabIndex = 34;
            panel1.Paint += panel1_Paint;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog1.Text = "Incorrect. Try again.";
            // 
            // guna2MessageDialog2
            // 
            guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog2.Caption = null;
            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            guna2MessageDialog2.Parent = this;
            guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            guna2MessageDialog2.Text = "Correct answer, you've earned {x} points!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(660, 54);
            panel2.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 9);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 27);
            label2.TabIndex = 5;
            label2.Text = "The smart sprouts";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(1, 9);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 31);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // MatchingLetters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Learn_App.Properties.Resources.WhatsApp_Image_2024_08_19_at_14_28_18_1225e67a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(660, 698);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dLetter);
            Controls.Add(cLetter);
            Controls.Add(bLetter);
            Controls.Add(aLetter);
            Controls.Add(button2);
            Controls.Add(submitButton);
            Controls.Add(label1);
            Name = "MatchingLetters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatchingLetters";
            Load += MatchingLetters_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button submitButton;
        private Button button2;
        private Button aLetter;
        private Button bLetter;
        private Button cLetter;
        private Button dLetter;
        private Label questionLetter;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        private Panel panel2;
        private Label label6;
        private Label label2;
    }
}