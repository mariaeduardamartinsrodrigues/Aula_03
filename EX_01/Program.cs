using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*01. Escreva um programa que imprima uma contagem regressiva de 10 até 1 e depois exiba "Feliz Ano Novo!".*/

namespace EX_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 10;

            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("Feliz Ano Novo!");
        }
    }
}
