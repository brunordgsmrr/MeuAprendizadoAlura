using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - condicionais");

            int idadeJoao = 16;
            int quantidadeDePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else if (quantidadeDePessoas >= 2)
            {
                Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado, pode entrar.");
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos, não pode entrar.");
            }


            Console.ReadLine();
        }
    }
}
