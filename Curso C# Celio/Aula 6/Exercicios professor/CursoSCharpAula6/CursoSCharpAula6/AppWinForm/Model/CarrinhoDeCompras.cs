using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinForm.Model
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; private set; }

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
