using System;
using CalculoRetangulo;

namespace ExemploRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um retângulo usando o construtor sem parâmetros
            Retangulo retangulo = new Retangulo();

            // Exibe informações do retângulo
            Console.WriteLine(retangulo);
            Console.WriteLine($"Área: {retangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {retangulo.CalcularPerimetro()}");
            Console.WriteLine($"Diagonal: {retangulo.CalcularDiagonal()}");
        }
    }
}
