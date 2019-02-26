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
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridFuncionario.Columns[3].Visible = false;
        }

        FuncionarioBll bll = new FuncionarioBll();
        Model.Funcionario funcionario = new Model.Funcionario();

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            paneldgvFuncionario.Visible = false;
            painelFucionario.Visible = true;
            lblFuncionario.Text = "Cadastro de Funcionários";
        }

        protected void GridFuncionario_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridFuncionario.Columns[3].Visible = true;
        }

        private void Clean()
        {
            lblFuncionario.Text = "Acervo - Funcionário";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            rbCurador.Checked = false;
            rbFuncionario.Checked = false;
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Login = txtLogin.Text;
            if (rbCurador.Checked)
            {
                funcionario.Tipo = 1;
            } else
            {
                funcionario.Tipo = 2;
            }
            bll.Create(funcionario);

            GridFuncionario.DataBind();
            painelFucionario.Visible = false;
            paneldgvFuncionario.Visible = true;
            Clean();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            painelFucionario.Visible = false;
            paneldgvFuncionario.Visible = true;
            Clean();
        }
    }
}