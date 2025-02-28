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

        private Random randy;
        public Particle()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            randy = new Random();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }



        private int speedX = 3; //randy.Next(1, 5);
        public int SpeedX { get; set; }

        private int speedY = 3;
        public int SpeedY { get; set; }

        public void Move()
        {
            this.Location = new Point(this.Location.X + speedX, this.Location.Y + speedY);
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

        void particle_ExceedBoundary(object sender, EventArgs e)
        {

           if (this.Location.X < (0 + left) || ( this.Location.X + this.Width ) > (this.Parent.Width - right))
            {
                HorizontalCollide();
            }
            if (this.Location.Y < (0 + top)  || ( this.Location.Y + this.Height ) > (this.Parent.Height - bottom))
            {
                VerticalCollide();
            }
        }
    }
    
}
