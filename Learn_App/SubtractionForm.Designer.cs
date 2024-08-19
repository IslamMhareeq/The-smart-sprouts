namespace Learn_App
{
    partial class SubtractionForm
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
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            trfl = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            btnSubmit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.BackColor = Color.White;
            lblQuestion.Font = new Font("Stencil", 14F);
            lblQuestion.ForeColor = Color.Black;
            lblQuestion.Location = new Point(428, 251);
            lblQuestion.Margin = new Padding(10, 0, 10, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 56);
            lblQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.White;
            txtAnswer.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.ForeColor = Color.Black;
            txtAnswer.Location = new Point(428, 435);
            txtAnswer.Margin = new Padding(10, 8, 10, 8);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(591, 63);
            txtAnswer.TabIndex = 1;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Font = new Font("Stencil", 14F);
            trfl.Location = new Point(814, 650);
            trfl.Margin = new Padding(2, 3, 2, 3);
            trfl.Name = "trfl";
            trfl.Size = new Size(45, 60);
            trfl.TabIndex = 6;
            trfl.UseVisualStyleBackColor = false;
            trfl.Click += trfl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 101);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F);
            label1.Location = new Point(428, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(591, 69);
            label1.TabIndex = 4;
            label1.Text = "The smart sprouts";
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
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Font = new Font("Stencil", 14F);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(568, 636);
            btnSubmit.Margin = new Padding(10, 8, 10, 8);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(234, 74);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // SubtractionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.صورة_واتساب_بتاريخ_2024_08_19_في_19_59_22_a5049653;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1447, 1514);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(10, 8, 10, 8);
            Name = "SubtractionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subtraction";
            Load += SubtractionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button trfl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Button btnSubmit;
        private Label label1;
    }
}