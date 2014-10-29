using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpWebApp.Helpers;

namespace MvpWebApp.Views
{
    public interface IClienteView : IView
    {
        List<entity.Cliente> Clientes { get; set; }
        event EventHandler LoadClientes;
        event EventHandler<AddClienteEventArgs> AddCliente;
        event EventHandler<GetClienteEventArgs> GetCliente;
        event EventHandler<AlterarClienteEventArgs> AlterarCliente;
    }
}
