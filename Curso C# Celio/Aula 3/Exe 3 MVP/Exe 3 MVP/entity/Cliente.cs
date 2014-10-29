using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_3_MVP.entity
{
    public class Cliente : Pessoa
    {
        string sobrenome;

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
    }
}