using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Bll;

namespace WebMuseu
{
    public partial class Obras : System.Web.UI.Page
    {
        Model.Obra obra = new Model.Obra();
        ObraBll bll = new ObraBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            painelObras.Visible = false;
        }

        private void Clean()
        {
            lblObras.Text = "Acervo - Obras";
            txtObra.Text = "";
            txtAutor.Text = "";
            txtAquisicao.Text = "";
            txtLocal.Text = "";
            cbxStatus = null;
            cbxCondicoes = null;
            txtSeguro.Text = "";
            txtDescricao.Text = "";
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            lblObras.Text = "Cadastro de Obras";
            panelTable.Visible = false;
            painelObras.Visible = true;
        }

        protected void btnCadastrarObra_Click(object sender, EventArgs e)
        {
            obra.Titulo = txtObra.Text;
            obra.Autor = txtAutor.Text;
            obra.Aquisicao = Convert.ToDateTime(txtAquisicao.Text);
            obra.Local = txtLocal.Text;
            obra.Status = cbxStatus.Text;
            obra.Condicoes = cbxCondicoes.Text;
            obra.Valor = txtSeguro.Text;
            obra.Descricao = txtDescricao.Text;

            bll.Create(obra);
            Clean();

            painelObras.Visible = false;
            panelTable.Visible = true;
            GridObras.DataBind();

        }

        protected void btnCancelarObra_Click(object sender, EventArgs e)
        {
            Clean();
            painelObras.Visible = false;
            panelTable.Visible = true;
        }
    }
}