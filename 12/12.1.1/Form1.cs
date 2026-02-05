using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox myText = new TextBox();
            myText.Location = new Point(25, 25);
            this.Controls.Add(myText);

            string strPoP = "您选择的权限如下：";
            foreach (Control ctrl in this.Controls)
            {
                if(ctrl.GetType().Name == "CheckBox")
                {
                    CheckBox cBox =(CheckBox)ctrl;
                    if(cBox.Checked == true)
                    {
                        strPoP += "\n" + cBox.Text;
                    }
                }
            }
            MessageBox.Show(strPoP);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label1.Text=textBox4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "欢迎登录https://zyk.mingrisoft.com开发资源库，开启你的编程人生";

            richTextBox2.SelectionBullet = true;

            string[] str = new string[] { "总经理", "副总经理", "人事部经理", "财务部经理", "部门经理", "普通员工" };
            comboBox1.DataSource = str;
            comboBox1.SelectedIndex = 0; // 设置默认选中项
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("系统登录");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("你选择了管理员登录");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("你选择了普通用户登录");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text="你选择的职位是："+comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("请输入内容");
            }
            else
            { 
                listBox1.Items.Add(textBox5.Text);
                textBox5.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("请选择要删除的项");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选择项目");
            }
            else
            {
                label4.Text = "你选择了" + listBox2.SelectedItems.Count.ToString() + "项";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                listBox2.Items.Add(textBox5.Text);
                textBox5.Text = "";
            }
            else
            {
                MessageBox.Show("请输入内容");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox5.Text.Trim());
            textBox5.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("你没有选择项目");
            }
            else
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
