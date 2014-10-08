namespace Weatherly_Outfitted
{
    partial class MainForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pboxIcon = new System.Windows.Forms.PictureBox();
            this.pboxPaperDoll = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPaperDoll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 446);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(366, 86);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Some shit goes in here, probably a summary of the weather for today (high point a" +
    "t what time, low point at what time, average wind speed, cloudcover, whatever th" +
    "e fuck)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "This is where the \r\npaper doll goes";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(200, 430);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Find your latitude and longitude here!";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(178, 280);
            this.textBox1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Weatherly_Outfitted.Properties.Resources.banner;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(366, 61);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pboxIcon
            // 
            this.pboxIcon.Location = new System.Drawing.Point(200, 79);
            this.pboxIcon.Name = "pboxIcon";
            this.pboxIcon.Size = new System.Drawing.Size(178, 62);
            this.pboxIcon.TabIndex = 3;
            this.pboxIcon.TabStop = false;
            // 
            // pboxPaperDoll
            // 
            this.pboxPaperDoll.BackColor = System.Drawing.Color.Transparent;
            this.pboxPaperDoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxPaperDoll.Location = new System.Drawing.Point(12, 79);
            this.pboxPaperDoll.Name = "pboxPaperDoll";
            this.pboxPaperDoll.Size = new System.Drawing.Size(182, 321);
            this.pboxPaperDoll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxPaperDoll.TabIndex = 1;
            this.pboxPaperDoll.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 541);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pboxIcon);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pboxPaperDoll);
            this.Name = "MainForm";
            this.Text = "Weatherly Outfitted";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPaperDoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxPaperDoll;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pboxIcon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

