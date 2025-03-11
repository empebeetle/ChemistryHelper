using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryHelper.Forms
{
    public partial class Particle : PictureBox
    {
        int left = 0;
        int right = 0;
        int top = 0;
        int bottom = 0;
        double initialXSpeed;
        double initialYSpeed;
        Random random = new Random();

        public Particle()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            //InitialParticleSpeeds();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }



        private double speedX; //randy.Next(1, 5);
        public double SpeedX
        {
            get { return speedX; }
            set { speedX = value; }
        }

        private double speedY;
        public double SpeedY
        {
            get { return speedY; }
            set { speedY = value; }
        }

        public double InitialXSpeed
        {
            get { return initialXSpeed; }
            set { initialXSpeed = value; }
        }

        public double InitialYSpeed
        {
            get { return initialYSpeed; }
            set { initialYSpeed = value; }
        }

        public void InitialParticleSpeeds()
        {

            InitialXSpeed = SpeedX;
            InitialYSpeed = SpeedY;
        }

        public void Move()
        {
            this.Location = new Point(this.Location.X + (int) speedX, this.Location.Y + (int) speedY);
        }

        public void VerticalCollide()
        {
            speedY = -speedY;
        }
        public void HorizontalCollide()
        {
            speedX = -speedX;
        }

        Timer timer = new Timer();
        public void Start()
        {
            timer.Interval = 16;
            timer.Tick += new EventHandler(timer_Tick) + new EventHandler(particle_ExceedBoundary);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void setBoundaries(int top, int bottom, int left, int right)
        {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
        }

        public void setTopBoundary(int top)
        {
            this.top = top;
        }

        void particle_ExceedBoundary(object sender, EventArgs e)
        {

           if (this.Location.X < (left) || ( this.Location.X + this.Width ) > (this.Parent.Width - right))
            {
                HorizontalCollide();
            }
            if (this.Location.Y < (top)  || ( this.Location.Y + this.Height ) > (this.Parent.Height - bottom))
            {
                VerticalCollide();
            }
        }
    }
    
}
