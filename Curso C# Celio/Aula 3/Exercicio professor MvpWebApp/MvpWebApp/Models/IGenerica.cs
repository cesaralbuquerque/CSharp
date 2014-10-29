using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvpWebApp.Models
{
    public class IGenerica<T>
    {
        List<T> itens { get; }
        void AddNovo(T item);
        void Alterar(T item);
        T GetItem(int id);
    }
}