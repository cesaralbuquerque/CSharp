using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWinForm
{
    public partial class frmDelegateAnonimo : Form
    {
        public frmDelegateAnonimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.PedidoComDelegate mPedido = new Model.PedidoComDelegate();
            mPedido.Pagar += delegate(double valor)
            {
                MessageBox.Show("O Pedio foi Pago no Boleto no valor de " + valor.ToString());
            };
            mPedido.Pagar += mPedido_Pagar;
            mPedido.Fechar(2000);
        }

        void mPedido_Pagar(double valor)
        {
            MessageBox.Show("Deverá ser pago: " + valor.ToString() + " valor");
        }
    }
}
