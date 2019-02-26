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
    public partial class FormEvento : Form
    {
        EventoBll bll = new EventoBll();
        ObraBll obraBll = new ObraBll();
        ItemEventoBll itemBll = new ItemEventoBll();
        Evento evento = new Evento();
        Obra obra = new Obra();

        public Funcionario funcionario = new Funcionario();

        public FormEvento(Funcionario funcionario)
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

        //Form no tamanho inicial
        private void UpdateForm()
        {
            Height = 280;
            gpxEvento.Visible = false;
            tsbCadastrar.Text = "Adicionar";
        }

        //Expandindo o formulario
        private void expandiForm()
        {
            gpxEvento.Visible = true;
            gpxObras.Visible = false;
            Height = 599;
        }

        //Atualização das tabelas
        private void UpdateGrid()
        {
            //dgvEventos
            dgvEventos.DataSource = bll.Listar("");
            dgvEventos.Columns[2].Visible = false;

            //dgvItensEventos
            dgvItensEvento.DataSource = itemBll.Listar(evento.Id);
            dgvItensEvento.Columns[3].Visible = false;
            dgvItensEvento.Columns[4].Visible = false;
            dgvItensEvento.Columns[6].Visible = false;
            dgvItensEvento.Columns[7].Visible = false;
            dgvItensEvento.Columns[8].Visible = false;

            //dgvObras
            dgvObras.DataSource = obraBll.Listar("");
        }

        //Atualização da tabela itens
        private void UpdateGridItens()
        {
            //dgvItensEventos
            dgvItensEvento.DataSource = itemBll.Listar(evento.Id);
            dgvItensEvento.Columns[3].Visible = false;
            dgvItensEvento.Columns[6].Visible = false;
            dgvItensEvento.Columns[7].Visible = false;
            dgvItensEvento.Columns[8].Visible = false;
        }

        //Atualização da tabela obras
        private void UpdateObras()
        {
            //dgvObras
            dgvObras.DataSource = obraBll.Listar("");
        }

        //Atualização da tabela eventos
        private void UpdateGridEventos()
        {
            //dgvObras
            dgvObras.DataSource = obraBll.Listar("");

            //dgvEventos
            dgvEventos.DataSource = bll.Listar("");
            dgvEventos.Columns[2].Visible = false;
        }

        //Numero aleatorio de registro
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 9999);
        }

        private void FormEvento_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            UpdateForm();

            //Alterações
            txtCodigoEvento.Text = Convert.ToString(RandomNumber(1, 9999));
            tsbCadastrar.Text = "Adicionar";

            //Campos invisiveis no inicio
            lblMsgErro.Visible = false;
            lblResponsavel.Visible = false;
            txtResponsavel.Visible = false;
            gpxObras.Visible = false;
            gpxItens.Visible = false;

            //Regra de funcionarios
            if (funcionario.Tipo == 1)
                tspMenu.Visible = true;
            else
                tspMenu.Visible = false;

            //Carregar obras no comboBox
            cbxObras.DataSource = obraBll.Listar("");

            // Resgatando a chave primária da tabela obras no seu combobox
            cbxObras.ValueMember = "id";

            // Exibindo o nome da obra no combobox apropriado.
            cbxObras.DisplayMember = "titulo";
        }

        //Inserindo dados nas variaveis da tabela eventos
        private Evento EventoSelect()
        {
            evento.Id = int.Parse(dgvEventos[0, dgvEventos.CurrentRow.Index].Value.ToString());
            evento.Titulo = dgvEventos[1, dgvEventos.CurrentRow.Index].Value.ToString();
            evento.Responsavel = Convert.ToInt32(dgvEventos[2, dgvEventos.CurrentRow.Index].Value.ToString());
            evento.DataInicio = Convert.ToDateTime(dgvEventos[4, dgvEventos.CurrentRow.Index].Value.ToString());
            evento.DataFim = Convert.ToDateTime(dgvEventos[5, dgvEventos.CurrentRow.Index].Value.ToString());
            evento.Obra = dgvEventos[6, dgvEventos.CurrentRow.Index].Value.ToString();
            return evento;
        }

        private Obra ObraSelect()
        {
            obra.Id = int.Parse(dgvObras[0, dgvObras.CurrentRow.Index].Value.ToString());
            obra.Status = dgvObras[5, dgvObras.CurrentRow.Index].Value.ToString();
            return obra;
        }

        //Inserindo as variaveis da tabela eventos nos seus campos apropriados
        private void EventoUpdate()
        {
            evento = EventoSelect();
            dgvItensEvento.DataSource = itemBll.Listar(evento.Id);
            txtCodigoEvento.Text = evento.Id.ToString();
            txtNomeEvento.Text = evento.Titulo;
            txtResponsavel.Text = Convert.ToString(evento.Responsavel);
            dtpInicio.Text = Convert.ToString(evento.DataInicio);
            dtpFinal.Text = Convert.ToString(evento.DataFim);
            cbxObras.Text = evento.Obra;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            Clean();
            tsbCadastrar.Text = "Salvar";
            expandiForm();
            UpdateGridItens();
            EventoUpdate();
            lblResponsavel.Visible = true;
            txtResponsavel.Visible = true;
        }

        private void tsbLimpar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtCodigoEvento.Text = Convert.ToString(RandomNumber(1, 9999));
            txtNomeEvento.Clear();
            dtpInicio.Text = null;
            cbxObras.Text = null;
            UpdateGridItens();
        }

        private void tsbCadastrar_Click(object sender, EventArgs e)
        {
            expandiForm();
            
            //Botão cadastrar novo evento
            if (tsbCadastrar.Text == "Adicionar")
            {
                Clean();
                tsbCadastrar.Text = "Cadastrar";
                lblResponsavel.Visible = false;
                txtResponsavel.Visible = false;
            }

            //Função salvar
            else if (tsbCadastrar.Text == "Salvar")
            {
                try
                {
                    //Salvando alterações do evento
                    evento.Id = Convert.ToInt32(txtCodigoEvento.Text);
                    evento.Titulo = txtNomeEvento.Text;
                    evento.Responsavel = Convert.ToInt32(txtResponsavel.Text);
                    evento.DataInicio = Convert.ToDateTime(dtpInicio.Text);
                    evento.DataFim = Convert.ToDateTime(dtpFinal.Text);

                    if (dgvItensEvento.RowCount == 0)
                    {
                        evento.Obra = "";
                    }
                    else
                    {
                        evento.Obra = dgvItensEvento[1, dgvItensEvento.CurrentCell.RowIndex].Value.ToString();

                        int cont = 0;
                        int i;
                        int j;

                        for (i = 0; i < dgvObras.Rows.Count - 1; i++)
                        {
                            for (j = 0; j < dgvObras.Columns.Count; j++)
                            {
                                if (dgvObras.Rows[i].Cells[j].Value.ToString() == cbxObras.Text)
                                {
                                    //MessageBox.Show(string.Format("Encontrados: {0}", cont), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    dgvObras.ClearSelection();
                                    dgvObras.Rows[i].Cells[j].Selected = true;
                                    cont++;

                                    //Salvando alterações das Obras
                                    obra.Id = int.Parse(dgvObras.Rows[i].Cells[0].Value.ToString());
                                    obra.Local = "Evento: " + txtNomeEvento.Text;
                                    obra.Status = "Em exposição";
                                    bll.UpdateObra(obra);
                                }
                            }
                        }

                    }

                    bll.Update(evento);
                    Clean();
                    UpdateForm();
                    UpdateGrid();
                    lblMsgErro.Visible = false;
                }
                catch (Exception ex)
                {
                    lblMsgErro.Visible = true;
                    lblMsgErro.Text = "Erro: " + ex.Message;
                }
            }

            //Função cadastrar/salvar novo evento
            else
            {
                try
                {
                    bll.Create(new Evento(txtNomeEvento.Text, funcionario.Id, Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpFinal.Text)));
                    Clean();
                    UpdateForm();
                    UpdateGrid();
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
                bll.Delete(EventoSelect());
                UpdateGrid();
                UpdateForm();
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

        //Adicionar obra ao evento
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int i;
            int j;

            try
            {
                //Saber se a obra selecionada pelo comboBox já está em atuando em evento
                for (i = 0; i < dgvObras.Rows.Count - 1; i++)
                {
                    for (j = 0; j < dgvObras.Columns.Count; j++)
                    {
                        if (dgvObras.Rows[i].Cells[j].Value.ToString() == cbxObras.Text)
                        {
                            if (dgvObras.Rows[i].Cells[5].Value.ToString() == "Em exposição")
                            {
                                MessageBox.Show("Obra em exposição.");
                                cbxObras.Text = null;
                            }
                            else if (dgvObras.Rows[i].Cells[5].Value.ToString() != "Em exposição")
                            {
                                //Contagem de linhas na tabela itens
                                if(dgvItensEvento.RowCount == 1)
                                {
                                    MessageBox.Show("Evento já possui obra alugada.");
                                    cbxObras.Text = null;
                                }

                                //Se a obra estiver disponível e não houver obras alugadas no evento o qual está sendo criado ou editado
                                //Cria-se item/obra para evento
                                else
                                {
                                    obra.Id = int.Parse(dgvObras.Rows[i].Cells[0].Value.ToString());
                                    obra.Local = "Evento: " + txtNomeEvento.Text;
                                    obra.Status = "Em exposição";

                                    bll.UpdateObra(obra);
                                    itemBll.Create(int.Parse(dgvObras.Rows[i].Cells[0].Value.ToString()), evento.Id);
                                    UpdateGridItens();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = "Erro: " + ex.Message;
            }
        }

        //Adicionar ou remover obra ao evento
        private void tsbObras_Click(object sender, EventArgs e)
        {
            Clean();
            tsbCadastrar.Text = "Salvar";
            expandiForm();
            UpdateGridItens();
            EventoUpdate();
            lblResponsavel.Visible = true;
            txtResponsavel.Visible = true;
            gpxItens.Visible = true;
        }

        //Seleção da Obra na tabela itens
        private void dgvItensEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbxObras.Text = dgvItensEvento.SelectedCells[1].Value.ToString();

            int cont = 0;
            int i;
            int j;

            for (i = 0; i < dgvObras.Rows.Count - 1; i++)
            {
                for (j = 0; j < dgvObras.Columns.Count; j++)
                {
                    if (dgvObras.Rows[i].Cells[j].Value.ToString() == cbxObras.Text)
                    {
                        //MessageBox.Show(string.Format("Encontrados: {0}", cont), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgvObras.ClearSelection();
                        dgvObras.Rows[i].Cells[j].Selected = true;
                        cont++;
                    }
                }
            }
        }

        private void cbxObras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cont = 0;
            int i;
            int j;

            try
            {
                //Busca e seleção da Obra na tabela
                for (i = 0; i < dgvObras.Rows.Count - 1; i++)
                {
                    for (j = 0; j < dgvObras.Columns.Count; j++)
                    {
                        if (dgvObras.Rows[i].Cells[j].Value.ToString() == cbxObras.Text)
                        {   
                            //MessageBox.Show(string.Format("Encontrados: {0}", cont), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvObras.ClearSelection();
                            dgvObras.Rows[i].Cells[j].Selected = true;
                            cont++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsgErro.Visible = true;
                lblMsgErro.Text = "Erro: " + ex.Message;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int i;
            int j;

            try
            {
                for (i = 0; i < dgvObras.Rows.Count - 1; i++)
                {
                    for (j = 0; j < dgvObras.Columns.Count; j++)
                    {
                        //Atualização de status da obra
                        if (dgvObras.Rows[i].Cells[j].Value.ToString() == cbxObras.Text)
                        {
                            obra.Id = int.Parse(dgvObras.Rows[i].Cells[0].Value.ToString());
                            obra.Local = "Sala de devolução";
                            obra.Status = "Disponível";

                            bll.UpdateObra(obra);

                            //Remoção da obra no evento
                            itemBll.Delete(int.Parse(dgvItensEvento.CurrentRow.Cells[0].Value.ToString()));
                            UpdateGridItens();
                            cbxObras.Text = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, selecione um item.");
                lblMsgErro.Visible = true;
                lblMsgErro.Text = "Erro: " + ex.Message;
            }
        }
    }   
}
