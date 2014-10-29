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
    public partial class frmDelegateLambda : Form
    {
        public frmDelegateLambda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            PedidoComDelegate mPedido = new PedidoComDelegate();
            mPedido.Pagar += v => MessageBox.Show("Boleto Pago no valor de " + v.ToString());
            mPedido.Pagar2 += (v1, v2) => MessageBox.Show("O valor de v1 é: " + v1 + " e o valor de v2 é: " + v2);
            // mPedido.Fechar(1450.45);
            mPedido.Fechar2(10);
        }
    }
}
