using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpWebApp.entity;

namespace MvpWebApp.Helpers
{
    public class AddClienteEventArgs<T> : EventArgs
    {
        public T NovoCliente { get; set; }

        public AddClienteEventArgs(T cliente)
        {
            NovoCliente = cliente;
        }
    }

    public class AlterarClienteEventArgs<T> : EventArgs
    {
        public T ClienteAlterado { get; set; }

        public AlterarClienteEventArgs(T cliente)
        {
            ClienteAlterado = cliente;
        }
    }

    public class GetClienteEventArgs<T> : EventArgs
    {
        public int ClienteId { get; set; }
        public T Cliente { get; set; }
        public GetClienteEventArgs(int clienteId)
        {
            this.ClienteId = clienteId;
        }

    }
}