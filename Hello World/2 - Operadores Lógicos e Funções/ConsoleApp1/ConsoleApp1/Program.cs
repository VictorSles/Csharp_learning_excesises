using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Há uma forma de converter variáveis, usando o .Parse (Conversão em inglês) no 
            // qual posso converter variáveis do tipo STR pra INT
            // No caso abaixo o valor digitado essecialmente é string mas é convertido para int
            int variavel_teste_1 = int.Parse(Console.ReadLine());
            Console.WriteLine(variavel_teste_1);
            // Console.ReadLine() essencialmente registra as varáveis como textos
        }
    }
}
