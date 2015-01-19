using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class Produto
    {
        public Produto(string pnome, double pvalor)
        {
            this.nome = pnome;
            this.valor = pvalor;
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
