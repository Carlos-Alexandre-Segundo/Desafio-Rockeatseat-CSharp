//1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
//-A soma entre esses dois números;
//-A subtração entre os dois números;
//-A multiplicação entre os dois números;
//-A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
//-A média entre os dois números.

namespace Teste;
class calculadoraMatematica
{
    public static void calculadora(string[] args)
    {
        double n1, n2;

        Console.WriteLine("Digite o primeiro número:");

        while (!double.TryParse(Console.ReadLine(), out n1))
        {
                Console.WriteLine("Valor inválido para o primeiro número. Por favor, insira um número válido.");
                return;    
        }

        Console.WriteLine("Digite o segundo número:");

        while (!double.TryParse(Console.ReadLine(), out n2))
        {           
                Console.WriteLine("Valor inválido para o segundo número. Por favor, insira um número válido.");
                return;            
        }

        Console.Clear();


        Console.WriteLine("O que você deseja fazer com esses números?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Média");

        string operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1":
                Console.WriteLine($"A soma de {n1} e {n2} é: {n1 + n2}");
                break;

            case "2":
                Console.WriteLine($"A subtração de {n1} e {n2} é: {n1 - n2}");

                break;

            case "3":
                Console.WriteLine($"A multiplicação de {n1} e {n2} é: {n1 * n2}");

                break;

            case "4":
                Console.WriteLine($"A divisão de {n1} e {n2} é: {(n2 != 0 ? (n1 / n2).ToString() : "Erro: Divisão por zero não é permitida")}");
                break;

            case "5":
                Console.WriteLine($"A média de {n1} e {n2} é: {(n1 + n2) / 2}");
                break;
        }

        Console.WriteLine("Você deseja continua na calculadora ? (s/n)");
        string resposta = Console.ReadLine().ToLower().Trim();
        if (resposta == "s" || resposta == "sim")
        {
            Console.Clear();
            calculadora(args);
        }
         else if (resposta == "n" || resposta == "não")
        {
            Console.WriteLine("Saindo da calculadora. Até a próxima!");

            Console.Clear();

            tabelaDeFuncoes.mostrarTabelaDeFuncoes(args);
        }
         else
        {
            Console.WriteLine("Resposta inválida. Saindo da calculadora. Até a próxima!");
        }

    }
}

