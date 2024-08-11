using System;

namespace Tp1CSharp
{
    public class Exercicio2Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePublicacao { get; set; }
        public double Preco { get; set; }
        
        public void AdicionarLivro (string titulo, string autor, int anoDePublicacao, double preco)
        {
            Titulo = titulo;
            Autor = autor;
            AnoDePublicacao = anoDePublicacao;
            Preco = preco;
        }
        public override string ToString()
        {
            return $"Titulo: {Titulo}, Autor: {Autor}, Ano de Publicação: {AnoDePublicacao}, Preço: {Preco}";
        }
    }
}