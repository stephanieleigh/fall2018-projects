// Car Rental Program
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

namespace CarRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double CENTS_PER_MILE = .25;
            const double DAILY_FEE = 20;
            double numberDays, miles, totalDailyFee, mileageFee, totalFee;
            numberDays = Convert.ToDouble(daysTextBox.Text);
            miles = Convert.ToDouble(milesTextBox.Text);
            totalDailyFee = numberDays * DAILY_FEE;
            mileageFee = miles * CENTS_PER_MILE;
            totalFee = totalDailyFee + mileageFee;
            totalRentalLabel.Text = "The total rental fee is " + totalFee.ToString("C");

        }
    }
}
