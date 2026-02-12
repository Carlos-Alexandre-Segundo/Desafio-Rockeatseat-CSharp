//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

using System.Runtime.Intrinsics.Arm;

namespace Teste;

    class contadorDePalavras
    {
        public static void qtdeDePalavras(string[] args)
        {
            Console.WriteLine("Digite uma ou mais palavras:");
            string input = Console.ReadLine();
            int quantidadeDeCaracteres = input.Length;
            Console.WriteLine($"A quantidade de caracteres digitados é: {quantidadeDeCaracteres}");

            Console.WriteLine("\n Você quer continuar ?");
            string resposta = Console.ReadLine().ToLower().Trim();

        if (resposta == "s" || resposta == "sim")
        {
            Console.Clear();
            contadorDePalavras.qtdeDePalavras(args);
        }
        if (resposta == "n" || resposta == "nao")
        {
            
            Console.WriteLine("Saindo do contador de palavras. Até a próxima!");

            Console.Clear();

            tabelaDeFuncoes.mostrarTabelaDeFuncoes(args);
        }
         else
            {
                Console.WriteLine("Resposta inválida. Saindo da calculadora. Até a próxima!");
            }


        }
}

