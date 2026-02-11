using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Enum___Switch
{
    internal class Program
    {
        // Lembrando que o ENUM fica fora da função main() pq enum NÃO É EXECUÇÃO DE INSTRUÇÃO
        // Mas sim definição de tipo
        enum Profissoes { Medico = 1, Advogado, Engenheiro, Analista_TI };
        static void Main(string[] args)
        {
            // A junção entre o ENUM e SWITCH serve devido a indexação de variáveis especificas com
            // valores que referenciam essas variáveis
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.Write("1- Médico\n2- Advogado\n3- Engenheiro\n4- Analista de TI\n");
            // Criar o enum, sendo o primeiro = 1 para começar com 0
            // Indexação de valores digitados pelo Usuário com a qty de valores listados acima
            int valoresDigitado = int.Parse(Console.ReadLine());
            // Isso abaixo funciona pq todo enum é internamente um numero inteiro
            Profissoes ProfissoesSelecionadas = (Profissoes)valoresDigitado;
            switch (ProfissoesSelecionadas)
            {
                case Profissoes.Medico:
                    Console.WriteLine("Sua profissão é Médico!");
                    break;
                case Profissoes.Advogado:
                    Console.WriteLine("Sua profissão é Advogado!");
                    break;
                case Profissoes.Engenheiro:
                    Console.WriteLine("Sua profissão é Engenheiro!");
                    break;
                case Profissoes.Analista_TI:
                    Console.WriteLine("Sua profissão é Analista de TI!");
                    break;
            }
        }
    }
}
