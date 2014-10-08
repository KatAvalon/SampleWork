using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Server_Status
{
    public partial class Form1 : Form
    {
        decimal timeLeft = 0.0m;
        int timeElapsed = 0;
        
        Server NA_EU = new Server() { IP = "184.107.107.176" };
        Server JP = new Server() { IP = "202.67.53.202" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PingServers();

            timeElapsed = 0;
            timer2.Tick += new EventHandler(timeElapsed_Tick);
            timer2.Start();

            timeLeft = 2;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
            lblTimer.Font = new Font(lblTimer.Font.FontFamily, 9);
            lblMadeBy.Text = "Made By: Kitty Inkura\n-------------\nMidgardsormr";
            lblElapsed.Text = "Last ping was:\n" + timeElapsed + " seconds ago";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 0.1m;
                lblTimer.Text = "Ping cooldown: " + timeLeft + " seconds";
                lblTimer.ForeColor = Color.DarkRed;
                btnPing.Enabled = false;
            }
            else
            {
                timer1.Stop();
                btnPing.Enabled = true;
                lblTimer.Text = "Ping when ready!";
                lblTimer.ForeColor = Color.Green;
            }
        }

        void timeElapsed_Tick(object sender, EventArgs e)
        {
            timeElapsed = timeElapsed + 1;
            lblElapsed.Text = "Last ping was:\n" + timeElapsed + " seconds ago";
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                MessageBox.Show("I can't let you do that, Dave");
            }
            else
            {
                PingServers();
            }
        }

        private void PingServers()
        {
            string String = "";

            if (timeLeft > 0)
            {
                MessageBox.Show("I can't let you do that, Dave");
            }
            else
            {
                lblWorking.Enabled = true;

                if (NA_EU.PingServer(NA_EU.IP) || JP.PingServer(JP.IP))
                {
                    String += "Your average latency to the NA/EU Datacenter is: " + NA_EU.PingTimeAverage(NA_EU.IP, 4);
                    lblNAEU.Text = "NA/EU Datacenter: " + NA_EU.Latency + "ms";
                    lblNAEU.ForeColor = Color.Green;

                    if (JP.PingServer(JP.IP))
                    {
                        String += "\nYour average latency to the JP Datacenter is: " + JP.PingTimeAverage(JP.IP, 4);
                        lblJP.Text = "JP Datacenter: " + JP.Latency + "ms";
                        lblJP.ForeColor = Color.Green;
                    }
                    else
                    {
                        String += "\nThe JP datacenter is not reachable!";
                        lblJP.Text = "JP Datacenter: Unreachable!";
                        lblJP.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    String += "\nThe NA/EU datacenter is not reachable!";
                    lblNAEU.Text = "NA/EU Datacenter: Unreachable!";
                    lblNAEU.ForeColor = Color.DarkRed;
                }

                timeElapsed = 0;
                timeLeft = 20;
                timer1.Start();
                lblWorking.Enabled = false;
            }
        }
    }
}
