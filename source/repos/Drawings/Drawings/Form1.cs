using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Drawings
{
    public partial class Form1 : Form
    {
        bool isPressed;
        Bitmap Draw, tempDrw; 
        Color penColor;
        //int lineWidth;
        Graphics delgr;
        //Object bck;

        public Form1()
        {
            InitializeComponent();
            Draw = new Bitmap(pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height);
            tempDrw = (Bitmap)Draw.Clone();
            penColor = Color.Black;
            //lineWidth = 1;
        }

        
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            if (isPressed)
            {
                graphics.FillEllipse(Brushes.Black, e.X, e.Y, 3, 3);
            }
            delgr = graphics;
            //bck = e;

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delgr.Clear(Color.White);
        }
    }
}
