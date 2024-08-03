namespace Learn_App
{
    partial class CompleteSequencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteSequencesForm));
            lblInstruction = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
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
            lblInstruction.BackColor = Color.Black;
            lblInstruction.Font = new Font("Stencil", 12F);
            lblInstruction.ForeColor = Color.White;
            lblInstruction.Location = new Point(114, 172);
            lblInstruction.Margin = new Padding(8, 0, 8, 0);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(0, 38);
            lblInstruction.TabIndex = 0;
            // 
            // txtNumber1
            // 
            txtNumber1.BackColor = Color.Black;
            txtNumber1.Font = new Font("Stencil", 12F);
            txtNumber1.ForeColor = Color.White;
            txtNumber1.Location = new Point(192, 322);
            txtNumber1.Margin = new Padding(8, 6, 8, 6);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(141, 45);
            txtNumber1.TabIndex = 1;
            txtNumber1.TextChanged += txtNumber1_TextChanged;
            // 
            // txtNumber2
            // 
            txtNumber2.BackColor = Color.Black;
            txtNumber2.Font = new Font("Stencil", 12F);
            txtNumber2.ForeColor = Color.White;
            txtNumber2.Location = new Point(391, 322);
            txtNumber2.Margin = new Padding(8, 6, 8, 6);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(141, 45);
            txtNumber2.TabIndex = 2;
            txtNumber2.TextChanged += txtNumber2_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.Font = new Font("Stencil", 12F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(192, 394);
            btnSubmit.Margin = new Padding(8, 6, 8, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(229, 64);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // trfl
            // 
            trfl.BackColor = Color.White;
            trfl.Location = new Point(474, 406);
            trfl.Margin = new Padding(2);
            trfl.Name = "trfl";
            trfl.Size = new Size(39, 47);
            trfl.TabIndex = 4;
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
            panel1.Size = new Size(1056, 75);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(393, -2);
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
            // CompleteSequencesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1056, 931);
            Controls.Add(panel1);
            Controls.Add(trfl);
            Controls.Add(btnSubmit);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblInstruction);
            Margin = new Padding(8, 6, 8, 6);
            Name = "CompleteSequencesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complete Sequences";
            Load += CompleteSequencesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button trfl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}