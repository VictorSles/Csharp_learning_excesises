using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        //Posso definir variáveis globais
        // Diferente do python eu preciso somente escrevê-la globalmente e declarar dentro de outras funções
        static string meuNomeCompleto = "Israel Victor Dias Sales";
        static void Main(string[] args)
        {
            // FOR, leva em consideração não somente oq será percorrido mas tb o contador
            string[] nomes = {"Israel", "Victor", "Dias", "Sales"};
            for (int contador = 0; contador < nomes.Length; contador++)
            {
                Console.WriteLine($"{contador}º - {nomes[contador]}");           
            }
            Console.WriteLine(meuNomeCompleto);
        }
    }
}
