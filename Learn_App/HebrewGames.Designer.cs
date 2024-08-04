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
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 100);
            panel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(367, -3);
            label2.Name = "label2";
            label2.Size = new Size(339, 97);
            label2.TabIndex = 6;
            label2.Text = "Learn App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 15F);
            label6.Location = new Point(10, 8);
            label6.Name = "label6";
            label6.Size = new Size(162, 81);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 343);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 59);
            label1.TabIndex = 12;
            label1.Text = "Choose a Math Game:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 180, 180);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 13F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(182, 622);
            button2.Margin = new Padding(10, 8, 10, 8);
            button2.Name = "button2";
            button2.Size = new Size(565, 159);
            button2.TabIndex = 11;
            button2.Text = "b. Complete The Words";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 180, 180);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(182, 435);
            button1.Margin = new Padding(10, 8, 10, 8);
            button1.Name = "button1";
            button1.Size = new Size(565, 159);
            button1.TabIndex = 10;
            button1.Text = "a. Match Letters";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HebrewGames
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 1494);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HebrewGames";
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
        private Label label1;
        private Button button2;
        private Button button1;
    }
}