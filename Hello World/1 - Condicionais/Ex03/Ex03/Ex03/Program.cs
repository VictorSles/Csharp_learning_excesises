using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ CHAMADOS ************");
            Console.WriteLine("BAIXO 0-3");
            Console.WriteLine("MÉDIO 3-6");
            Console.WriteLine("ALTO 6-9\n");
            Console.Write("Digite o nível de urgência: ");
            int valor_digitado = int.Parse(Console.ReadLine());
            //Console.WriteLine(valor_digitado);
            if (valor_digitado >= 0 && valor_digitado <= 3)
            {
                Console.WriteLine($"\n{valor_digitado} representa um baixo nível de urgência!");
            }
            else if (valor_digitado > 3 && valor_digitado <= 6)
            {
                Console.WriteLine($"\n{valor_digitado} representa um médio valor de urgência!");
            }
            else if (valor_digitado > 6 && valor_digitado <= 9)
            {
                Console.WriteLine($"\n{valor_digitado} representa um alto nível de urgência!");
            }
            else
            {
                Console.WriteLine($"\n{valor_digitado} representa um GRAVE nível de urgência!");
            }
        }
    }
}
