using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex3
    {
        public static void Main(string[] args)
        {
            int numero = 10;

            while (numero > 0)
            {
                Console.WriteLine(numero);
                numero--;
            }

            Console.WriteLine("FIM!");
        }
    }
}