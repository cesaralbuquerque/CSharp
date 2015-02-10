using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadernoDecoraFestas.Models
{
    public class CadastroDeFornecedoresContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}