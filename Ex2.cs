using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex2
    {
        public static void Main(string[] args)
        {
            int numero;
            int soma = 0;

            do
            {
                Console.Write("Digite um número (0 para sair): ");
                numero = int.Parse(Console.ReadLine());
                soma += numero;
            } while (numero != 0);

            Console.WriteLine("A soma dos números digitados é: " + soma);
        }
    }
}
