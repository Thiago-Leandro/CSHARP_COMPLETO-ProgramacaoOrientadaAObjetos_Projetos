using System.Diagnostics.SymbolStore;
using System.Globalization;

namespace EstruturaRepetitivaFor
{
    class EstruturaRepetitivaFor
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar?");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }
    }
}