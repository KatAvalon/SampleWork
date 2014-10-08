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
using ForecastIO;
using System.Diagnostics;

namespace Weatherly_Outfitted
{
    public partial class MainForm : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();
        string icon;
        Random random = new Random();
        ForecastIOResponse wData;
        float latitude = 41.747f;
        float longitude = -89.743f;
        string hourlyString = "";
        string response = "";
        private Graphics GFX;

        public MainForm()
        {
            InitializeComponent();

            GFX = pboxPaperDoll.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startWorker();
        }

        private void startWorker()
        {
            int randomNumber = random.Next(0, 101);

            bw.DoWork +=
                new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            if (bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync();
                textBox1.Text = "IT'S LOADING (i think), BE PATIENT";
                pboxIcon.Image = Properties.Resources.loading;
                if (!(randomNumber >= 100))
                {
                    randomNumber = random.Next(0, 2);
                    if (randomNumber == 0)
                    {
                        pboxPaperDoll.Image = Properties.Resources.bar_loader;
                    }
                    else
                    {
                        pboxPaperDoll.Image = Properties.Resources.circle_loader;
                    }
                }
                else
                {
                    pboxPaperDoll.Image = Properties.Resources.pacman_loader;
                }
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            hourlyString = "";

            var request = new ForecastIORequest("bd996ecbf406f3ab16eae62ced5e3ed3", latitude, longitude, Unit.auto);
            wData = request.Get();
            response = "It took " + request.ApiResponseTime + " for a response and has been called " + request.ApiCallsMade + " times today.";
            
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime time;
            icon = Convert.ToString(wData.minutely.icon);
            Debug.WriteLine(icon);

            for (int i = 0; i < 12; i++)
            {
                time = (FromUnixTime(wData.hourly.data[i].time));
                var timeFormat = String.Format("{0:h:mm tt}", time);

                hourlyString += "At " + timeFormat;
                hourlyString += "\r\n ∙ " + wData.hourly.data[i].summary + " - Feels like " +  wData.hourly.data[i].apparentTemperature + "°F";
                hourlyString += "\r\n ∙ " + wData.hourly.data[i].humidity.ToString("#0.##%") + " humidity";

                if (hourlyString != "" && i < 11)
                {
                    hourlyString += "\r\n\r\n";
                }
            }

            textBox1.Text = hourlyString;

            if (!(e.Error == null))
            {
                this.lblDescription.Text = ("Error: " + e.Error.Message);
            }
            else
            {
                pboxPaperDoll.Image = null;
                pboxPaperDoll.Refresh();
                if (icon == "clear-day")
                {
                    //pboxPaperDoll.Image = Properties.Resources.i_like_shorts;
                    pboxIcon.Image = Properties.Resources.clear_day;

                    GFX.DrawImage(Properties.Resources.pants, new Point(5, 60));
                    GFX.DrawImage(Properties.Resources.shirt, new Point(0, 0));

                }
                else if (icon == "clear-night")
                {
                    pboxPaperDoll.Image = null;
                    pboxIcon.Image = Properties.Resources.clear_night;

                }
                else if (icon == "rain")
                {
                    pboxPaperDoll.Image = null;
                    pboxIcon.Image = Properties.Resources.rain;

                }
                else
                {
                    pboxPaperDoll.Image = null;
                    pboxIcon.Image = Properties.Resources.default_error;

                    //lblDescription.Text = "Something bad may have happened... or I just don't have something set up for the specified weather type yet!";
                }

                lblDescription.Text += "\r\n\r\n " + response;
            }
            //pboxPaperDoll.Refresh();
            
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("http://itouchmap.com/latlong.html");
        }

        public DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
            epoch = epoch.AddHours(wData.offset);
            return epoch;
        }


    }
}