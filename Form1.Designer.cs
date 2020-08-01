using System.Drawing;
using System.Windows.Forms;

namespace MovingElements
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.MaximumSize = new System.Drawing.Size(416, 338);
            this.MinimumSize = new System.Drawing.Size(416, 338);
            this.components = new System.ComponentModel.Container();
            this.StartPosition = FormStartPosition.Manual;
            //
            // ButtonCenter
            //
            ButtonCenter.Location = new Point(180, 30);
            ButtonCenter.Text = "O";
            this.Controls.Add(ButtonCenter);
            ButtonCenter.Click += ButtonCenter_Click;
            ButtonCenter.MouseHover += delegate { Cursor = Cursors.SizeAll; };
            ButtonCenter.MouseLeave += delegate { Cursor = Cursors.Default; };
            //
            // ButtonLeft
            //
            ButtonLeft.Location = new Point(100, 30);
            ButtonLeft.Text = "<-";
            this.Controls.Add(ButtonLeft);
            ButtonLeft.Click += ButtonLeft_Click;
            ButtonLeft.MouseHover += delegate { Cursor = Cursors.PanWest; };
            ButtonLeft.MouseLeave += delegate { Cursor = Cursors.Default; };
            ButtonLeft.LocationChanged += delegate
            {
                if (ButtonLeft.Location.X == 0)
                {
                    BackColor = Color.Orange;
                }
            };
            //
            // ButtonRight
            //
            ButtonRight.Location = new Point(260, 30);
            ButtonRight.Text = "->";
            this.Controls.Add(ButtonRight);
            ButtonRight.Click += ButtonRight_Click;
            ButtonRight.MouseHover += delegate { Cursor = Cursors.PanEast; };
            ButtonRight.MouseLeave += delegate { Cursor = Cursors.Default; };
            ButtonRight.LocationChanged += delegate
            {
                if (ButtonRight.Location.X + ButtonRight.Width >= ClientSize.Width)
                {
                    BackColor = Color.Yellow;
                }
            };

            //
            // ButtonUp
            //
            ButtonUp.Location = new Point(180, 0);
            ButtonUp.Text = "/\\";
            this.Controls.Add(ButtonUp);
            ButtonUp.Click += ButtonUp_Click;
            ButtonUp.MouseHover += delegate { Cursor = Cursors.PanNorth; };
            ButtonUp.MouseLeave += delegate { Cursor = Cursors.Default; };
            ButtonUp.LocationChanged += delegate
            {
                if (ButtonUp.Location.Y == 0)
                {
                    BackColor = Color.Green;
                }
            };

            //
            // ButtonDown
            //
            ButtonDown.Location = new Point(180, 60);
            ButtonDown.Text = "\\/";
            this.Controls.Add(ButtonDown);
            ButtonDown.Click += ButtonDown_Click;
            ButtonDown.MouseHover += delegate { Cursor = Cursors.PanSouth; };
            ButtonDown.MouseLeave += delegate { Cursor = Cursors.Default; };
            ButtonDown.LocationChanged += delegate
            {
                if (ButtonDown.Location.Y + ButtonDown.Height >= ClientSize.Height)
                {
                    BackColor = Color.Red;
                }
            };
        }

        private Button ButtonCenter = new Button();
        private Button ButtonLeft = new Button();
        private Button ButtonRight = new Button();
        private Button ButtonUp = new Button();
        private Button ButtonDown = new Button();
        #endregion
    }
}