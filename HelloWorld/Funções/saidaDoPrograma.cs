using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class saidaDoPrograma
    {
        public static void sair(string[] args)
        {
            Console.WriteLine("Terminamos a sua função, você deseja sair ? (s/n)");
            string resposta = Console.ReadLine().ToLower().Trim();

            if(resposta == "s" || resposta == "sim")
            {
                Console.WriteLine("Saindo do programa. Até a próxima!");
                Environment.Exit(0);
            }
             else if (resposta == "n" || resposta == "não")
            {
                Console.WriteLine("Continuando no programa. Selecione outra função.");
                Console.Clear();
                
            }
             else
            {
                Console.WriteLine("Resposta inválida. Continuando no programa. Selecione outra função.");
            }
        }
           
    }
}
