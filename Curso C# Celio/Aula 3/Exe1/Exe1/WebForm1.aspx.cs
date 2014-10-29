using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exe1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void testeFinally(){
            string text1 = TextBox1.Text;
            try
            {
                int a = Convert.ToInt32(text1);
                Label2.Text = a.ToString();
            }
            catch (FormatException e)
            {
                System.Text.StringBuilder mSB = new System.Text.StringBuilder();
                mSB.Append("A entrada de texto não é uma sequencia de dígitos.\n\n erro:");
                mSB.Append(e.ToString());
                Label2.Text = mSB.ToString();
            }
            finally
            {
                Label3.Text = "Obrigado por usar nosso sistema";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            testeFinally();
            Referencia.Util.Class1 a = new Referencia.Util.Class1();
            a.endereco = "aaa";

        }
    }
}