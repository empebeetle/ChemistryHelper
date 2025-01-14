using System;
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
        public RigidContainerForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);
        }

        private void RigidContainerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
