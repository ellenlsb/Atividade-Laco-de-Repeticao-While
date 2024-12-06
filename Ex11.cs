using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int numero = Math.Abs(int.Parse(Console.ReadLine()));
            int contador = 0;

            do
            {
                numero /= 10;
                contador++;
            } while (numero > 0);

            Console.WriteLine("O número possui " + contador + " dígitos.");
        }
    }
}
