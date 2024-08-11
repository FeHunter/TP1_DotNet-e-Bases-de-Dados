using System;

namespace Tp1CSharp
{
    delegate void CalcularArea (double p1, double p2);
    class Exercicio1AreaCirculo
    {
        public CalcularArea AreaCircula = new CalcularArea(AreaDoCirculo);
        public static void AreaDoCirculo (double raio, double _)
        {
            Console.WriteLine($"Área do Circulo é {(Math.PI * Math.Pow(raio, 2)).ToString("F2")}");
        }
    }

    class Exercicio1AreaRetangulo
    {
        public CalcularArea AreaRetangulo = new CalcularArea(AreaDoRetangulo);
        public static void AreaDoRetangulo (double largura, double altura)
        {
            Console.WriteLine($"Área do Retangulo é {largura * altura}");
        }
    }
}