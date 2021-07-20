using System.Collections.Generic;

namespace crudseries.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorID(int id);
         void Insere(T entidade);
         void Exclui(int Id);
         void Atualiza(int id, T entidade);
         int ProximoID();

    }
}