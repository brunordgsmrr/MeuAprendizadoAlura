using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio\n");

            int n;
            int fat = 1;

            for (n = 1; n <= 10; n++)
            {
                fat *= n;
                Console.WriteLine("Fatorial de " + n + " é " + fat);
            }

            Console.ReadLine();
        }
    }
}
