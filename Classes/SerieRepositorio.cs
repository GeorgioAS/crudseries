using System;
using crudseries.Interfaces;
using System.Collections.Generic;

namespace crudseries
{
    public class SerieRepositorio: IRepositorio<Serie>
    {
        private List<Serie> listaserie = new List<Serie>();

        public void Atualiza(int id, Serie entidade)
        {
            listaserie[id] = entidade;
        }

        public void Exclui(int Id)
        {
            listaserie[Id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaserie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaserie;
        }

        public int ProximoID()
        {
            return listaserie.Count;
        }

        public Serie RetornaPorID(int id)
        {
            return listaserie[id];
        }
    }
}