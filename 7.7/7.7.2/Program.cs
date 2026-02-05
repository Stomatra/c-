using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] P = new string[] { "A区 空车位", "B区 空车位", "C区 空车位" };
            int[] N= new int[] { 0, 0, 0 };
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine("请输入{0}的车位数：", P[i]);
                N[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("{0}  ", P[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("{0}              ", N[i]);
            }
            Console.ReadLine();
        }
    }
}
