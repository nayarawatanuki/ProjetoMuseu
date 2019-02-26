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
    public class FuncionarioDal
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

        public void Create(Funcionario funcionario)
        {
            try
            {
                getProcedure("InserirFuncionario");

                cmd.Parameters.AddWithValue("pnome", funcionario.Nome);
                cmd.Parameters.AddWithValue("plogin", funcionario.Login);
                cmd.Parameters.AddWithValue("psenha", funcionario.Senha);
                cmd.Parameters.AddWithValue("ptipo", funcionario.Tipo);
                cmd.Parameters.AddWithValue("pemail", funcionario.Email);
                cmd.Parameters.AddWithValue("ptelefone", funcionario.Telefone);

                conn.Open();

                funcionario.Id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void Update(Funcionario funcionario)
        {
            try
            {
                getProcedure("UpdateFuncionario");

                cmd.Parameters.AddWithValue("pid", funcionario.Id);
                cmd.Parameters.AddWithValue("pnome", funcionario.Nome);
                cmd.Parameters.AddWithValue("plogin", funcionario.Login);
                cmd.Parameters.AddWithValue("psenha", funcionario.Senha);
                cmd.Parameters.AddWithValue("ptipo", funcionario.Tipo);
                cmd.Parameters.AddWithValue("pemail", funcionario.Email);
                cmd.Parameters.AddWithValue("ptelefone", funcionario.Telefone);

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
                getProcedure("RemoveFuncionario");

                cmd.Parameters.AddWithValue("pcodigo", id);

                conn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir funcionário" + id);
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

        public ListFuncionario List(string filtro)
        {
            try
            {
                ListFuncionario list = new ListFuncionario();

                getProcedure("SelectFuncionario");

                cmd.Parameters.AddWithValue("pfiltro", filtro);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Funcionario funcionario = new Funcionario();
                        funcionario.Id = int.Parse(dr["id"].ToString());
                        funcionario.Nome = dr["nome"].ToString();
                        funcionario.Login = dr["login"].ToString();
                        funcionario.Senha = dr["senha"].ToString();
                        funcionario.Tipo = Convert.ToInt32(dr["tipo"].ToString());
                        funcionario.Email = dr["email"].ToString();
                        funcionario.Telefone = dr["telefone"].ToString();
                        list.Add(funcionario);
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
