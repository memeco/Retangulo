using System;

namespace RetanguloCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, altura, area, perimetro, diagonal;

            Console.Write("Digite a largura do retângulo: ");
            largura = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            Console.WriteLine("\nÁrea = " + area.ToString("F2"));
            Console.WriteLine("Perímetro = " + perimetro.ToString("F2"));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F2"));

          
        }
    }
}