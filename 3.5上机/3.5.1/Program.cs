using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的家：");
            string home = Console.ReadLine();
            Console.WriteLine("请输入你的单位：");
            string company = Console.ReadLine();
            Console.WriteLine("\n");
            for(int i = 0; i < 20; i++)
            {
                Console.Write("=");
            }
            Console.Write("设置常用地点");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
            Console.WriteLine("家：" + home);
            Console.WriteLine("单位：" + company);
            Console.ReadLine();
        }
    }
}
