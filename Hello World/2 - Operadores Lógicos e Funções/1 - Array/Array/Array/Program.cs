using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de Arrays no qual possuem valores fixos inalterados.
            // Temos 2 formas de criar array
            // 1º Mais completa
            string[] CompleteName = new string[4]
            {
                "Israel",
                "Victor",
                "Dias",
                "Sales"
            };
            Console.WriteLine(CompleteName[0]);
            //2º Mais simples
            string[] NomePai = { "Israel", "Sales", "De", "Castro" };
            Console.WriteLine(NomePai[2]);
        }
    }
}
