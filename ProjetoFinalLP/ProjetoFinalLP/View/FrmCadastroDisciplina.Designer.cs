namespace ProjetoFinalLP
{
    partial class FrmCadastroDisciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroDisciplina));
            this.grdDisciplina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.lblCodDisicplina = new System.Windows.Forms.Label();
            this.txtNomeDisciplina = new System.Windows.Forms.TextBox();
            this.lblNomeDisicplina = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.txtDataEncerramento = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEncerramento = new System.Windows.Forms.Label();
            this.txtQtdAulas = new System.Windows.Forms.TextBox();
            this.lblQtdAulas = new System.Windows.Forms.Label();
            this.txtCodProfDisc = new System.Windows.Forms.TextBox();
            this.lblCodProf = new System.Windows.Forms.Label();
            this.txtCodCursoDisc = new System.Windows.Forms.TextBox();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDisciplina
            // 
            this.grdDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisciplina.Location = new System.Drawing.Point(108, 281);
            this.grdDisciplina.Name = "grdDisciplina";
            this.grdDisciplina.Size = new System.Drawing.Size(469, 196);
            this.grdDisciplina.TabIndex = 228;
            this.grdDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDisciplina_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 227;
            this.label1.Text = "Cadastrar Disciplina";
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Enabled = false;
            this.txtCodDisciplina.Location = new System.Drawing.Point(188, 120);
            this.txtCodDisciplina.MaxLength = 15;
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.Size = new System.Drawing.Size(172, 20);
            this.txtCodDisciplina.TabIndex = 217;
            // 
            // lblCodDisicplina
            // 
            this.lblCodDisicplina.AutoSize = true;
            this.lblCodDisicplina.BackColor = System.Drawing.Color.Transparent;
            this.lblCodDisicplina.Location = new System.Drawing.Point(105, 123);
            this.lblCodDisicplina.Name = "lblCodDisicplina";
            this.lblCodDisicplina.Size = new System.Drawing.Size(77, 13);
            this.lblCodDisicplina.TabIndex = 216;
            this.lblCodDisicplina.Text = "Cód Disicplina:";
            // 
            // txtNomeDisciplina
            // 
            this.txtNomeDisciplina.Location = new System.Drawing.Point(188, 156);
            this.txtNomeDisciplina.Name = "txtNomeDisciplina";
            this.txtNomeDisciplina.Size = new System.Drawing.Size(389, 20);
            this.txtNomeDisciplina.TabIndex = 215;
            // 
            // lblNomeDisicplina
            // 
            this.lblNomeDisicplina.AutoSize = true;
            this.lblNomeDisicplina.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeDisicplina.Location = new System.Drawing.Point(105, 159);
            this.lblNomeDisicplina.Name = "lblNomeDisicplina";
            this.lblNomeDisicplina.Size = new System.Drawing.Size(86, 13);
            this.lblNomeDisicplina.TabIndex = 214;
            this.lblNomeDisicplina.Text = "Nome Disicplina:";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(171, 192);
            this.txtDataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataInicio.Mask = "00/00/0000";
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(64, 20);
            this.txtDataInicio.TabIndex = 231;
            this.txtDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblDataInicio.Location = new System.Drawing.Point(105, 195);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(61, 13);
            this.lblDataInicio.TabIndex = 230;
            this.lblDataInicio.Text = "Data Inicio:";
            // 
            // txtDataEncerramento
            // 
            this.txtDataEncerramento.Location = new System.Drawing.Point(430, 192);
            this.txtDataEncerramento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataEncerramento.Mask = "00/00/0000";
            this.txtDataEncerramento.Name = "txtDataEncerramento";
            this.txtDataEncerramento.Size = new System.Drawing.Size(67, 20);
            this.txtDataEncerramento.TabIndex = 233;
            this.txtDataEncerramento.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataEncerramento
            // 
            this.lblDataEncerramento.AutoSize = true;
            this.lblDataEncerramento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataEncerramento.Location = new System.Drawing.Point(308, 195);
            this.lblDataEncerramento.Name = "lblDataEncerramento";
            this.lblDataEncerramento.Size = new System.Drawing.Size(117, 13);
            this.lblDataEncerramento.TabIndex = 232;
            this.lblDataEncerramento.Text = "Data de Encerramento:";
            // 
            // txtQtdAulas
            // 
            this.txtQtdAulas.Location = new System.Drawing.Point(167, 238);
            this.txtQtdAulas.Name = "txtQtdAulas";
            this.txtQtdAulas.Size = new System.Drawing.Size(85, 20);
            this.txtQtdAulas.TabIndex = 235;
            // 
            // lblQtdAulas
            // 
            this.lblQtdAulas.AutoSize = true;
            this.lblQtdAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdAulas.Location = new System.Drawing.Point(105, 241);
            this.lblQtdAulas.Name = "lblQtdAulas";
            this.lblQtdAulas.Size = new System.Drawing.Size(56, 13);
            this.lblQtdAulas.TabIndex = 234;
            this.lblQtdAulas.Text = "Qtd Aulas:";
            // 
            // txtCodProfDisc
            // 
            this.txtCodProfDisc.Location = new System.Drawing.Point(311, 238);
            this.txtCodProfDisc.Name = "txtCodProfDisc";
            this.txtCodProfDisc.Size = new System.Drawing.Size(85, 20);
            this.txtCodProfDisc.TabIndex = 237;
            // 
            // lblCodProf
            // 
            this.lblCodProf.AutoSize = true;
            this.lblCodProf.BackColor = System.Drawing.Color.Transparent;
            this.lblCodProf.Location = new System.Drawing.Point(259, 241);
            this.lblCodProf.Name = "lblCodProf";
            this.lblCodProf.Size = new System.Drawing.Size(51, 13);
            this.lblCodProf.TabIndex = 236;
            this.lblCodProf.Text = "Cód Prof:";
            // 
            // txtCodCursoDisc
            // 
            this.txtCodCursoDisc.Location = new System.Drawing.Point(474, 238);
            this.txtCodCursoDisc.Name = "txtCodCursoDisc";
            this.txtCodCursoDisc.Size = new System.Drawing.Size(103, 20);
            this.txtCodCursoDisc.TabIndex = 239;
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCurso.Location = new System.Drawing.Point(409, 241);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(59, 13);
            this.lblCodCurso.TabIndex = 238;
            this.lblCodCurso.Text = "Cód Curso:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(651, 147);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 67);
            this.btnNovo.TabIndex = 221;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(651, 240);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 67);
            this.btnAlterar.TabIndex = 222;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(801, 147);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 67);
            this.btnExcluir.TabIndex = 223;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(651, 338);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 67);
            this.btnSalvar.TabIndex = 224;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(801, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 67);
            this.btnCancelar.TabIndex = 225;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(801, 338);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 67);
            this.btnSair.TabIndex = 226;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCadastroDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1005, 489);
            this.Controls.Add(this.txtCodCursoDisc);
            this.Controls.Add(this.lblCodCurso);
            this.Controls.Add(this.txtCodProfDisc);
            this.Controls.Add(this.lblCodProf);
            this.Controls.Add(this.txtQtdAulas);
            this.Controls.Add(this.lblQtdAulas);
            this.Controls.Add(this.txtDataEncerramento);
            this.Controls.Add(this.lblDataEncerramento);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.grdDisciplina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.lblCodDisicplina);
            this.Controls.Add(this.txtNomeDisciplina);
            this.Controls.Add(this.lblNomeDisicplina);
            this.Name = "FrmCadastroDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Disciplina";
            this.Load += new System.EventHandler(this.FrmCadastroDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.Label lblCodDisicplina;
        private System.Windows.Forms.TextBox txtNomeDisciplina;
        private System.Windows.Forms.Label lblNomeDisicplina;
        private System.Windows.Forms.MaskedTextBox txtDataInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox txtDataEncerramento;
        private System.Windows.Forms.Label lblDataEncerramento;
        private System.Windows.Forms.TextBox txtQtdAulas;
        private System.Windows.Forms.Label lblQtdAulas;
        private System.Windows.Forms.TextBox txtCodProfDisc;
        private System.Windows.Forms.Label lblCodProf;
        private System.Windows.Forms.TextBox txtCodCursoDisc;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
    }
}