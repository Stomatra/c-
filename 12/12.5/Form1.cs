using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String Path = "C:\\Users\\yjh12\\Desktop\\照片";
            Image img = Image.FromFile(Path + "\\吉大校徽.jpg");
            imageList1.Images.Add("校徽", img);
            imageList1.ImageSize = new Size(200, 200);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count==0)
            {
                MessageBox.Show("没有图像");
            }
            else
            {
                pictureBox1.Image = imageList1.Images["校徽"];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("没有图像");
            }
            else 
            {
                imageList1.Images.RemoveAt(0);
                pictureBox1.Image = null;
            }
        }

    }
}
