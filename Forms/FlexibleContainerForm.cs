using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryHelper
{
    public partial class FlexibleContainerForm : Form
    {
        double n;
        double v;
        double t;
        double volume;
        double initialVolume = 11.4;

        public FlexibleContainerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
            n = Double.Parse(molesTxt.Text);
            v = Double.Parse(volumeTxt.Text);
            t = Double.Parse(tempTxt.Text);
            volume = (n * 0.0821 * t) / 1;
        }

        private void FlexibleContainerForm_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void molesTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            molesTxt.Text = n * trackBar1.Value / 5 + "";
            resizeBalloon();

        }

        private void resizeBalloon()
        {
            // keeps the balloon centered.

            Size size = new Size(pictureBox1.Width, pictureBox1.Height);
            Size bize = pictureBox1.Size;
            Random bruh = new Random();
            Point ogCenter = new Point((pictureBox1.Width) / 2 + pictureBox1.Location.X, pictureBox1.Location.Y - pictureBox1.Height / 2);
            Point corner;
            Point newCenter;
            for (int i = 0; i < 1; i++)
            {
                corner = pictureBox1.Location;
                size.Width = (int)(size.Width * getVolume()/initialVolume); //the multiplier should be proportional to the rate in change of surface area to volume.
                size.Height = (int)(size.Height * getVolume() / initialVolume);
                pictureBox1.Size = size;
                newCenter = new Point((pictureBox1.Width) / 2 + pictureBox1.Location.X, pictureBox1.Location.Y - pictureBox1.Height / 2);
                pictureBox1.Location = new Point(pictureBox1.Location.X + ogCenter.X - newCenter.X, pictureBox1.Location.Y - ogCenter.Y + newCenter.Y);
            }
        }
        
        private double getVolume()
        {
            n = Double.Parse(molesTxt.Text);
            v = Double.Parse(volumeTxt.Text);
            t = Double.Parse(tempTxt.Text);
            return volume = (n * 0.0821 * t) / 1;
        }

    }
}
