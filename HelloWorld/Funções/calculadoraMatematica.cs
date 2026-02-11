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
        
        Console.WriteLine("Digite o primeiro número:");
        try
        {
            double n1 = Convert.ToDouble(Console.ReadLine());
            if (!double.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Valor inválido para o primeiro número. Por favor, insira um número válido.");
                return;
            }
        }
        catch
        {
        double n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        if (!double.TryParse(Console.ReadLine(), out n2))

            {
                Console.WriteLine("Valor inválido para o segundo número. Por favor, insira um número válido.");
                return;
            }

            
        }


        Console.WriteLine("O que você deseja fazer com esses números?");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            string operacao = Console.ReadLine();
        
       
    }

}
