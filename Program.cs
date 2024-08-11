using System;

namespace Tp1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Exercicio 1 - Area do Circulo
            Exercicio1AreaCirculo exercicio1AreaCirculo= new Exercicio1AreaCirculo();
            exercicio1AreaCirculo.AreaCircula(5, 0);

            // // Exercicio 1 - Area do Retangulo
            Exercicio1AreaRetangulo areaRetangulo = new Exercicio1AreaRetangulo();
            areaRetangulo.AreaRetangulo(5, 2);

            // Exercicio 2
            Exercicio2Livro livro = new Exercicio2Livro();
            Action<string, string, int, double> registraLivro = livro.AdicionarLivro;
            registraLivro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, 79.90);
            Console.WriteLine(livro.ToString());

            // Exercicio 3
            Exercicio3 exercicio3ValorDoPedido = new Exercicio3();
            Func<int, double, double, double, double> valorDoPedido = exercicio3ValorDoPedido.ValorTotalDoPedido;
            double resultadoEx3 = valorDoPedido(5, 50, 20, 15);
            Console.WriteLine("Valor total do pedido = " + resultadoEx3);

            // Exercicio 4
            Exercicio4 exercicio4Alerta = new Exercicio4();
            ClienteExercicio4 clienteExercicio4 = new ClienteExercicio4();
            exercicio4Alerta.AlertaDelegate += clienteExercicio4.RecebeAlerta;
            exercicio4Alerta.EnviarAlerta();
        }
    }
}