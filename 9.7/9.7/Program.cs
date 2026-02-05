using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7
{
    public class Person
    {
        public void words(string person)
        {
            if (person == "曹操")
            {
                Console.WriteLine("曹操：哈哈哈");
            }
            else if(person == "赵云")
            {
                Console.WriteLine("赵云拦截去路");
                Console.WriteLine("赵云：吾乃常山赵子龙，曹贼哪里跑！");
            }
            else if( person == "徐晃"||person=="张郃"||person=="张辽")
            {
                Console.WriteLine(person+"上前拦截");
                Console.WriteLine(person+"：莫动我主公！");
            }
            else if (person == "张飞")
            {
                Console.WriteLine("张飞拦截去路");
                Console.WriteLine("张飞：燕人张飞在此，曹贼哪里跑！");
            }
            else if (person == "关羽")
            {
                Console.WriteLine("关羽拦住去路");
                Console.WriteLine("关羽：长叹一声");
            }
            else 
            {
                Console.WriteLine("曹操落荒而逃");
            }
        }
        public void run()
        {
            Person p = new Person();
            Console.WriteLine("曹操赤壁失利，败走华容道");
            p.words("曹操");
            p.words("赵云");
            p.words("徐晃");
            p.words("张郃");
            p.words("");
            p.words("曹操");
            p.words("张飞");
            p.words("张辽");
            p.words("徐晃");
            p.words("");
            p.words("曹操");
            p.words("关羽");
            p.words("");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.run();
            Console.ReadKey();
        }
    }
}
