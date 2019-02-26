namespace museu
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            this.gpxCadastroFuncionarios = new System.Windows.Forms.GroupBox();
            this.gpxFuncionario = new System.Windows.Forms.GroupBox();
            this.rdbFuncionario = new System.Windows.Forms.RadioButton();
            this.lblSenha = new System.Windows.Forms.Label();
            this.rdbCurador = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gpxContatos = new System.Windows.Forms.GroupBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblControle = new System.Windows.Forms.Label();
            this.gpxFuncionarios = new System.Windows.Forms.GroupBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tsbCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbDeletar = new System.Windows.Forms.ToolStripButton();
            this.tsbLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.dgvCadastros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gpxCadastroFuncionarios.SuspendLayout();
            this.gpxFuncionario.SuspendLayout();
            this.gpxContatos.SuspendLayout();
            this.gpxFuncionarios.SuspendLayout();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).BeginInit();
            this.SuspendLayout();
            // 
            // gpxCadastroFuncionarios
            // 
            this.gpxCadastroFuncionarios.Controls.Add(this.gpxFuncionario);
            this.gpxCadastroFuncionarios.Controls.Add(this.gpxContatos);
            this.gpxCadastroFuncionarios.Controls.Add(this.txtNome);
            this.gpxCadastroFuncionarios.Controls.Add(this.txtCodigo);
            this.gpxCadastroFuncionarios.Controls.Add(this.lblNome);
            this.gpxCadastroFuncionarios.Controls.Add(this.lblCod);
            this.gpxCadastroFuncionarios.Location = new System.Drawing.Point(39, 268);
            this.gpxCadastroFuncionarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxCadastroFuncionarios.Name = "gpxCadastroFuncionarios";
            this.gpxCadastroFuncionarios.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpxCadastroFuncionarios.Size = new System.Drawing.Size(600, 269);
            this.gpxCadastroFuncionarios.TabIndex = 16;
            this.gpxCadastroFuncionarios.TabStop = false;
            this.gpxCadastroFuncionarios.Text = "Cadastro";
            // 
            // gpxFuncionario
            // 
            this.gpxFuncionario.Controls.Add(this.rdbFuncionario);
            this.gpxFuncionario.Controls.Add(this.lblSenha);
            this.gpxFuncionario.Controls.Add(this.rdbCurador);
            this.gpxFuncionario.Controls.Add(this.txtSenha);
            this.gpxFuncionario.Controls.Add(this.lblLogin);
            this.gpxFuncionario.Controls.Add(this.txtLogin);
            this.gpxFuncionario.Location = new System.Drawing.Point(63, 77);
            this.gpxFuncionario.Name = "gpxFuncionario";
            this.gpxFuncionario.Size = new System.Drawing.Size(196, 163);
            this.gpxFuncionario.TabIndex = 19;
            this.gpxFuncionario.TabStop = false;
            this.gpxFuncionario.Text = "Funcionário";
            // 
            // rdbFuncionario
            // 
            this.rdbFuncionario.AutoSize = true;
            this.rdbFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbFuncionario.Location = new System.Drawing.Point(98, 34);
            this.rdbFuncionario.Name = "rdbFuncionario";
            this.rdbFuncionario.Size = new System.Drawing.Size(80, 17);
            this.rdbFuncionario.TabIndex = 13;
            this.rdbFuncionario.Text = "Funcionário";
            this.rdbFuncionario.UseVisualStyleBackColor = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.Location = new System.Drawing.Point(17, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha";
            // 
            // rdbCurador
            // 
            this.rdbCurador.AutoSize = true;
            this.rdbCurador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rdbCurador.Location = new System.Drawing.Point(20, 34);
            this.rdbCurador.Name = "rdbCurador";
            this.rdbCurador.Size = new System.Drawing.Size(62, 17);
            this.rdbCurador.TabIndex = 12;
            this.rdbCurador.Text = "Curador";
            this.rdbCurador.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(20, 129);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(158, 20);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblLogin.Location = new System.Drawing.Point(17, 67);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(20, 82);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(158, 20);
            this.txtLogin.TabIndex = 14;
            // 
            // gpxContatos
            // 
            this.gpxContatos.Controls.Add(this.mtxTelefone);
            this.gpxContatos.Controls.Add(this.txtEmail);
            this.gpxContatos.Controls.Add(this.lblEmail);
            this.gpxContatos.Controls.Add(this.lblTelefone);
            this.gpxContatos.Location = new System.Drawing.Point(283, 127);
            this.gpxContatos.Name = "gpxContatos";
            this.gpxContatos.Size = new System.Drawing.Size(248, 113);
            this.gpxContatos.TabIndex = 21;
            this.gpxContatos.TabStop = false;
            this.gpxContatos.Text = "Contatos";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(21, 36);
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(124, 20);
            this.mtxTelefone.TabIndex = 23;
            this.mtxTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxTelefone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 23);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(218, 50);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(63, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(215, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(60, 36);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo";
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControle.Location = new System.Drawing.Point(26, -42);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(184, 22);
            this.lblControle.TabIndex = 15;
            this.lblControle.Text = "Controle de Cadastros";
            // 
            // gpxFuncionarios
            // 
            this.gpxFuncionarios.Controls.Add(this.lblMsgErro);
            this.gpxFuncionarios.Controls.Add(this.tspMenu);
            this.gpxFuncionarios.Controls.Add(this.dgvCadastros);
            this.gpxFuncionarios.Location = new System.Drawing.Point(39, 45);
            this.gpxFuncionarios.Name = "gpxFuncionarios";
            this.gpxFuncionarios.Size = new System.Drawing.Size(600, 224);
            this.gpxFuncionarios.TabIndex = 14;
            this.gpxFuncionarios.TabStop = false;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMsgErro.Location = new System.Drawing.Point(6, 170);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblMsgErro.Size = new System.Drawing.Size(588, 23);
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
            this.toolStripSeparator1,
            this.tsbSair});
            this.tspMenu.Location = new System.Drawing.Point(3, 196);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMenu.Size = new System.Drawing.Size(594, 25);
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
            // dgvCadastros
            // 
            this.dgvCadastros.AllowUserToAddRows = false;
            this.dgvCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadastros.Location = new System.Drawing.Point(6, 17);
            this.dgvCadastros.Name = "dgvCadastros";
            this.dgvCadastros.Size = new System.Drawing.Size(588, 150);
            this.dgvCadastros.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Controle de Cadastros";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpxCadastroFuncionarios);
            this.Controls.Add(this.lblControle);
            this.Controls.Add(this.gpxFuncionarios);
            this.Name = "FormFuncionario";
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.gpxCadastroFuncionarios.ResumeLayout(false);
            this.gpxCadastroFuncionarios.PerformLayout();
            this.gpxFuncionario.ResumeLayout(false);
            this.gpxFuncionario.PerformLayout();
            this.gpxContatos.ResumeLayout(false);
            this.gpxContatos.PerformLayout();
            this.gpxFuncionarios.ResumeLayout(false);
            this.gpxFuncionarios.PerformLayout();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadastros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpxCadastroFuncionarios;
        private System.Windows.Forms.GroupBox gpxFuncionario;
        private System.Windows.Forms.RadioButton rdbFuncionario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.RadioButton rdbCurador;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox gpxContatos;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.GroupBox gpxFuncionarios;
        private System.Windows.Forms.DataGridView dgvCadastros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripButton tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbDeletar;
        private System.Windows.Forms.ToolStripButton tsbLimpar;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}