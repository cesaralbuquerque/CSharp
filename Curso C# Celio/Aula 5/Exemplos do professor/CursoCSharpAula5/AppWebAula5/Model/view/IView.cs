using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWebAula5.Model.helpers;

namespace AppWebAula5.Model.view
{
    public interface IView<T> where T: entidades.IEntidade
    {
        List<T> Lista { get; set; }
        event EventHandler Carregar;
        event EventHandler<CUDEventArgs<T>> Adicionar;
        event EventHandler<CUDEventArgs<T>> Alterar;
        event EventHandler<CUDEventArgs<T>> Excluir;
        event EventHandler<BuscarEventArgs<T>> Buscar;
    }
}
