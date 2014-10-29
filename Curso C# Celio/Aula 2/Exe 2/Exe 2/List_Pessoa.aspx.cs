using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exe_2
{
    public partial class List_Pessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableRow cabecalho = new TableRow();
            TableHeaderCell a = new TableHeaderCell();
            TableHeaderCell b = new TableHeaderCell();
            TableHeaderCell c = new TableHeaderCell();
            TableHeaderCell d = new TableHeaderCell();
            TableHeaderCell ee = new TableHeaderCell();
            TableHeaderCell f = new TableHeaderCell();
            a.Text=("Nome");
            cabecalho.Cells.Add(a);
            b.Text = ("Endereço");
            cabecalho.Cells.Add(b);
            c.Text = ("Fone");
            cabecalho.Cells.Add(c);
            d.Text = ("Salário bruto");
            cabecalho.Cells.Add(d);
            ee.Text = ("Desconto");
            cabecalho.Cells.Add(ee);
            f.Text = ("Salário Liquido");
            cabecalho.Cells.Add(f);
            Table1.Rows.Add(cabecalho);

            foreach (Pessoa pessoa in Controler_Pessoa.lista) // Loop through List with foreach
            {

                TableRow r = new TableRow();    
                TableCell nome = new TableCell();
                nome.Controls.Add(new LiteralControl(pessoa.Nome.ToString()));
                r.Cells.Add(nome);

                TableCell endereco = new TableCell();
                endereco.Controls.Add(new LiteralControl(pessoa.Endereco.ToString()));
                r.Cells.Add(endereco);

                TableCell telefone = new TableCell();
                telefone.Controls.Add(new LiteralControl(pessoa.Telefone.ToString()));
                r.Cells.Add(telefone);

                TableCell idade = new TableCell();
                idade.Controls.Add(new LiteralControl(pessoa.Idade.ToString()));
                r.Cells.Add(idade);

                TableCell salario = new TableCell();
                salario.Controls.Add(new LiteralControl(pessoa.Salario.ToString()));
                r.Cells.Add(salario);

                TableCell desconto = new TableCell();
                desconto.Controls.Add(new LiteralControl(pessoa.Desconto.ToString()));
                r.Cells.Add(desconto);

                TableCell salarioLiquido = new TableCell();
                double liquido = (double.Parse(pessoa.Salario)) - (double.Parse(pessoa.Desconto));
                salarioLiquido.Controls.Add(new LiteralControl(liquido.ToString()));
                r.Cells.Add(salarioLiquido);

                Table1.Rows.Add(r);
                
  //<tr>
  //  <td>Nome</td>
  //  <td>Endereço</td> 
  //  <td>Telefone</td>
  //  <td>Idade</td> 
  //  <td>Salário bruto</td>
  //  <td>Desconto</td> 
  //  <td>Salário Liquido</td> 
  //</tr>
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Create_Pessoa.aspx");
        }
    }
}