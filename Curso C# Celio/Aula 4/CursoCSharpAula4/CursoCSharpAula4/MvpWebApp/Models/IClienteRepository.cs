using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpWebApp.entity;

namespace MvpWebApp.Models
{
    public interface IClienteRepository
    {
        List<Cliente> Clientes { get; }
        void AddNovoCliente(Cliente cliente);
        void AlterarCliente(Cliente cliente);
        Cliente GetCliente(int clienteId);
    }
}
