using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWebAula5.Model.entidades;

namespace AppWebAula5.Model.repository
{
    public interface IRepository <T> where T: IEntidade
    {
        List<T> Listar { get; }
        void Adicionar(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T Buscar(int id);
    }
}
