using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Funcionario
    {
        private int id;
        private string nome;
        private string login;
        private string senha;
        private int tipo;
        private string email;
        private string telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        public Funcionario(){}

        public Funcionario(string nome, string login, string senha, int tipo, string email, string telefone){
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.tipo = tipo;
            this.email = email;
            this.telefone = telefone;
        }
    }
}
