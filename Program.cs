using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._06._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите количество чисел ряда Фибоначчи: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] fib = new int[n];
                for (int i = 0; i < n + 1; i++)
                {

                }
                Console.WriteLine(Fib(n));
            }
        }

        static int Fib(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
}
