using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_3_MVP.Model
{
    public class ClienteRepository : IClienteRepository
    {
        List<entity.Cliente> clientes = new List<entity.Cliente>();

        //public List<entity.Cliente> Clientes
        //{
        //    get { return clientes; }
        //}
        //public void addNovoCliente(entity.Cliente cliente)
        //{
        //    cliente.Codigo = clientes.Count + 1;
        //    clientes.Add(cliente);
        //}
        
        //public void alterarCliente(entity.Cliente cliente)
        //{
        //    entity.Cliente mCliente = clientes.Find(cliente.Codigo);
        //}

        //public entity.Cliente GetCliente(int clienteId)
        //{ 
        //}


        List<ClienteRepository> IClienteRepository.Clientes
        {
            get { throw new NotImplementedException(); }
        }

        public void addNovoCliente(ClienteRepository cliente)
        {
            cliente.Codigo = clientes.Count + 1;
            clientes.Add(cliente);
        }

        public void alterarCliente(ClienteRepository cliente)
        {
            entity.Cliente mCliente = clientes.Find(cliente.Codigo);
        }

        public ClienteRepository getCliente(int clienteId)
        {
            return clientes.FirstOrDefault(x => x.Codigo == clienteId);
        }
    }
}