using AppWebAula5.Model.entidades;
using AppWebAula5.Model.presenter;
using AppWebAula5.Model.repository;
using AppWebAula5.Model.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWebAula5.View
{
    public partial class Clientes : System.Web.UI.Page, IView<eCliente>
    {
        List<eCliente> _ListaClientes;
        IRepository<eCliente> mRepository;
        Presenter<eCliente> mPresenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            mRepository = this.Session["RepositoryCliente"] as IRepository<eCliente>;
            if(mRepository == null)
            {
                mRepository = new RepositoryLista<eCliente>();
                this.Session.Add("RepositoryCliente", mRepository);
            }
            mPresenter = new Presenter<eCliente>(this, mRepository);
        }

        #region Implementação da Interface IView

        public List<eCliente> Lista
        {
            get
            {
                return _ListaClientes;
            }
            set
            {
                this._ListaClientes = value;
            }
        }

        public event EventHandler Carregar;

        public event EventHandler<Model.helpers.CUDEventArgs<eCliente>> Adicionar;

        public event EventHandler<Model.helpers.CUDEventArgs<eCliente>> Alterar;

        public event EventHandler<Model.helpers.CUDEventArgs<eCliente>> Excluir;

        public event EventHandler<Model.helpers.BuscarEventArgs<eCliente>> Buscar;

        #endregion

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            eCliente mCliente = new eCliente
            {
                CPF_CNPJ = txtCPF.Text,
                Nome = txtNome.Text,
                SobreNome = txtSobreNome.Text,
                Endereco = txtEndereco.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                UF = txtUF.Text
            };
            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                mCliente.Codigo = codigo;
                Alterar(sender, new Model.helpers.CUDEventArgs<eCliente>(mCliente));
            }
            else
            {
                Adicionar(sender, new Model.helpers.CUDEventArgs<eCliente>(mCliente));
                txtCodigo.Text = mCliente.Codigo.ToString();
            }


        }


    }
}