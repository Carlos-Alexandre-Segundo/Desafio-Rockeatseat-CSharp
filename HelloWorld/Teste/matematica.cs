using Helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;
class Program
{
    enum nivelDeDificuldade 
    { 
        Facil,
        Medio,
        Dificil,
        MuitoDificil
    }

    static void Main()
    {
        nivelDeDificuldade nivel = nivelDeDificuldade.Dificil;

        Console.WriteLine($"O nível de dificuldade selecionado é: {nivel}");
    }

}
