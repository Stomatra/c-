using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double allsteps = 80500;
            double dayPerYear = 365;
            double averageAge = 70;
            double stepsPerDay = allsteps / (dayPerYear*averageAge);
            double stepsPerYear = allsteps / averageAge;
            Console.WriteLine("每天要走{0:F2}千米",stepsPerDay);
            Console.WriteLine("每年要走{0:F2}千米",stepsPerYear);
            Console.ReadLine();
        }
    }
}
