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
            Console.WriteLine(particles.Count);
        }

        private void RigidContainerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.Controls.Cast<Control>()
                         .Where(control => control.Name.ToLower().Contains("particle"))
                         .ToList()
                         .ForEach(p => p.Visible = false);
        }


        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int visibleCount = trackBar1.Value;

            // First get the list of particles
            var particles = this.Controls.Cast<Control>()
                                         .Where(control => control.Name.ToLower().Contains("particle"))
                                         .ToList();

            // Then set their visibility
            foreach (var particle in particles)
            {
                string numberString = new String(particle.Name.Where(Char.IsDigit).ToArray());
                if (int.TryParse(numberString, out int particleNumber))
                {
                    particle.Visible = (particleNumber <= visibleCount);
                }
            }
        }
    }
}
