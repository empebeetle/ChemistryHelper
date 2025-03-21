﻿using System;
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
    public partial class ChooseContainerForm : Form
    {
        public ChooseContainerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
        }

        private void ChooseContainerForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FlexibleContainerForm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RigidContainerForm().Show();
            this.Hide();
        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new HelperToolsForm().Show();
            this.Hide();
        }
    }
}
