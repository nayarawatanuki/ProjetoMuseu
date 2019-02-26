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
    public class ObraDal
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

        public void Create(Obra obra)
        {
            try
            {
                getProcedure("InserirObras");

                cmd.Parameters.AddWithValue("ptitulo", obra.Titulo);
                cmd.Parameters.AddWithValue("pautor", obra.Autor);
                cmd.Parameters.AddWithValue("paquisicao", obra.Aquisicao);
                cmd.Parameters.AddWithValue("plocal", obra.Local);
                cmd.Parameters.AddWithValue("pstatus", obra.Status);
                cmd.Parameters.AddWithValue("pcondicoes", obra.Condicoes);
                cmd.Parameters.AddWithValue("pvalor", obra.Valor);
                cmd.Parameters.AddWithValue("pdescricao", obra.Descricao);

                conn.Open();

                obra.Id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Update(Obra obra)
        {
            try
            {
                getProcedure("UpdateObras");

                cmd.Parameters.AddWithValue("pid", obra.Id);
                cmd.Parameters.AddWithValue("ptitulo", obra.Titulo);
                cmd.Parameters.AddWithValue("pautor", obra.Autor);
                cmd.Parameters.AddWithValue("paquisicao", obra.Aquisicao);
                cmd.Parameters.AddWithValue("plocal", obra.Local);
                cmd.Parameters.AddWithValue("pstatus", obra.Status);
                cmd.Parameters.AddWithValue("pcondicoes", obra.Condicoes);
                cmd.Parameters.AddWithValue("pvalor", obra.Valor);
                cmd.Parameters.AddWithValue("pdescricao", obra.Descricao);

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
                getProcedure("RemoveObras");

                cmd.Parameters.AddWithValue("pcodigo", id);

                conn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a obra" + id);
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

        public ListObra List(string filtro)
        {
            try
            {
                ListObra list = new ListObra();

                getProcedure("SelectObras");

                cmd.Parameters.AddWithValue("pfiltro", filtro);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        Obra obra = new Obra();
                        obra.Id = int.Parse(dr["id"].ToString());
                        obra.Titulo = dr["titulo"].ToString();
                        obra.Autor = dr["autor"].ToString();
                        obra.Aquisicao = Convert.ToDateTime(dr["aquisicao"].ToString());
                        obra.Local = dr["local"].ToString();
                        obra.Status = dr["status"].ToString();
                        obra.Condicoes = dr["condicoes"].ToString();
                        obra.Valor = dr["valor"].ToString();
                        obra.Descricao = dr["descricao"].ToString();
                        list.Add(obra);
                    }
                }
                //dr.Close();
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
