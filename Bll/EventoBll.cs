using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Bll
{
    public class EventoBll
    {
        EventoDal dal;

        public EventoBll()
        {
            dal = new EventoDal();
        }

        public void Create(Evento evento)
        {
            try
            {
                if (evento.Titulo.Trim().Length == 0)
                {
                    throw new Exception("Titulo do Evento é obrigatorio");
                }

                else if (evento.DataInicio == DateTime.Now || evento.DataInicio == DateTime.Today)
                {
                    throw new Exception("Não é Possivel marcar um evento para o mesmo Dia," +
                        "Por favor Agende seu evento com antecendencia de pelo menos 1 dia");
                }
                else
                {
                    dal.Create(evento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Evento evento)
        {
            try
            {
                if (evento.Titulo.Length == 0)
                {
                    throw new Exception("Titulo do Evento é obrigatorio");
                }

                else if (evento.DataInicio == DateTime.Now || evento.DataInicio == DateTime.Today)
                {
                    throw new Exception("Não é Possivel marcar um evento para o mesmo Dia," +
                        "Por favor Agende seu evento com antecendencia de pelo menos 1 dia");
                }
                else
                {
                    dal.Update(evento);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateObra(Obra obra)
        {
            dal.UpdateObra(obra);
        }

        public void Delete(Evento evento)
        {
            try
            {
                if (evento.Id <= 0)
                    throw new Exception("Evento não selecionado");

                dal.Remove(evento.Id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListEvento Listar(string filtro)
        {
            return dal.List(filtro);
        }
    }
}
