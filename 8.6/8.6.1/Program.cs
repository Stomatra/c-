using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的身份证号：");
            string id = Console.ReadLine();
            Console.Write("你的生日是：");
            string birth= id.Substring(6, 8);
            Console.WriteLine(birth);
            Console.Write("你的性别是：");
            string sex= id.Substring(16, 1);
            if(sex=="1")
            {
                Console.WriteLine("男");
            }
            else
            {
                Console.WriteLine("女");
            }
            Console.ReadLine();
        }
    }
}
