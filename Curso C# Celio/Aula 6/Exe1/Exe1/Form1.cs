using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



    }

    public class Empresa
    {
        private List<Funcionario> Funcionarios;

        public List<Funcionario> Funcionarios1
        {
            get { return Funcionarios; }
            set { Funcionarios = value; }
        }

        public Empresa()
        { 
            Funcionarios = new List<Funcionario>();
        }

        public void adicionaFuncionario(Funcionario func)
        {
            Funcionarios.Add(func);
        }
    }



    public class CalculadoraDeSalario
    {
        public double calculaSalario(Funcionario funcionario)
        {
            if(funcionario.Cargo1 == Funcionario.Cargo.DESENVOLVEDOR && funcionario.Salario >=3000.00)
            {
                return funcionario.Salario * 0.9;
            }
            else if ((funcionario.Cargo1 == Funcionario.Cargo.DBA || funcionario.Cargo1 == Funcionario.Cargo.TESTADOR) && funcionario.Salario>=2500.00)
            {
                return funcionario.Salario * 0.85;
            }
            return funcionario.Salario;
        }
    }


    public class Funcionario
    {
        public Funcionario(string pnome, double psalario, Cargo pcargo)
        {
            this.nome = pnome;
            this.salario = psalario;
            this.cargo = pcargo;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double salario;

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        private Cargo cargo;

        public Cargo Cargo1
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public enum Cargo
        {
            DESENVOLVEDOR, DBA, TESTADOR
        };
    }


}
