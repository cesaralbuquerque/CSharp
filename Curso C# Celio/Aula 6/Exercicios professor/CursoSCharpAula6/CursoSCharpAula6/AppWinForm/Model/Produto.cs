using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinForm.Model
{
    public class Produto
    {
        private string _Nome;
        private double _Valor;

        public Produto(string pNome, double pValor)
        {
            this._Nome = pNome;
            this._Valor = pValor;
        }
        public double Valor {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public string Nome { get { return _Nome; } }
    }
}
