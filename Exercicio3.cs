using System;

namespace Tp1CSharp
{
    public class Exercicio3
    {
        public double ValorTotalDoPedido (int quantidade, double precoUnitario, double frete, double desconto)
        {
            double subtotal = quantidade * precoUnitario;
            double total = subtotal + frete - desconto;
            return total;
        }
    }
}

// quantidade de itens, o preço unitário, o valor do frete e o desconto aplicado
