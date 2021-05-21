using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(valueTextBox.Text);
                int conversionChoice = Convert.ToInt16(choiceTextBox.Text);
                if(conversionChoice > 4)
                {
                    outputLabel.Text = "Invalid conversion";
                    return;
                }

                switch (conversionChoice)
                {
                    case 1:
                        outputLabel.Text = $"{value} inches = {inchesToCentimetres(value).ToString("0.00")} centimetres";
                        break;
                    case 2:
                        feetToCentimetres(value);
                        outputLabel.Text = $"{value} feet = {feetToCentimetres(value).ToString("0.00")} centimetres";
                        break;
                    case 3:
                        yardsToMetres(value);
                        outputLabel.Text = $"{value} yards = {yardsToMetres(value).ToString("0.00")} metres";
                        break;
                    case 4:
                        milesToKilometres(value);
                        outputLabel.Text = $"{value} miles = {milesToKilometres(value).ToString("0.00")} kilometres";
                        break;
                }
            }
            catch
            {
                outputLabel.Text = "Invalid inputs";
            }
        }
        public double inchesToCentimetres(double inches)
        {
            double toCm = inches * 2.54;
            return toCm;
        }
        public double feetToCentimetres(double feet)
        {
            double toCm = feet * 30.48;
            return toCm;
        }
        public double yardsToMetres(double yards)
        {
            double toMetres = yards * 0.91;
            return toMetres;
        }
        public double milesToKilometres(double miles)
        {
            double toKm = miles * 1.6;
            return toKm;
        }
    }
}
