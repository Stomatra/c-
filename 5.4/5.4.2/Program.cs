using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入a的值：");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            if (a < 50)
            {
                b = 3 * a;
                Console.WriteLine("b=" + b+"（a<50时）");
            }
            else if (a>=50&&a < 500)
            {
                b = 6 * a + 60;
                Console.WriteLine("b=" + b+"（a>=50且a<500时）");
            }
            else
            {
                b = 9*a - 90;
                Console.WriteLine("b=" + b+"（a>=500时）");
            }
            Console.ReadLine();
        }
    }
}
