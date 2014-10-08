using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FFXIV_Log_in_simulator
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int lollogin;
        int loltimer;

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;

            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int loginRandom = randomizer.Next(0, 11);
            lollogin = loginRandom;
            int loginTimeRandom = randomizer.Next(0, 10);
            loltimer = loginTimeRandom;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loltimer <= 0)
            {
                timer1.Stop();
                if (lollogin >= 3 && lollogin < 5)
                {
                    MessageBox.Show("LOL WRONG PASSWORD TRY AGAIN");
                    timer1.Stop();
                }
                else if (lollogin < 3)
                {
                    MessageBox.Show("CONNECTION ERROR TRY AGAIN");
                    timer1.Stop();
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                    timer1.Stop();
                }
                timer1.Stop();
            } else 
            {
                loltimer = loltimer - 1;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YEP, EVERYTHING IS ONLINE! COME LOG IN, ADVENTURERS");
        }
    }
}
