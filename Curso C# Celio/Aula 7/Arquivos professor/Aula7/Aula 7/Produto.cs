//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aula_7
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdGrupo { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public Nullable<decimal> Venda { get; set; }
        public Nullable<int> Saldo { get; set; }
    
        public virtual Grupo Grupo { get; set; }
    }
}