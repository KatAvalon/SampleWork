using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Log_in_simulator
{
    public partial class Form2 : Form
    {
        int stage = 0;
        int queueTimer;
        Random randomizer = new Random();

        public Form2()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            MessageBox.Show("USE \"0\" ON YOUR NUMBERPAD TO FIGHT THE LOGIN BOSS");
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                int loginRandom = 0;

                    if (stage == 0)
                    {
                        disableBoxes();
                        pictureBox1.BackgroundImage = Properties.Resources.character;
                        stage = 1;
                        
                    }
                    else if (stage == 1)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources._1017;
                        loginRandom = randomizer.Next(0, 11);
                        if (loginRandom == 10)
                        {
                            pictureBox1.BackgroundImage = Properties.Resources.queue;
                            int queueTime = randomizer.Next(20, 50);
                            queueTimer = queueTime;
                            timer1.Start();
                            stage = 3;
                        }
                        else
                        {
                            pictureBox1.BackgroundImage = Properties.Resources._1017;
                            stage = 2;
                        }
                    }
                    else if (stage == 2)
                    {
                        enableBoxes();
                        pictureBox1.BackgroundImage = Properties.Resources.start_screen;
                        stage = 0;
                        
                    }
                    else if (stage == 3)
                    {
                    }
            }
        }

        public void enableBoxes()
        {
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
        }

        public void disableBoxes()
        {
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            queueTimer = queueTimer - 1;

            if (queueTimer <= 0)
            {
                pictureBox1.BackgroundImage = Properties.Resources._1017;
                stage = 2;
                timer1.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GO AHEAD, DON'T BE SCARED. YOU KNOW YOU WANT TO HIT THAT 0.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Want to join our FC, Vanguard of Vylbrand (VoV)? Send anyone a message!\nHere's a shortened link to our FC on the lodestone: http://d.pr/dOmn\n\nMade by Kitty Inkura of Midgardsormr");
        }
    }
}
