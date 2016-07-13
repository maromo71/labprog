using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessTier;
using EntitiesTier;

namespace PresentationTier.Produtos
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Produto> lista = null;
            ProdutoBUS bus = new ProdutoBUS();
            lista = bus.listar();
            GridView1.DataSource = lista;
            GridView1.DataBind();
        }
    }
}