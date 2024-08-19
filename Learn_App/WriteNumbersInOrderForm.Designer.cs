namespace Learn_App
{
    partial class WriteNumbersInOrderForm
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
            lblInstruction = new Label();
            txtNumbers = new TextBox();
            btnSubmit = new Button();
            trfl = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.BackColor = Color.White;
            lblInstruction.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruction.ForeColor = Color.Black;
            lblInstruction.Location = new Point(60, 156);
            lblInstruction.Margin = new Padding(8, 0, 8, 0);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(688, 48);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Arrange the numbers in ascending order:";
            lblInstruction.Click += lblInstruction_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.BackColor = Color.White;
            txtNumbers.Font = new Font("Microsoft Sans Serif", 12F);
            txtNumbers.ForeColor = Color.Black;
            txtNumbers.Location = new Point(216, 455);
            txtNumbers.Margin = new Padding(8);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(1038, 53);
            txtNumbers.TabIndex = 1;
            txtNumbers.TextChanged += txtNumbers_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.White;
            btnSubmit.Font = new Font("Stencil", 12F);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(531, 690);
            btnSubmit.Margin = new Padding(8);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(241, 74);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Font = new Font("Stencil", 14F);
            trfl.Location = new Point(795, 704);
            trfl.Name = "trfl";
            trfl.Size = new Size(80, 59);
            trfl.TabIndex = 7;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1447, 103);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F);
            label1.Location = new Point(428, 17);
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
            label6.Name = "label6";
            label6.Size = new Size(183, 69);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // WriteNumbersInOrderForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.صورة_واتساب_بتاريخ_2024_08_19_في_19_59_22_a5049653;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1447, 1514);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(btnSubmit);
            Controls.Add(txtNumbers);
            Controls.Add(lblInstruction);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(8);
            Name = "WriteNumbersInOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Write Numbers in Order";
            Load += WriteNumbersInOrderForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button trfl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}