using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpWebApp.entity;

namespace MvpWebApp.Models
{
    public class Repository<T>: IRepository<T> where T : Pessoa
    {
        List<T> dados = new List<T>();

        public List<T> Dados
        {
            get { return dados; }
        }

        public void AddNovo(T entidade)
        {
            entidade.Codigo = dados.Count + 1;
            dados.Add(entidade);
        }

        public void Alterar(T entidade)
        {
            T mEntidade = dados.Find(x => x.Codigo == entidade.Codigo);
            dados.Remove(mEntidade);
            dados.Add(mEntidade);
        }

        public T Get(int id)
        {
            return dados.FirstOrDefault(x => x.Codigo == id);
        }
    }
}