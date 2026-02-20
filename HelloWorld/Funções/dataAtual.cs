//Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:

using System.Globalization;

namespace Teste;

    class dataAtual
{
    public static void calendario(string[] strings)
    {
        DateTime agora = DateTime.Now;
        CultureInfo culturaBR = new CultureInfo("pt-BR");

        Console.WriteLine("=== DATA ATUAL EM DIFERENTES FORMATOS ===\n");

        // 1. Formato completo
        Console.WriteLine("1. FORMATO COMPLETO:");
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", culturaBR));
        Console.WriteLine();

        // 2. Apenas data
        Console.WriteLine("2. APENAS DATA (dd/MM/yyyy):");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));
        Console.WriteLine();

        // 3. Apenas hora (24h)
        Console.WriteLine("3. APENAS HORA (formato 24h):");
        Console.WriteLine(agora.ToString("HH:mm:ss"));
        Console.WriteLine();

        // 4. Data com mês por extenso
        Console.WriteLine("4. DATA COM MÊS POR EXTENSO:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", culturaBR));

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
        Console.Clear();
    }
}
