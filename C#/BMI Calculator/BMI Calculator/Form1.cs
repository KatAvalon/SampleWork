using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        bool red = false;

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                double BMI = (int.Parse(textBox2.Text) / Math.Pow(float.Parse(textBox1.Text), 2) * 703);
                label1.Text = Convert.ToString(BMI);

                if (BMI <= 18.5)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Underweight";
                }
                else if (BMI > 15.5 && BMI < 25)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Normal";
                }
                else if (BMI >= 25 && BMI < 40)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Overweight";
                }
                else
                {
                    label3.ForeColor = Color.Orange;
                    label3.Text = "Something broke..";
                    timer1.Start();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Are you sure those are numbers?");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                double BMI = float.Parse(textBox4.Text) / Math.Pow(float.Parse(textBox3.Text), 2);
                label2.Text = Convert.ToString(BMI);

                if (BMI <= 18.5)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Underweight";
                }
                else if (BMI > 15.5 && BMI < 25)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Normal";
                }
                else if (BMI >= 25 && BMI < 40)
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Overweight";
                }
                else
                {
                    label3.ForeColor = Color.Orange;
                    label3.Text = "Something broke..";
                    timer1.Start();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Are you sure those are numbers?");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (red == false)
            {
                label3.ForeColor = Color.Red;
                red = true;
            }
            else
            {
                label3.ForeColor = Color.Orange;
                red = false;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ain't finished yet home skillet!");
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
