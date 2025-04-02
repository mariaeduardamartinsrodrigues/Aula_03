using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*09. Faça um programa que calcule o valor final da série para 30 termos.
S = 480 – 475 + 470 – 465 + 460 ...*/

namespace EX_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termos = 30;
            double soma = 480;
            double valor = 475;
            int i = 1;

            while (i < termos)
            {
                if (i % 2 == 0)
                {
                    soma += valor;
                }
                else
                {
                    soma -= valor;
                }
                valor -= 5;
                i++;
            }
        }
    }
}
