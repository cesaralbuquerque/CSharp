using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_3_MVP.entity
{
    public class Fornecedor : Pessoa
    {
        enum tiposPessoa {Fisica, Juridica };
        Fornecedor.tiposPessoa tipoPessoa;

        private Fornecedor.tiposPessoa TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = value; }
        }

    }
}