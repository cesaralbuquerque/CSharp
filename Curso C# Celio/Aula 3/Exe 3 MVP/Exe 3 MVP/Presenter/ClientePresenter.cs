using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exe_3_MVP.View;
using Exe_3_MVP.entity;
using Exe_3_MVP.Model;
using Exe_3_MVP.Helpers;

namespace Exe_3_MVP.Presenter
{
    public class ClientePresenter
    {
        IClienteView view;
        IClienteRepository repositorio;

        public ClientePresenter()
        {
            this.view = view;
            this.repositorio = repositorio;
            this.AttachEventsToView();
        }

        private void AttachEventsToView()
        {
            view.LoadClientes += OnLoadingClientes;
            view.AddCliente += OnAddClientes;
            view.AlterarCliente += OnAlterarClientes;
            view.GetCliente += OnGetClientes;
        }

        private void OnLoadingClientes(object sender, EventArgs e)
        {
            view.Clientes = repositorio.Clientes;
        }

        private void OnAlterarClientes(object sender, Helpers.AlterarClienteEventArgs e)
        {
            repositorio.alterarCliente(e.ClienteAlterado);
        }

        private void OnGetClientes(object sender, Helpers.GetClienteEventsArgs e)
        {
            e.Cliente = repositorio.GetCliente(e.ClienteId);
        }

        private void OnAddClientes(object sender, Helpers.AddClienteEventArgs e)
        {
            repositorio.addNovoCliente(e.NovoCliente);
        }




    }
}