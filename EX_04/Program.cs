using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*04. Escreva um programa que leia um número inteiro n. Em seguida, leia a idade de n pessoas, calcule e imprima (a) a
quantidade de pessoas em cada faixa etária e (b) a porcentagem de cada faixa etária em relação ao total de pessoas.
Faixas etárias:
• 1 a 15 anos
• 16 a 30 anos
• 31 a 45 anos
• 46 a 60 anos
• ≥ 61 anos*/

namespace EX_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n, contador = 0, idades, somapessoa = 0, faixa1 = 0, faixa2=0, faixa3=0, faixa4=0, faixa5=0;
            double porcentagem1faixa, porcentagem2faixa, porcentagem3faixa, porcentagem4faixa, porcentagem5faixa;

            Console.WriteLine("Informe a quantidade de número de pessoas: ");
            n = int.Parse(Console.ReadLine());

            while (contador < n) 
            {
                Console.WriteLine($"Informe o {contador + 1}º número: ");
                idades = int.Parse(Console.ReadLine());

                somapessoa += idades;

                contador++;

                if (idades >= 1 && idades <= 15)
                {
                    faixa1++;
                }
                else if (idades >= 16 && idades <= 30)
                {
                    faixa2++;
                }
                else if (idades >= 31 && idades <= 45)
                {
                    faixa3++;
                }
                else if (idades >= 46 && idades <= 60)
                {
                    faixa3++;
                }
                else
                {
                    faixa4++;
                }
            }
            porcentagem1faixa = (faixa1 / n) * 100;
            porcentagem2faixa = (faixa2 / n) * 100;
            porcentagem3faixa = (faixa3 / n) * 100;
            porcentagem4faixa = (faixa4 / n) * 100;
            porcentagem5faixa = (faixa5 / n) * 100;

            Console.WriteLine($"A quantidade de pessoas na\n faixa etária 1 é: {faixa1}\n faixa etária 2 é: {faixa2}\n faixa etária 3 é: {faixa3}\n faixa etária 4 é: {faixa4}\n faixa etária 5 é: {faixa5}");
            Console.WriteLine($"A porcentagem de pessoas na\n faixa etária 1 é: {porcentagem1faixa}\n faixa etária 2 é: {porcentagem2faixa}\n faixa etária 3 é: {porcentagem3faixa}\n faixa etária 4 é: {porcentagem4faixa}\n faixa etária 5 é: {porcentagem5faixa}");
        }
    }
}
