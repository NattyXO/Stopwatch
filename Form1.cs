using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        int H = 00;
        int M = 00;
        int S = 00;
        private List<string> lapTimes = new List<string>(); // Create a list to store lap times

        int originalInterval;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            lblHours.Text = "00";

            lblMinute.Text = "00";

            lblSeconds.Text = "00";
            // Store the original interval
            originalInterval = timer1.Interval;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnFastTime_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) // Check if the timer is running
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
            }else
            {
                MessageBox.Show("Before you click Fast time, please start the time.");
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
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

            lblHours.Text = H.ToString().PadLeft(2, '0'); // Ensures two-digit display with leading zeros
            lblMinute.Text = M.ToString().PadLeft(2, '0');
            lblSeconds.Text = S.ToString().PadLeft(2, '0');
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblHours.Text = "00";

            lblMinute.Text = "00";

            lblSeconds.Text = "00";

            // Stop the timer
            timer1.Stop();

            H = 0;
            M = 0;
            S = 0;
            // Reset the interval to its original value
            timer1.Interval = originalInterval;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            string githublink = "https://github.com/NattyXO";
            Process.Start(githublink);

        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) // Check if the timer is running
            {
                string currentTime = $"{H.ToString().PadLeft(2, '0')}:{M.ToString().PadLeft(2, '0')}:{S.ToString().PadLeft(2, '0')}";

                lapTimes.Add(currentTime); // Add current time to the lap times list

                if (lapTimes.Count > 12)
                {
                    lapTimes.RemoveAt(0); // Remove the oldest record when exceeding 12
                }

                // Update the lblLap to display up to 12 lap times
                lblLap.Text = string.Join(Environment.NewLine, lapTimes);
            }
            else
            {
                MessageBox.Show("Before recording time, start the time.");
            }
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            string softwareName = "Stopwatch";
            string softwareVersion = "1.0"; // Set the version of your software here

            string message = $"Name: {softwareName}\nVersion: {softwareVersion}";
            MessageBox.Show(message+"\nAhadu Tech");
        }
    }
}
