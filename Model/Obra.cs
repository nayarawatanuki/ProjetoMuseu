using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Obra
    {
        private int id;
        private string titulo;
        private string autor;
        private DateTime aquisicao;
        private string local;
        private string status;
        private string condicoes;
        private string valor;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime Aquisicao { get => aquisicao; set => aquisicao = value; }
        public string Local { get => local; set => local = value; }
        public string Status { get => status; set => status = value; }
        public string Condicoes { get => condicoes; set => condicoes = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Obra() {}

        public Obra(string titulo, string autor, DateTime aquisicao, string local, string status, string condicoes, string valor, string descricao) {
            this.titulo = titulo;
            this.autor = autor;
            this.aquisicao = aquisicao;
            this.local = local;
            this.status = status;
            this.condicoes = condicoes;
            this.valor = valor;
            this.descricao = descricao;
        }
    }
}
