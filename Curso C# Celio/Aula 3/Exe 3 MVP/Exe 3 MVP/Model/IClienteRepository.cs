using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_3_MVP.Model
{
    public interface IClienteRepository
    {
        List<ClienteRepository> Clientes { get; }
        void addNovoCliente(ClienteRepository cliente);
        void alterarCliente(ClienteRepository cliente);
        ClienteRepository getCliente(int clienteId);
    }
}