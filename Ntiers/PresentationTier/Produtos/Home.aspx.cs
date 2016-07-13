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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void limpar()
        {
            txtDescProduto.Text = "";
            txtValorProduto.Text = "";
            chkAtivo.Checked = false;
        }

        protected void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                ProdutoBUS bus = new ProdutoBUS();
                produto = bus.buscar(int.Parse(txtIdProduto.Text));
                if (produto != null)
                {
                    txtDescProduto.Text = produto.NomeProduto;
                    txtValorProduto.Text = produto.ValorProduto.ToString();
                    if (produto.AtivoProduto == true)
                        chkAtivo.Checked = true;
                    else
                        chkAtivo.Checked = false;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;

                }
                else
                {
                    limpar();
                    btnSalvar.Enabled = true;
                    btnAlterar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message.ToString();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                ProdutoBUS bus = new ProdutoBUS();
                produto.IdProduto = int.Parse(txtIdProduto.Text);
                produto.ValorProduto = double.Parse(txtValorProduto.Text);
                produto.NomeProduto = txtDescProduto.Text;
                if (chkAtivo.Checked)
                    produto.AtivoProduto = true;
                else
                    produto.AtivoProduto = false;
                //23 de outubro.
                bus.inserir(produto);
                lblMensagem.Text = "Registro Salvo com Sucesso";
                limpar();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.ToString();
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                ProdutoBUS bus = new ProdutoBUS();
                produto.IdProduto = int.Parse(txtIdProduto.Text);
                produto.ValorProduto = double.Parse(txtValorProduto.Text);
                produto.NomeProduto = txtDescProduto.Text;
                if (chkAtivo.Checked)
                    produto.AtivoProduto = true;
                else
                    produto.AtivoProduto = false;
                //23 de outubro.
                bus.alterar(produto);
                lblMensagem.Text = "Registro Alterado com Sucesso";
                limpar();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.ToString();
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                ProdutoBUS bus = new ProdutoBUS();
                produto.IdProduto = int.Parse(txtIdProduto.Text);
                bus.excluir(produto);
                lblMensagem.Text = "Registro Excluído com Sucesso";
                limpar();
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro: " + ex.ToString();
            }
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Produtos/Listar.aspx");
        }
    }
}