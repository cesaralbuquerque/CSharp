using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MvpWebApp.entity;
using MvpWebApp.Helpers;
using MvpWebApp.Presenter;

namespace MvpWebApp.Views
{
    public partial class CadastraCliente : System.Web.UI.Page, IClienteView
    {
        ClientePresenter presenter;

        List<entity.Cliente> clientes;

        public event EventHandler LoadClientes;
        public event EventHandler<Helpers.AddClienteEventArgs> AddCliente;
        public event EventHandler<Helpers.GetClienteEventArgs> GetCliente;
        public event EventHandler<Helpers.AlterarClienteEventArgs> AlterarCliente;

        public List<Cliente> Clientes
        {
            get
            {
                return clientes;
            }
            set
            {
                this.clientes = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["repository"] == null)
                this.Session["repository"] = new Models.ClienteRepository();
            presenter = new ClientePresenter(this, 
                this.Session["repository"] as Models.ClienteRepository);
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente mCliente = new Cliente();
            int codigo = 0;
            int.TryParse(txtCodigo.Text, out codigo);
            mCliente.Codigo = codigo;
            mCliente.Nome = txtNome.Text;

            if (mCliente.Codigo == 0)
                AddCliente(this, new AddClienteEventArgs(mCliente));
            else
                AlterarCliente(this, new AlterarClienteEventArgs(mCliente));
            
            BindClientes();
        }

        private void BindClientes()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            LoadClientes(this, EventArgs.Empty);
            gvClientes.DataSource = clientes;
            gvClientes.DataBind();
        }

        protected void gvClientes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GetClienteEventArgs mEvento = new GetClienteEventArgs(e.NewSelectedIndex + 1);
            GetCliente(this, mEvento);
            txtCodigo.Text = mEvento.Cliente.Codigo.ToString();
            txtNome.Text = mEvento.Cliente.Nome;
        }

    }
}