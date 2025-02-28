namespace ChemistryHelper
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHelperTools = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.bHelperTools);
            this.panel1.Location = new System.Drawing.Point(-1, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 84);
            this.panel1.TabIndex = 46;
            // 
            // bHelperTools
            // 
            this.bHelperTools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bHelperTools.Location = new System.Drawing.Point(794, 17);
            this.bHelperTools.Name = "bHelperTools";
            this.bHelperTools.Size = new System.Drawing.Size(154, 47);
            this.bHelperTools.TabIndex = 3;
            this.bHelperTools.Text = "Back";
            this.bHelperTools.UseVisualStyleBackColor = false;
            this.bHelperTools.Click += new System.EventHandler(this.bHelperTools_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Unit 1: Atomic Structure and Properties",
            "Unit 2: Compound Structure and Properties",
            "Unit 3: Properties of Substances and Mixtures",
            "Unit 4: Chemical Reactions",
            "Unit 5: Kinetics",
            "Unit 6: Thermochemistry",
            "Unit 7: Equilibrium",
            "Unit 8: Acids and Bases",
            "Unit 9: Thermodynamics and Electrochemistry"});
            this.checkedListBox1.Location = new System.Drawing.Point(73, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(604, 301);
            this.checkedListBox1.TabIndex = 47;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(421, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(153, 32);
            this.labelTitle.TabIndex = 48;
            this.labelTitle.Text = "SETTINGS";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Units Completed:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Click to reset question history";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(683, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 184);
            this.button2.TabIndex = 52;
            this.button2.Text = "click for freak mode";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bHelperTools;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}