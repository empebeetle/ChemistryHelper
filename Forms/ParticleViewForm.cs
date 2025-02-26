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
            //particle1.Location = new Point(pictureBox1.Left + pictureBox1.Width/2, pictureBox1.Top + pictureBox1.Height / 2);
            particle2.Location = new Point(35, 72);

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

            particle2.Start();            
        }
    }
}
