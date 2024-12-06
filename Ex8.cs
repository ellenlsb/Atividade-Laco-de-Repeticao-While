using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex8
    {
        public static void Main(string[] args)
        {
            int numeroSecreto = 42; // Número secreto definido pelo programa
            int palpite;

            do
            {
                Console.Write("Adivinhe o número secreto: ");
                palpite = int.Parse(Console.ReadLine());

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                    break;
                }
                else
                {
                    Console.WriteLine("Tente novamente!");
                }

            } while (true);
        }
    }
}
