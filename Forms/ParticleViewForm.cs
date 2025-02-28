using System;
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
    public partial class ParticleViewForm : Form
    {
        public ParticleViewForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
            pictureBox1.Controls.Add(particle2);
            pictureBox1.Controls.Add(particle1);
            pictureBox1.Controls.Add(particle3);
            pictureBox1.Controls.Add(particle4);


            //particle1.Location = new Point(pictureBox1.Left + pictureBox1.Width/2, pictureBox1.Top + pictureBox1.Height / 2);
            particle2.Location = new Point(35, 72);
            particle3.Location = new Point(60, 60);
            particle4.Location = new Point(10, 10);
            particle1.Location = new Point(19, 20);

        }

        private void ParticleViewForm_Load(object sender, EventArgs e)
        {

        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new HelperToolsForm().Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void transparentPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void particle1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            particle2.setBoundaries(60, 10, 23, 23);

            particle2.Start();
            particle1.Start();
            particle3.Start();
            particle4.Start();
            particle2.SpeedX = 30;
            particle2.SpeedY = 30;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void particle2_Click(object sender, EventArgs e)
        {

        }
    }
}
