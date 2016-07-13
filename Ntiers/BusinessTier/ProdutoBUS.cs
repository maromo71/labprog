using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using EntitiesTier;

namespace BusinessTier
{
    public class ProdutoBUS : IBusiness<Produto>
    {
        
        public Produto buscar(int id)
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                if (validaIdProduto(id))
                {
                    return dao.buscar(id);
                }
                else
                {
                    throw new ArgumentException("Campo não ser menor ou igual a zero");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void alterar(Produto obj)
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                if (validaIdProduto(obj.IdProduto))
                {
                    dao.alterar(obj);
                }
                else
                {
                    throw new ArgumentException("Campo não ser menor ou igual a zero");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void inserir(Produto obj)
        {
            try
            {
                ProdutoDAO dao = new ProdutoDAO();

                if (validaIdProduto(obj.IdProduto))
                {
                    dao.inserir(obj);
                }
                else
                {
                    throw new ArgumentException("Campo não ser menor ou igual a zero");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void excluir(Produto obj)
        {
            ProdutoDAO dao = new ProdutoDAO();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Produto> listar()
        {
            ProdutoDAO dao = new ProdutoDAO();
            try
            {
                return dao.listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validaIdProduto(int idProduto)
        {
            //Regra de validação. Supondo que tenhamos uma regra
            //onde o código deve ser um número positivo
            if (idProduto < 0)
            {
                return false;
            }
            return true;
        }
    }
}
