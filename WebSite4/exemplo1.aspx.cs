using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class exemplo1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string nome;
        nome = "Fulano de Tal";
        Label1.Text = nome.ToUpper().ToString();
    }
}

