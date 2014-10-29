using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpWebApp.Models
{
    public class Generica <T> : IGenerica<T> where T : entity.Pessoa
    {
        List<T> itens = new List<T>();

        public List<T> Itens{
            get {return itens;}
        }

        public void AddNovo(T item){
            
        }
        public void Alterar(T item){
        
        }
        public T GetItem(int id)
        {
                return itens.FirstOrDefault(x => x.Codigo == id);
        }


        //public entity.Pessoa GetItem(int id)
        //{
        //    List<entity.Pessoa> itens2 = Itens as List<entity.Pessoa>;
        //    return itens2.FirstOrDefault(x => x.Codigo == id);
        //} 

    }
}