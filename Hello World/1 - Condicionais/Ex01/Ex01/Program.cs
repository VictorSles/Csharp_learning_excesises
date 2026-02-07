using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o 1º valor: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int valor_2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 3º valor: ");
            int valor_3 = int.Parse(Console.ReadLine());
            if (valor_1 == valor_2)
            {
                Console.WriteLine($"Possuimos valores igual entre {valor_1} - {valor_2}");
            }
            else if (valor_1 == valor_3)
            {
                Console.WriteLine($"Possuimos valores iguais entre {valor_1} - {valor_3}");
            }
            else if (valor_2 == valor_3)
            {
                Console.WriteLine($"Possuimos valores iguais entre {valor_2} - {valor_3}");
            }
            else
            {
                Console.WriteLine("Não possuimos valores iguais entre os valores digitados!");
            }
            //////////////////////////////////////////////////
            int menor_valor = 0;
            if (valor_1 < valor_2 && valor_1 < valor_3)
            {
                menor_valor = valor_1;
                Console.WriteLine($"O menor valor digitado é {valor_1}");
            }
            else if (valor_2 < valor_1 && valor_2 < valor_3)
            {
                menor_valor = valor_2;
                Console.WriteLine($"O menor valor digitado é {valor_2}");
            }
            else
            {
                menor_valor = valor_3;
                Console.WriteLine($"O menor valor digitado é {valor_3}");
            }
        }
    }
}
