namespace ChemistryHelper
{
    partial class RigidContainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RigidContainerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHelperTools = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tempTxt = new System.Windows.Forms.TextBox();
            this.molesTxt = new System.Windows.Forms.TextBox();
            this.volumeTxt = new System.Windows.Forms.TextBox();
            this.pressureTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bottle = new System.Windows.Forms.PictureBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.cork = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cork)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.bHelperTools);
            this.panel1.Location = new System.Drawing.Point(-1, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 84);
            this.panel1.TabIndex = 44;
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
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(749, 491);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(100, 45);
            this.trackBar2.TabIndex = 43;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(516, 491);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(100, 45);
            this.trackBar1.TabIndex = 42;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MistyRose;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(632, 447);
            this.textBox2.MaximumSize = new System.Drawing.Size(100, 38);
            this.textBox2.MinimumSize = new System.Drawing.Size(100, 38);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "0.0821\r\n(L*atm)/(mol*K) ";
            // 
            // tempTxt
            // 
            this.tempTxt.BackColor = System.Drawing.Color.LightCyan;
            this.tempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTxt.Location = new System.Drawing.Point(749, 447);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.Size = new System.Drawing.Size(100, 38);
            this.tempTxt.TabIndex = 40;
            this.tempTxt.Text = "298.15";
            this.tempTxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // molesTxt
            // 
            this.molesTxt.BackColor = System.Drawing.Color.LightCyan;
            this.molesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molesTxt.Location = new System.Drawing.Point(516, 447);
            this.molesTxt.Name = "molesTxt";
            this.molesTxt.Size = new System.Drawing.Size(100, 38);
            this.molesTxt.TabIndex = 39;
            this.molesTxt.Text = "0";
            // 
            // volumeTxt
            // 
            this.volumeTxt.BackColor = System.Drawing.Color.LightCyan;
            this.volumeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTxt.Location = new System.Drawing.Point(248, 447);
            this.volumeTxt.Name = "volumeTxt";
            this.volumeTxt.Size = new System.Drawing.Size(100, 38);
            this.volumeTxt.TabIndex = 38;
            this.volumeTxt.Text = "1";
            // 
            // pressureTxt
            // 
            this.pressureTxt.BackColor = System.Drawing.Color.Bisque;
            this.pressureTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureTxt.Location = new System.Drawing.Point(133, 447);
            this.pressureTxt.Name = "pressureTxt";
            this.pressureTxt.ReadOnly = true;
            this.pressureTxt.Size = new System.Drawing.Size(100, 38);
            this.pressureTxt.TabIndex = 37;
            this.pressureTxt.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "P              V              =              n              R             T";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(355, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(261, 32);
            this.labelTitle.TabIndex = 35;
            this.labelTitle.Text = "RIGID CONTAINER";
            // 
            // bottle
            // 
            this.bottle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bottle.Image = ((System.Drawing.Image)(resources.GetObject("bottle.Image")));
            this.bottle.Location = new System.Drawing.Point(429, 81);
            this.bottle.Name = "bottle";
            this.bottle.Size = new System.Drawing.Size(113, 333);
            this.bottle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bottle.TabIndex = 34;
            this.bottle.TabStop = false;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(248, 491);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(100, 45);
            this.trackBar3.TabIndex = 45;
            this.trackBar3.Value = 1;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // cork
            // 
            this.cork.Image = ((System.Drawing.Image)(resources.GetObject("cork.Image")));
            this.cork.Location = new System.Drawing.Point(432, 52);
            this.cork.Name = "cork";
            this.cork.Size = new System.Drawing.Size(107, 33);
            this.cork.TabIndex = 46;
            this.cork.TabStop = false;
            // 
            // RigidContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.cork);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tempTxt);
            this.Controls.Add(this.molesTxt);
            this.Controls.Add(this.volumeTxt);
            this.Controls.Add(this.pressureTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bottle);
            this.Controls.Add(this.trackBar3);
            this.Name = "RigidContainerForm";
            this.Text = "RigidContainerForm";
            this.Load += new System.EventHandler(this.RigidContainerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bHelperTools;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.TextBox molesTxt;
        private System.Windows.Forms.TextBox volumeTxt;
        private System.Windows.Forms.TextBox pressureTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox bottle;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.PictureBox cork;
    }
}