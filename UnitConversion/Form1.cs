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
                        inchesToCentimetres(value);
                        break;
                    case 2:
                        feetToCentimetres(value);
                        break;
                    case 3:
                        yardsToMetres(value);
                        break;
                    case 4:
                        milesToKilometres(value);
                        break;
                }
            }
            catch
            {
                outputLabel.Text = "Invalid inputs";
            }
        }
        public void inchesToCentimetres(double inches)
        {
            double toCm = inches * 2.54;
            outputLabel.Text = $"{inches} inches = {toCm} centimetres";
        }
        public void feetToCentimetres(double feet)
        {
            double toCm = feet * 30.48;
            outputLabel.Text = $"{feet} feet = {toCm} centimetres";
        }
        public void yardsToMetres(double yards)
        {
            double toMetres = yards * 0.91;
            outputLabel.Text = $"{yards} yards = {toMetres} metres";
        }
        public void milesToKilometres(double miles)
        {
            double toKm = miles * 1.6;
            outputLabel.Text = $"{miles} miles = {toKm} kilometres";
        }
    }
}
