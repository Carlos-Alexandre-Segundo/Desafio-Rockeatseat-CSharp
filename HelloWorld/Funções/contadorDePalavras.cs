//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

namespace Teste;

class contadorDePalavras
{
    public static void qtdeDePalavras(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite uma ou mais palavras:");
            string input = Console.ReadLine();
            int quantidadeDeCaracteres = input.Length;
            Console.WriteLine($"A quantidade de caracteres digitados é: {quantidadeDeCaracteres}");

            Console.WriteLine("\nVocê continuar com o contador de palavras ? (s/n)");
            string resposta = Console.ReadLine().ToLower().Trim();
            if (resposta == "s" || resposta == "sim" || resposta == "SIM")
            {
                Console.Clear();
                continue;
            }
            else if (resposta == "n" || resposta == "não" || resposta == "nao")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o contador de palavras, agora passa um pix");
                Console.WriteLine("Pressione Enter para voltar ao menu...");
                Console.ReadLine();
                Console.Clear();
                tabelaDeFuncoes.mostrarTabelaDeFuncoes(args);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadLine();
                Console.Clear();
                continue;
            }
        }
    }
}

