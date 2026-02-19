using System;
using System.Text.RegularExpressions;

namespace Teste;
class verificadorDePlaca
{
    public static void verificarPlaca(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Digite a placa do veículo:");

            string placa = Console.ReadLine().ToUpper().Trim();

            string placaRegex = @"^[A-Z]{3}[-]?\d{4}$|^[A-Z]{3}\d[A-Z]\d{2}$";

            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("A placa não pode ser vazia.");
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            string placaLimpa = placa.Replace("-", "").Replace(" ", "").ToUpper();

            if (System.Text.RegularExpressions.Regex.IsMatch(placaLimpa, placaRegex))
            {
                Console.WriteLine($"A Placa {placa} é válida!");
            }
            else
            {
                Console.WriteLine($"A placa {placa} não é válida, digite novamente.");
            }

           

            Console.WriteLine("\nVocê quer verificar outra placa? (s/n)");
            string resposta = Console.ReadLine().ToLower().Trim();
            if (resposta == "s" || resposta == "sim" || resposta == "SIM")
            {
                Console.Clear();
                continue;                          
            }
            else if (resposta == "n"|| resposta == "não" || resposta == "nao")
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o verificador de placas, agora passa um pix");
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

