using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6._2._2
{
    internal class Program
    {
        public abstract class Animal
        {
            public abstract void Eat();
            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }
        public interface IRun
        {
            void Run();
        }
        public interface ISwim
        {
            void Swim();
        }
        public class Dog : Animal, IRun, ISwim
        {
            public override void Eat()
            {
                Console.WriteLine("Dog is eating.");
            }
            public void Run()
            {
                Console.WriteLine("Dog is running.");
            }
            public void Swim()
            {
                Console.WriteLine("Dog is swimming.");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();
            dog.Run();
            dog.Swim();
            Console.ReadLine();
        }
    }
}
