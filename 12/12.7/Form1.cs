using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled=false;
            button1.Text = "Please wait...";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.PerformStep();
                label2.Text = progressBar1.Value.ToString() + "%";
                System.Threading.Thread.Sleep(50); // Simulate work
            }
            button1.Text = "Done!";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
