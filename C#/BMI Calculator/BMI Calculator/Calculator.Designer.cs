namespace BMI_Calculator
{
    partial class Calculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblI = new System.Windows.Forms.Label();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(159, 238);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPounds);
            this.tabPage1.Controls.Add(this.lblM);
            this.tabPage1.Controls.Add(this.txtInches);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtFeet);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(151, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "I -> M";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(64, 78);
            this.txtPounds.MaxLength = 5;
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(61, 20);
            this.txtPounds.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pounds";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblM
            // 
            this.lblM.BackColor = System.Drawing.Color.Transparent;
            this.lblM.Location = new System.Drawing.Point(6, 113);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(139, 51);
            this.lblM.TabIndex = 4;
            this.lblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(64, 49);
            this.txtInches.MaxLength = 4;
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(61, 20);
            this.txtInches.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inches";
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(64, 17);
            this.txtFeet.MaxLength = 2;
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(61, 20);
            this.txtFeet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feet";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.lblI);
            this.tabPage2.Controls.Add(this.txtKilograms);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtMeters);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(151, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "M -> I";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblI
            // 
            this.lblI.BackColor = System.Drawing.Color.Transparent;
            this.lblI.Location = new System.Drawing.Point(6, 96);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(139, 65);
            this.lblI.TabIndex = 8;
            this.lblI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKilograms
            // 
            this.txtKilograms.Location = new System.Drawing.Point(70, 49);
            this.txtKilograms.MaxLength = 5;
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(61, 20);
            this.txtKilograms.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kilograms";
            // 
            // txtMeters
            // 
            this.txtMeters.Location = new System.Drawing.Point(70, 17);
            this.txtMeters.MaxLength = 6;
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.Size = new System.Drawing.Size(61, 20);
            this.txtMeters.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Meters";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 262);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKilograms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblI;
    }
}