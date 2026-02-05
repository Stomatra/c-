using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] str = new string[] {
                "明日科技",
                "C#编程词典",
                "C#基础到项目实践",
                "公司",
                "软件",
                "图书"
            };
            for (int i = 0; i < str.Length; i++)
            {
                // 添加项到 ListView
                listView1.Items.Add(str[i]);
            }
            listView1.Groups.Add(new ListViewGroup("名称"));
            listView1.Groups.Add(new ListViewGroup("类别"));
            for (int i = 0; i < 3; i++)
            {
                listView1.Items[i].Group = listView1.Groups[0];
            }
            for (int i = 3; i < str.Length; i++)
            {
                listView1.Items[i].Group = listView1.Groups[1];
            }
        }
    }
}
