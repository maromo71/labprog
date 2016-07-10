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

    }
    protected void btnCalcular_Click(object sender, EventArgs e)
    {
        Pessoa p = new Pessoa();
        try
        {
            p.Nome = txtNome.Text;
            p.DataNasc = calDataNasc.SelectedDate;
            int idade = p.CalcularIdade();
            lblIdade.Text = idade.ToString();
        }
        catch (Exception erro)
        {
            lblIdade.Text = "Aconteceu o erro: " + erro.Message.ToString();
        }
        
    }
}