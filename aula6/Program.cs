// Operadores de atribuição
namespace aula6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite um valor: ");
           int valor = Convert.ToInt32(Console.ReadLine());


            valor++;
            Console.WriteLine(valor);

            valor--;
            Console.WriteLine(valor);

            valor += 9;
            Console.WriteLine(valor);

            valor -= 7;
            Console.WriteLine(valor);

            valor *= 6;
            Console.WriteLine(valor);

            valor /= 3;
            Console.WriteLine(valor);        
        }
    }
}
