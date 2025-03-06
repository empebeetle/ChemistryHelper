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
        List<Particle> particles;

        public RigidContainerForm()
        {
            InitializeComponent();
            particles = this.Controls.OfType<Particle>().ToList(); //This code uses LINQ to filter the Controls collection and only include objects of type Particle, then converts the result to a List<Particle>. This ensures type safety and proper initialization of your particles list.
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

            //particles = this.Controls.Cast<Control>().Where(control => control.Name.ToLower().Contains("particle")).ToList();
            particles.ForEach(p => { p.Visible = false; 
                //p.Start(); 
            });
            //lambda expression, passing each particle in the list to the function that sets it to invisible and starts it.
            //particles.ForEach(p => bottle.Controls.Add(p));
        }


        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int visibleCount = trackBar1.Value;

            /*
            // First get the list of particles
            var particles = this.Controls.Cast<Control>()
                                         .Where(control => control.Name.ToLower().Contains("particle"))
                                         .ToList();

            */

            // Then set their visibility
            foreach (Particle p in particles)
            {
                string numberString = new String(p.Name.Where(Char.IsDigit).ToArray());
                if (int.TryParse(numberString, out int particleNumber))
                {
                    p.Visible = (particleNumber <= visibleCount);
                }
            }
        }
    }
}
