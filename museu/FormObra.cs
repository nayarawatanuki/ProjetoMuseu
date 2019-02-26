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
    public partial class FormObra : Form
    {
        ObraBll bll = new ObraBll();
        Obra obra = new Obra();

        public Funcionario funcionario;

        public FormObra(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush
                (this.ClientRectangle, Color.Silver, Color.White, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


        private void UpdateGrid()
        {
            //filtro vazio
            dgvObras.DataSource = bll.Listar("");
            Height = 328;
            gpxObras.Height = 212;
            gpxCadastro.Visible = false;
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 9999);
        }

        private void FormObra_Load(object sender, EventArgs e)
        {
            txtCodObra.Text = Convert.ToString(RandomNumber(1, 9999));
            UpdateGrid();
            Height = 328;
            gpxObras.Height = 212;
            tsbCadastrar.Text = "Adicionar";
            gpxCadastro.Visible = false;
            lblMsgErro.Visible = false;

            if(funcionario.Tipo == 1)
                tspMenu.Visible = true;
            else
                tspMenu.Visible = false;
        }


        private Obra ObraSelect()
        {
            obra.Id = int.Parse(dgvObras[0, dgvObras.CurrentRow.Index].Value.ToString());
            obra.Titulo = dgvObras[1, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Autor = dgvObras[2, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Aquisicao = Convert.ToDateTime(dgvObras[3, dgvObras.CurrentRow.Index].Value.ToString());
            obra.Local = dgvObras[4, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Status = dgvObras[5, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Condicoes = dgvObras[6, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Valor = dgvObras[7, dgvObras.CurrentRow.Index].Value.ToString();
            obra.Descricao = dgvObras[8, dgvObras.CurrentRow.Index].Value.ToString();
            return obra;
        }

        private void ObraUpdate()
        {
            Obra obra = ObraSelect();
            txtCodObra.Text = obra.Id.ToString();
            txtObra.Text = obra.Titulo;
            txtArtistas.Text = obra.Autor;
            dtpAquisicao.Text = Convert.ToString(obra.Aquisicao);
            txtLocal.Text = obra.Local;
            cbxStatus.Text = obra.Status;
            cbxCondicoes.Text = obra.Condicoes;
            mtxSeguro.Text = Convert.ToString(obra.Valor);
            txtDescricao.Text = obra.Descricao;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            tsbCadastrar.Text = "Salvar";
            ObraUpdate();
            //Width = 647;
            Height = 695;
            gpxCadastro.Visible = true;
        }

        private void mtxSeguro_KeyPress(object sender, KeyPressEventArgs e)
        {
            mtxSeguro.Mask = "R$ 000.000.000.000";
        }

        private void Clean()
        {
            txtCodObra.Text = Convert.ToString(RandomNumber(1, 200000));
            txtObra.Clear();
            txtArtistas.Clear();
            dtpAquisicao.Text = null;
            txtLocal.Clear();
            cbxStatus.Text = null;
            cbxCondicoes.Text = null;
            mtxSeguro.Text = null;
            txtDescricao.Clear();
            tsbCadastrar.Text = "Adicionar";
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            if(tsbCadastrar.Text == "Adicionar")
            {
                Height = 695;
                gpxCadastro.Visible = true;
                tsbCadastrar.Text = "Cadastrar";
            }
            else if (tsbCadastrar.Text == "Salvar")
            {
                try
                {
                    obra.Id = ObraSelect().Id;
                    obra.Titulo = txtObra.Text;
                    obra.Autor = txtArtistas.Text;
                    obra.Aquisicao = Convert.ToDateTime(dtpAquisicao.Text);
                    obra.Local = txtLocal.Text;
                    obra.Status = cbxStatus.Text;
                    obra.Condicoes = cbxCondicoes.Text;
                    obra.Valor = mtxSeguro.Text;
                    obra.Descricao = txtDescricao.Text;

                    bll.Update(obra);
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
            else
            {
                try
                {
                    bll.Create(new Obra(txtObra.Text, txtArtistas.Text, Convert.ToDateTime(dtpAquisicao.Text), txtLocal.Text, cbxStatus.Text, cbxCondicoes.Text, mtxSeguro.Text, txtDescricao.Text));
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
                bll.Delete(ObraSelect());
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

        private void tsbSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
