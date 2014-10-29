using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConnectionBDWell.Models.AbstractFactory;

namespace Abstract_Factory
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBFactory factory = new SQLFactory();
            DBConnection conn = factory.CreateConnection();
            DBCommand command = factory.CreateCommand();

            conn.Open();
            command.Execute();
        }
    }
}