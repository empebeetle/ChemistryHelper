using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization; // code tutorial from https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to 
using System.Windows.Forms;



namespace ChemistryHelper
{
    public partial class HomePage : Form
    {
        DateTime examDate;
        public HomePage()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1000, 650);
            this.MaximumSize = new Size(1000, 650);

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !monthCalendar1.Visible;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            examDate = monthCalendar1.SelectionStart;
            updateExamDate();
            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bHelperTools_Click(object sender, EventArgs e)
        {
            new HelperToolsForm().Show();
            Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            Hide();
        }

        private void txtDayCounter_TextChanged(object sender, EventArgs e)
        {
            updateExamDate();
        }

        private void updateExamDate()
        {
            TimeSpan timeUntilExam = examDate - DateTime.Now;
            txtDayCounter.Text = timeUntilExam.Days + "";
            
        }

        private void txtDaysUntilExam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
