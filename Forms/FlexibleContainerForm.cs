using ChemistryHelper.Forms;
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
        double nInitial;
        double v;
        double t;
        double vInitial = 11.4;
        double tInitial = 298.15;
        Size size = new Size(); //size of the balloon
        Size sizeInitial = new Size();
        Random bruh = new Random();

        public FlexibleContainerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650); //window size
            this.MaximumSize = new Size(1000, 650);
            n = Double.Parse(molesTxt.Text);
            nInitial = Double.Parse(molesTxt.Text);
            v = Double.Parse(volumeTxt.Text);
            t = Double.Parse(tempTxt.Text);
            sizeInitial.Width = pictureBox1.Width;
            sizeInitial.Height = pictureBox1.Height;
            
            
        }

        private void FlexibleContainerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            trackBar1.Value = 5;
            trackBar2.Value = 5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Location = new Point(bruh.Next(250, 750), bruh.Next(0, 400));

        }

        private void molesTxt_TextChanged(object sender, EventArgs e) //BROKEN
        {

        }

        private void molesTxt_KeyDown(object sender, KeyEventArgs e) 
        {                        
            if(e.KeyData == Keys.Enter)   
            {
                if (molesTxt.Text == "0" || molesTxt.Text == "")
                {
                    molesTxt.Text = "0.1";
                }
                if (Double.TryParse(molesTxt.Text, out double placeholder) == false)
                {
                    MessageBox.Show("not a number.");
                    molesTxt.Text = n.ToString();
                    
                }
                if (Double.Parse(molesTxt.Text) > 0.9314)
                {
                    molesTxt.Text = "0.9314";
                }
                //never handles negatives
                resizeBalloon();
            }             
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tempTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (Double.TryParse(tempTxt.Text, out double placeholder) == false)
                {
                    MessageBox.Show("not a number.");
                    tempTxt.Text = t.ToString();
                    t = placeholder;

                }

                if (tempTxt.Text == "0" || tempTxt.Text == "")
                {
                    tempTxt.Text = "59.63";
                }

                if (Double.Parse(tempTxt.Text) > 596.3)
                {
                    tempTxt.Text = "596.3";
                }
                resizeBalloon();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            molesTxt.Text = nInitial * (double) trackBar1.Value / 5 + "";
            resizeBalloon();

        }

        private void resizeBalloon()
        {
            // keeps the balloon centered.


            Point ogCenter = new Point((pictureBox1.Width) / 2 + pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Height / 2);
            Point corner;
            Point newCenter;

            corner = pictureBox1.Location;
            size.Width = (int)(sizeInitial.Width * getVolume()/vInitial); //the multiplier should be proportional to the rate in change of surface area to volume.
            size.Height = (int)(sizeInitial.Height * getVolume() / vInitial);
            pictureBox1.Size = size;
            newCenter = new Point((pictureBox1.Width) / 2 + pictureBox1.Location.X, pictureBox1.Location.Y + pictureBox1.Height / 2);
            pictureBox1.Location = new Point(pictureBox1.Location.X + ogCenter.X - newCenter.X, pictureBox1.Location.Y + ogCenter.Y - newCenter.Y);
            
        }
        
        private double getVolume()
        {
            n = Double.Parse(molesTxt.Text);
            t = Double.Parse(tempTxt.Text);
            v = (n * 0.0821 * t) / 1;
            volumeTxt.Text = v + "";
            return v;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            tempTxt.Text = tInitial * (double)trackBar2.Value / 5 + "";
            resizeBalloon();
        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void particle1_Click(object sender, EventArgs e)
        {
        }

        private void volumeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
