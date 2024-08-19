namespace Learn_App
{
    partial class MatchLetterHeb
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
            gamePanel = new Panel();
            lblCharacter = new Label();
            btnStart = new Button();
            btnClose = new Button();
            lblScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            gamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // gamePanel
            // 
            gamePanel.BackColor = Color.LightCyan;
            gamePanel.Controls.Add(lblCharacter);
            gamePanel.Dock = DockStyle.Top;
            gamePanel.Location = new Point(0, 0);
            gamePanel.Margin = new Padding(6);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(1503, 670);
            gamePanel.TabIndex = 0;
            gamePanel.Paint += panel1_Paint;
            // 
            // lblCharacter
            // 
            lblCharacter.BackColor = Color.RosyBrown;
            lblCharacter.Font = new Font("Segoe UI", 14F);
            lblCharacter.Location = new Point(606, 156);
            lblCharacter.Margin = new Padding(6, 0, 6, 0);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(106, 84);
            lblCharacter.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(255, 224, 192);
            btnStart.Font = new Font("Segoe UI", 12F);
            btnStart.Location = new Point(263, 692);
            btnStart.Margin = new Padding(6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(236, 100);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 224, 192);
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(15, 692);
            btnClose.Margin = new Padding(6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(236, 100);
            btnClose.TabIndex = 2;
            btnClose.Text = "Back";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 12F);
            lblScore.Location = new Point(535, 715);
            lblScore.Margin = new Padding(6, 0, 6, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(120, 54);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Click += lblScore_Click;
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // MatchLetterHeb
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1503, 819);
            Controls.Add(lblScore);
            Controls.Add(btnStart);
            Controls.Add(btnClose);
            Controls.Add(gamePanel);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(6);
            Name = "MatchLetterHeb";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyPress += Form1_KeyPress;
            gamePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel gamePanel;
        private Button btnStart;
        private Button btnClose;
        private Label lblScore;
        private Label lblCharacter;
        private System.Windows.Forms.Timer gameTimer;
    }
}