using ChemistryHelper.Forms;
using System;
using System.Collections;
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
    public partial class RigidContainerForm : Form
    {
        List<Particle> particles = new List<Particle>();
        public RigidContainerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
            //for (int i = 0; i < 10; i++)
            //{
            //    particles[i] = particle1
            //}
            foreach (Control p in Controls)
            {
                if (p is Particle)
                {
                    particles.Add((Particle)p);
                    p.Enabled = false;
                }
                //particles.Add(p);
                //p.Enabled = false;
            }
        }


        private void RigidContainerForm_Load(object sender, EventArgs e)
        {

        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < trackBar1.Value; i++)
            {
                //Particle p = new Particle();
                //p.Location = new Point(100, 100);
                //p.Size = new Size(10, 10);
                //p.BackColor = Color.Red;
                //p.SpeedX = 3;
                //p.SpeedY = 3;
                //p.Start();
                //Controls.Add(p);
                particles[i].Enabled = true;
                particles[i].Start();
            }
        }
    }
}
