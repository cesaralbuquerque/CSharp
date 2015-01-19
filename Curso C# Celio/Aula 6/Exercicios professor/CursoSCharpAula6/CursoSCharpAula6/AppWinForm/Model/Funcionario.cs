using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinForm.Model
{
    public enum Cargo
    {
        DESENVOLVEDOR,
        DBA,
        TESTADOR
    }

    public class Funcionario
    {
        public String Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }
    }
}
