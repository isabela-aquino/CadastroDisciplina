namespace ProjetoFinalLP
{
    partial class FrmListaProfessores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProfessores));
            this.lblListaProfessores = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.grdListaProfessores = new System.Windows.Forms.DataGridView();
            this.tabPorCod = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grdListaProfessor = new System.Windows.Forms.DataGridView();
            this.txtProcurarCod = new System.Windows.Forms.TextBox();
            this.tabPorNome = new System.Windows.Forms.TabPage();
            this.btnLimparNome = new System.Windows.Forms.Button();
            this.txtProcurarNome = new System.Windows.Forms.TextBox();
            this.grdListaProfessor1 = new System.Windows.Forms.DataGridView();
            this.btnProcurarNome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPorCurso = new System.Windows.Forms.TabPage();
            this.btnLimparCurso = new System.Windows.Forms.Button();
            this.cboPesquisaCurso = new System.Windows.Forms.ComboBox();
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProfessor2 = new System.Windows.Forms.DataGridView();
            this.tabAniversario = new System.Windows.Forms.TabPage();
            this.btnLimparAniversario = new System.Windows.Forms.Button();
            this.cboMes = new System.Windows.Forms.ComboBox();
            this.btnProcurarMes = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.grdListaProfessor2 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessores)).BeginInit();
            this.tabPorCod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor)).BeginInit();
            this.tabPorNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor1)).BeginInit();
            this.tabPorCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfessor2)).BeginInit();
            this.tabAniversario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaProfessores
            // 
            this.lblListaProfessores.AutoSize = true;
            this.lblListaProfessores.BackColor = System.Drawing.Color.Transparent;
            this.lblListaProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProfessores.Location = new System.Drawing.Point(517, 11);
            this.lblListaProfessores.Name = "lblListaProfessores";
            this.lblListaProfessores.Size = new System.Drawing.Size(282, 31);
            this.lblListaProfessores.TabIndex = 11;
            this.lblListaProfessores.Text = "Lista de Professores";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabPorCod);
            this.tabControl.Controls.Add(this.tabPorNome);
            this.tabControl.Controls.Add(this.tabPorCurso);
            this.tabControl.Controls.Add(this.tabAniversario);
            this.tabControl.Location = new System.Drawing.Point(117, 114);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1178, 460);
            this.tabControl.TabIndex = 14;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.grdListaProfessores);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Size = new System.Drawing.Size(1170, 434);
            this.tabGeral.TabIndex = 4;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // grdListaProfessores
            // 
            this.grdListaProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProfessores.Location = new System.Drawing.Point(39, 32);
            this.grdListaProfessores.Name = "grdListaProfessores";
            this.grdListaProfessores.Size = new System.Drawing.Size(1093, 383);
            this.grdListaProfessores.TabIndex = 14;
            // 
            // tabPorCod
            // 
            this.tabPorCod.Controls.Add(this.btnLimpar);
            this.tabPorCod.Controls.Add(this.btnProcurar);
            this.tabPorCod.Controls.Add(this.label6);
            this.tabPorCod.Controls.Add(this.grdListaProfessor);
            this.tabPorCod.Controls.Add(this.txtProcurarCod);
            this.tabPorCod.Location = new System.Drawing.Point(4, 22);
            this.tabPorCod.Name = "tabPorCod";
            this.tabPorCod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorCod.Size = new System.Drawing.Size(1170, 434);
            this.tabPorCod.TabIndex = 0;
            this.tabPorCod.Text = "Por Código";
            this.tabPorCod.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(670, 23);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 33);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(546, 23);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(108, 33);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Código:";
            // 
            // grdListaProfessor
            // 
            this.grdListaProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProfessor.Location = new System.Drawing.Point(33, 105);
            this.grdListaProfessor.Name = "grdListaProfessor";
            this.grdListaProfessor.Size = new System.Drawing.Size(1093, 312);
            this.grdListaProfessor.TabIndex = 13;
            // 
            // txtProcurarCod
            // 
            this.txtProcurarCod.Location = new System.Drawing.Point(93, 30);
            this.txtProcurarCod.Name = "txtProcurarCod";
            this.txtProcurarCod.Size = new System.Drawing.Size(435, 20);
            this.txtProcurarCod.TabIndex = 1;
            // 
            // tabPorNome
            // 
            this.tabPorNome.Controls.Add(this.btnLimparNome);
            this.tabPorNome.Controls.Add(this.txtProcurarNome);
            this.tabPorNome.Controls.Add(this.grdListaProfessor1);
            this.tabPorNome.Controls.Add(this.btnProcurarNome);
            this.tabPorNome.Controls.Add(this.label7);
            this.tabPorNome.Location = new System.Drawing.Point(4, 22);
            this.tabPorNome.Name = "tabPorNome";
            this.tabPorNome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorNome.Size = new System.Drawing.Size(1170, 434);
            this.tabPorNome.TabIndex = 1;
            this.tabPorNome.Text = "Por Nome";
            this.tabPorNome.UseVisualStyleBackColor = true;
            // 
            // btnLimparNome
            // 
            this.btnLimparNome.Location = new System.Drawing.Point(600, 24);
            this.btnLimparNome.Name = "btnLimparNome";
            this.btnLimparNome.Size = new System.Drawing.Size(110, 28);
            this.btnLimparNome.TabIndex = 16;
            this.btnLimparNome.Text = "Limpar";
            this.btnLimparNome.UseVisualStyleBackColor = true;
            this.btnLimparNome.Click += new System.EventHandler(this.btnLimparNome_Click);
            // 
            // txtProcurarNome
            // 
            this.txtProcurarNome.Location = new System.Drawing.Point(77, 29);
            this.txtProcurarNome.Name = "txtProcurarNome";
            this.txtProcurarNome.Size = new System.Drawing.Size(381, 20);
            this.txtProcurarNome.TabIndex = 15;
            // 
            // grdListaProfessor1
            // 
            this.grdListaProfessor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProfessor1.Location = new System.Drawing.Point(33, 105);
            this.grdListaProfessor1.Name = "grdListaProfessor1";
            this.grdListaProfessor1.Size = new System.Drawing.Size(1093, 312);
            this.grdListaProfessor1.TabIndex = 14;
            // 
            // btnProcurarNome
            // 
            this.btnProcurarNome.Location = new System.Drawing.Point(475, 24);
            this.btnProcurarNome.Name = "btnProcurarNome";
            this.btnProcurarNome.Size = new System.Drawing.Size(110, 28);
            this.btnProcurarNome.TabIndex = 2;
            this.btnProcurarNome.Text = "Procurar";
            this.btnProcurarNome.UseVisualStyleBackColor = true;
            this.btnProcurarNome.Click += new System.EventHandler(this.btnProcurarNome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nome :";
            // 
            // tabPorCurso
            // 
            this.tabPorCurso.Controls.Add(this.btnLimparCurso);
            this.tabPorCurso.Controls.Add(this.cboPesquisaCurso);
            this.tabPorCurso.Controls.Add(this.btnProcurar1);
            this.tabPorCurso.Controls.Add(this.label1);
            this.tabPorCurso.Controls.Add(this.grdProfessor2);
            this.tabPorCurso.Location = new System.Drawing.Point(4, 22);
            this.tabPorCurso.Name = "tabPorCurso";
            this.tabPorCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorCurso.Size = new System.Drawing.Size(1170, 434);
            this.tabPorCurso.TabIndex = 2;
            this.tabPorCurso.Text = "Por Curso";
            this.tabPorCurso.UseVisualStyleBackColor = true;
            // 
            // btnLimparCurso
            // 
            this.btnLimparCurso.Location = new System.Drawing.Point(568, 37);
            this.btnLimparCurso.Name = "btnLimparCurso";
            this.btnLimparCurso.Size = new System.Drawing.Size(110, 28);
            this.btnLimparCurso.TabIndex = 19;
            this.btnLimparCurso.Text = "Limpar";
            this.btnLimparCurso.UseVisualStyleBackColor = true;
            this.btnLimparCurso.Click += new System.EventHandler(this.btnLimparCurso_Click);
            // 
            // cboPesquisaCurso
            // 
            this.cboPesquisaCurso.FormattingEnabled = true;
            this.cboPesquisaCurso.Location = new System.Drawing.Point(84, 42);
            this.cboPesquisaCurso.Name = "cboPesquisaCurso";
            this.cboPesquisaCurso.Size = new System.Drawing.Size(360, 21);
            this.cboPesquisaCurso.TabIndex = 18;
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.Location = new System.Drawing.Point(451, 37);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(110, 28);
            this.btnProcurar1.TabIndex = 17;
            this.btnProcurar1.Text = "Procurar";
            this.btnProcurar1.UseVisualStyleBackColor = true;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Curso :";
            // 
            // grdProfessor2
            // 
            this.grdProfessor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProfessor2.Location = new System.Drawing.Point(41, 100);
            this.grdProfessor2.Name = "grdProfessor2";
            this.grdProfessor2.Size = new System.Drawing.Size(1093, 312);
            this.grdProfessor2.TabIndex = 14;
            // 
            // tabAniversario
            // 
            this.tabAniversario.Controls.Add(this.btnLimparAniversario);
            this.tabAniversario.Controls.Add(this.cboMes);
            this.tabAniversario.Controls.Add(this.btnProcurarMes);
            this.tabAniversario.Controls.Add(this.lblMes);
            this.tabAniversario.Controls.Add(this.grdListaProfessor2);
            this.tabAniversario.Location = new System.Drawing.Point(4, 22);
            this.tabAniversario.Name = "tabAniversario";
            this.tabAniversario.Size = new System.Drawing.Size(1170, 434);
            this.tabAniversario.TabIndex = 3;
            this.tabAniversario.Text = "Aniversário";
            this.tabAniversario.UseVisualStyleBackColor = true;
            // 
            // btnLimparAniversario
            // 
            this.btnLimparAniversario.Location = new System.Drawing.Point(568, 30);
            this.btnLimparAniversario.Name = "btnLimparAniversario";
            this.btnLimparAniversario.Size = new System.Drawing.Size(110, 28);
            this.btnLimparAniversario.TabIndex = 23;
            this.btnLimparAniversario.Text = "Limpar";
            this.btnLimparAniversario.UseVisualStyleBackColor = true;
            this.btnLimparAniversario.Click += new System.EventHandler(this.btnLimparAniversario_Click);
            // 
            // cboMes
            // 
            this.cboMes.FormattingEnabled = true;
            this.cboMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto ",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cboMes.Location = new System.Drawing.Point(83, 35);
            this.cboMes.Name = "cboMes";
            this.cboMes.Size = new System.Drawing.Size(360, 21);
            this.cboMes.TabIndex = 22;
            // 
            // btnProcurarMes
            // 
            this.btnProcurarMes.Location = new System.Drawing.Point(450, 30);
            this.btnProcurarMes.Name = "btnProcurarMes";
            this.btnProcurarMes.Size = new System.Drawing.Size(110, 28);
            this.btnProcurarMes.TabIndex = 21;
            this.btnProcurarMes.Text = "Procurar";
            this.btnProcurarMes.UseVisualStyleBackColor = true;
            this.btnProcurarMes.Click += new System.EventHandler(this.btnProcurarMes_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(37, 38);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 13);
            this.lblMes.TabIndex = 20;
            this.lblMes.Text = "Mês :";
            // 
            // grdListaProfessor2
            // 
            this.grdListaProfessor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProfessor2.Location = new System.Drawing.Point(40, 93);
            this.grdListaProfessor2.Name = "grdListaProfessor2";
            this.grdListaProfessor2.Size = new System.Drawing.Size(1093, 312);
            this.grdListaProfessor2.TabIndex = 19;
            // 
            // FrmListaProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 603);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblListaProfessores);
            this.DoubleBuffered = true;
            this.Name = "FrmListaProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Professores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListaProfessores_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessores)).EndInit();
            this.tabPorCod.ResumeLayout(false);
            this.tabPorCod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor)).EndInit();
            this.tabPorNome.ResumeLayout(false);
            this.tabPorNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor1)).EndInit();
            this.tabPorCurso.ResumeLayout(false);
            this.tabPorCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProfessor2)).EndInit();
            this.tabAniversario.ResumeLayout(false);
            this.tabAniversario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProfessor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaProfessores;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPorCod;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdListaProfessor;
        private System.Windows.Forms.TextBox txtProcurarCod;
        private System.Windows.Forms.TabPage tabPorNome;
        private System.Windows.Forms.TextBox txtProcurarNome;
        private System.Windows.Forms.DataGridView grdListaProfessor1;
        private System.Windows.Forms.Button btnProcurarNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPorCurso;
        private System.Windows.Forms.Button btnProcurar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProfessor2;
        private System.Windows.Forms.Button btnLimparNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cboPesquisaCurso;
        private System.Windows.Forms.TabPage tabAniversario;
        private System.Windows.Forms.ComboBox cboMes;
        private System.Windows.Forms.Button btnProcurarMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DataGridView grdListaProfessor2;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.DataGridView grdListaProfessores;
        private System.Windows.Forms.Button btnLimparCurso;
        private System.Windows.Forms.Button btnLimparAniversario;
    }
}