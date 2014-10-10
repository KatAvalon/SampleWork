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
    public partial class Calculator : Form
    {
        string output = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float meters;
            float floatConvert;
            float kilograms;

            if (txtFeet.Text == null || txtFeet.Text == "") txtFeet.Text = "0";
            if (txtInches.Text == null || txtInches.Text == "") txtInches.Text = "0";
            if (txtPounds.Text == null || txtPounds.Text == "") txtPounds.Text = "0";

            bool feetResult = float.TryParse(txtFeet.Text, out floatConvert);
            if (feetResult)
            {
                
                meters = floatConvert / 3.2808F;

                bool inchResult = float.TryParse(txtInches.Text, out floatConvert);
                if (inchResult)
                {
                    meters += (floatConvert / 39.370F);
                    output = meters + " meters";

                    bool lbResult = float.TryParse(txtPounds.Text, out floatConvert);
                    if (lbResult)
                    {
                        kilograms = (floatConvert / 2.2046F);
                        output += "\n" + kilograms + " kilograms";
                    }
                    else
                    {
                        output = "Please use actual numbers";
                    }
                }
                else
                {
                    output = "Please use actual numbers";
                }
            }
            else
            {
                output = "Please use actual numbers";
            }

            lblM.Text = output;
        }

        public void FormInsert()
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMeters.Text == null || txtMeters.Text == "") txtMeters.Text = "0";
            if (txtKilograms.Text == null || txtKilograms.Text == "") txtKilograms.Text = "0";

            float inches;
            float floatConvert;
            float pounds;

            bool metersResult = float.TryParse(txtMeters.Text, out floatConvert);
            if (metersResult)
            {
                inches = floatConvert * 39.370F;
                output = inches + " inches";

                bool lbResult = float.TryParse(txtKilograms.Text, out floatConvert);
                if (lbResult)
                {
                    pounds = (floatConvert * 2.2046F);
                    output += "\n" + pounds + " pounds";
                }
                else
                {
                    output = "You sure you doin' this right?";
                }

            }
            else
            {
                output = "You sure you doin' this right?";
            }

            lblI.Text = output;
        }

    }
}
