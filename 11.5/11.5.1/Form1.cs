using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _11._5._1
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否显示Form2？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                form2.Show();
            }
            else
            {
                form2.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("干什么！");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr=MessageBox.Show("真的要关闭吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true; // 取消关闭操作
            }
            else
            {
                form2.Close(); // 关闭Form2
            }
        }
    }
}
