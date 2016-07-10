using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exemplo2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Definindo uma nova string para o DropDownList1
            DropDownList1.Items.Add("Abóbora");
            //Adicionando o text e o value
            DropDownList1.Items.Add(new ListItem("Ameixa", "Ameixa"));
            ListBox1.Items.Add(new ListItem("Real", "01"));
            ListBox1.Items.Add(new ListItem("Dólar", "02"));
            ListBox1.Items.Add(new ListItem("Libra", "03"));
        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblFruta.Text = DropDownList1.SelectedValue;
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)
        {
            lblFrutaFresca.Visible = true;
            lblFrutaFresca.Text = "Entregar logo para o cliente";
        }
        else
        {
            lblFrutaFresca.Visible = false;
            lblFrutaFresca.Text = "";
        }
    }
    protected void btnSelecionar_Click(object sender, EventArgs e)
    {
        lblMoeda.Text = "<h4>Moeda(s) Selecionada(s)</h4>";

        foreach (ListItem item in ListBox1.Items)
        {
            if (item.Selected)
            {
                lblMoeda.Text += "Código: " + item.Value + " - Moeda: " + item.Value;
                lblMoeda.Text += "<br />";
            }
        }
        lblMoeda.Text += "<hr />";
    }
}