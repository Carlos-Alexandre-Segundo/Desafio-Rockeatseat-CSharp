namespace Helloworld;

class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro Ligado");
    }

    public void Desligar() 
    {
        Console.WriteLine("Carro Desligado");
    }

    private void Teste1()
    {
        Console.WriteLine("Teste 1");
    }

    internal void Teste2()
    {
        Console.WriteLine("Carro Desligado");
    }
}
