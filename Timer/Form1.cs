using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int minute, second, milliSecond;

        private void startButton_Click(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                timer1.Enabled = false;
                startButton.Text = "Start";
                stopButton.Enabled = true;
            }
            else
            {
                timer1.Enabled = true;
                startButton.Text = "Stop";
                stopButton.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (milliSecond == 99)
            {
                if (second == 59)
                {
                    if (minute == 99)
                    {
                        minute = 0;
                        second = 0;
                    }
                }
                else
                {
                    second++;
                    milliSecond = 0;
                }
            }
            else
            {
                milliSecond++;
            }


            if (minute.ToString().Length == 1)
            {
                label1.Text = "0" + minute.ToString();
            }
            else
            {
                label1.Text =minute.ToString();
            }

            if (second.ToString().Length == 1)
            {
                label2.Text = "0" + second.ToString();
            }
            else
            {
                label2.Text = second.ToString();
            }

            if (milliSecond.ToString().Length == 1)
            {
                label3.Text = "0" + milliSecond.ToString();
            }
            else
            {
                label3.Text = milliSecond.ToString();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.minute = 0;
            this.second = 0;
            this.milliSecond = 0;
            this.label1.Text = "00";
            this.label2.Text = "  :00";
            this.label3.Text = ".  00";
        }

        //private System.Windows.Forms.Timer timer= new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();
            minute = 0;
            second = 0;
            milliSecond = 0;
            timer1.Interval = 10;
        }
    }
}
