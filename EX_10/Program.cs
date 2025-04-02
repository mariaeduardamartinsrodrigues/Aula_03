using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

/*10. Escreva um programa que leia um número indefinido de notas de alunos e calcule a média. O programa deve parar
quando for digitado um valor negativo como nota.*/

namespace EX_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double qtddnota, contador = 1, nota, somanotas = 0, medianotas = 0;

            Console.WriteLine($"Informe qual será a quantidade de notas a serem lidas: ");
            qtddnota = int.Parse(Console.ReadLine());

            while (qtddnota >= contador)
            {
                Console.WriteLine("Informe uma nota");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 0)
                {
                    somanotas += nota;
                    medianotas = somanotas / contador;
                }
                else 
                {
                    Console.WriteLine($"Valor inválido.");
                    Console.WriteLine("Informe uma nota positiva.");
                    nota = double.Parse(Console.ReadLine());
                }
                contador++;
            }
            Console.WriteLine($"A média das {qtddnota} notas informadas é {medianotas}.");
        }
    }
}
