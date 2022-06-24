namespace ProjetoFinalLP
{
    partial class FrmCadastroProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProfessor));
            this.txtDataNascimentoProf = new System.Windows.Forms.MaskedTextBox();
            this.grdProfessor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblNascimentoProf = new System.Windows.Forms.Label();
            this.txtCodProf = new System.Windows.Forms.TextBox();
            this.lblCodProf = new System.Windows.Forms.Label();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataNascimentoProf
            // 
            this.txtDataNascimentoProf.Location = new System.Drawing.Point(212, 220);
            this.txtDataNascimentoProf.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataNascimentoProf.Mask = "00/00/0000";
            this.txtDataNascimentoProf.Name = "txtDataNascimentoProf";
            this.txtDataNascimentoProf.Size = new System.Drawing.Size(64, 20);
            this.txtDataNascimentoProf.TabIndex = 194;
            this.txtDataNascimentoProf.ValidatingType = typeof(System.DateTime);
            // 
            // grdProfessor
            // 
            this.grdProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfessor.Location = new System.Drawing.Point(108, 260);
            this.grdProfessor.Name = "grdProfessor";
            this.grdProfessor.Size = new System.Drawing.Size(477, 206);
            this.grdProfessor.TabIndex = 193;
            this.grdProfessor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProfessor_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 190;
            this.label1.Text = "Cadastrar Professor";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(801, 343);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 67);
            this.btnSair.TabIndex = 188;
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
            this.btnCancelar.Location = new System.Drawing.Point(801, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 67);
            this.btnCancelar.TabIndex = 187;
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
            this.btnSalvar.Location = new System.Drawing.Point(641, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 67);
            this.btnSalvar.TabIndex = 186;
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
            this.btnExcluir.Location = new System.Drawing.Point(801, 147);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 67);
            this.btnExcluir.TabIndex = 185;
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
            this.btnAlterar.Location = new System.Drawing.Point(641, 242);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(99, 67);
            this.btnAlterar.TabIndex = 184;
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
            this.btnNovo.Location = new System.Drawing.Point(641, 147);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 67);
            this.btnNovo.TabIndex = 183;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblNascimentoProf
            // 
            this.lblNascimentoProf.AutoSize = true;
            this.lblNascimentoProf.BackColor = System.Drawing.Color.Transparent;
            this.lblNascimentoProf.Location = new System.Drawing.Point(105, 223);
            this.lblNascimentoProf.Name = "lblNascimentoProf";
            this.lblNascimentoProf.Size = new System.Drawing.Size(102, 13);
            this.lblNascimentoProf.TabIndex = 182;
            this.lblNascimentoProf.Text = "Data de Nacimento:";
            // 
            // txtCodProf
            // 
            this.txtCodProf.Enabled = false;
            this.txtCodProf.Location = new System.Drawing.Point(196, 140);
            this.txtCodProf.MaxLength = 15;
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(172, 20);
            this.txtCodProf.TabIndex = 179;
            // 
            // lblCodProf
            // 
            this.lblCodProf.AutoSize = true;
            this.lblCodProf.BackColor = System.Drawing.Color.Transparent;
            this.lblCodProf.Location = new System.Drawing.Point(105, 147);
            this.lblCodProf.Name = "lblCodProf";
            this.lblCodProf.Size = new System.Drawing.Size(76, 13);
            this.lblCodProf.TabIndex = 178;
            this.lblCodProf.Text = "Cód Porfessor:";
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(196, 181);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(389, 20);
            this.txtNomeProf.TabIndex = 177;
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProf.Location = new System.Drawing.Point(105, 188);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(85, 13);
            this.lblNomeProf.TabIndex = 176;
            this.lblNomeProf.Text = "Nome Professor:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(373, 220);
            this.txtSalario.MaxLength = 15;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(124, 20);
            this.txtSalario.TabIndex = 196;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Location = new System.Drawing.Point(283, 223);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(89, 13);
            this.lblSalario.TabIndex = 195;
            this.lblSalario.Text = "Salario Porfessor:";
            // 
            // FrmCadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 489);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtDataNascimentoProf);
            this.Controls.Add(this.grdProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblNascimentoProf);
            this.Controls.Add(this.txtCodProf);
            this.Controls.Add(this.lblCodProf);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.lblNomeProf);
            this.DoubleBuffered = true;
            this.Name = "FrmCadastroProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Professor";
            this.Load += new System.EventHandler(this.FrmCadastroProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDataNascimentoProf;
        private System.Windows.Forms.DataGridView grdProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblNascimentoProf;
        private System.Windows.Forms.TextBox txtCodProf;
        private System.Windows.Forms.Label lblCodProf;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.Label lblNomeProf;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
    }
}