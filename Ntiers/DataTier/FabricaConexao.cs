using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class FabricaConexao
    {
        //String de conexão com o banco
        private String strCon =
            @"Data Source=(localdb)\Projects;Initial Catalog=PRODUTOS_DB;Integrated Security=True";
        //Objeto de conexão
        private static SqlConnection objConexao = null;
        //Construtor
        public FabricaConexao()
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strCon;
            objConexao.Open();
        }
        //Método estático que estabelece a conexao com o banco
        public static SqlConnection getConexao()
        {
            if (objConexao == null)
            {
                new FabricaConexao();
            }
            return objConexao;
        }
        //Método estático que fecha a conexao com o banco
        public static void fecharConexao()
        {
            objConexao.Close();
        }

    }
}
