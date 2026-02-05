using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[10][];
            for(int i = 0; i < 9; i++)
            {
                arr[i] = new int[i + 1]; // Initiali
                arr[i][0] = 1;
                arr[i][i] = 1;
            }
            for(int i = 1; i < 9; i++)
            {
                for(int j =1; j < i; j++)
                {
                    arr[i][j] = arr[i- 1][j - 1] + arr[i - 1][j];
                }
            }
            for(int i = 0;i < 9; i++)
            {
                for (int k = i; k < 9; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
