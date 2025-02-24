namespace ChemistryHelper
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHelperTools = new System.Windows.Forms.Button();
            this.txtDaysUntilExam = new System.Windows.Forms.TextBox();
            this.txtDayCounter = new System.Windows.Forms.TextBox();
            this.bSetExamDate = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtAPQuestion = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.bHelperTools);
            this.panel1.Controls.Add(this.txtDaysUntilExam);
            this.panel1.Controls.Add(this.txtDayCounter);
            this.panel1.Controls.Add(this.bSetExamDate);
            this.panel1.Location = new System.Drawing.Point(-2, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 84);
            this.panel1.TabIndex = 0;
            // 
            // bHelperTools
            // 
            this.bHelperTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bHelperTools.Location = new System.Drawing.Point(350, 17);
            this.bHelperTools.Name = "bHelperTools";
            this.bHelperTools.Size = new System.Drawing.Size(300, 47);
            this.bHelperTools.TabIndex = 3;
            this.bHelperTools.Text = "Helper Tools";
            this.bHelperTools.UseVisualStyleBackColor = false;
            this.bHelperTools.Click += new System.EventHandler(this.bHelperTools_Click);
            // 
            // txtDaysUntilExam
            // 
            this.txtDaysUntilExam.Location = new System.Drawing.Point(53, 45);
            this.txtDaysUntilExam.Name = "txtDaysUntilExam";
            this.txtDaysUntilExam.ReadOnly = true;
            this.txtDaysUntilExam.Size = new System.Drawing.Size(96, 20);
            this.txtDaysUntilExam.TabIndex = 2;
            this.txtDaysUntilExam.Text = "Days Until Exam";
            this.txtDaysUntilExam.TextChanged += new System.EventHandler(this.txtDaysUntilExam_TextChanged);
            // 
            // txtDayCounter
            // 
            this.txtDayCounter.Location = new System.Drawing.Point(15, 46);
            this.txtDayCounter.Name = "txtDayCounter";
            this.txtDayCounter.ReadOnly = true;
            this.txtDayCounter.Size = new System.Drawing.Size(31, 20);
            this.txtDayCounter.TabIndex = 1;
            this.txtDayCounter.TextChanged += new System.EventHandler(this.txtDayCounter_TextChanged);
            // 
            // bSetExamDate
            // 
            this.bSetExamDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSetExamDate.Location = new System.Drawing.Point(15, 17);
            this.bSetExamDate.Name = "bSetExamDate";
            this.bSetExamDate.Size = new System.Drawing.Size(134, 23);
            this.bSetExamDate.TabIndex = 0;
            this.bSetExamDate.Text = "Set Exam Date";
            this.bSetExamDate.UseVisualStyleBackColor = false;
            this.bSetExamDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(352, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(293, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "CHEMISTRY HELPER";
            // 
            // txtAPQuestion
            // 
            this.txtAPQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAPQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPQuestion.Location = new System.Drawing.Point(200, 81);
            this.txtAPQuestion.Name = "txtAPQuestion";
            this.txtAPQuestion.Size = new System.Drawing.Size(600, 250);
            this.txtAPQuestion.TabIndex = 2;
            this.txtAPQuestion.Text = resources.GetString("txtAPQuestion.Text");
            this.txtAPQuestion.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 382);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(918, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txtAPQuestion);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSetExamDate;
        private System.Windows.Forms.TextBox txtDaysUntilExam;
        private System.Windows.Forms.TextBox txtDayCounter;
        private System.Windows.Forms.Button bHelperTools;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RichTextBox txtAPQuestion;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
    }
}

