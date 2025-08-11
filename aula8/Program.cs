// Operadores if, else e switch case.

using System.Collections;
using System.Runtime.CompilerServices;

namespace aula8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Qual sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você pode dirigir.");
            }
            else
            {
                Console.WriteLine("Você não pode dirigir.");
            }

            Console.WriteLine("Que dia é hoje?");
            int dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda");
                    break;

                case 3:
                    Console.WriteLine("Terça");
                    break;

                case 4:
                    Console.WriteLine("Quarta");
                    break;

                case 5:
                    Console.WriteLine("Quinta");
                    break;

                case 6:
                    Console.WriteLine("Sexta");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default: Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}
