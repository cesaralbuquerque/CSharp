using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpWebApp.Models;
using MvpWebApp.Helpers;
using MvpWebApp.entity;
using MvpWebApp.Views;

namespace MvpWebApp.Presenter
{
    public class ClientePresenter
    {
       IClienteView view;
       IRepository<Cliente> repositorio;
       

       public ClientePresenter(IClienteView view, IRepository<Cliente> repositorio)
       {
           this.view = view;
           this.repositorio = repositorio;
           this.AttachEventsToView();
       }

       private void AttachEventsToView()
       {
           view.LoadClientes += OnLoadingClientes;
           view.AddCliente += OnAddCliente;
           view.AlterarCliente += OnAlterarCliente;
           view.GetCliente += OnGetCliente;     
       }

       private void OnGetCliente(object sender, GetClienteEventArgs e)
       {
           e.Cliente = repositorio.Get(e.ClienteId);
       }

       private void OnAlterarCliente(object sender, AlterarClienteEventArgs e)
       {
           repositorio.Alterar(e.ClienteAlterado);
       }

       private void OnAddCliente(object sender, AddClienteEventArgs e)
       {
           repositorio.AddNovo(e.NovoCliente);
       }

       private void OnLoadingClientes(object sender, EventArgs e)
       {
           view.Clientes = repositorio.Dados;
       }
    }
}