using System;

namespace Tp1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Exercio 1 - Area do Circulo
            Exercicio1AreaCirculo exercicio1AreaCirculo= new Exercicio1AreaCirculo();
            exercicio1AreaCirculo.AreaCircula(5, 0);

            // // Exercio 1 - Area do Retangulo
            Exercicio1AreaRetangulo areaRetangulo = new Exercicio1AreaRetangulo();
            areaRetangulo.AreaRetangulo(5, 2);

            // Exercio 2
            Exercicio2Livro livro = new Exercicio2Livro();
            Action<string, string, int, double> registraLivro = livro.AdicionarLivro;
            registraLivro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 79.90);
            Console.WriteLine(livro.ToString());
        }
    }
}