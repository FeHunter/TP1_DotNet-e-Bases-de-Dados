using System;

namespace Tp1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Area do Circulo
            Exercicio1AreaCirculo exercicio1AreaCirculo= new Exercicio1AreaCirculo();
            exercicio1AreaCirculo.AreaCircula(5, 0);

            // Area do Retangulo
            Exercicio1AreaRetangulo areaRetangulo = new Exercicio1AreaRetangulo();
            areaRetangulo.AreaRetangulo(5, 2);
        }
    }
}