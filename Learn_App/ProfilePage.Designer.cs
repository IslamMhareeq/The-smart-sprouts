namespace Learn_App
{
    partial class ProfilePage
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnUpdate = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            purchasedItemsListBox = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15F);
            label1.Location = new Point(80, 186);
            label1.Name = "label1";
            label1.Size = new Size(0, 62);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Showcard Gothic", 15F);
            btnUpdate.Location = new Point(80, 1206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(596, 102);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Manage your user";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 105);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 18F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(374, 3);
            label5.Name = "label5";
            label5.Size = new Size(339, 97);
            label5.TabIndex = 6;
            label5.Text = "Learn App";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15F);
            label2.Location = new Point(80, 292);
            label2.Name = "label2";
            label2.Size = new Size(0, 62);
            label2.TabIndex = 11;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 15F);
            label3.Location = new Point(80, 397);
            label3.Name = "label3";
            label3.Size = new Size(0, 62);
            label3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 15F);
            label4.Location = new Point(80, 489);
            label4.Name = "label4";
            label4.Size = new Size(0, 62);
            label4.TabIndex = 13;
            // 
            // purchasedItemsListBox
            // 
            purchasedItemsListBox.Font = new Font("Showcard Gothic", 15F);
            purchasedItemsListBox.FormattingEnabled = true;
            purchasedItemsListBox.ItemHeight = 62;
            purchasedItemsListBox.Location = new Point(80, 600);
            purchasedItemsListBox.Name = "purchasedItemsListBox";
            purchasedItemsListBox.Size = new Size(960, 500);
            purchasedItemsListBox.TabIndex = 14;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 1448);
            Controls.Add(purchasedItemsListBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "ProfilePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilePage";
            Load += ProfilePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox purchasedItemsListBox;
    }
}
