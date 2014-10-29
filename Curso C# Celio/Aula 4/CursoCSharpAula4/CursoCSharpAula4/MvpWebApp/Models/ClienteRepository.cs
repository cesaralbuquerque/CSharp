using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpWebApp.Models
{
    public class ClienteRepository: IClienteRepository
    {
        List<entity.Cliente> clientes = new List<entity.Cliente>();


        public List<entity.Cliente> Clientes
        {
            get { return clientes; }
        }

        public void AddNovoCliente(entity.Cliente cliente)
        {
            cliente.Codigo = clientes.Count + 1;
            clientes.Add(cliente);

        }

        public void AlterarCliente(entity.Cliente cliente)
        {
            entity.Cliente mCliente = clientes.Find(x => x.Codigo == cliente.Codigo);
            mCliente.Nome = cliente.Nome;
        }

        public entity.Cliente GetCliente(int clienteId)
        {
            return clientes.FirstOrDefault(x => x.Codigo == clienteId);
        }
    }
}