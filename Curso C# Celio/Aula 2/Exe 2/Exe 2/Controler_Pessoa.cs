using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exe_2
{
    public class Controler_Pessoa
    {
        static public List<Pessoa> lista = new List<Pessoa>();

        static public void addPessoa(ref Pessoa pessoa)
        {
            lista.Add(pessoa);
        }
    }
}