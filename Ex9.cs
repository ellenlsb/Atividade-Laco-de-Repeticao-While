using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex9
    {
        public static void Main(string[] args)
        {
            string entrada;

            do
            {
                Console.Write("Digite uma string (ou 'fim' para encerrar): ");
                entrada = Console.ReadLine();

                if (entrada == "fim") break;

                int contagemVogais = 0;
                foreach (char c in entrada.ToLower())
                {
                    if ("aeiou".Contains(c)) contagemVogais++;
                }

                Console.WriteLine("Número de vogais: " + contagemVogais);

            } while (true);
        }
    }
}
