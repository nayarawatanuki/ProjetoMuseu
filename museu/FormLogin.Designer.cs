namespace museu
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnSair = new System.Windows.Forms.Button();
            this.gpxAcesso = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.gpxOpcoes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbObras = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbEventos = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.gpxAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpxOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpxAcesso
            // 
            this.gpxAcesso.BackColor = System.Drawing.Color.Transparent;
            this.gpxAcesso.Controls.Add(this.pictureBox1);
            this.gpxAcesso.Controls.Add(this.lblSenha);
            this.gpxAcesso.Controls.Add(this.btnLimpar);
            this.gpxAcesso.Controls.Add(this.lblLogin);
            this.gpxAcesso.Controls.Add(this.btnConfirma);
            this.gpxAcesso.Controls.Add(this.txtSenha);
            this.gpxAcesso.Controls.Add(this.txtLogin);
            resources.ApplyResources(this.gpxAcesso, "gpxAcesso");
            this.gpxAcesso.Name = "gpxAcesso";
            this.gpxAcesso.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblSenha
            // 
            resources.ApplyResources(this.lblSenha, "lblSenha");
            this.lblSenha.Name = "lblSenha";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblLogin
            // 
            resources.ApplyResources(this.lblLogin, "lblLogin");
            this.lblLogin.Name = "lblLogin";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnConfirma, "btnConfirma");
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // txtSenha
            // 
            resources.ApplyResources(this.txtSenha, "txtSenha");
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            resources.ApplyResources(this.txtLogin, "txtLogin");
            this.txtLogin.Name = "txtLogin";
            // 
            // gpxOpcoes
            // 
            this.gpxOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.gpxOpcoes.Controls.Add(this.label3);
            this.gpxOpcoes.Controls.Add(this.btnSair);
            this.gpxOpcoes.Controls.Add(this.pbObras);
            this.gpxOpcoes.Controls.Add(this.label2);
            this.gpxOpcoes.Controls.Add(this.pbEventos);
            this.gpxOpcoes.Controls.Add(this.label1);
            this.gpxOpcoes.Controls.Add(this.pbFuncionario);
            resources.ApplyResources(this.gpxOpcoes, "gpxOpcoes");
            this.gpxOpcoes.Name = "gpxOpcoes";
            this.gpxOpcoes.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pbObras
            // 
            this.pbObras.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbObras, "pbObras");
            this.pbObras.Name = "pbObras";
            this.pbObras.TabStop = false;
            this.pbObras.Tag = "Obras";
            this.pbObras.Click += new System.EventHandler(this.pbObras_Click);
            this.pbObras.MouseEnter += new System.EventHandler(this.pbObras_MouseEnter);
            this.pbObras.MouseLeave += new System.EventHandler(this.pbObras_MouseLeave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pbEventos
            // 
            this.pbEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbEventos, "pbEventos");
            this.pbEventos.Name = "pbEventos";
            this.pbEventos.TabStop = false;
            this.pbEventos.Tag = "Eventos";
            this.pbEventos.Click += new System.EventHandler(this.pbEventos_Click);
            this.pbEventos.MouseEnter += new System.EventHandler(this.pbEventos_MouseEnter);
            this.pbEventos.MouseLeave += new System.EventHandler(this.pbEventos_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pbFuncionario, "pbFuncionario");
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.TabStop = false;
            this.pbFuncionario.Tag = "Funcionários";
            this.pbFuncionario.Click += new System.EventHandler(this.pbFuncionario_Click);
            this.pbFuncionario.MouseEnter += new System.EventHandler(this.pbFuncionario_MouseEnter);
            this.pbFuncionario.MouseLeave += new System.EventHandler(this.pbFuncionario_MouseLeave);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpxOpcoes);
            this.Controls.Add(this.gpxAcesso);
            this.Name = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Resize += new System.EventHandler(this.FormLogin_Resize_1);
            this.gpxAcesso.ResumeLayout(false);
            this.gpxAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpxOpcoes.ResumeLayout(false);
            this.gpxOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpxAcesso;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.GroupBox gpxOpcoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbEventos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbObras;
    }
}

