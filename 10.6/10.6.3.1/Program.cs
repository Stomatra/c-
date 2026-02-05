using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6._3._1
{
    /*实现一个简单的计算器：
定义委托CalculateHandler(int a, int b)。
编写静态方法Add、Subtract、Multiply（分别实现加减乘）。
在Main中通过委托变量动态切换调用不同方法，并输出结果。*/
    internal class Program
    {
        public delegate int CalculateHandler(int a, int b);
        public class Calculator
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }
            public static int Subtract(int a, int b)
            {
                return a - b;
            }
            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }
        static void Main(string[] args)
        {
            CalculateHandler calculateHandler;
            int a = 10, b = 5;

            calculateHandler = Calculator.Add;
            Console.WriteLine($"Add: {calculateHandler(a, b)}");
            calculateHandler = Calculator.Subtract;
            Console.WriteLine($"Subtract: {calculateHandler(a, b)}");
            calculateHandler = Calculator.Multiply;
            Console.WriteLine($"Multiply: {calculateHandler(a, b)}");
        }
    }
}
