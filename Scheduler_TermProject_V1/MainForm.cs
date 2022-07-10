using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_TermProject_V1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_fcfs_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "FCFS" };
            sub.Show();
        }

        private void btn_sjf_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "SJF" };
            sub.Show();
        }

        private void btn_hrn_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "HRN" };
            sub.Show();
        }

        private void btn_nonpre_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "nonPreemptive" };
            sub.Show();
        }

        private void btn_srt_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "SRT" };
            sub.Show();
        }

        private void btn_rr_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "RoundRobin" };
            sub.Show();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm() { Text = "Preemptive" };
            sub.Show();
        }

        private void btn_egg_Click(object sender, EventArgs e)
        {
            //SubForm sub = new SubForm() { Text = "FCFS" };
            //sub.Show();
        }
    }
}
