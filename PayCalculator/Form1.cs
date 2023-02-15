using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //variable declarations
                double hours, rate, pretax, taxes, earned;
                double taxRate = .20;

                //get inputs
                hours = Convert.ToDouble(hoursInput.Text);
                rate = Convert.ToDouble(payInput.Text);

                //do calculations
                pretax = hours * rate;
                taxes = pretax * taxRate;
                earned = pretax - taxes;

                //output
                pretaxOutput.Text = $"{pretax.ToString("$.00")}";
                taxOutput.Text = $"{taxes.ToString("C")}";
                earnedOutput.Text = $"{earned.ToString("C")}";
            }
            catch 
            {
                pretaxOutput.Text = "ERROR";
                hoursInput.Text = "";
                payInput.Text = "";
            }
        }
    }
}
