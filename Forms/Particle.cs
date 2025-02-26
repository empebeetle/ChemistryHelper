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



        private int speedX = 1 //randy.Next(1, 5);
        public int SpeedX { get; set; }

        private int speedY = 1;
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
            timer.Interval = 32;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void setBoundaries(int top, int bottom, int left, int right)
        {
            new EventHandler(exceed_boundary);
        }
    }
}
