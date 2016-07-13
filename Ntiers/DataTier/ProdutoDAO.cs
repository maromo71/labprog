using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesTier;

namespace DataTier
{
    public class ProdutoDAO : IDataAccessObject<Produto>
    {

        public void alterar(Produto obj)
        {
            SqlConnection objConexao = FabricaConexao.getConexao();
            SqlParameter[] param = new SqlParameter[4]
            {
                new SqlParameter("@idProduto", SqlDbType.Int),
                new SqlParameter("@nomeProduto", SqlDbType.NVarChar),
                new SqlParameter("@valorProduto", SqlDbType.Float),
                new SqlParameter("@ativoProduto", SqlDbType.Bit)
            };
            param[0].Value = obj.IdProduto;
            param[1].Value = obj.NomeProduto;
            param[2].Value = obj.ValorProduto;
            param[3].Value = obj.AtivoProduto;
            string strQuery = "Update Produto set nomeProduto="
                + "@nomeProduto, valorProduto=@valorProduto, "
            + " ativoProduto=@ativoProduto where idProduto=@idProduto";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public Produto buscar(int id)
        {
            SqlConnection objConexao = FabricaConexao.getConexao();
            SqlParameter param = new SqlParameter("idProduto", id);
            string strQuery = "SELECT * FROM Produto WHERE idProduto=@idProduto";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Produto objProduto = null;
                if (objReader.Read())
                {
                    objProduto = new Produto();
                    objProduto.IdProduto = Convert.ToInt16(objReader["idProduto"]);
                    objProduto.NomeProduto = Convert.ToString(objReader["nomeProduto"]);
                    objProduto.ValorProduto = Convert.ToDouble(objReader["valorProduto"]);
                    objProduto.AtivoProduto = Convert.ToBoolean(objReader["ativoProduto"]);
                }
                objReader.Close();
                return objProduto;
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public void excluir(Produto obj)
        {
            SqlConnection objConexao = FabricaConexao.getConexao();
            SqlParameter param = new SqlParameter("@idProduto", obj.IdProduto);
            string strQuery = "Delete from Produto where idProduto=@idProduto";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public void inserir(Produto obj)
        {
            SqlConnection objConexao = FabricaConexao.getConexao();
            SqlParameter[] param = new SqlParameter[4]
            {
                new SqlParameter("@idProduto", SqlDbType.Int),
                new SqlParameter("@nomeProduto", SqlDbType.NVarChar),
                new SqlParameter("@valorProduto", SqlDbType.Float),
                new SqlParameter("@ativoProduto", SqlDbType.Bit)
            };
            param[0].Value = obj.IdProduto;
            param[1].Value = obj.NomeProduto;
            param[2].Value = obj.ValorProduto;
            param[3].Value = obj.AtivoProduto;
            string strQuery = "Insert into Produto(idProduto," +
                " nomeProduto, valorProduto, ativoProduto)" +
                " values(@idProduto, @nomeProduto, @valorProduto, @ativoProduto)";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public List<Produto> listar()
        {
            List<Produto> produtos = new List<Produto>();
            SqlConnection objConexao = FabricaConexao.getConexao();
            string strQuery = "SELECT * FROM Produto";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {

                    Produto objProduto = new Produto();
                    objProduto.IdProduto = Convert.ToInt16(objReader["idProduto"]);
                    objProduto.NomeProduto = Convert.ToString(objReader["nomeProduto"]);
                    objProduto.ValorProduto = Convert.ToDouble(objReader["valorProduto"]);
                    objProduto.AtivoProduto = Convert.ToBoolean(objReader["ativoProduto"]);
                    produtos.Add(objProduto);
                }
                objReader.Close();
                return produtos;
            }
            catch (Exception err)
            {
                throw err;
            }
        }


        
    }
}
