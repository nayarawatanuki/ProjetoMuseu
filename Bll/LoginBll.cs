using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Bll
{
    public class LoginBll
    {
        LoginDal dal;

        public LoginBll()
        {
            dal = new LoginDal();
        }

        public Funcionario login(string login, string senha)
        {
            try
            {
                if (login.Trim().Length == 0)
                {
                    throw new Exception("Login do Funcionario é Obrigatório");
                }
                else if (senha.Trim().Length > 50)
                {
                    throw new Exception("Senha do Funcionário é Obrigatório");
                }
                else
                {
                    Funcionario funcionario = new Funcionario();
                    return funcionario = dal.login(login, senha);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
