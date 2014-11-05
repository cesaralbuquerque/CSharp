using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebAula5.Model.entidades
{
    public class ePessoa : IEntidade
    {

        public int Codigo { get; set; }

        public string CPF_CNPJ { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}