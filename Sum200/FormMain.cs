// Author:  Nathan Esplan
// Date:    2020-09-22
// Project: Sum 200 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // Button to start program
        private void btnStart_Click(object sender, EventArgs e)
        {
            int sum = 0;

            // Loop through 1-200 and add each number to sum
            for(int i=1;i <= 200; i++)
            {
                sum += i;

                // If we reached 100, display on halfway text label
                if(i == 100)
                {
                    txtHalfway.Text = Convert.ToString(sum);
                }
            }

            // Display total of the 200 numbers
            txtTotal.Text = Convert.ToString(sum);
        }
    }
}
