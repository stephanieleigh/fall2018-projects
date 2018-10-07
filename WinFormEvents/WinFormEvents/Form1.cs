// Advanced C#
// Module 07
// Example of Windows Forms Events
// Stephanie Wilson
// October 5, 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button_MyOtherClick;
        }

        private void button_MyOtherClick(object sender, EventArgs e)
        {
            myOtherLabel.Text = "Hello again!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myLabel.Text = "Hello world!";
        }

    }
}
