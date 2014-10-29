using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpWebApp.Helpers;

namespace MvpWebApp.Views
{
    public interface IClienteView<T> : IView
    {
        List<T> Clientes { get; set; }
        event EventHandler LoadClientes;
        event EventHandler<AddClienteEventArgs<T>> AddCliente;
        event EventHandler<GetClienteEventArgs<T>> GetCliente;
        event EventHandler<AlterarClienteEventArgs<T>> AlterarCliente;
    }
}
