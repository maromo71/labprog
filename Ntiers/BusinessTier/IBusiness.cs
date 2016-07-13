using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public interface IBusiness<T> where T:new()
    {
         T buscar(int id);

        void alterar(T obj);

        void inserir(T obj);

        void excluir(T obj);

        List<T> listar();
    }
}
