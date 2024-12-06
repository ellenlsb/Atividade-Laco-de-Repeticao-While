using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex4
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            int multiplicador = 1;

            while (multiplicador <= 10)
            {
                Console.WriteLine(numero + " x " + multiplicador + " = " + (numero * multiplicador));
                multiplicador++;
            }
        }
    }
}
