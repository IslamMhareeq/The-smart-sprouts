
namespace Learn_App
{
    partial class MathGames
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 180, 180);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(455, 363);
            button1.Margin = new Padding(10, 8, 10, 8);
            button1.Name = "button1";
            button1.Size = new Size(565, 159);
            button1.TabIndex = 0;
            button1.Text = "a. Write numbers in order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnGameA_Click;
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 180, 180);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 13F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(455, 550);
            button2.Margin = new Padding(10, 8, 10, 8);
            button2.Name = "button2";
            button2.Size = new Size(565, 159);
            button2.TabIndex = 1;
            button2.Text = "b. Complete sequences";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnGameB_Click;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 180, 180);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 13F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(455, 735);
            button3.Margin = new Padding(10, 8, 10, 8);
            button3.Name = "button3";
            button3.Size = new Size(565, 159);
            button3.TabIndex = 2;
            button3.Text = "c. Addition";
            button3.UseVisualStyleBackColor = false;
            button3.Click += BtnGameC_Click;
            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 180, 180);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 13F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(455, 920);
            button4.Margin = new Padding(10, 8, 10, 8);
            button4.Name = "button4";
            button4.Size = new Size(565, 159);
            button4.TabIndex = 3;
            button4.Text = "d. Subtraction";
            button4.UseVisualStyleBackColor = false;
            button4.Click += BtnGameD_Click;
            button4.MouseEnter += Button_MouseEnter;
            button4.MouseLeave += Button_MouseLeave;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 180, 180);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 13F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(455, 1108);
            button5.Margin = new Padding(10, 8, 10, 8);
            button5.Name = "button5";
            button5.Size = new Size(565, 159);
            button5.TabIndex = 4;
            button5.Text = "e. Multiplication";
            button5.UseVisualStyleBackColor = false;
            button5.Click += BtnGameE_Click;
            button5.MouseEnter += Button_MouseEnter;
            button5.MouseLeave += Button_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 17F);
            label1.Location = new Point(423, 255);
            label1.Margin = new Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new Size(642, 68);
            label1.TabIndex = 6;
            label1.Text = "Choose a Math Game:";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1479, 100);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(455, 9);
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
            label6.Name = "label6";
            label6.Size = new Size(183, 69);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // MathGames
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.صورة_واتساب_بتاريخ_2024_08_19_في_19_59_22_a5049653;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1479, 1602);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 8, 10, 8);
            Name = "MathGames";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Math Games App";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label2;
    }
}