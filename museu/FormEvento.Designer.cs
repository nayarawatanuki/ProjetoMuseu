namespace museu
{
    partial class FormEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvento));
            this.gpxEvento = new System.Windows.Forms.GroupBox();
            this.gpxItens = new System.Windows.Forms.GroupBox();
            this.gpxItensObras = new System.Windows.Forms.GroupBox();
            this.dgvItensEvento = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblObras = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbxObras = new System.Windows.Forms.ComboBox();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.gpxObras = new System.Windows.Forms.GroupBox();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            this.lblCodigoEvento = new System.Windows.Forms.Label();
            this.gpxTempo = new System.Windows.Forms.GroupBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.txtCodigoEvento = new System.Windows.Forms.TextBox();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.gpxResponsavel = new System.Windows.Forms.GroupBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.tsbSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.tsbObras = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.lblAcervoExpo = new System.Windows.Forms.Label();
            this.gpxEvento.SuspendLayout();
            this.gpxItens.SuspendLayout();
            this.gpxItensObras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEvento)).BeginInit();
            this.gpxObras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            this.gpxTempo.SuspendLayout();
            this.gpxResponsavel.SuspendLayout();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxEvento
            // 
            this.gpxEvento.BackColor = System.Drawing.Color.Transparent;
            this.gpxEvento.Controls.Add(this.gpxItens);
            this.gpxEvento.Controls.Add(this.lblResponsavel);
            this.gpxEvento.Controls.Add(this.txtResponsavel);
            this.gpxEvento.Controls.Add(this.gpxObras);
            this.gpxEvento.Controls.Add(this.lblCodigoEvento);
            this.gpxEvento.Controls.Add(this.gpxTempo);
            this.gpxEvento.Controls.Add(this.txtNomeEvento);
            this.gpxEvento.Controls.Add(this.txtCodigoEvento);
            this.gpxEvento.Controls.Add(this.lblNomeEvento);
            this.gpxEvento.Location = new System.Drawing.Point(26, 222);
            this.gpxEvento.Name = "gpxEvento";
            this.gpxEvento.Size = new System.Drawing.Size(668, 327);
            this.gpxEvento.TabIndex = 32;
            this.gpxEvento.TabStop = false;
            this.gpxEvento.Text = "Evento";
            // 
            // gpxItens
            // 
            this.gpxItens.Controls.Add(this.gpxItensObras);
            this.gpxItens.Controls.Add(this.btnRemover);
            this.gpxItens.Controls.Add(this.lblObras);
            this.gpxItens.Controls.Add(this.btnAdicionar);
            this.gpxItens.Controls.Add(this.cbxObras);
            this.gpxItens.Location = new System.Drawing.Point(219, 87);
            this.gpxItens.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxItens.Name = "gpxItens";
            this.gpxItens.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxItens.Size = new System.Drawing.Size(423, 221);
            this.gpxItens.TabIndex = 28;
            this.gpxItens.TabStop = false;
            this.gpxItens.Text = "Obras";
            // 
            // gpxItensObras
            // 
            this.gpxItensObras.Controls.Add(this.dgvItensEvento);
            this.gpxItensObras.Location = new System.Drawing.Point(13, 70);
            this.gpxItensObras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxItensObras.Name = "gpxItensObras";
            this.gpxItensObras.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxItensObras.Size = new System.Drawing.Size(398, 109);
            this.gpxItensObras.TabIndex = 29;
            this.gpxItensObras.TabStop = false;
            this.gpxItensObras.Text = "Itens";
            // 
            // dgvItensEvento
            // 
            this.dgvItensEvento.AllowUserToAddRows = false;
            this.dgvItensEvento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItensEvento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItensEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItensEvento.Location = new System.Drawing.Point(8, 20);
            this.dgvItensEvento.Name = "dgvItensEvento";
            this.dgvItensEvento.ReadOnly = true;
            this.dgvItensEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItensEvento.Size = new System.Drawing.Size(383, 80);
            this.dgvItensEvento.TabIndex = 21;
            this.dgvItensEvento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItensEvento_CellClick);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(331, 184);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 27);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lblObras
            // 
            this.lblObras.AutoSize = true;
            this.lblObras.Location = new System.Drawing.Point(11, 24);
            this.lblObras.Name = "lblObras";
            this.lblObras.Size = new System.Drawing.Size(35, 13);
            this.lblObras.TabIndex = 29;
            this.lblObras.Text = "Obras";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(156, 36);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(60, 26);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbxObras
            // 
            this.cbxObras.FormattingEnabled = true;
            this.cbxObras.Location = new System.Drawing.Point(14, 40);
            this.cbxObras.Name = "cbxObras";
            this.cbxObras.Size = new System.Drawing.Size(136, 21);
            this.cbxObras.TabIndex = 28;
            this.cbxObras.SelectedIndexChanged += new System.EventHandler(this.cbxObras_SelectedIndexChanged);
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(35, 74);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(69, 13);
            this.lblResponsavel.TabIndex = 26;
            this.lblResponsavel.Text = "Responsável";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Enabled = false;
            this.txtResponsavel.Location = new System.Drawing.Point(38, 87);
            this.txtResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(93, 20);
            this.txtResponsavel.TabIndex = 27;
            // 
            // gpxObras
            // 
            this.gpxObras.Controls.Add(this.dgvObras);
            this.gpxObras.Location = new System.Drawing.Point(538, 1);
            this.gpxObras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxObras.Name = "gpxObras";
            this.gpxObras.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxObras.Size = new System.Drawing.Size(221, 153);
            this.gpxObras.TabIndex = 22;
            this.gpxObras.TabStop = false;
            this.gpxObras.Text = "Obras";
            // 
            // dgvObras
            // 
            this.dgvObras.AllowUserToAddRows = false;
            this.dgvObras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(9, 19);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.ReadOnly = true;
            this.dgvObras.Size = new System.Drawing.Size(202, 121);
            this.dgvObras.TabIndex = 21;
            // 
            // lblCodigoEvento
            // 
            this.lblCodigoEvento.AutoSize = true;
            this.lblCodigoEvento.Location = new System.Drawing.Point(35, 32);
            this.lblCodigoEvento.Name = "lblCodigoEvento";
            this.lblCodigoEvento.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoEvento.TabIndex = 1;
            this.lblCodigoEvento.Text = "Código";
            // 
            // gpxTempo
            // 
            this.gpxTempo.Controls.Add(this.dtpFinal);
            this.gpxTempo.Controls.Add(this.dtpInicio);
            this.gpxTempo.Controls.Add(this.lblInicio);
            this.gpxTempo.Controls.Add(this.lblFinal);
            this.gpxTempo.Location = new System.Drawing.Point(38, 124);
            this.gpxTempo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxTempo.Name = "gpxTempo";
            this.gpxTempo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxTempo.Size = new System.Drawing.Size(133, 131);
            this.gpxTempo.TabIndex = 12;
            this.gpxTempo.TabStop = false;
            this.gpxTempo.Text = "Tempo do Evento";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(19, 89);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(101, 20);
            this.dtpFinal.TabIndex = 15;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(19, 44);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(101, 20);
            this.dtpInicio.TabIndex = 14;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(16, 27);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 8;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(16, 74);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(23, 13);
            this.lblFinal.TabIndex = 9;
            this.lblFinal.Text = "Fim";
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(219, 48);
            this.txtNomeEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(423, 20);
            this.txtNomeEvento.TabIndex = 14;
            // 
            // txtCodigoEvento
            // 
            this.txtCodigoEvento.Enabled = false;
            this.txtCodigoEvento.Location = new System.Drawing.Point(38, 48);
            this.txtCodigoEvento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoEvento.Name = "txtCodigoEvento";
            this.txtCodigoEvento.ReadOnly = true;
            this.txtCodigoEvento.Size = new System.Drawing.Size(93, 20);
            this.txtCodigoEvento.TabIndex = 12;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Location = new System.Drawing.Point(216, 31);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(87, 13);
            this.lblNomeEvento.TabIndex = 3;
            this.lblNomeEvento.Text = "Nome do Evento";
            // 
            // gpxResponsavel
            // 
            this.gpxResponsavel.Controls.Add(this.lblMsgErro);
            this.gpxResponsavel.Controls.Add(this.tspMenu);
            this.gpxResponsavel.Controls.Add(this.dgvEventos);
            this.gpxResponsavel.Location = new System.Drawing.Point(26, 46);
            this.gpxResponsavel.Name = "gpxResponsavel";
            this.gpxResponsavel.Size = new System.Drawing.Size(668, 170);
            this.gpxResponsavel.TabIndex = 31;
            this.gpxResponsavel.TabStop = false;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMsgErro.Location = new System.Drawing.Point(6, 116);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblMsgErro.Size = new System.Drawing.Size(654, 23);
            this.lblMsgErro.TabIndex = 56;
            this.lblMsgErro.Text = "Mensagem de Erro:";
            this.lblMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspMenu
            // 
            this.tspMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadastrar,
            this.tsbEditar,
            this.tsbDeletar,
            this.tsbLimpar,
            this.tsbSeparador,
            this.tsbObras,
            this.toolStripSeparator1,
            this.tsbSair});
            this.tspMenu.Location = new System.Drawing.Point(3, 142);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.Size = new System.Drawing.Size(662, 25);
            this.tspMenu.TabIndex = 49;
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCadastrar.Image")));
            this.tsbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(77, 22);
            this.tsbCadastrar.Text = "Cadastrar";
            this.tsbCadastrar.Click += new System.EventHandler(this.tsbCadastrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(57, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbDeletar
            // 
            this.tsbDeletar.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeletar.Image")));
            this.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletar.Name = "tsbDeletar";
            this.tsbDeletar.Size = new System.Drawing.Size(64, 22);
            this.tsbDeletar.Text = "Deletar";
            this.tsbDeletar.Click += new System.EventHandler(this.tsbDeletar_Click);
            // 
            // tsbLimpar
            // 
            this.tsbLimpar.Image = ((System.Drawing.Image)(resources.GetObject("tsbLimpar.Image")));
            this.tsbLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpar.Name = "tsbLimpar";
            this.tsbLimpar.Size = new System.Drawing.Size(64, 22);
            this.tsbLimpar.Text = "Limpar";
            this.tsbLimpar.Click += new System.EventHandler(this.tsbLimpar_Click);
            // 
            // tsbSeparador
            // 
            this.tsbSeparador.Name = "tsbSeparador";
            this.tsbSeparador.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbObras
            // 
            this.tsbObras.Image = ((System.Drawing.Image)(resources.GetObject("tsbObras.Image")));
            this.tsbObras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObras.Name = "tsbObras";
            this.tsbObras.Size = new System.Drawing.Size(112, 22);
            this.tsbObras.Text = "Adicionar Obras";
            this.tsbObras.Click += new System.EventHandler(this.tsbObras_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSair
            // 
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(46, 22);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(6, 17);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.Size = new System.Drawing.Size(654, 96);
            this.dgvEventos.TabIndex = 20;
            // 
            // lblAcervoExpo
            // 
            this.lblAcervoExpo.AutoSize = true;
            this.lblAcervoExpo.BackColor = System.Drawing.Color.Transparent;
            this.lblAcervoExpo.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcervoExpo.Location = new System.Drawing.Point(22, 21);
            this.lblAcervoExpo.Name = "lblAcervoExpo";
            this.lblAcervoExpo.Size = new System.Drawing.Size(135, 22);
            this.lblAcervoExpo.TabIndex = 29;
            this.lblAcervoExpo.Text = "Acervo - Evento";
            // 
            // FormEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 561);
            this.Controls.Add(this.gpxEvento);
            this.Controls.Add(this.gpxResponsavel);
            this.Controls.Add(this.lblAcervoExpo);
            this.Name = "FormEvento";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FormEvento_Load);
            this.gpxEvento.ResumeLayout(false);
            this.gpxEvento.PerformLayout();
            this.gpxItens.ResumeLayout(false);
            this.gpxItens.PerformLayout();
            this.gpxItensObras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItensEvento)).EndInit();
            this.gpxObras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            this.gpxTempo.ResumeLayout(false);
            this.gpxTempo.PerformLayout();
            this.gpxResponsavel.ResumeLayout(false);
            this.gpxResponsavel.PerformLayout();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxEvento;
        private System.Windows.Forms.Label lblCodigoEvento;
        private System.Windows.Forms.GroupBox gpxTempo;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.TextBox txtCodigoEvento;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.GroupBox gpxResponsavel;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.Label lblAcervoExpo;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbDeletar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.ToolStripButton tsbObras;
        private System.Windows.Forms.ToolStripSeparator tsbSeparador;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gpxItens;
        private System.Windows.Forms.Label lblObras;
        private System.Windows.Forms.ComboBox cbxObras;
        private System.Windows.Forms.DataGridView dgvItensEvento;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox gpxObras;
        private System.Windows.Forms.DataGridView dgvObras;
        private System.Windows.Forms.GroupBox gpxItensObras;
    }
}