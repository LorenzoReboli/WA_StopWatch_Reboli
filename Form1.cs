using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WA_StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch stopwatch;

        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            txt_Min.Text = "0";
            txt_Sec.Text = "0";
            txt_Mil.Text = "0";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            stopwatch.Stop();
            txt_Min.Text = stopwatch.Elapsed.Minutes.ToString();
            txt_Sec.Text = stopwatch.Elapsed.Seconds.ToString();
            txt_Mil.Text = stopwatch.Elapsed.Milliseconds.ToString();
        }
        
    }
}
