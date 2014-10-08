using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Early_Access
{
    public partial class Form1 : Form
    {
        DateTime dt1 = DateTime.Parse("08/24/2013 2:00 AM");
        DateTime dt2 = DateTime.Now;

        
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;

            if (dt1 <= dt2)
            {
                label1.Text = "YES";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "NO";
                label1.ForeColor = Color.Red;
            }

            System.Diagnostics.Debug.WriteLine(dt1);

            //timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dt1.Date <= dt2.Date)
            {
                label1.Text = "YES";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "NO";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
