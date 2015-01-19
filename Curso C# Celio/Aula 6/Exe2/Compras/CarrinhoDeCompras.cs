using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos;

        public CarrinhoDeCompras()
        {
            Produtos = new List<Produto>();
        }

        public void adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }

        
    }
}
