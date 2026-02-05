using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6._2._1
{/*设计一个Shape（形状）类层次：
父类Shape：包含虚方法GetArea()（返回面积）。
子类Circle（圆）：新增Radius属性，重写GetArea()。
子类Rectangle（矩形）：新增Width和Height属性，重写GetArea()。
要求：在Main方法中创建多个形状对象，存入List<Shape>，循环调用GetArea()并打印结果（体现多态）。*/
    public class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Math.Max(Width, Height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Circle(3),
                new Rectangle(2, 8)
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area: {shape.GetArea()}");
            }
            Console.ReadLine();
        }
    }
}
