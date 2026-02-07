using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de função com parâmetros
            // void é quando a função não retorna nada, somente trata os dados
            Console.Write("Qual seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Qual sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            // Precisamos sempre defnir o tipo de variável dos parâmetros de cada função
            // Observe que a função criada (minhaPrimeiraFuncao(nome, idade)) é fora da função main
            // E os parâmetros da função são chamados na Main() pq foi lá onde eles foram declarados.
            minhaPrimeiraFuncao(nome, idade);
        }
        static void minhaPrimeiraFuncao(string meuNome, int minhaIdade)
        {
            Console.WriteLine($"Prazer conhecê-lo Sr. {meuNome} de {minhaIdade} anos!");
        }
    }
}
