using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        //Enum permite que criemos variaveis com tipos (str, int, etc...) e valores especificos
        enum nomes { Israel, Victor, Dias, Sales }
        static void Main(string[] args)
        {
            nomes PrimeiroNome = nomes.Israel;
            nomes SegundoNome = nomes.Victor;
            nomes TerceiroNome = nomes.Dias;
            nomes QuartoNome = nomes.Sales;
            Console.WriteLine(PrimeiroNome);
            Console.WriteLine(SegundoNome);
            Console.WriteLine(TerceiroNome);
            Console.WriteLine(QuartoNome);
        }
    }
}
