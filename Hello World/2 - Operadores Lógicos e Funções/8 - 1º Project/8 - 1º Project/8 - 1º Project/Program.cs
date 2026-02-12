using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___1º_Project
{
    internal class Program
    {
        enum valuesToUse {Soma=1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair};
        static void Main(string[] args) {
            bool ChoiceLeave = false;
            while (!ChoiceLeave) {
                Console.WriteLine("Welcome to your new CMD Calculator!");
                Console.WriteLine("1ª Soma\n2º Subtração\n3º Divisão\n4º Multiplicação\n5º Potência\n6º Raiz\n7º Sair");             
                Console.Write("Please choice a value: ");
                valuesToUse opcoes = (valuesToUse)int.Parse(Console.ReadLine());
                switch (opcoes)
                {
                    case valuesToUse.Sair:
                        ChoiceLeave = true;
                        break;
                    case valuesToUse.Soma:
                        Soma();
                        break;
                    case valuesToUse.Subtracao:
                        Sub();
                        break;
                    case valuesToUse.Divisao:
                        Div();
                        break;
                    case valuesToUse.Multiplicacao:
                        Mult();
                        break;
                    case valuesToUse.Potencia:
                        Pot();
                        break;
                    case valuesToUse.Raiz:
                        Root();
                        break;
                }
                Console.Clear();
            }
        }
        static void Soma()
        {           
            Console.Write("Digite o 1º valor: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int valor_2 = int.Parse(Console.ReadLine());
            int soma = valor_1 + valor_2;
            Console.WriteLine($"{valor_1} + {valor_2} = {soma}");
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.Write("Digite o 1º valor: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int valor_2 = int.Parse(Console.ReadLine());
            int soma = valor_1 - valor_2;
            Console.WriteLine($"{valor_1} - {valor_2} = {soma}");
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.Write("Digite o 1º valor: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int valor_2 = int.Parse(Console.ReadLine());
            int soma = valor_1 * valor_2;
            Console.WriteLine($"{valor_1} * {valor_2} = {soma}");
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.Write("Digite o 1º valor: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º valor: ");
            int valor_2 = int.Parse(Console.ReadLine());
            float soma = (float)valor_1 / (float)valor_2;
            Console.WriteLine($"{valor_1} / {valor_2} = {soma}");
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.Write("Digite o valor base: ");
            int valor_1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            int valor_2 = int.Parse(Console.ReadLine());
            double pow = Math.Pow(valor_1, valor_2);
            Console.WriteLine($"{valor_1}^{valor_2} = {pow}");
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
        static void Root()
        {
            Console.Write("Digite o valor base: ");
            int valor_1 = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(valor_1);
            Console.WriteLine(root);
            Console.WriteLine("Aperte ENTER para voltar ao MENU.");
            Console.ReadLine();
        }
    }
}
