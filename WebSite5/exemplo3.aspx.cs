using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exemplo3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBusca_Click(object sender, EventArgs e)
    {
        pnlBusca.Visible = false;
        pnlResult.Visible = true;
    }
    protected void btnNova_Click(object sender, EventArgs e)
    {
        pnlBusca.Visible = true;
        pnlResult.Visible = false;
    }
}