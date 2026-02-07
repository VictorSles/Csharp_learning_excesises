using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
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
                Console.WriteLine($"1º valor é igual ao 2º valor");
            }
            else if (valor_1 == valor_3)
            {
                Console.WriteLine($"1º valor é igual ao 3º valor ");
            }
            else if (valor_2 == valor_3)
            {
                Console.WriteLine($"2º valor é igual ao 3º valor");
            }
            else
            {
                Console.WriteLine("Não há valores iguais entre os descritos!");
            }
                /////////////////////////
                int maior_valor = 0;
            maior_valor = valor_1;
            if (valor_2 > maior_valor)
            {
                maior_valor = valor_2;
                Console.WriteLine($"2º valor é maior com valor de {maior_valor}");
            }
            else if (maior_valor > valor_3)
            {
                Console.WriteLine($"1º valor é maior com o valor de {maior_valor}");
            }
            else
            {
                maior_valor = valor_3;
                Console.WriteLine($"3º valor é maior com valor de {maior_valor}");
            }
        }
    }
}
