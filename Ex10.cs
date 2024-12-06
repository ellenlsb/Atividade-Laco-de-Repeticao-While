using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
            {
                Console.WriteLine("Não é primo.");
                return;
            }

            int divisor = 2;
            bool isPrimo = true;

            while (divisor <= Math.Sqrt(numero))
            {
                if (numero % divisor == 0)
                {
                    isPrimo = false;
                    break;
                }
                divisor++;
            }

            if (isPrimo) Console.WriteLine("É primo.");
            else Console.WriteLine("Não é primo.");
        }
    }
}
