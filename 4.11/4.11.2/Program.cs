using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入在线支付次数：");
            int onlinePayments = int.Parse(Console.ReadLine());
            Console.Write("请输入到店支付次数：");
            int inStorePayments = int.Parse(Console.ReadLine());
            int totaljsl=180*(onlinePayments+inStorePayments);
            Console.WriteLine("今天蚂蚁庄园一共产生{0}克鸡饲料",totaljsl);
            Console.ReadLine();
        }
    }
}
