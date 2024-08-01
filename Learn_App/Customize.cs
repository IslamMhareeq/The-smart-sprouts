using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomShape
{
    public static class Customize
    {
        public static void ApplyRoundCorners(Form form, int cornerRadius)
        {
            form.Paint += (sender, e) =>
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
                path.AddArc(new Rectangle(form.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
                path.AddArc(new Rectangle(form.Width - cornerRadius, form.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
                path.AddArc(new Rectangle(0, form.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
                path.CloseAllFigures();

                form.Region = new Region(path);

                using (Pen pen = new Pen(Color.DarkBlue, 1.0f))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            };

            form.Resize += (sender, e) =>
            {
                form.Invalidate(); // Redraw the form when it's resized to maintain the rounded corners
            };
        }
        public static void AddCustomCloseButton(Form form)
        {
            Guna2CircleButton closeButton = new Guna2CircleButton
            {
                Size = new Size(30, 30),
                FillColor = Color.Red,
                ForeColor = Color.White,
                Text = "X",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(form.Width - 40, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };

            closeButton.Click += (sender, e) =>
            {
                Application.Exit();
            };

            form.Controls.Add(closeButton);
        }



    }
}
