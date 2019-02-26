using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Evento
    {
        private int id;
        private string titulo;
        private int responsavel;
        private string responsavelNome;
        private DateTime dataInicio;
        private DateTime dataFim;
        private string obra;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Responsavel { get => responsavel; set => responsavel = value; }
        public string ResponsavelNome { get => responsavelNome; set => responsavelNome = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }
        public string Obra { get => obra; set => obra = value; }

        public Evento(){}

        public Evento(string titulo, int responsavel, DateTime dataInicio, DateTime dataFim) {
            this.titulo = titulo;
            this.responsavel = responsavel;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
        }
    }
}
