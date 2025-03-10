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
        Random random = new Random();

        public RigidContainerForm()
        {
            InitializeComponent();
            //particles = this.Controls.OfType<Particle>().ToList(); //This code uses LINQ to filter the Controls collection and only include objects of type Particle, then converts the result to a List<Particle>. This ensures type safety and proper initialization of your particles list.
            particles = new List<Particle>();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
            CreateParticles();
            Console.WriteLine(particles.Count);
        }

        private void CreateParticles()
        {
            // Example of creating particles
            for (int i = 0; i < 10; i++)
            {
                Particle particle = new Particle
                {
                    Name = "particle" + i,
                    Size = new Size(27, 27),
                    Location = new Point(random.Next(10, 30) , random.Next(10,30)),
                    SpeedX = random.Next(1, 5) * random.NextDouble() + 3,
                    SpeedY = i,
                    Image = Image.FromFile("C:/__Students/Li/ChemistryHelper/Photos/small sulfur.png")
                }
                ;
                particles.Add(particle);
            }
        }

        private void RigidContainerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            

            
            this.SetControls();

        }

        private void SetControls()
        {
            for (int i = 0; i < particles.Count; i++)
            {
                bottle.Controls.Add(particles[i]);
            }
            //particles = this.Controls.Cast<Control>().Where(control => control.Name.ToLower().Contains("particle")).ToList();
            particles.ForEach(p => { p.Visible = false; 
                p.Start(); 
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
            /*
            foreach (Particle p in particles)
            {
                string numberString = new String(p.Name.Where(Char.IsDigit).ToArray());
                if (int.TryParse(numberString, out int particleNumber))
                {
                    p.Visible = (particleNumber <= visibleCount);
                }
            }
            */

            for (int i = 0; i < visibleCount; i++)
            {
                particles[i].Visible = true;
            }
            for (int i = visibleCount; i < particles.Count; i++)
            {
                particles[i].Visible = false;
            }
        }

        private void particle4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            cork.Location = new Point(cork.Location.X, cork.Location.Y - trackBar3.Value * bottle.Height);
            foreach (Particle p in particles)
            {
                p.setTopBoundary(cork.Location.Y);
            }
        }
    }
}
