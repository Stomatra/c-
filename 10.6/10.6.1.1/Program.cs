using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _10._6._1._1
{
    /*设计一个Book类
    要求：
    包含私有字段：title（书名）、author（作者）、price（价格，需保证≥0）。
    提供公共属性访问这些字段（Price属性设置时需验证，非法值抛出异常）。
    包含构造函数（参数：书名、作者、价格）。
    包含ShowInfo()方法，打印书籍完整信息（如："《C# 入门》- 张三 - 59.9 元"）。*/
    internal class Program
    {
        public class Book
        {
            private string title;
            private string author;
            private double price;
            public string Title;
            public string Author;
            public double Price
            {
                get
                {
                    return price;
                }
                set
                {
                    if (value > 0 && value < 200)
                    {
                        price = value;
                    }
                    else
                    {
                        Console.WriteLine("数据不合适！");
                    }
                }
            }
            public Book(string title, string author, double price)
            {
                this.title = title;
                this.author = author;
                this.price = price;
            }
            public void ShowInfo()
            {
                Console.WriteLine($"《{title}》- {author} - {price} 元");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入书名：");
            string title = Console.ReadLine();
            Console.WriteLine("请输入作者：");
            string author = Console.ReadLine();
            Console.WriteLine("请输入价格：");
            double price = Convert.ToDouble(Console.ReadLine());
            Book book = new Book(title, author, price);
            book.ShowInfo();
            Console.ReadLine();
        }
    }
}
