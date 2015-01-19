using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class CalculaCompra
    {
        public double total(CarrinhoDeCompras carrinho)
        {
            double total = 0;
            foreach (Produto prod in carrinho.Produtos)
            {
                total += prod.Valor;
            }

            return total *= porcentagem(total);

        }

        private double porcentagem(double total)
        {
            if (total >= 100 && total < 200)
                return 0.9;
            else if (total >= 200 && total < 300)
                return 0.8;
            else if (total >= 300 && total < 400)
                return 0.75;
            else if (total >= 400)
                return 0.7;
            return 1;
        }
    }
}
