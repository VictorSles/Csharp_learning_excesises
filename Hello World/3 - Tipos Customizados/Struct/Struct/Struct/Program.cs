using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        // Struct serve pra que possamos definir um "molde" de varáveis dentro de uma lib
        // E se tratando de um tipo de variável, criamos fora da função main()
        struct MeusDados
        {
            // Public server pra que possa ser global
            public string nome;
            public int idade;
            public float altura;
            public float peso;
        }
        static void Main(string[] args)
        {
            MeusDados minhas_info_1 = new MeusDados();
            minhas_info_1.nome = "Israel";
            minhas_info_1.idade = 22;
            minhas_info_1.altura = 1.90f;
            minhas_info_1.peso = 110f;
            Console.WriteLine($"Meu nome é {minhas_info_1.nome}");
            Console.WriteLine($"Minha idade é {minhas_info_1.idade}");
            Console.WriteLine($"Minha altura é {minhas_info_1.altura}");
            Console.WriteLine($"Meu peso é {minhas_info_1.peso}");
            Console.ReadLine();
        }
    }
}
