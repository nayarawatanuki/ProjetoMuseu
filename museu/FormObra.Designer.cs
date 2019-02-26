namespace museu
{
    partial class FormObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObra));
            this.gpxObras = new System.Windows.Forms.GroupBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.dgvObras = new System.Windows.Forms.DataGridView();
            this.lblAcervoObra = new System.Windows.Forms.Label();
            this.gpxCadastro = new System.Windows.Forms.GroupBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblCodigoSala = new System.Windows.Forms.Label();
            this.txtCodObra = new System.Windows.Forms.TextBox();
            this.mtxSeguro = new System.Windows.Forms.MaskedTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblSeguroEmprestimo = new System.Windows.Forms.Label();
            this.lblCodObra = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbxCondicoes = new System.Windows.Forms.ComboBox();
            this.dtpAquisicao = new System.Windows.Forms.DateTimePicker();
            this.lblCondicoes = new System.Windows.Forms.Label();
            this.lblDataRecebimento = new System.Windows.Forms.Label();
            this.lblObra = new System.Windows.Forms.Label();
            this.lblArtistas = new System.Windows.Forms.Label();
            this.txtArtistas = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.gpxObras.SuspendLayout();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).BeginInit();
            this.gpxCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpxObras
            // 
            this.gpxObras.Controls.Add(this.lblMsgErro);
            this.gpxObras.Controls.Add(this.tspMenu);
            this.gpxObras.Controls.Add(this.dgvObras);
            this.gpxObras.Location = new System.Drawing.Point(35, 52);
            this.gpxObras.Name = "gpxObras";
            this.gpxObras.Size = new System.Drawing.Size(559, 227);
            this.gpxObras.TabIndex = 53;
            this.gpxObras.TabStop = false;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMsgErro.Location = new System.Drawing.Point(6, 171);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblMsgErro.Size = new System.Drawing.Size(547, 23);
            this.lblMsgErro.TabIndex = 55;
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
            this.toolStripSeparator1,
            this.tsbSair});
            this.tspMenu.Location = new System.Drawing.Point(3, 199);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.Size = new System.Drawing.Size(553, 25);
            this.tspMenu.TabIndex = 48;
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
            // dgvObras
            // 
            this.dgvObras.AllowUserToAddRows = false;
            this.dgvObras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObras.Location = new System.Drawing.Point(6, 19);
            this.dgvObras.Name = "dgvObras";
            this.dgvObras.ReadOnly = true;
            this.dgvObras.Size = new System.Drawing.Size(547, 150);
            this.dgvObras.TabIndex = 47;
            // 
            // lblAcervoObra
            // 
            this.lblAcervoObra.AutoSize = true;
            this.lblAcervoObra.BackColor = System.Drawing.Color.Transparent;
            this.lblAcervoObra.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcervoObra.Location = new System.Drawing.Point(31, 25);
            this.lblAcervoObra.Name = "lblAcervoObra";
            this.lblAcervoObra.Size = new System.Drawing.Size(139, 24);
            this.lblAcervoObra.TabIndex = 52;
            this.lblAcervoObra.Text = "Acervo - Obras";
            // 
            // gpxCadastro
            // 
            this.gpxCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gpxCadastro.Controls.Add(this.cbxStatus);
            this.gpxCadastro.Controls.Add(this.lblStatus);
            this.gpxCadastro.Controls.Add(this.txtLocal);
            this.gpxCadastro.Controls.Add(this.lblCodigoSala);
            this.gpxCadastro.Controls.Add(this.txtCodObra);
            this.gpxCadastro.Controls.Add(this.mtxSeguro);
            this.gpxCadastro.Controls.Add(this.lblDescricao);
            this.gpxCadastro.Controls.Add(this.lblSeguroEmprestimo);
            this.gpxCadastro.Controls.Add(this.lblCodObra);
            this.gpxCadastro.Controls.Add(this.txtDescricao);
            this.gpxCadastro.Controls.Add(this.cbxCondicoes);
            this.gpxCadastro.Controls.Add(this.dtpAquisicao);
            this.gpxCadastro.Controls.Add(this.lblCondicoes);
            this.gpxCadastro.Controls.Add(this.lblDataRecebimento);
            this.gpxCadastro.Controls.Add(this.lblObra);
            this.gpxCadastro.Controls.Add(this.lblArtistas);
            this.gpxCadastro.Controls.Add(this.txtObra);
            this.gpxCadastro.Controls.Add(this.txtArtistas);
            this.gpxCadastro.Location = new System.Drawing.Point(35, 297);
            this.gpxCadastro.Name = "gpxCadastro";
            this.gpxCadastro.Size = new System.Drawing.Size(559, 323);
            this.gpxCadastro.TabIndex = 54;
            this.gpxCadastro.TabStop = false;
            this.gpxCadastro.Text = "Cadastro de Obras";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(29, 186);
            this.txtLocal.Multiline = true;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(233, 33);
            this.txtLocal.TabIndex = 45;
            this.txtLocal.Text = " , Andar: , Ala:\r\n";
            // 
            // lblCodigoSala
            // 
            this.lblCodigoSala.AutoSize = true;
            this.lblCodigoSala.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodigoSala.Location = new System.Drawing.Point(26, 173);
            this.lblCodigoSala.Name = "lblCodigoSala";
            this.lblCodigoSala.Size = new System.Drawing.Size(33, 13);
            this.lblCodigoSala.TabIndex = 44;
            this.lblCodigoSala.Text = "Local";
            // 
            // txtCodObra
            // 
            this.txtCodObra.Enabled = false;
            this.txtCodObra.Location = new System.Drawing.Point(29, 36);
            this.txtCodObra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodObra.Name = "txtCodObra";
            this.txtCodObra.ReadOnly = true;
            this.txtCodObra.Size = new System.Drawing.Size(83, 20);
            this.txtCodObra.TabIndex = 37;
            // 
            // mtxSeguro
            // 
            this.mtxSeguro.Location = new System.Drawing.Point(299, 187);
            this.mtxSeguro.Name = "mtxSeguro";
            this.mtxSeguro.Size = new System.Drawing.Size(140, 20);
            this.mtxSeguro.TabIndex = 40;
            this.mtxSeguro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxSeguro_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescricao.Location = new System.Drawing.Point(26, 237);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 41;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblSeguroEmprestimo
            // 
            this.lblSeguroEmprestimo.AutoSize = true;
            this.lblSeguroEmprestimo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeguroEmprestimo.Location = new System.Drawing.Point(296, 173);
            this.lblSeguroEmprestimo.Name = "lblSeguroEmprestimo";
            this.lblSeguroEmprestimo.Size = new System.Drawing.Size(64, 13);
            this.lblSeguroEmprestimo.TabIndex = 38;
            this.lblSeguroEmprestimo.Text = "Seguro (R$)";
            // 
            // lblCodObra
            // 
            this.lblCodObra.AutoSize = true;
            this.lblCodObra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodObra.Location = new System.Drawing.Point(26, 23);
            this.lblCodObra.Name = "lblCodObra";
            this.lblCodObra.Size = new System.Drawing.Size(44, 13);
            this.lblCodObra.TabIndex = 36;
            this.lblCodObra.Text = "ID Obra";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(29, 251);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(504, 60);
            this.txtDescricao.TabIndex = 16;
            // 
            // cbxCondicoes
            // 
            this.cbxCondicoes.FormattingEnabled = true;
            this.cbxCondicoes.Items.AddRange(new object[] {
            "Perfeitas Condições ",
            "Conservada ",
            "Comprometida"});
            this.cbxCondicoes.Location = new System.Drawing.Point(299, 146);
            this.cbxCondicoes.Name = "cbxCondicoes";
            this.cbxCondicoes.Size = new System.Drawing.Size(146, 21);
            this.cbxCondicoes.TabIndex = 19;
            this.cbxCondicoes.TabStop = false;
            // 
            // dtpAquisicao
            // 
            this.dtpAquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAquisicao.Location = new System.Drawing.Point(29, 147);
            this.dtpAquisicao.Name = "dtpAquisicao";
            this.dtpAquisicao.Size = new System.Drawing.Size(123, 20);
            this.dtpAquisicao.TabIndex = 24;
            // 
            // lblCondicoes
            // 
            this.lblCondicoes.AutoSize = true;
            this.lblCondicoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCondicoes.Location = new System.Drawing.Point(296, 134);
            this.lblCondicoes.Name = "lblCondicoes";
            this.lblCondicoes.Size = new System.Drawing.Size(57, 13);
            this.lblCondicoes.TabIndex = 4;
            this.lblCondicoes.Text = "Condições";
            // 
            // lblDataRecebimento
            // 
            this.lblDataRecebimento.AutoSize = true;
            this.lblDataRecebimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDataRecebimento.Location = new System.Drawing.Point(26, 134);
            this.lblDataRecebimento.Name = "lblDataRecebimento";
            this.lblDataRecebimento.Size = new System.Drawing.Size(53, 13);
            this.lblDataRecebimento.TabIndex = 17;
            this.lblDataRecebimento.Text = "Aquisição";
            // 
            // lblObra
            // 
            this.lblObra.AutoSize = true;
            this.lblObra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblObra.Location = new System.Drawing.Point(26, 59);
            this.lblObra.Name = "lblObra";
            this.lblObra.Size = new System.Drawing.Size(30, 13);
            this.lblObra.TabIndex = 27;
            this.lblObra.Text = "Obra";
            // 
            // lblArtistas
            // 
            this.lblArtistas.AutoSize = true;
            this.lblArtistas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblArtistas.Location = new System.Drawing.Point(26, 96);
            this.lblArtistas.Name = "lblArtistas";
            this.lblArtistas.Size = new System.Drawing.Size(41, 13);
            this.lblArtistas.TabIndex = 28;
            this.lblArtistas.Text = "Artistas";
            // 
            // txtArtistas
            // 
            this.txtArtistas.Location = new System.Drawing.Point(29, 109);
            this.txtArtistas.Name = "txtArtistas";
            this.txtArtistas.Size = new System.Drawing.Size(223, 20);
            this.txtArtistas.TabIndex = 30;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(296, 96);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // txtObra
            // 
            this.txtObra.Location = new System.Drawing.Point(29, 72);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(503, 20);
            this.txtObra.TabIndex = 29;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Disponível ",
            "Em exposição",
            "Alugada "});
            this.cbxStatus.Location = new System.Drawing.Point(299, 108);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 47;
            // 
            // FormObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 657);
            this.Controls.Add(this.gpxCadastro);
            this.Controls.Add(this.gpxObras);
            this.Controls.Add(this.lblAcervoObra);
            this.Name = "FormObra";
            this.Text = "Obras";
            this.Load += new System.EventHandler(this.FormObra_Load);
            this.gpxObras.ResumeLayout(false);
            this.gpxObras.PerformLayout();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObras)).EndInit();
            this.gpxCadastro.ResumeLayout(false);
            this.gpxCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxObras;
        private System.Windows.Forms.DataGridView dgvObras;
        private System.Windows.Forms.Label lblAcervoObra;
        private System.Windows.Forms.GroupBox gpxCadastro;
        private System.Windows.Forms.MaskedTextBox mtxSeguro;
        private System.Windows.Forms.Label lblSeguroEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpAquisicao;
        private System.Windows.Forms.ComboBox cbxCondicoes;
        private System.Windows.Forms.Label lblDataRecebimento;
        private System.Windows.Forms.Label lblCondicoes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblObra;
        private System.Windows.Forms.Label lblArtistas;
        private System.Windows.Forms.TextBox txtArtistas;
        private System.Windows.Forms.TextBox txtCodObra;
        private System.Windows.Forms.Label lblCodObra;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblCodigoSala;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbDeletar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtObra;
    }
}