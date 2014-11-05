using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAula5.Model.helpers
{
    public class CUDEventArgs<T> : EventArgs where T : entidades.IEntidade
    {
        public T Entidade { get; set; }

        public CUDEventArgs(T entidade)
        {
            this.Entidade = entidade;
        }
    }

    public class BuscarEventArgs<T> : EventArgs where T : entidades.IEntidade
    {
        public int Codigo { get; set; }
        public T Entidade { get; set; }
        public BuscarEventArgs(int codigo)
        {
            this.Codigo = codigo;
        }

    }

}