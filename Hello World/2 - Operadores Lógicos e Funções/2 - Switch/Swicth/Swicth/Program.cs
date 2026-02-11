using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swicth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();
            switch (nome)
            {
                case "Israel":
                    Console.WriteLine("Seu nome é Israel");
                    break;
                case "Victor":
                    Console.WriteLine("Seu nome é Victor");
                    break;
                case "Dias":
                    Console.WriteLine("Seu nome é Dias");
                    break;
                case "Sales":
                    Console.WriteLine("Seu nome é Sales");
                    break;
                    // Default serve pra "Nenhuma das opções"
                default:
                    Console.WriteLine("Esse nome não se encaixa em nenhuma categoria");
                    break;
            }
        }
    }
}
