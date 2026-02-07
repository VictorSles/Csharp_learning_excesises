using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write(); Serve para imprimir algo na tela
            Console.Write("Hello World\n");
            // Console.WriteLine(); Serve pra imprimir algo na tela e pular a linha
            Console.WriteLine("Meu próximo Hello World em outra linha");
            // Declarando uma variável genérica
            var minha_var = "Minha variável!";
            Console.WriteLine(minha_var);
            // Console.ReadLine(); Serve para lê algo que o usuário irá digitar na tela
            Console.ReadLine();
        }
    }
}
