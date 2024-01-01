using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown_Timer
{
    
    public partial class Form1 : Form
    {
        int H = 00;
        int M = 00;
        int S = 00;

        int originalInterval;
        public Form1() 
        {
            InitializeComponent();
            label1.Text = "00";

            label2.Text = "00";

            label3.Text = "00";
            // Store the original interval
            originalInterval = timer1.Interval;

        }
        private void btnStartTime_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStopTime_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void btnLapTime_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFastTime_Click(object sender, EventArgs e)
        {
            int minimumInterval = 1; // Define a minimum interval value

            if (timer1.Interval > minimumInterval) // Check if current interval is greater than minimum
            {
                timer1.Interval /= 2;
                if (timer1.Interval < minimumInterval)
                {
                    timer1.Interval = minimumInterval;
                }
            }
            else
            {
                timer1.Interval = minimumInterval; // Set to minimum if it's already less than minimum
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            S++;
            if (S >= 60)
            {
                M++;
                S = 0;
            }
            if (M >= 60)
            {
                H++;
                M = 0;
            }

            label1.Text = H.ToString().PadLeft(2, '0'); // Ensures two-digit display with leading zeros
            label2.Text = M.ToString().PadLeft(2, '0');
            label3.Text = S.ToString().PadLeft(2, '0');
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";

            // Stop the timer
            timer1.Stop();

            H = 0;
            M = 0;
            S = 0;
            // Reset the interval to its original value
            timer1.Interval = originalInterval;
        }
    }
}
