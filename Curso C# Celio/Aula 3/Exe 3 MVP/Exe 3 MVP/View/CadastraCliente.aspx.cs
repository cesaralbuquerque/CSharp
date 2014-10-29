using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Exe_3_MVP.entity;
using Exe_3_MVP.Presenter;
using Exe_3_MVP.Helpers;

namespace Exe_3_MVP.View
{
    public partial class CadastraCliente : System.Web.UI.Page , IClienteView
    {
        ClientePresenter presenter;

        List<entity.Cliente> clientes;

        public event EventHandler LoadClientes;
        public event EventHandler<Helpers.AddClienteEventArgs> AddCliente;
        public event EventHandler<Helpers.GetClienteEventsArgs> GetCliente;
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
                this.Session["repository"] = new Model.ClienteRepository();
           presenter = new ClientePresenter(this, this.Session["repository"] as Model.ClienteRepository);
                
        }

        private void BindClientes()
        {
            TextBoxCodigo.Text = "";
            TextBoxNome.Text = "";
            LoadClientes(this, EventArgs.Empty);
            gvClientes.DataSource = clientes;
            gvClientes.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente mcliente = new Cliente();
            int codigo = 0;
            int.TryParse(TextBoxCodigo.Text, out codigo);
            mcliente.Codigo = codigo;
            mcliente.Nome = TextBoxNome.Text;

            if (mcliente.Codigo == 0)
            {
                AddCliente(this, new AddClienteEventArgs(mcliente));
            }
            else
            {
                AlterarCliente(this, new AlterarClienteEventArgs(mcliente));
            }

            BindClientes();
        }

    }
}