using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForm.Model
{
    public class Boleto
    {
        public void Pagar(double Valor)
        {
            MessageBox.Show("Boleto Pago no valor de " + Valor.ToString());
        }

    }

    public class Pedido
    {
        Boleto _boleto = new Boleto();

        public void Fechar(double valor)
        {
            _boleto.Pagar(valor);
        }
    }

    //public delegate void PagarEvent(double valor);
    //public delegate void Pgar2Event(double valor1, double valor2);


    public class PedidoComDelegate
    {
        public event Action<double> Pagar;
        public event Action<double, double> Pagar2;
        public event Action<double, string, string, decimal> pagar3;

        public void Fechar(double valor)
        {
            Pagar(valor);
        }

        public void Fechar2(double valor)
        {
            Pagar2(valor, valor * 2);
        }

    }

    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
    }
}
