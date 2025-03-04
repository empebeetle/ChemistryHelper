using ChemistryHelper.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryHelper
{
    public partial class HelperToolsForm : Form
    {
        public HelperToolsForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);

            this.FormClosing += new FormClosingEventHandler(HelperToolsForm_FormClosing);
            //subscribes to this event

        }

        private void HelperToolsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HelperToolsForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ParticleViewForm().Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new RICETableForm().Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ChooseContainerForm().Show();
            Hide();
        }
    }
}
