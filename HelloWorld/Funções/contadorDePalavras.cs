//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

namespace Teste;

    class contadorDePalavras
    {
        public static void qtdeDePalavras(string[] args)
        {
            Console.WriteLine("Digite uma ou mais palavras:");
            string input = Console.ReadLine();
            int quantidadeDeCaracteres = input.Length;
            Console.WriteLine($"A quantidade de caracteres digitados é: {quantidadeDeCaracteres}");
    }
}

