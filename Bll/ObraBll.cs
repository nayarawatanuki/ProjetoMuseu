using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Bll
{
    public class ObraBll
    {
        ObraDal dal;

        public ObraBll()
        {
            dal = new ObraDal();
        }

        public void Create(Obra obra)
        {

            try
            {
                if(obra.Titulo.Length == 0)
                {
                    throw new Exception("Nome da obra obrigatório.");
                }
                else if (obra.Autor.Length == 0)
                {
                    throw new Exception("Autor obrigatório");
                }
                else if(obra.Valor.Length == 0)
                {
                    throw new Exception("Por favor, insira um valor.");
                }
                else if(obra.Local.Length == 0)
                {
                    throw new Exception("Por favor, insira um local.");
                }
                else if(obra.Condicoes.Length == 0)
                {
                    throw new Exception("Por favor, insira um tipo de condição");
                }
                else if(obra.Descricao.Length == 0)
                {
                    throw new Exception("Por favor, insira dimensões ou caracteristicas.");
                }
                else
                {
                    dal.Create(obra);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Obra obra)
        {
            try
            {
                if (obra.Titulo.Trim().Length == 0)
                {
                    throw new Exception("Nome da obra obrigatório.");
                }
                else if (obra.Autor.Trim().Length == 0)
                {
                    throw new Exception("Autor obrigatório");
                }
                else if (obra.Valor.Length == 0)
                {
                    throw new Exception("Por favor, insira um valor.");
                }
                else if (obra.Local.Length == 0)
                {
                    throw new Exception("Por favor, insira um local.");
                }
                else if (obra.Condicoes.Length == 0)
                {
                    throw new Exception("Por favor, insira um tipo de condição");
                }
                else if (obra.Descricao.Length == 0)
                {
                    throw new Exception("Por favor, insira dimensões ou caracteristicas.");
                }
                else
                {
                    dal.Update(obra);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(Obra obra)
        {
            try
            {
                if (obra.Id <= 0)
                    throw new Exception("Obra não selecionada");

                dal.Remove(obra.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListObra Listar(string filtro)
        {
            return dal.List(filtro);
        }
    }
}
