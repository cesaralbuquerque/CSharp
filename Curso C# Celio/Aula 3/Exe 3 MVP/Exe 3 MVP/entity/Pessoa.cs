using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_3_MVP.entity
{
    public class Pessoa
    {
        int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        string endereço;

        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }
        string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}