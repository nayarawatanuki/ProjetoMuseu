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
    public class LoginDal
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

        public Funcionario login(string login, string senha)
        {
            try
            {
                getProcedure("Login");

                cmd.Parameters.AddWithValue("funlogin", login);
                cmd.Parameters.AddWithValue("funsenha", senha);
                conn.Open();

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();

                Funcionario funcionario = new Funcionario();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        funcionario.Id = int.Parse(dr["id"].ToString());
                        funcionario.Nome = dr["nome"].ToString();
                        funcionario.Login = dr["login"].ToString();
                        funcionario.Senha = dr["senha"].ToString();
                        funcionario.Tipo = Convert.ToInt32(dr["tipo"].ToString());
                        funcionario.Email = dr["email"].ToString();
                        funcionario.Telefone = dr["telefone"].ToString();
                    }
                }
                dr.Close();
                return funcionario;
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
