namespace Learn_App
{
    partial class Hebrew
    {
        private void InitializeComponent()
        {
            label_word = new Label();
            textBox1_Guess = new TextBox();
            button1_next = new Button();
            button2_start = new Button();
            label_result = new Label();
            label_score = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_word
            // 
            label_word.BackColor = Color.LightBlue;
            label_word.Font = new Font("Segoe MDL2 Assets", 24F);
            label_word.Location = new Point(128, 98);
            label_word.Name = "label_word";
            label_word.Size = new Size(338, 65);
            label_word.TabIndex = 0;
            label_word.Text = "המילה";
            label_word.TextAlign = ContentAlignment.MiddleCenter;
            label_word.Click += label_word_Click;
            // 
            // textBox1_Guess
            // 
            textBox1_Guess.BackColor = Color.White;
            textBox1_Guess.Font = new Font("Segoe UI", 18F);
            textBox1_Guess.Location = new Point(128, 160);
            textBox1_Guess.Margin = new Padding(3, 2, 3, 2);
            textBox1_Guess.Name = "textBox1_Guess";
            textBox1_Guess.Size = new Size(338, 39);
            textBox1_Guess.TabIndex = 1;
            textBox1_Guess.TextAlign = HorizontalAlignment.Center;
            textBox1_Guess.TextChanged += textBox1_Guess_TextChanged;
            // 
            // button1_next
            // 
            button1_next.BackColor = Color.PaleTurquoise;
            button1_next.Enabled = false;
            button1_next.FlatAppearance.BorderColor = Color.Black;
            button1_next.FlatStyle = FlatStyle.Flat;
            button1_next.Font = new Font("Segoe UI", 18F);
            button1_next.Location = new Point(128, 212);
            button1_next.Margin = new Padding(3, 2, 3, 2);
            button1_next.Name = "button1_next";
            button1_next.Size = new Size(338, 63);
            button1_next.TabIndex = 2;
            button1_next.Text = "הבא";
            button1_next.UseVisualStyleBackColor = false;
            button1_next.Click += button1_next_Click;
            // 
            // button2_start
            // 
            button2_start.BackColor = SystemColors.GradientInactiveCaption;
            button2_start.FlatAppearance.BorderColor = Color.Black;
            button2_start.FlatStyle = FlatStyle.Flat;
            button2_start.Font = new Font("Segoe UI", 18F);
            button2_start.Location = new Point(128, 276);
            button2_start.Margin = new Padding(3, 2, 3, 2);
            button2_start.Name = "button2_start";
            button2_start.Size = new Size(338, 63);
            button2_start.TabIndex = 3;
            button2_start.Text = "התחלה";
            button2_start.UseVisualStyleBackColor = false;
            button2_start.Click += button2_start_Click;
            // 
            // label_result
            // 
            label_result.BackColor = SystemColors.ActiveCaption;
            label_result.Font = new Font("Segoe MDL2 Assets", 24F);
            label_result.ImageAlign = ContentAlignment.MiddleRight;
            label_result.Location = new Point(128, 348);
            label_result.Name = "label_result";
            label_result.Size = new Size(338, 65);
            label_result.TabIndex = 4;
            label_result.Text = "תוצאה";
            label_result.TextAlign = ContentAlignment.TopCenter;
            label_result.Click += label_result_Click;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Segoe UI", 13.8F);
            label_score.Location = new Point(277, 417);
            label_score.Name = "label_score";
            label_score.Size = new Size(32, 25);
            label_score.TabIndex = 5;
            label_score.Text = "00";
            label_score.Click += label_score_Click;
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
            panel1.Size = new Size(596, 41);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(176, 7);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 27);
            label1.TabIndex = 5;
            label1.Text = "The smart sprouts";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 18F);
            label6.Location = new Point(5, 7);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 27);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click_1;
            // 
            // Hebrew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_08_19_at_14_28_18_1225e67a;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(596, 463);
            Controls.Add(panel1);
            Controls.Add(label_score);
            Controls.Add(label_result);
            Controls.Add(button2_start);
            Controls.Add(button1_next);
            Controls.Add(textBox1_Guess);
            Controls.Add(label_word);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hebrew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hebrew Learning Game";
            Load += Hebrew_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox1_Guess;
        private System.Windows.Forms.Button button1_next;
        private System.Windows.Forms.Button button2_start;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}
