using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    internal class Program
    {
        struct MeusDados
        {
            public string nome;
            public int idade;
            public float peso;
            public float altura;
            // Os construtores são usados para facilitar a criação de structs
            // Os construtores devem estar dentro das Structs
            public MeusDados(string nome, int idade, float peso, float altura)
            {
                this.nome = nome;
                this.idade = idade;
                this.peso = peso;
                this.altura = altura;
            }
        }
        static void Main(string[] args)
        {
            MeusDados Victor = new MeusDados("Israel Victor Dias Sales", 22, 110f, 1.90f);
            MeusDados Adriana = new MeusDados("Adriana Celly Da Silva Viana", 39, 70f, 1.60f);
            MeusDados Fabiola = new MeusDados("Fabiola Sales De Castro", 39, 84.5f, 1.74f);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
