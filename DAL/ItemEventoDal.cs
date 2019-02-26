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
    public class ItemEventoDal
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

        public void Create(int idObra, int idEvento)
        {
            try
            {
                getProcedure("InserirItemEvento");

                cmd.Parameters.AddWithValue("pidobra", idObra);
                cmd.Parameters.AddWithValue("pidevento", idEvento);

                conn.Open();

                cmd.ExecuteScalar();
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

        public void Update(int id, int idObra, int idEvento)
        {
            try
            {
                getProcedure("UpdateItemEvento");

                //cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("pid", id);
                cmd.Parameters.AddWithValue("pidobra", idObra);
                cmd.Parameters.AddWithValue("pidevento", idEvento);
                //cmd.Parameters.AddWithValue("plocal", obra.Local);
                //cmd.Parameters.AddWithValue("pstatus", obra.Status);

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
                getProcedure("RemoveItemEvento");

                cmd.Parameters.AddWithValue("pcodigo", id);

                conn.Open();

                int resultado = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o item" + id);
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

        public ListObra List(int idEvento)
        {
            try
            {
                ListObra list = new ListObra();

                getProcedure("SelectItemEvento");
                cmd.Parameters.AddWithValue("pcodigo", idEvento);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Obra obra = new Obra();
                        obra.Id = int.Parse(dr["id"].ToString());
                        obra.Titulo = dr["titulo"].ToString();
                        obra.Autor = dr["autor"].ToString();
                        obra.Local = dr["local"].ToString();
                        obra.Status = dr["status"].ToString();
                        list.Add(obra);
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
