using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exe_3_MVP.entity;

namespace Exe_3_MVP.Helpers
{
    public class AddClienteEventArgs : EventArgs
    {
        public entity.Cliente NovoCliente { get; set; }

        public AddClienteEventArgs(entity.Cliente cliente)
        {
        }

    }

    public class AlterarClienteEventArgs : EventArgs
    {
        public entity.Cliente ClienteAlterado { get; set; } 

        public AlterarClienteEventArgs(entity.Cliente cliente)
        {
        }
    }

    public class GetClienteEventsArgs : EventArgs
    {
        public int ClienteId{get;set;}
        public Cliente cliente {get;set;}
        public GetClienteEventsArgs(int clienteId)
        {
            this.ClienteId = clienteId;
        }
    }
}