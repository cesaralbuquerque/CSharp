using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string label = Label1.Text;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = Label1.Text;
        }
        
        //CPF 067.190.219-90
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string cpf = TextBox1.Text;
            cpf = String.Format("{0}.{1}.{2}-{3}", cpf.Substring(0, 3), cpf.Substring(3, 3), cpf.Substring(6, 3), cpf.Substring(9, 2));

            TextBox1.Text = cpf;
        }







    }
}