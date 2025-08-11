// Matrizes e Matrizes bidmensionais.
using System;
using System.Linq;

namespace aula11
{
    class Program
    {
        static void Main()
        {
            string[] carros = { "bmw", "mercedes", "volvo", "ford" };

            Array.Sort(carros);
            Console.WriteLine(carros[2]);
            Console.WriteLine(carros.Length);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }

            foreach (string v in carros)
            {
                Console.WriteLine(v);
            }

            int[] números = { 9, 0, 6, 17, 8 };

            Array.Sort(números);
            Console.WriteLine(números.Max());
            Console.WriteLine(números.Min());
            Console.WriteLine(números.Sum());

            int[,] valor = { { 3, 4, 7 }, { 9, 8, 2 } };

            Console.WriteLine(valor[0, 2]);

            foreach (int l in valor)
            {
                Console.WriteLine(l);
            }

            for (int li = 0; li < valor.GetLength(0); li++)
            {
                for (int col = 0; col < valor.GetLength(1); col++)
                {
                    Console.WriteLine(valor[li, col]);
                }
            }
        }
    }
}