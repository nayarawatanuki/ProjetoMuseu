using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Bll;

namespace WebMuseu.Pages
{
    public partial class ILogin : System.Web.UI.Page
    {
        LoginBll bll = new LoginBll();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length == 0 && txtSenha.Text.Length == 0)
            {
                return;
            }
            Model.Funcionario funcionario = bll.login(txtLogin.Text, txtSenha.Text);
            Response.Redirect("Funcionario");
        }
    }
}