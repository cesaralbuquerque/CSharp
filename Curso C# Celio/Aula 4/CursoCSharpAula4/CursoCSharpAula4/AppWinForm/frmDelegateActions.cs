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
    public partial class frmDelegateActions : Form
    {
        List<Cliente> clientes = new List<Cliente>
            {
                new Cliente{ID=1,Nome="Fulano"},
                new Cliente{ID=2, Nome="Beltrano"},
                new Cliente{ID=3, Nome="Fábio"},
                new Cliente{ID=4, Nome="Marcio"}
            };

        public frmDelegateActions()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Action<Cliente> minhaAction = new Action<Cliente>(delegate(Model.Cliente c) {
                MessageBox.Show("O Nome do Cliente é: " + c.Nome);
            });
            
            clientes.ForEach(minhaAction);
        }

        private void btnPredicate_Click(object sender, EventArgs e)
        {
            Predicate<Cliente> mPredicate = new Predicate<Cliente>(c => c.ID > 3);

            clientes.FindAll(mPredicate).ForEach(c => MessageBox.Show("O Cliente Atual é: " + c.Nome));
            /*
            List<string> Nomes = new List<string> { "Fulano", "Beltrano", "Fábio", "Márcio" };
            foreach (var nome in Nomes)
            {
                if (nome.Contains('r'))
                    MessageBox.Show(nome);
            }
            MessageBox.Show("Usando Predicate");
            Predicate<string> mValidaNomes = new Predicate<string>(n => n.Contains('r'));
            foreach(var nome in Nomes.FindAll(mValidaNomes))
            {
                MessageBox.Show(nome);
            }
            */
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            Func<Cliente, Cliente> mfunc = new Func<Cliente, Cliente>(Validar);
            

            //foreach (var c in clientes.Select(mfunc))
            //{
            //    if (c != null)
            //        MessageBox.Show("O Cliente que contém a letra r é: " + c.Nome);
            //}

            Func<Cliente, bool> mFunBool = new Func<Cliente, bool>(c => c.Nome.Contains('r'));

            foreach (var c in clientes.Where(mFunBool))
            {
                MessageBox.Show("O Cliente que contém a letra r é: " + c.Nome);
            }

            //foreach (var cliente in clientes)
            //{
            //    if (Validar(cliente) != null)
            //        MessageBox.Show("O Cliente que contém a letra r é: " + cliente.Nome);
            //}

            
            
        }

        Cliente Validar(Cliente c)
        {
            if (c.Nome.Contains('r'))
                return c;
            else 
                return null;
        }
    }
}
