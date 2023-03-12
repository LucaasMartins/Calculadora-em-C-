using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_em_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double num1, num2, resultado;

            Console.WriteLine("Olá, qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo " + nome + "!" + " Vamos dar início aos nossos calculos.");

            Console.WriteLine("Por favor, informe um número:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora, informe mais um número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Agora, escolha sua operações:");
            Console.WriteLine("\ta - Adição");
            Console.WriteLine("\ts - Subtração");
            Console.WriteLine("\tm - Multiplicação");
            Console.WriteLine("\td - Divisão");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Seu resultado é = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Seu resultado é = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Seu resultado é = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Seu resultado é = " + (num1 / num2));
                    break;
            }


            Console.ReadKey();

        }
    }
}
