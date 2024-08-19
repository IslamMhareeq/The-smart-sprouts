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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubtractionForm));
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
            lblQuestion.BackColor = Color.Black;
            lblQuestion.Font = new Font("Stencil", 14F);
            lblQuestion.ForeColor = Color.White;
            lblQuestion.Location = new Point(57, 58);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(0, 22);
            lblQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = Color.Black;
            txtAnswer.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.ForeColor = Color.White;
            txtAnswer.Location = new Point(69, 112);
            txtAnswer.Margin = new Padding(4, 3, 4, 3);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(248, 30);
            txtAnswer.TabIndex = 1;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Font = new Font("Stencil", 14F);
            trfl.Location = new Point(225, 155);
            trfl.Margin = new Padding(1, 1, 1, 1);
            trfl.Name = "trfl";
            trfl.Size = new Size(21, 22);
            trfl.TabIndex = 6;
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
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 37);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(195, 0);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 39);
            label1.TabIndex = 5;
            label1.Text = "Learn App";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 16F);
            label6.Location = new Point(4, 3);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 36);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.Font = new Font("Stencil", 14F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(113, 150);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(99, 27);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // SubtractionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(609, 586);
            Controls.Add(btnSubmit);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Margin = new Padding(4, 3, 4, 3);
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
        private Label label1;
        private Button btnSubmit;
    }
}