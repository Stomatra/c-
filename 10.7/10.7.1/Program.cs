using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._7._1
{
    internal class Program
    {
        public class RandomlyChosePuke
        {
            public List<string> puke = new List<string>
        {
            "A",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Q",
            "J",
            "K",
        };
            public virtual void choosePuke() { }
            protected static Random random = new Random();
        }
        public class RandomlyChosePukeRepeatablely : RandomlyChosePuke
        {
            public override void choosePuke()
            {
                int index = random.Next(puke.Count);
                string chosenPuke = puke[index];
                Console.WriteLine($"抽出： {chosenPuke}");
            }
        }
        public class RandomlyChosePukeNotRepeatablely : RandomlyChosePuke
        {
            public override void choosePuke()
            {
                if (puke.Count == 0)
                {
                    Console.WriteLine("没有牌可以抽出。");
                    return;
                }
                int index = random.Next(puke.Count);
                string chosenPuke = puke[index];
                puke.RemoveAt(index);
                Console.WriteLine($"抽出: {chosenPuke}");
            }
        }
        static void Main(string[] args)
        {
            RandomlyChosePukeRepeatablely repeatableChoser = new RandomlyChosePukeRepeatablely();
            RandomlyChosePukeNotRepeatablely notRepeatableChoser = new RandomlyChosePukeNotRepeatablely();
            Console.WriteLine("----可重复抽牌----");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("第" + (i+1) + "次");
                repeatableChoser.choosePuke();
            }
            Console.WriteLine("----不重复抽牌----");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("第" + (i + 1) + "次");
                notRepeatableChoser.choosePuke();
            }
            Console.ReadLine();
    }
    }
}
