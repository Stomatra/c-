using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = 1.78; // Height in meters
            double weight = 75.0; // Weight in kilograms
            double exponent = weight/(height*height); // Exponent for BMI calculation
            Console.WriteLine("你的身高为："+height);
            Console.WriteLine("你的体重为："+weight);
            Console.WriteLine("你的BMI指数为："+exponent);
            Console.Write("你的体重属于：");
            if(exponent < 18.5)
            {
                Console.WriteLine("过轻");
            }
            else if (exponent >= 18.5 && exponent < 24)
            {
                Console.WriteLine("正常");
            }
            else if (exponent >= 24 && exponent < 28)
            {
                Console.WriteLine("过重");
            }
            else
            {
                Console.WriteLine("肥胖");
            }
        }
    }
}
