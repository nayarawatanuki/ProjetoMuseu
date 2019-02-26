using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Model;

namespace DAL
{
    public class EventoDal
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void getProcedure(String name)
        {
            conn.ConnectionString = Setting.StrConnection;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = conn;
            cmd.CommandText = name;
        }

        public void Create(Evento evento)
        {
            try
            {
                getProcedure("InserirEventos");

                cmd.Parameters.AddWithValue("ptitulo", evento.Titulo);
                cmd.Parameters.AddWithValue("presponsavel", evento.Responsavel);
                cmd.Parameters.AddWithValue("pdatainicio", evento.DataInicio);
                cmd.Parameters.AddWithValue("pdatafim", evento.DataFim);

                conn.Open();

                evento.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Update(Evento evento)
        {
            try
            {
                getProcedure("UpdateEventos");

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("pid", evento.Id);
                cmd.Parameters.AddWithValue("ptitulo", evento.Titulo);
                cmd.Parameters.AddWithValue("presponsavel", evento.Responsavel);
                cmd.Parameters.AddWithValue("pdatainicio", evento.DataInicio);
                cmd.Parameters.AddWithValue("pdatafim", evento.DataFim);
                cmd.Parameters.AddWithValue("pobra", evento.Obra);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateObra(Obra obra)
        {
            try
            {
                getProcedure("UpdateObraEventos");

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("pid", obra.Id);
                cmd.Parameters.AddWithValue("plocal", obra.Local);
                cmd.Parameters.AddWithValue("pstatus", obra.Status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void Remove(int id)
        {
            try
            {
                getProcedure("RemoveEventos");

                cmd.Parameters.AddWithValue("pcodigo", id);

                conn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir evento" + id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public ListEvento List(string filtro)
        {
            try
            {
                ListEvento list = new ListEvento();

                getProcedure("SelectEventos");

                cmd.Parameters.AddWithValue("pfiltro", filtro);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Evento evento = new Evento();
                        evento.Id = int.Parse(dr["id"].ToString());
                        evento.Titulo = dr["titulo"].ToString();
                        evento.Responsavel = Convert.ToInt32(dr["responsavel"].ToString());
                        evento.ResponsavelNome = dr["responsavelNome"].ToString();
                        evento.DataInicio = Convert.ToDateTime(dr["dataInicio"].ToString());
                        evento.DataFim = Convert.ToDateTime(dr["dataFim"].ToString());
                        evento.Obra = dr["obra"].ToString();
                        list.Add(evento);
                    }
                }
                dr.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
