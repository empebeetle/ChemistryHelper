using ChemistryHelper.Forms;
using ChemistryHelper.Properties;
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
        double n;
        double nInitial = 0;
        double v;
        double t;
        double vInitial = 1;
        double tInitial = 298.15;
        double p;
        double pInitial = 0;
        Random random = new Random();
        double corkStartingLocation;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticleViewForm));

        public RigidContainerForm()
        {
            InitializeComponent();
            //particles = this.Controls.OfType<Particle>().ToList(); //This code uses LINQ to filter the Controls collection and only include objects of type Particle, then converts the result to a List<Particle>. This ensures type safety and proper initialization of your particles list.
            particles = new List<Particle>();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
            CreateParticles();
            Console.WriteLine(particles.Count);
            corkStartingLocation = cork.Location.Y;
        }

        private void CreateParticles()
        {
            for (int i = 0; i < 10; i++)
            {
                Particle particle = new Particle
                {
                    Name = "particle" + i,
                    Size = new Size(27, 27),
                    Location = new Point(random.Next(10, 30), random.Next(10, 30)),
                    SpeedX = random.Next(1, 5) * random.NextDouble() + 3,
                    SpeedY = random.Next(1, 5) * random.NextDouble() + 3,
                    
                    Image = ((System.Drawing.Image)(resources.GetObject("particle2.Image")))
                };
                particle.InitialParticleSpeeds();
                particles.Add(particle);
            }
        }

        private void RigidContainerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            

            
            this.SetControls();
            trackBar3.Value = 100;
            trackBar1.Value = 0;
            trackBar2.Value = 5;

        }

        private double getVolume()
        {
            n = Double.Parse(molesTxt.Text);
            t = Double.Parse(tempTxt.Text);
            v = (n * 0.0821 * t) / 1;
            volumeTxt.Text = v + "";
            return v;
        }

        private double getPressure()
        {
            n = Double.Parse(molesTxt.Text);
            t = Double.Parse(tempTxt.Text);
            v = Double.Parse(volumeTxt.Text);
            p = (n * 0.0821 * t) / v;
            pressureTxt.Text = p + "";
            return p;
        }

        private void molesTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
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
            }
        }

        private void SetControls()
        {
            particles.ForEach(p => { bottle.Controls.Add(p); p.Visible = false; p.Start(); });
        }


        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int visibleCount = trackBar1.Value;
            molesTxt.Text = trackBar1.Value + "";

            for (int i = 0; i < visibleCount; i++)
            {
                particles[i].Visible = true;
            }
            for (int i = visibleCount; i < particles.Count; i++)
            {
                particles[i].Visible = false;
            }
            getPressure();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            volumeTxt.Text = (double) trackBar3.Value/100 + "";
            cork.Location = new Point(cork.Location.X, (int) (corkStartingLocation + ((100 - (double) trackBar3.Value)/100 * bottle.Height)));
            foreach (Particle p in particles)
            {
                p.setTopBoundary(cork.Location.Y);
            }
            getPressure();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            tempTxt.Text = tInitial * (double)trackBar2.Value / 5 + "";
            foreach (Particle p in particles)
            {
                p.SpeedX = p.InitialXSpeed * trackBar2.Value / 5;
                p.SpeedY = p.InitialYSpeed * trackBar2.Value / 5;
                
            }
            getPressure();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
