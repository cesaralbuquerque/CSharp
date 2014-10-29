using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exe_3_MVP.Helpers;

namespace Exe_3_MVP.View
{
    public interface IClienteView
    {
        List<entity.Cliente> Clientes { get; set; }
        event EventHandler LoadClientes;
        event EventHandler<AddClienteEventArgs> AddCliente;
        event EventHandler<GetClienteEventsArgs> GetCliente;
        event EventHandler<AlterarClienteEventArgs> AlterarCliente;

    }
}