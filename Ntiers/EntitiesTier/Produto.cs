using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesTier
{
    public class Produto
    {
        #region Propriedades automáticas
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public bool AtivoProduto { get; set; }
        #endregion
    }
}
