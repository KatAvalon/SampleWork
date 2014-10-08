namespace FFXIV_Server_Status
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblNAEU = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.lblJP = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWorking = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNAEU
            // 
            this.lblNAEU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAEU.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNAEU.Location = new System.Drawing.Point(12, 9);
            this.lblNAEU.Name = "lblNAEU";
            this.lblNAEU.Size = new System.Drawing.Size(177, 18);
            this.lblNAEU.TabIndex = 0;
            this.lblNAEU.Text = "NA/EU Datacenter";
            this.lblNAEU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPing
            // 
            this.btnPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.Location = new System.Drawing.Point(12, 130);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(73, 28);
            this.btnPing.TabIndex = 1;
            this.btnPing.Text = "Ping!";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lblJP
            // 
            this.lblJP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJP.ForeColor = System.Drawing.Color.DarkRed;
            this.lblJP.Location = new System.Drawing.Point(12, 27);
            this.lblJP.Name = "lblJP";
            this.lblJP.Size = new System.Drawing.Size(167, 18);
            this.lblJP.TabIndex = 3;
            this.lblJP.Text = "JP Datacenter";
            this.lblJP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(9, 108);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(174, 19);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "Ping cooldown: 20 seconds";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FFXIV_Server_Status.Properties.Resources.ffxivboot_0002;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(151, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 136);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblWorking
            // 
            this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorking.ForeColor = System.Drawing.Color.White;
            this.lblWorking.Location = new System.Drawing.Point(91, 130);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(78, 28);
            this.lblWorking.TabIndex = 7;
            this.lblWorking.Text = "Working...";
            this.lblWorking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.ForeColor = System.Drawing.Color.White;
            this.lblMadeBy.Location = new System.Drawing.Point(12, 45);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(150, 63);
            this.lblMadeBy.TabIndex = 8;
            this.lblMadeBy.Text = "Made By: Kitty Inkura\\n-------------\\nMidgardsormr";
            this.lblMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElapsed
            // 
            this.lblElapsed.ForeColor = System.Drawing.Color.White;
            this.lblElapsed.Location = new System.Drawing.Point(175, 121);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(97, 40);
            this.lblElapsed.TabIndex = 9;
            this.lblElapsed.Text = "Last ping";
            this.lblElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.lblElapsed);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblJP);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.lblNAEU);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FF X|V: Latency Reborn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNAEU;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lblJP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Timer timer2;
    }
}

