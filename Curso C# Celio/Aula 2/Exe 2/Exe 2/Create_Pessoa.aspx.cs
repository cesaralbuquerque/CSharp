using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exe_2
{
    public partial class Cadastro_Pessoa : System.Web.UI.Page
    {
       
        

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = TextBox1.Text;
            pessoa.Endereco = TextBox2.Text;
            pessoa.Telefone = TextBox3.Text;
            pessoa.Idade = TextBox4.Text;
            pessoa.Salario = TextBox5.Text;
            pessoa.Desconto = TextBox6.Text;
            Controler_Pessoa.addPessoa(ref pessoa);
            this.Response.Redirect("List_Pessoa.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            foreach(System.Web.UI.Control web in this.form1.Controls){
                if(web is TextBox){
                    ((TextBox)web).Text = "";
                }
            }
        }
    }

}