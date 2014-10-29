using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exe_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public void passandoPorParametro(ref Pessoa pessoa)
        {
            pessoa.Nome += "sobrenome";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pessoa a = new Pessoa();
            WebForm1 b = new WebForm1();
            a.Nome = "cesar";
            b.passandoPorParametro(ref a);
            Label1.Text = a.Nome;
            Fisica f = new Fisica();
            f.Nome = "cesar";
            f.Sexo = Fisica.Sexos.masculino;



        }
    }

    public interface IPessoa
    {
        string Nome { get; set;}
    }

    public class Pessoa
    {
        string nome;
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
    }

    public class Fisica : Pessoa
    {
        public enum Sexos { masculino, feminino };
        Fisica.Sexos sexo;

        public Fisica.Sexos Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        string cpf;
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
    public class Juridica : Pessoa
    {
        string cnpj;
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }

}