using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Model;
using System.Drawing.Drawing2D;

namespace museu
{
    public partial class FormFuncionario : Form
    {
        FuncionarioBll bll = new FuncionarioBll();

        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            //filtro vazio
            dgvCadastros.DataSource = bll.Listar("");
            dgvCadastros.Columns[3].Visible = false;
            gpxCadastroFuncionarios.Visible = false;
            Height = 320;
            lblMsgErro.Visible = false;
        }



        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 9999);
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(RandomNumber(1, 200000));
            UpdateGrid();
            Height = 327;
            tsbCadastrar.Text = "Adicionar";
            lblMsgErro.Visible = false;
        }

        private Funcionario FuncionarioSelect()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = int.Parse(dgvCadastros[0, dgvCadastros.CurrentRow.Index].Value.ToString());
            funcionario.Nome = dgvCadastros[1, dgvCadastros.CurrentRow.Index].Value.ToString();
            funcionario.Login = dgvCadastros[2, dgvCadastros.CurrentRow.Index].Value.ToString();
            funcionario.Senha = dgvCadastros[3, dgvCadastros.CurrentRow.Index].Value.ToString();
            funcionario.Tipo = Convert.ToInt32(dgvCadastros[4, dgvCadastros.CurrentRow.Index].Value.ToString());
            funcionario.Email = dgvCadastros[5, dgvCadastros.CurrentRow.Index].Value.ToString();
            funcionario.Telefone = dgvCadastros[6, dgvCadastros.CurrentRow.Index].Value.ToString();
            return funcionario;
        }

        private void FuncionarioUpdate()
        {
            Funcionario funcionario = FuncionarioSelect();
            txtCodigo.Text = funcionario.Id.ToString();
            txtNome.Text = funcionario.Nome;
            txtLogin.Text = funcionario.Login;
            txtSenha.Text = funcionario.Senha;
            if(funcionario.Tipo == 1)
            {
                rdbCurador.Checked = true;
                rdbFuncionario.Checked = false;
            }else if(funcionario.Tipo == 2)
            {
                rdbFuncionario.Checked = true;
                rdbCurador.Checked = false;
            }
            txtEmail.Text = funcionario.Email;
            mtxTelefone.Text = funcionario.Telefone;
        }

        private void mtxTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtxTelefone.Mask = "(00) 00000-0000";
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            tsbCadastrar.Text = "Salvar";
            FuncionarioUpdate();
            gpxCadastroFuncionarios.Visible = true;
            //Width = 647;
            Height = 602;
        }

        private void Clean()
        {
           txtCodigo.Text = Convert.ToString(RandomNumber(1, 9999));
           txtNome.Clear();
           txtLogin.Clear();
           txtSenha.Clear();
           rdbCurador.Checked = false;
           rdbFuncionario.Checked = false;
           txtEmail.Clear();
           mtxTelefone.Text = null;
           tsbCadastrar.Text = "Adicionar";
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush
                (this.ClientRectangle, Color.Silver, Color.White, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            if (tsbCadastrar.Text == "Adicionar")
            {
                Height = 602;
                gpxCadastroFuncionarios.Visible = true;
                tsbCadastrar.Text = "Cadastrar";
            }
            else if (tsbCadastrar.Text == "Salvar")
            {
                try
                {
                    Funcionario funcionario = new Funcionario();
                    funcionario.Id = FuncionarioSelect().Id;
                    funcionario.Nome = txtNome.Text;
                    funcionario.Login = txtLogin.Text;
                    funcionario.Senha = txtSenha.Text;

                    if (rdbCurador.Checked == true)
                    {
                        funcionario.Tipo = 1;
                    }else if(rdbFuncionario.Checked == true)
                    {
                        funcionario.Tipo = 2;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, escolha um tipo de usuário.");
                    }

                    funcionario.Email = txtEmail.Text;
                    funcionario.Telefone = mtxTelefone.Text;

                    bll.Update(funcionario);
                    UpdateGrid();
                    Clean();
                    lblMsgErro.Visible = false;
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                    lblMsgErro.Visible = true;
                    lblMsgErro.Text = "Erro: " + ex.Message;
                }
            }
            else
            {
                try
                {
                    if (rdbCurador.Checked == true)
                    {
                        bll.Create(new Funcionario(txtNome.Text, txtLogin.Text, txtSenha.Text, 1, txtEmail.Text, mtxTelefone.Text));
                    }
                    else if (rdbFuncionario.Checked == true)
                    {
                        bll.Create(new Funcionario(txtNome.Text, txtLogin.Text, txtSenha.Text, 2, txtEmail.Text, mtxTelefone.Text));
                    }
                    else
                    {
                        MessageBox.Show("Por favor, escolha um tipo de usuário.");
                    }

                    UpdateGrid();
                    Clean();
                    lblMsgErro.Visible = false;
                }
                catch (Exception ex)
                {
                    lblMsgErro.Visible = true;
                    lblMsgErro.Text = "Erro: " + ex.Message;
                }
            }
        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                bll.Delete(FuncionarioSelect());
                UpdateGrid();
                Clean();
                lblMsgErro.Visible = false;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                lblMsgErro.Visible = true;
                lblMsgErro.Text = "Erro: " + ex.Message;
            }
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
