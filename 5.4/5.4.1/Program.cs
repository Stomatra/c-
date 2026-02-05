using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入关卡：");
            int level = int.Parse(Console.ReadLine());
            if(level < 1 || level > 3)
            {
                Console.WriteLine("请输入正确的关数，当前游戏只有三关！");
                return;
            }
            Console.WriteLine("当前进入第{0}关……",level);
            return;
        }
    }
}
