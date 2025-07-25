/* Métodos Math
Math.Max máximo valor
Math.Min mínimo valor
Math.Sqrt raíz quadrada
Math.Abs valor absoluto
Math.Round arredondamento
*/

namespace aula7
{
    class Program
    {
        static void Main()
        {
            int N1 = 10;
            int N2 = 2;

            Console.WriteLine(Math.Max(N1, N2));
            Console.WriteLine(Math.Min(N1, N2));
            Console.WriteLine(Math.Sqrt(N1 + N2));
            Console.WriteLine(Math.Abs(-10.5));
            Console.WriteLine(Math.Round(4.8));

        }
    }
}