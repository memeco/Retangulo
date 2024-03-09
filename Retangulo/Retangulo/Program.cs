using System;

using System;

namespace CalculoRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, largura;

            Console.Write("Digite a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura do retângulo: ");
            largura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(altura, largura);

            Console.WriteLine("\nÁrea: " + retangulo.CalcularArea().ToString("F2"));
            Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro().ToString("F2"));
            Console.WriteLine("Diagonal: " + retangulo.CalcularDiagonal().ToString("F2"));

        }
    }
}
