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
            label6 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Stencil", 13F);
            lblInstruction.Location = new Point(45, 122);
            lblInstruction.Margin = new Padding(7, 0, 7, 0);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(801, 42);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Arrange the numbers in ascending order:";
            lblInstruction.Click += lblInstruction_Click;
            // 
            // txtNumbers
            // 
            txtNumbers.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumbers.Location = new Point(220, 326);
            txtNumbers.Margin = new Padding(7, 7, 7, 7);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(794, 52);
            txtNumbers.TabIndex = 1;
            txtNumbers.TextChanged += txtNumbers_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Stencil", 14F);
            btnSubmit.Location = new Point(333, 503);
            btnSubmit.Margin = new Padding(7, 7, 7, 7);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(184, 57);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Font = new Font("Stencil", 14F);
            trfl.Location = new Point(534, 515);
            trfl.Margin = new Padding(2);
            trfl.Name = "trfl";
            trfl.Size = new Size(61, 46);
            trfl.TabIndex = 7;
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
            panel1.Size = new Size(1359, 81);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 16F);
            label6.Location = new Point(8, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 69);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(544, 1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 7;
            label1.Text = "Learn App";
            // 
            // WriteNumbersInOrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 1068);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(btnSubmit);
            Controls.Add(txtNumbers);
            Controls.Add(lblInstruction);
            Margin = new Padding(7, 7, 7, 7);
            Name = "WriteNumbersInOrderForm";
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