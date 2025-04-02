using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/*02. Escreva um programa que leia dois números inteiros ímpares X e Y, e imprima os números ímpares de X até Y
(inclusive). Caso o usuário informe valores inválidos (X e Y não serem ímpares, OU X ser maior que Y) o programa
deverá imprimir uma mensagem de erro (Erro! Valores Inválidos).
Exemplo: x = 3, y = 11
Impressão: 3, 5, 7, 9, 11*/

namespace EX_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, num;

            Console.WriteLine("Informe um valor inteiro ímpar para x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um valor inteiro ímpar para y: ");
            y = int.Parse(Console.ReadLine());


            while (x > y || x % 2 == 0 || y % 2 == 0)
            {
                Console.WriteLine("Erro! Valores Inválidos. Informe x e y novamente: ");

                Console.WriteLine("Informe um valor inteiro para x: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe um valor inteiro para y: ");
                y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os números ímpares entre {0} e {1} são: ", x , y);

            num = x;
            while (num <= y) 
            {
                Console.WriteLine(num + " ");
                num += 2;
            }

        }
    }
}
