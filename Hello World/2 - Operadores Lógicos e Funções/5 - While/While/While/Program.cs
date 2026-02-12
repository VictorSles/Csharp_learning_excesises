using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While
            int Contador = 0;
            while (Contador < 30)
            {
                Contador++;
                Console.WriteLine(Contador);
            }
            Console.WriteLine("Fim da contagem");
        }
    }
}
