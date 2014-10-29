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
       IClienteRepository repositorio;

       public ClientePresenter(IClienteView view, IClienteRepository repositorio)
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
           e.Cliente = repositorio.GetCliente(e.ClienteId);
       }

       private void OnAlterarCliente(object sender, AlterarClienteEventArgs e)
       {
           repositorio.AlterarCliente(e.ClienteAlterado);
       }

       private void OnAddCliente(object sender, AddClienteEventArgs e)
       {
           repositorio.AddNovoCliente(e.NovoCliente);
       }

       private void OnLoadingClientes(object sender, EventArgs e)
       {
           view.Clientes = repositorio.Clientes;
       }
    }
}