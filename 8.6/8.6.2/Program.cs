using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("打卡员工姓名：");
            string name=Console.ReadLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine(name+"打卡成功！");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(string.Format("打卡时间：{0:F}",dateTime));
            Console.ReadLine();
        }
    }
}
