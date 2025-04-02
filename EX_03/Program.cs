using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*03. Escreva um programa que leia do teclado 31 valores reais correspondentes ao índice pluviométrico diário da região
da Pampulha durante o mês de janeiro. O programa deve determinar e imprimir o índice pluviométrico médio, o índice
pluviométrico máximo e o dia que ele ocorreu. Obs: O índice pluviométrico refere-se à quantidade de chuva por metro
quadrado em determinado local.*/

namespace EX_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double indicePlu, somaIndices = 0, maiorIndicePlu = 0, indicePluMedio;
            int diaMaiorIndice = 1, contador = 0;

            while (contador < 3)
            {
                Console.Write($"Informe o índice pluviométrico do dia {contador + 1} do mês de janeiro: ");
                indicePlu = double.Parse(Console.ReadLine());

                somaIndices += indicePlu;

                if (indicePlu > maiorIndicePlu)
                {
                    maiorIndicePlu = indicePlu; 
                    diaMaiorIndice = contador + 1;
                }

                contador++;
            }

            indicePluMedio = somaIndices / 31;

            Console.WriteLine($"O índice pluviométrico médio é {indicePluMedio:F3}");
            Console.WriteLine($"O maior índice pluviométrico foi {maiorIndicePlu:F3}, ocorrido no dia {diaMaiorIndice}.");
        }
    }
}
