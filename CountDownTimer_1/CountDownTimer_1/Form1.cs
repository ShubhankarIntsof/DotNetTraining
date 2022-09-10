using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Globalization;

namespace CountDownTimer_1
{
    public partial class Form1 : Form
    {
        int cdtmr;
        int initial_;



        public Form1()
        {
            InitializeComponent();


        }

        private void timeDisplay_TextChanged(object sender, EventArgs e)
        {


        }

        private void timeProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var timeString = timeDisplay.Text;
            int k = (int) TimeSpan.ParseExact(timeString, "hh\\:mm\\:ss", CultureInfo.InvariantCulture).TotalSeconds;

            initial_ = k;
            cdtmr = initial_;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;

            timeProgressBar.Maximum = initial_;
            btnStart.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cdtmr > 0)
            {
                cdtmr--;
                TimeSpan time = TimeSpan.FromSeconds(cdtmr);
                timeDisplay.Text = time.ToString(@"hh\:mm\:ss");
                timeProgressBar.Value = initial_ - cdtmr;
            }
            else
            {

                btnStart.Enabled = true;
                timer1.Stop();

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            cdtmr = 0;
            timer1.Stop();
            timeDisplay.Text = "00:00:00";
            timeProgressBar.Value = 0;
            btnStart.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
