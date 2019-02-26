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
    public partial class FormLogin : Form
    {
        

        LoginBll bll = new LoginBll();

        public Funcionario funcionario;

        public FormLogin()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush
                (this.ClientRectangle, Color.Silver, Color.White, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Width = 411;
            btnSair.Visible = false;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira um login.");
            }else if(txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Por favor, insira uma senha.");
            }/*else if(txtLogin.Text != "admin" || txtSenha.Text != "admin")
            {
                MessageBox.Show("Login ou senha não cadastrado.");
            }*//*else if(rdbCurador.Checked == false && rdbFuncionario.Checked == false)
            {
                MessageBox.Show("Por favor, marque um tipo de acesso.");
            }*/
            else
            {
                Funcionario funcionario = new Funcionario();
                funcionario = bll.login(txtLogin.Text, txtSenha.Text);
                if (funcionario.Id != 0)
                    entrar(funcionario);
                else
                    MessageBox.Show("Funcionário inválido.");
            }


        }

        private void entrar(Funcionario funcionario)
        {
            this.funcionario = funcionario;
            gpxAcesso.Visible = false;
            gpxOpcoes.Visible = true;
            gpxOpcoes.Location = new Point(30,32);
            btnSair.Location = new Point(325, 180);
            Width = 566;
            Height = 350;
            ControlBox = false;
            btnSair.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       /* private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (rdbObras.Checked)
            {
                FormObra obra = new FormObra(funcionario);
                obra.ShowDialog();
            }else if (rdbEventos.Checked)
            {
                FormEvento evento = new FormEvento(funcionario);
                evento.ShowDialog();
            }else if (rdbFuncionarios.Checked)
            {
                FormCadastro funcionarios = new FormCadastro();
                funcionarios.ShowDialog();
            }
        }*/

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //rdbCurador.Checked = false;
            //rdbFuncionario.Checked = false;
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void FormLogin_Resize_1(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario funcionarios = new FormFuncionario();
            funcionarios.ShowDialog();
        }

        private void pbFuncionario_MouseLeave(object sender, EventArgs e)
        {
            pbFuncionario.BackColor = Color.Transparent;
          
        }

        private void pbFuncionario_MouseEnter(object sender, EventArgs e)
        {
            pbFuncionario.BackColor = Color.LightGray;
           
        }

        private void pbEventos_Click(object sender, EventArgs e)
        {
            FormEvento evento = new FormEvento(funcionario);
            evento.ShowDialog();
        }

        private void pbEventos_MouseEnter(object sender, EventArgs e)
        {
            pbEventos.BackColor = Color.LightGray;
        }

        private void pbEventos_MouseLeave(object sender, EventArgs e)
        {
            pbEventos.BackColor = Color.Transparent;
        }

        private void pbObras_Click(object sender, EventArgs e)
        {
            FormObra obra = new FormObra(funcionario);
            obra.ShowDialog();
        }

        private void pbObras_MouseEnter(object sender, EventArgs e)
        {
            pbObras.BackColor = Color.LightGray;
        }

        private void pbObras_MouseLeave(object sender, EventArgs e)
        {
            pbObras.BackColor = Color.Transparent;
        }
        
        
    }
}
