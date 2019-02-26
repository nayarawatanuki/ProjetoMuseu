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
    public partial class Eventos : System.Web.UI.Page
    {
        ItemEventoBll itemBll = new ItemEventoBll();

        EventoBll bll = new EventoBll();
        Model.Evento evento = new Model.Evento();
        Model.Obra obra = new Model.Obra();
        ItemEventoBll itemEvento = new ItemEventoBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            PanelEvento.Visible = false;
            PanelObras.Visible = false;
            Label1.Visible = false;
            btnAdicionarObras.Visible = false;
            GridEventos.Columns[2].Visible = false;
        }

        private void Clean()
        {
            lblEventos.Text = "Acervo - Eventos";
            txtNomeEvento.Text = "";
            txtResponsavel.Text = "";
            
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            bll.Create(new Evento(txtNomeEvento.Text, Convert.ToInt32(txtResponsavel.Text), Convert.ToDateTime(txtDataInicio.Text), Convert.ToDateTime(txtDataFinal.Text)));
            GridEventos.DataBind();
            Clean();

            lblEventos.Text = "Acervo - Eventos";
            PanelEvento.Visible = false;
            PanelObras.Visible = false;
            panelTable.Visible = true;
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            lblEventos.Text = "Cadastro de Eventos";
            PanelEvento.Visible = true;
            PanelObras.Visible = false;
            panelTable.Visible = false;
        }

        protected void btnAdicionarObras_Click(object sender, EventArgs e)
        {
            int linhasSelecionadas = 0;
            for (int i = 0; i < GridEventos.Rows.Count - 1; i++)
            {
                if (GridEventos.SelectedRow == null)
                {
                    Label1.Visible = true;
                    Label1.Text = "por favor, selecione um evento";
                }else
                if (GridEventos.SelectedRow.RowState == DataControlRowState.Selected)
                {
                    linhasSelecionadas++;

                    Label1.Visible = false;
                    PanelEvento.Visible = false;
                    PanelObras.Visible = true;
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "erro";
                }

            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            PanelEvento.Visible = false;
            PanelObras.Visible = false;
            panelTable.Visible = true;
            Clean();
        }

        protected void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            /*int i;
            int linhasSelecionadas = 0;
            for (i = 0; i < GridObras.Rows.Count - 1; i++)
            {
                if (GridObras.SelectedRow == null)
                {
                    Label1.Visible = true;
                    Label1.Text = "por favor, selecione uma obra";
                }
                else
                if (GridObras.SelectedRow.RowState == DataControlRowState.Selected)
                {
                    linhasSelecionadas++;

                    obra.Id = int.Parse(GridObras.Rows[i].Cells[0].ToString());
                    obra.Local = "Evento: " + GridEventos.SelectedRow.Cells[1].ToString();
                    obra.Status = "Em exposição";

                    bll.UpdateObra(obra);
                    GridObras.DataBind();

                    GridEventos.SelectedRow.Cells[6].Text = GridObras.SelectedRow.Cells[1].Text;

                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "erro";
                }

            }*/

            foreach (GridViewRow rows in GridObras.Rows)
            {
                DropDownList cbx = (DropDownList)rows.FindControl("cbxObra");
            }

            

            int i;
            int j;

            try
            {
                //Saber se a obra selecionada pelo comboBox já está em atuando em evento
                for (i = 0; i < GridObras.Rows.Count - 1; i++)
                {
                    for (j = 0; j < GridObras.Columns.Count - 1; j++)
                    {
                        if (GridObras.Rows[i].Cells[j].Equals(cbxObra))
                        {
                            //dgvObras.ClearSelection();
                            //GridObras.Rows[i].Cells[j].Selected = true;
                            if (GridObras.Rows[i].Cells[5].ToString() == "Em exposição")
                            {
                                Label1.Visible = true;
                                Label1.Text = "Obra em exposição.";
                                cbxObra.Text = null;
                            }
                            else if (GridObras.Rows[i].Cells[5].ToString() != "Em exposição")
                            {
                                //Contagem de linhas na tabela itens
                                /*if (dgvItemEventos.Rows.Count == 1)
                                {
                                    //MessageBox.Show("Evento já possui obra alugada.");
                                    cbxObra.Text = null;
                                }

                                //Se a obra estiver disponível e não houver obras alugadas no evento o qual está sendo criado ou editado
                                //Cria-se item/obra para evento
                                else
                                {*/
                                obra.Id = int.Parse(GridObras.Rows[i].Cells[0].ToString());
                                obra.Local = "Evento: " + txtNomeEvento.Text;
                                obra.Status = "Em exposição";

                                bll.UpdateObra(obra);
                                GridObras.DataBind();
                                //itemBll.Create(int.Parse(GridObras.Rows[i].Cells[0].ToString()), evento.Id);
                                //dgvItemEventos.DataBind();
                                //}
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = "Erro: " + ex.Message;
            }
        }

        protected void GridObras_DataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow rows in GridObras.Rows)
            {
                DropDownList cbx = (DropDownList)rows.FindControl("cbxObra");
            }

            /*int rowscount = GridObras.Rows.Count;
            string[] prioridade = new string[rowscount];
            int[] pk_acao = new int[rowscount];

            for (int linha = 0; linha < rowscount; linha++)
            {
                prioridade[linha] = ((DropDownList)GridObras.Rows[e.RowIndex].Cells[1].FindControl("cbxObra")).SelectedValue;

                //((DropDownList)GridObras.Rows[e.RowIndex].Cells[1].Controls[0]).SelectedValue;

            }*/
        }
    }
}