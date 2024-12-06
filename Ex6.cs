using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Ex6
    {
        public static void Main(string[] args)
        {
            string operacao;

            do
            {
                Console.Write("Escolha uma operação (+, -, *, /) ou digite 'sair' para encerrar: ");
                operacao = Console.ReadLine();

                if (operacao == "sair") break;

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                if (operacao == "+") Console.WriteLine("Resultado: " + (num1 + num2));
                else if (operacao == "-") Console.WriteLine("Resultado: " + (num1 - num2));
                else if (operacao == "*") Console.WriteLine("Resultado: " + (num1 * num2));
                else if (operacao == "/") Console.WriteLine("Resultado: " + (num1 / num2));
                else Console.WriteLine("Operação inválida.");

            } while (true);
        }
    }
}