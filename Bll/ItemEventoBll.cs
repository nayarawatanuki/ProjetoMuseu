using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Bll
{
    public class ItemEventoBll
    {
        ItemEventoDal dal;

        public ItemEventoBll()
        {
            dal = new ItemEventoDal();
        }

        public void Create(int idObra, int idEvento)
        {
            try
            {
                dal.Create(idObra, idEvento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id, int idObra, int idEvento)
        {
            dal.Update(id, idObra, idEvento);
        }

        public void Delete(int codigo)
        {
            try
            {
                if (codigo <= 0)
                    throw new Exception("Item não selecionado");

                dal.Remove(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListObra Listar(int idEvento)
        {
            return dal.List(idEvento);
        }
    }
}
