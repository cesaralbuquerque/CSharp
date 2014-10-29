using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpWebApp.entity;

namespace MvpWebApp.Helpers
{
    public class AddClienteEventArgs : EventArgs
    {
        public entity.Cliente NovoCliente { get; set; }

        public AddClienteEventArgs(entity.Cliente cliente)
        {
            NovoCliente = cliente;
        }
    }

    public class AlterarClienteEventArgs : EventArgs
    {
        public entity.Cliente ClienteAlterado { get; set; }

        public AlterarClienteEventArgs(entity.Cliente cliente)
        {
            ClienteAlterado = cliente;
        }
    }

    public class GetClienteEventArgs : EventArgs
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public GetClienteEventArgs(int clienteId)
        {
            this.ClienteId = clienteId;
        }

    }

}