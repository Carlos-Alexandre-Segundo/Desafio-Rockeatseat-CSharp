using System.Security.Cryptography.X509Certificates;

namespace Teste;


class boasVindas
{
    public static void mensagemBoasVindas(string[] args)
    {
        Console.WriteLine("Olá, digite seu nome:");
        string nome = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("olá, " + nome + "! Seja muito bem-vindo!");
    }
}
