using System;
using System.Drawing;
using System.Windows.Forms;
//@author Ansari Mohammed Faisal - 000812671

namespace Assignment5A
{
    /// <summary>
    /// class creates a apps which displays water flowing and filling the bucket
    /// </summary>
    public partial class Form1 : Form
    {
        Color waterColour = Color.Blue; //default color
        private int lengthCounter = 1; //keep track of water length
        bool bucketFull = false;
        public Form1()
        {
            InitializeComponent();
            base.Paint += bucketDrawer; //draw bucket
            speedTrackBar.Value = 0;
        }

        /// <summary>
        /// this function is called when user chooses a color for water by clicking colour button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            ColorDialog colourChoosed = new ColorDialog();
            if (colourChoosed.ShowDialog() == DialogResult.OK)
            {
                waterColour = colourChoosed.Color;
            }
        }
        /// <summary>
        /// this function is used to display water that flows from the tap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waterDrop(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();
            SolidBrush brush = new SolidBrush(waterColour);
            graphics.FillRectangle(brush, 85, 200, 15, 201 - lengthCounter);
            if (this.lengthCounter >= 100)
            {
                bucketFull = true;
                speedTimer.Enabled = false;
                speedTrackBar.Value = 0;
                this.lengthCounter = 0;
                graphics.FillRectangle(new SolidBrush(BackColor), 85, 200, 15, 101);
            }
            graphics.FillRectangle(brush, 86, 400 - this.lengthCounter, 199, 1);
            this.lengthCounter++;
        }

        /// <summary>
        /// this function closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// this function draws bucket
        /// </summary>
        /// <param name="a"></param>
        /// <param name="paintEvent"></param>
        private void bucketDrawer(object a, PaintEventArgs paintEvent)
        {
            Graphics graphics = paintEvent.Graphics;
            graphics.DrawLine(new Pen(Color.Black), 84, 290, 84, 400);
            graphics.DrawLine(new Pen(Color.Black), 84, 400, 285, 400);
            graphics.DrawLine(new Pen(Color.Black), 285, 400, 285, 290);

        }

        /// <summary>
        /// this function controls the speed as well as fill the bucket with water(rectangle)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            var speed = (speedTrackBar.Maximum - speedTrackBar.Value) * 10;
            if (speedTrackBar.Value == 10)//prevent 0 speed when max value
            {
                speed = (int)(0.5 * 10);
            }
            Graphics graphics = CreateGraphics();
            if (speedTrackBar.Value == 0)
            {
                speedTimer.Enabled = false;

            }
            else
            {
                if (!bucketFull)
                {
                    speedTimer.Interval = speed;
                    speedTimer.Enabled = true;
                }
                else
                {
                    bucketFull = false;
                    graphics.FillRectangle(new SolidBrush(BackColor), 86, 285, 199, 140);
                    graphics.FillRectangle(new SolidBrush(BackColor), 86, 200, 15, 86);
                    speedTimer.Interval = speed;
                    speedTimer.Enabled = true;
                }
            }
        }
    }
}
