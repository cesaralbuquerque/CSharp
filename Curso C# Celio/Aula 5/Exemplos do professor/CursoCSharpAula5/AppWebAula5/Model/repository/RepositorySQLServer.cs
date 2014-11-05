using AppWebAula5.Model.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAula5.Model.repository
{
    public class RepositorySQLServer<T>:IRepository<T> where T: IEntidade
    {
        public List<T> Listar
        {
            get { throw new NotImplementedException(); }
        }

        public void Adicionar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Alterar(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T entidade)
        {
            throw new NotImplementedException();
        }

        public T Buscar(int id)
        {
            throw new NotImplementedException();
        }
    }
}