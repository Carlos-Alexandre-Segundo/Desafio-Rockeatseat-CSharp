using System.Security.Cryptography.X509Certificates;

namespace Teste;

//Crie um programa em que o usuário precisa digitar um
//nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
class boasVindas
{
    public static void mensagemBoasVindas(string[] args)
    {
        Console.WriteLine("Olá, digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("olá, " + nome + "! Seja muito bem-vindo!");
    }
}
