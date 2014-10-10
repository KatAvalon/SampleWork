namespace FFXIV_Crafting_Calculator
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblGil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblMadeBy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(243, 38);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hempen Yarn",
            "Undyed Hempen Cloth",
            "Hempen Halfgloves",
            "Hempen Underpants",
            "Hempen Pantalettes",
            "Hempen Undershirt",
            "Hempen Coif",
            "Hempen Camise",
            "Hempen Breeches of Crafting",
            "Hempen Kurta",
            "Hempen Coif of Gathering",
            "Hempen Shepherd\'s Slops",
            "Hempen Dalmatica",
            "Hempen Breeches",
            "Hempen Dalmatica of Gathering",
            "Hempen Tunic",
            "Hempen Cowl",
            "Hempen Sarouel",
            "Hempen Chausses",
            "Hempen Tights",
            "Hempen Bandana"});
            this.comboBox1.Location = new System.Drawing.Point(186, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the item:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many do you want to make?";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 160);
            this.listBox1.TabIndex = 5;
            // 
            // lblGil
            // 
            this.lblGil.AutoSize = true;
            this.lblGil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGil.ForeColor = System.Drawing.Color.White;
            this.lblGil.Location = new System.Drawing.Point(10, 65);
            this.lblGil.Name = "lblGil";
            this.lblGil.Size = new System.Drawing.Size(105, 20);
            this.lblGil.TabIndex = 6;
            this.lblGil.Text = "Gil Required: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "(Raw materials needed)";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(191, 186);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(172, 75);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "VERSION: 1.1.0.0";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Click += new System.EventHandler(this.lblMaterials_Click);
            // 
            // lblMadeBy
            // 
            this.lblMadeBy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.lblMadeBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMadeBy.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMadeBy.ForeColor = System.Drawing.Color.White;
            this.lblMadeBy.Location = new System.Drawing.Point(191, 101);
            this.lblMadeBy.Name = "lblMadeBy";
            this.lblMadeBy.Size = new System.Drawing.Size(172, 75);
            this.lblMadeBy.TabIndex = 9;
            this.lblMadeBy.Text = "Made By: Kitty Inkura of Midgardsormr";
            this.lblMadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMadeBy.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FFXIV_Crafting_Calculator.Properties.Resources.ffxivboot_0002;
            this.pictureBox1.Location = new System.Drawing.Point(90, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(375, 270);
            this.Controls.Add(this.lblMadeBy);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGil);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Final Fantasy X|V: A Crafter Reborn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblMadeBy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

