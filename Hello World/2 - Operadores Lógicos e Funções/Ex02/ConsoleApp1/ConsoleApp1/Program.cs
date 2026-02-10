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
            int anoNascimento = meuNascmiento(idade);
            string meuSobrenome = sobrenome(nome);
            minhaPrimeiraFuncao(nome, idade, anoNascimento, meuSobrenome);
        }
        static void minhaPrimeiraFuncao(string meuNome, int minhaIdade, int anoNasc, string Meusobrenome)
        {
            Console.WriteLine($"Prazer conhecê-lo Sr. {meuNome} de {minhaIdade} anos!");
            Console.WriteLine($"Você nasceu no ano {anoNasc} e seu sobrenome é {Meusobrenome}");
        }
        // As funções podem referenciar um retorno vazio (void) como no caso acima
        // Mas tb podem referenciar um retorno de algum tipo de varável
        static int meuNascmiento(int minhaIdade)
        {
            int AnoNascimento = 2025 - minhaIdade;
            return AnoNascimento;
        }
        static string sobrenome(string nome)
        {
            string sobrenome = "Victor";
            //Console.WriteLine($"Seu nome é {nome} porém seu sobrenome é {sobrenome}");
            return sobrenome;
        }
    }
}
