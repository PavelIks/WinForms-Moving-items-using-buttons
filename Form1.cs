using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovingElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCenter_Click(object sender, EventArgs e)
        {
            ButtonCenter.Location = new Point(180, 30);
            ButtonLeft.Location = new Point(100, 30);
            ButtonRight.Location = new Point(260, 30);
            ButtonUp.Location = new Point(180, 0);
            ButtonDown.Location = new Point(180, 60);
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            if (ButtonLeft.Location.X != 0)
            {
                ButtonCenter.Location = new Point(ButtonCenter.Location.X - 1, ButtonCenter.Location.Y);
                ButtonLeft.Location = new Point(ButtonLeft.Location.X - 1, ButtonCenter.Location.Y);
                ButtonRight.Location = new Point(ButtonRight.Location.X - 1, ButtonCenter.Location.Y);
                ButtonUp.Location = new Point(ButtonUp.Location.X - 1, ButtonUp.Location.Y);
                ButtonDown.Location = new Point(ButtonDown.Location.X - 1, ButtonDown.Location.Y);
            }
            else
            {
                Location = new Point(Location.X - 1, Location.Y);
            }
            if (ButtonCenter.Location.X + ButtonCenter.Width / 2 == Width / 2)
            {
                BackColor = Color.Blue;
            }
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            if (ButtonRight.Location.X + ButtonRight.Width < ClientSize.Width)
            {
                ButtonCenter.Location = new Point(ButtonCenter.Location.X + 1, ButtonCenter.Location.Y);
                ButtonLeft.Location = new Point(ButtonLeft.Location.X + 1, ButtonCenter.Location.Y);
                ButtonRight.Location = new Point(ButtonRight.Location.X + 1, ButtonCenter.Location.Y);
                ButtonUp.Location = new Point(ButtonUp.Location.X + 1, ButtonUp.Location.Y);
                ButtonDown.Location = new Point(ButtonDown.Location.X + 1, ButtonDown.Location.Y);
            }
            else
            {
                Location = new Point(Location.X + 1, Location.Y);
            }
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {

            if (ButtonUp.Location.Y != 0)
            {
                ButtonCenter.Location = new Point(ButtonCenter.Location.X, ButtonCenter.Location.Y - 1);
                ButtonLeft.Location = new Point(ButtonLeft.Location.X, ButtonCenter.Location.Y - 1);
                ButtonRight.Location = new Point(ButtonRight.Location.X, ButtonCenter.Location.Y - 1);
                ButtonUp.Location = new Point(ButtonUp.Location.X, ButtonUp.Location.Y - 1);
                ButtonDown.Location = new Point(ButtonDown.Location.X, ButtonDown.Location.Y - 1);
            }
            else
            {
                Location = new Point(Location.X, Location.Y - 1);
            }
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            if (ButtonDown.Location.Y + ButtonDown.Height < ClientSize.Height)
            {
                ButtonCenter.Location = new Point(ButtonCenter.Location.X, ButtonCenter.Location.Y + 1);
                ButtonLeft.Location = new Point(ButtonLeft.Location.X, ButtonCenter.Location.Y + 1);
                ButtonRight.Location = new Point(ButtonRight.Location.X, ButtonCenter.Location.Y + 1);
                ButtonUp.Location = new Point(ButtonUp.Location.X, ButtonUp.Location.Y + 1);
                ButtonDown.Location = new Point(ButtonDown.Location.X, ButtonDown.Location.Y + 1);

            }
            else
            {
                Location = new Point(Location.X, Location.Y + 1);
            }
        }
    }
}