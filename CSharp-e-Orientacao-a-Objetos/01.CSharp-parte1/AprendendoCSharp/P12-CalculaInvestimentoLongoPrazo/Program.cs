﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executa o projeto 12");

            double valorInvestido = 1000;
            double fatorRedimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRedimento;
                    Console.WriteLine($"Após {contadorAno - 1} anos e {contadorMes} mês, você terá R${valorInvestido}");
                }
                fatorRedimento += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
