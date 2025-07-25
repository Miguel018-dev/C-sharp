// Input e Output
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace aula4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
        }
    }
}