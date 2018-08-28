// Miles to Kilometers Program
// Advanced C#
// Written by Stephanie Wilson
// August 27, 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometers
{
    public partial class KiloForm : Form
    {
        public KiloForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            const double CONVERT_KILOS = 1.6;
            double miles, kilometers;
            miles = Convert.ToDouble(milesTextBox.Text);
            kilometers = miles * CONVERT_KILOS;
            kilosLabel.Text = miles + " miles is " + kilometers + " kilometers";
        }
    }
}
