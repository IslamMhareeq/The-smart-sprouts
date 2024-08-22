namespace Learn_App
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            labelLibrary = new Label();
            buttonEnglish = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            Main = new Label();
            Store = new Label();
            Prof = new Label();
            sidebartran = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelLibrary
            // 
            labelLibrary.AutoSize = true;
            labelLibrary.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold);
            labelLibrary.Location = new Point(191, 59);
            labelLibrary.Margin = new Padding(1, 0, 1, 0);
            labelLibrary.Name = "labelLibrary";
            labelLibrary.Size = new Size(0, 45);
            labelLibrary.TabIndex = 1;
            labelLibrary.TextAlign = ContentAlignment.MiddleCenter;
            labelLibrary.Click += labelLibrary_Click;
            // 
            // buttonEnglish
            // 
            buttonEnglish.BackColor = Color.FromArgb(0, 180, 180);
            buttonEnglish.Font = new Font("Segoe UI", 15F);
            buttonEnglish.Location = new Point(191, 183);
            buttonEnglish.Margin = new Padding(1, 1, 1, 1);
            buttonEnglish.Name = "buttonEnglish";
            buttonEnglish.Size = new Size(210, 79);
            buttonEnglish.TabIndex = 6;
            buttonEnglish.Text = "English Game";
            buttonEnglish.UseVisualStyleBackColor = false;
            buttonEnglish.Click += buttonEnglish_Click;
            buttonEnglish.MouseEnter += Button_MouseEnter;
            buttonEnglish.MouseLeave += Button_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 180, 180);
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(191, 286);
            button1.Margin = new Padding(1, 1, 1, 1);
            button1.Name = "button1";
            button1.Size = new Size(210, 79);
            button1.TabIndex = 6;
            button1.Text = "Math Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 180, 180);
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(191, 400);
            button2.Margin = new Padding(1, 1, 1, 1);
            button2.Name = "button2";
            button2.Size = new Size(210, 79);
            button2.TabIndex = 7;
            button2.Text = "Hebrew Game";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(1, 1, 1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 40);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15F);
            label2.Location = new Point(508, 8);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 26);
            label2.TabIndex = 4;
            label2.Text = "Log Out";
            label2.Click += label2_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 18F);
            label6.Location = new Point(191, 6);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(234, 27);
            label6.TabIndex = 3;
            label6.Text = "The smart sprouts";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 18F, FontStyle.Italic);
            label1.Location = new Point(28, 4);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 31);
            label1.TabIndex = 1;
            label1.Text = "menu";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(13, 16);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightCyan;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(1, 1, 1, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 490);
            flowLayoutPanel1.TabIndex = 9;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Main);
            panel2.Controls.Add(Store);
            panel2.Controls.Add(Prof);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(1, 1, 1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 143);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // Main
            // 
            Main.AutoSize = true;
            Main.Font = new Font("Showcard Gothic", 14F);
            Main.Location = new Point(12, 97);
            Main.Margin = new Padding(1, 0, 1, 0);
            Main.Name = "Main";
            Main.Size = new Size(109, 23);
            Main.TabIndex = 12;
            Main.Text = "Main Page";
            Main.Click += label4_Click;
            // 
            // Store
            // 
            Store.AutoSize = true;
            Store.Font = new Font("Showcard Gothic", 14F);
            Store.Location = new Point(12, 61);
            Store.Margin = new Padding(1, 0, 1, 0);
            Store.Name = "Store";
            Store.Size = new Size(71, 23);
            Store.TabIndex = 11;
            Store.Text = "Store";
            Store.Click += label3_Click;
            // 
            // Prof
            // 
            Prof.AutoSize = true;
            Prof.Font = new Font("Showcard Gothic", 14F);
            Prof.Location = new Point(12, 26);
            Prof.Margin = new Padding(1, 0, 1, 0);
            Prof.Name = "Prof";
            Prof.Size = new Size(88, 23);
            Prof.TabIndex = 10;
            Prof.Text = "Profile";
            Prof.Click += label2_Click;
            // 
            // sidebartran
            // 
            sidebartran.Interval = 10;
            sidebartran.Tick += sidebartran_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 131);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(289, 34);
            label3.TabIndex = 23;
            label3.Text = "Choose your game:";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 530);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(buttonEnglish);
            Controls.Add(labelLibrary);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 1, 1, 1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page Select";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Button buttonEnglish;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer sidebartran;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.Label Prof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Label label3;
    }
}
