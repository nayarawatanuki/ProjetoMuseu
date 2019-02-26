using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Bll
{
    public class FuncionarioBll
    {
        FuncionarioDal dal;

        public FuncionarioBll()
        {
            dal = new FuncionarioDal();
        }

        public void Create(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Nome.Trim().Length == 0)
                {
                    throw new Exception("Nome do Funcionario Obrigatório");
                }
                else if (funcionario.Nome.Trim().Length > 50)
                {
                    throw new Exception("O limite de caracteres foi excedido");
                }
                else if (funcionario.Login.Trim().Length == 0)
                {
                    throw new Exception("Login é obrigatorio");
                }
                else if (funcionario.Senha.Trim().Length == 0)
                {
                    throw new Exception("Senha é obrigatória");
                }
                else if (funcionario.Telefone.Trim().Length == 0)
                {
                    throw new Exception("Telefone é obrigatório");
                }
                else if (funcionario.Email.Trim().Length == 0)
                {
                    throw new Exception("Email é obrigatório");
                }
                else
                {
                    dal.Create(funcionario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Nome.Trim().Length == 0)
                {
                    throw new Exception("Nome do Funcionario Obrigatório");
                }
                else if (funcionario.Nome.Trim().Length > 50)
                {
                    throw new Exception("O limite de caracteres foi excedido");
                }
                else if (funcionario.Login.Trim().Length == 0)
                {
                    throw new Exception("Login é obrigatorio");
                }
                else if (funcionario.Senha.Trim().Length == 0)
                {
                    throw new Exception("Senha é obrigatória");
                }
                else if (funcionario.Telefone.Trim().Length == 0)
                {
                    throw new Exception("Telefone é obrigatório");
                }
                else if (funcionario.Email.Trim().Length == 0)
                {
                    throw new Exception("Email é obrigatório");
                }
                else
                {
                    dal.Update(funcionario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public void Delete(int codigo)
        {
            try
            {
                if (codigo <= 0)
                    throw new Exception("Funcionario não selecionado");

                dal.Remove(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/

        public void Delete(Funcionario funcionario)
        {
            try
            {
                if (funcionario.Id <= 0)
                    throw new Exception("Funcionario não selecionado");

                dal.Remove(funcionario.Id);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ListFuncionario Listar(string filtro)
        {
            return dal.List(filtro);
        }
}
        
           
    
}
