// Operadores Aritiméticos
namespace Name
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o primeiro número:");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int N2 = Convert.ToInt32(Console.ReadLine());

            int soma = N1 + N2;
            int subtração = N1 - N2;
            int multiplicação = N1 * N2;
            int divisão = N1 / N2;
            int resto = N1 % N2;

            Console.WriteLine("Resultado da soma é: " + soma);
            Console.WriteLine("Resultado da subtração é: " + subtração);
            Console.WriteLine("Resultado da multiplicação é: " + multiplicação);
            Console.WriteLine("Resultado da divisão é: " + divisão);
            Console.WriteLine("Resultado do resto da dividão é: " + resto);
        }
    }
}