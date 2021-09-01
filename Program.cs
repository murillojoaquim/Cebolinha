using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Digite uma frase para o cebolinha dizer: ");
            string texto = Console.ReadLine();
            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nCebolinha: ");
            
            Console.ResetColor();
            Console.WriteLine(texto.Replace("r", "l"));

            Console.ResetColor();
            

        }
    }
}
