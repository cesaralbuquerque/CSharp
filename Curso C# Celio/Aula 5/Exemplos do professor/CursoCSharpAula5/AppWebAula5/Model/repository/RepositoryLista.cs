using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppWebAula5.Model.entidades;

namespace AppWebAula5.Model.repository
{
    public class RepositoryLista<T> : IRepository<T> where T : IEntidade
    {
        List<T> dados = new List<T>();

        public void Alterar(T entidade)
        {
            T mEntidade = dados.Find(x => x.Codigo == entidade.Codigo);
            dados.Remove(mEntidade);
            dados.Add(entidade);
        }

        public List<T> Listar
        {
            get { return dados; }
        }

        public void Adicionar(T entidade)
        {
            entidade.Codigo = dados.Count + 1;
            dados.Add(entidade);
        }

        public void Excluir(T entidade)
        {
            T mEntidade = dados.Find(x => x.Codigo == entidade.Codigo);
            dados.Remove(mEntidade);
        }

        public T Buscar(int id)
        {
            return dados.FirstOrDefault(x => x.Codigo == id);
        }
    }
}