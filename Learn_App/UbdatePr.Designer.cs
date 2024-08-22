
namespace Learn_App
{
    partial class UbdatePr
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
            changeN = new Label();
            ChangeP = new Label();
            txtN = new TextBox();
            txtP = new TextBox();
            BN = new Button();
            BP = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // changeN
            // 
            changeN.AutoSize = true;
            changeN.Font = new Font("Stencil", 14F);
            changeN.Location = new Point(33, 81);
            changeN.Margin = new Padding(1, 0, 1, 0);
            changeN.Name = "changeN";
            changeN.Size = new Size(145, 22);
            changeN.TabIndex = 0;
            changeN.Text = "Change Name:";
            // 
            // ChangeP
            // 
            ChangeP.AutoSize = true;
            ChangeP.Font = new Font("Stencil", 14F);
            ChangeP.Location = new Point(33, 217);
            ChangeP.Margin = new Padding(1, 0, 1, 0);
            ChangeP.Name = "ChangeP";
            ChangeP.Size = new Size(193, 22);
            ChangeP.TabIndex = 1;
            ChangeP.Text = "Change Password:";
            ChangeP.Click += label2_Click;
            // 
            // txtN
            // 
            txtN.Font = new Font("Stencil", 14F);
            txtN.Location = new Point(33, 104);
            txtN.Margin = new Padding(1);
            txtN.Name = "txtN";
            txtN.Size = new Size(189, 30);
            txtN.TabIndex = 3;
            // 
            // txtP
            // 
            txtP.Font = new Font("Stencil", 14F);
            txtP.Location = new Point(37, 240);
            txtP.Margin = new Padding(1);
            txtP.Name = "txtP";
            txtP.Size = new Size(189, 30);
            txtP.TabIndex = 4;
            // 
            // BN
            // 
            BN.Font = new Font("Stencil", 14F);
            BN.Location = new Point(33, 136);
            BN.Margin = new Padding(1);
            BN.Name = "BN";
            BN.Size = new Size(112, 41);
            BN.TabIndex = 6;
            BN.Text = "Confirm";
            BN.UseVisualStyleBackColor = true;
            BN.Click += BN_Click;
            // 
            // BP
            // 
            BP.Font = new Font("Stencil", 14F);
            BP.Location = new Point(37, 272);
            BP.Margin = new Padding(1);
            BP.Name = "BP";
            BP.Size = new Size(112, 38);
            BP.TabIndex = 7;
            BP.Text = "Confirm";
            BP.UseVisualStyleBackColor = true;
            BP.Click += BP_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 37);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(180, 7);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 27);
            label1.TabIndex = 6;
            label1.Text = "The smart sprouts";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 18F);
            label6.Location = new Point(1, 7);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(74, 27);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // UbdatePr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 379);
            Controls.Add(panel1);
            Controls.Add(BP);
            Controls.Add(BN);
            Controls.Add(txtP);
            Controls.Add(txtN);
            Controls.Add(ChangeP);
            Controls.Add(changeN);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "UbdatePr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UbdatePr";
            Load += UbdatePr_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label changeN;
        private System.Windows.Forms.Label ChangeP;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.Button BP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}