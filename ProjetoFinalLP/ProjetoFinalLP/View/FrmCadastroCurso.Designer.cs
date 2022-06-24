namespace ProjetoFinalLP
{
    partial class FrmCadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCurso));
            this.grdCurso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblQtdSemestre = new System.Windows.Forms.Label();
            this.txtDescricaoCurso = new System.Windows.Forms.TextBox();
            this.lblDescricaoCurso = new System.Windows.Forms.Label();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.nudQtdSemestre = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCurso
            // 
            this.grdCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCurso.Location = new System.Drawing.Point(89, 290);
            this.grdCurso.Name = "grdCurso";
            this.grdCurso.Size = new System.Drawing.Size(451, 187);
            this.grdCurso.TabIndex = 212;
            this.grdCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCurso_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 209;
            this.label1.Text = "Cadastrar Curso";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(796, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 67);
            this.btnSair.TabIndex = 207;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(796, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 67);
            this.btnCancelar.TabIndex = 206;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(650, 348);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 67);
            this.btnSalvar.TabIndex = 205;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(796, 156);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 67);
            this.btnExcluir.TabIndex = 204;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(650, 247);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 67);
            this.btnAlterar.TabIndex = 203;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(650, 156);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 67);
            this.btnNovo.TabIndex = 202;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblQtdSemestre
            // 
            this.lblQtdSemestre.AutoSize = true;
            this.lblQtdSemestre.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdSemestre.Location = new System.Drawing.Point(382, 157);
            this.lblQtdSemestre.Name = "lblQtdSemestre";
            this.lblQtdSemestre.Size = new System.Drawing.Size(77, 13);
            this.lblQtdSemestre.TabIndex = 201;
            this.lblQtdSemestre.Text = "Qtd Semestre: ";
            // 
            // txtDescricaoCurso
            // 
            this.txtDescricaoCurso.Location = new System.Drawing.Point(151, 219);
            this.txtDescricaoCurso.Multiline = true;
            this.txtDescricaoCurso.Name = "txtDescricaoCurso";
            this.txtDescricaoCurso.Size = new System.Drawing.Size(389, 59);
            this.txtDescricaoCurso.TabIndex = 200;
            // 
            // lblDescricaoCurso
            // 
            this.lblDescricaoCurso.AutoSize = true;
            this.lblDescricaoCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoCurso.Location = new System.Drawing.Point(86, 224);
            this.lblDescricaoCurso.Name = "lblDescricaoCurso";
            this.lblDescricaoCurso.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoCurso.TabIndex = 199;
            this.lblDescricaoCurso.Text = "Descrição:";
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Enabled = false;
            this.txtCodCurso.Location = new System.Drawing.Point(151, 155);
            this.txtCodCurso.MaxLength = 15;
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.Size = new System.Drawing.Size(172, 20);
            this.txtCodCurso.TabIndex = 198;
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCurso.Location = new System.Drawing.Point(86, 158);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(59, 13);
            this.lblCodCurso.TabIndex = 197;
            this.lblCodCurso.Text = "Cód Curso:";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.Location = new System.Drawing.Point(151, 186);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(389, 20);
            this.txtNomeCurso.TabIndex = 196;
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCurso.Location = new System.Drawing.Point(86, 189);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(68, 13);
            this.lblNomeCurso.TabIndex = 195;
            this.lblNomeCurso.Text = "Nome Curso:";
            // 
            // nudQtdSemestre
            // 
            this.nudQtdSemestre.Location = new System.Drawing.Point(465, 155);
            this.nudQtdSemestre.Name = "nudQtdSemestre";
            this.nudQtdSemestre.Size = new System.Drawing.Size(75, 20);
            this.nudQtdSemestre.TabIndex = 213;
            // 
            // FrmCadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 489);
            this.Controls.Add(this.nudQtdSemestre);
            this.Controls.Add(this.grdCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblQtdSemestre);
            this.Controls.Add(this.txtDescricaoCurso);
            this.Controls.Add(this.lblDescricaoCurso);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.lblCodCurso);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.lblNomeCurso);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "FrmCadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Curso";
            this.Load += new System.EventHandler(this.FrmCadastroCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblQtdSemestre;
        private System.Windows.Forms.TextBox txtDescricaoCurso;
        private System.Windows.Forms.Label lblDescricaoCurso;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.NumericUpDown nudQtdSemestre;
    }
}