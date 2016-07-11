using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class exemploCookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Passo 0 - Recuperando o nome de uma Sessão
        if (Page.Session["nome"] != null)
        {
            lblSessao.Text = "Bem vindo " + Session["nome"].ToString();
        }
        else
        {
            lblSessao.Text = "Sessão não iniciada";
        }
        // 1 - Verifica-se se o navegador aceita cookie
        if (Request.Browser.Cookies)
        {
            // 2 - Verifica-se se o cookie não foi criado anteriormente. Se for nulo
            // vai para o passo 3
            if (Request.Cookies["ultimaVisita"] == null)
            {
                // 3 - Criando o cookie                 
                HttpCookie cookie = new HttpCookie("ultimaVisita", DateTime.Now.ToString());

                // 4 - Informe em quanto tempo este cookie expira (20 dias)  
                cookie.Expires = DateTime.Now.AddDays(20);

                // 5 - Adicionando o cookie no navegador 
                Response.Cookies.Add(cookie);
                lblMsg.Text = "Seja bem vindo a sua primeira visita em nosso site";
            }
            else
            {
                // 6 - Se o cookie já existe recupera-se a informação em um label 
                HttpCookie cookie = Request.Cookies["ultimaVisita"];
                lblMsg.Text = "Olá, sua última visita foi em, " + cookie.Value;

                //  7 - Envia-se um novo cookie para o navegador para uma próxima visita
                Response.Cookies["ultimaVisita"].Value = DateTime.Now.ToString();
                Response.Cookies["ultimaVisita"].Expires = DateTime.Now.AddDays(20);
            }
        }
        else
        {
            // 8 - Se o navegador não aceita cookie exibo uma mensagem 
            lblMsg.Text = "Seu navegador não aceita cookies";
        }

    }
}