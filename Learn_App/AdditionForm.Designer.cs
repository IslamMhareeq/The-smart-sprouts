
namespace Learn_App
{
    partial class AdditionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            trfl = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(181, 269);
            lblQuestion.Margin = new Padding(8, 0, 8, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 47);
            lblQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.Font = new Font("Segoe UI", 15F);
            txtAnswer.Location = new Point(148, 377);
            txtAnswer.Margin = new Padding(8, 6, 8, 6);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(279, 61);
            txtAnswer.TabIndex = 1;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(148, 451);
            btnSubmit.Margin = new Padding(8, 6, 8, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(231, 79);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Location = new Point(388, 483);
            trfl.Margin = new Padding(2);
            trfl.Name = "trfl";
            trfl.Size = new Size(39, 47);
            trfl.TabIndex = 3;
            trfl.UseVisualStyleBackColor = false;
            trfl.Click += trfl_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 79);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(319, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 6;
            label1.Text = "Learn App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 15F);
            label6.Location = new Point(8, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 65);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // AdditionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 989);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Margin = new Padding(8, 6, 8, 6);
            Name = "AdditionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addition";
            Load += AdditionForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button trfl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}