using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poem=new string[]
            {
                "《大风歌》",
                "大风起兮云飞扬，",
                "威加海内兮归故乡。",
                "安得猛士兮守四方。"
            };
            string[] spell = { 
                "《dà fēng gē 》",
                "dà fēng qǐ xī yún fēi yáng ，",
                "wēi jiā hǎi nèi xī guī gù xiāng，",
                "ān dé měng shì xī shǒu sì fāng 。"
            };
            poem[0] = poem[0].PadLeft(8);
            spell[0] = spell[0].PadLeft(15);
            for (int i=0; i < poem.Length; i++)
            {
                Console.WriteLine(poem[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(spell[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine(spell[i]);
                Console.WriteLine(poem[i]);
            }
            Console.ReadLine();
        }
    }
}
