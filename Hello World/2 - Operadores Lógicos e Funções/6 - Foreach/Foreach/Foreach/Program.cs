using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Israel", "Victor", "Dias", "Sales"};
            foreach (string item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
