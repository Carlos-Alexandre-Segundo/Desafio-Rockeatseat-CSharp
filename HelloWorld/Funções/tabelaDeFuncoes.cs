using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class tabelaDeFuncoes
    {
        public static void mostrarTabelaDeFuncoes(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n=== Menu Principal ===");
                Console.WriteLine("Qual função você deseja ?");
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("2 - Data Atual");
                Console.WriteLine("3 - Contador de palavras");
                Console.WriteLine("4 - Verificador de Placas");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Função 1 selecionada.");
                        calculadoraMatematica.calculadora(args);
                        break;

                    case "2":
                        Console.WriteLine("Função 2 selecionada.");
                        dataAtual.calendario(args);
                        break;

                    case "3":
                        Console.WriteLine("Função 3 selecionada.");
                        contadorDePalavras.qtdeDePalavras(args);
                        break;

                    case "4":
                        Console.WriteLine("Função 4 selecionada.");
                        verificadorDePlaca.verificarPlaca(args);
                        break;

                    case "0":
                        Console.WriteLine("Saída selecionada.");
                        saidaDoPrograma.sair(args);
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, selecione uma função de 0 a 4.");
                        break;
                }
            }
        }
    }
}
