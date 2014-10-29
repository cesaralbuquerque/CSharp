using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpWebApp.Models
{
    public interface IRepository <T> where T: entity.Pessoa
    {
        List<T> Dados { get; }
        void AddNovo(T entidade);
        void Alterar(T entidade);
        T Get(int id);
    }
}
