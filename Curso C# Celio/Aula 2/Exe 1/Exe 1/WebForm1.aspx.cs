using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exe_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Valores valores = new Valores();
            float a = float.Parse(TextBox1.Text);
            float b = float.Parse(TextBox2.Text);
            float c = Valores.calcula(a, b, this.DropDownList1.SelectedValue);

            Label2.Text = c.ToString();
        }

       
    }

   public class Valores{
        //o fato deste metodo ser static não há necessidade de instanciar um objeto
        public static float calcula(float a, float b, string operacao){
            switch (operacao){
                case "Soma":
                    return a + b;
                case "Subtração":
                    return a - b;
                case "Divisão":
                    return a / b;
                case "Multiplicação":
                    return a * b;
            }
            return 1;
        }
    
    }

}