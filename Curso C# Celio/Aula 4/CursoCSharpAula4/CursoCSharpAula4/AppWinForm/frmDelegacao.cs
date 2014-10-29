using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppWinForm.Model;

namespace AppWinForm
{
    public partial class frmDelegacao : Form
    {
        public frmDelegacao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Model.Pedido pedido = new Model.Pedido();
            pedido.Fechar(200);
        }

        private void btnFecharPedidoPorDelegate_Click(object sender, EventArgs e)
        {
            Model.PedidoComDelegate pedido = new Model.PedidoComDelegate();
            pedido.Pagar += pedido_Pagar;
            pedido.Pagar += pedido_Pagar2;
            pedido.Fechar(20000);

        }

        void pedido_Pagar2(double valor)
        {
            MessageBox.Show("Pgar2 - Boleto Pago no valor de " + valor.ToString());
        }

        void pedido_Pagar(double valor)
        {
            MessageBox.Show("Boleto Pago no valor de " + valor.ToString());
        }

    }
}
