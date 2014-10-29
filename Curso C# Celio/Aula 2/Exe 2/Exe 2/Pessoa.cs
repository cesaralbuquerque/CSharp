using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_2
{
    public class Pessoa
    {
        String nome, endereco, telefone, idade, salario, desconto;

        public String Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public String Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public String Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
    }
}