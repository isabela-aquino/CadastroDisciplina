namespace ProjetoFinalLP
{
    partial class FrmListaDisciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaDisciplinas));
            this.lblListaDisicplinas = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.grdListaDisciplinas = new System.Windows.Forms.DataGridView();
            this.tabPorCod = new System.Windows.Forms.TabPage();
            this.btnLimparDisc = new System.Windows.Forms.Button();
            this.btnProcurarDisc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grdListaDisciplina = new System.Windows.Forms.DataGridView();
            this.txtProcurarCodDisc = new System.Windows.Forms.TextBox();
            this.tabPorNome = new System.Windows.Forms.TabPage();
            this.btnLimparNomeDisc = new System.Windows.Forms.Button();
            this.txtProcurarNomeDisc = new System.Windows.Forms.TextBox();
            this.grdListaDisciplina1 = new System.Windows.Forms.DataGridView();
            this.btnProcurarNomeDisc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPorCurso = new System.Windows.Forms.TabPage();
            this.btnLimparDiscCurso = new System.Windows.Forms.Button();
            this.cboPesquisaCursoDisc = new System.Windows.Forms.ComboBox();
            this.btnProcurarDiscCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdListaDisciplina2 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplinas)).BeginInit();
            this.tabPorCod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina)).BeginInit();
            this.tabPorNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina1)).BeginInit();
            this.tabPorCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaDisicplinas
            // 
            this.lblListaDisicplinas.AutoSize = true;
            this.lblListaDisicplinas.BackColor = System.Drawing.Color.Transparent;
            this.lblListaDisicplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDisicplinas.Location = new System.Drawing.Point(512, 20);
            this.lblListaDisicplinas.Name = "lblListaDisicplinas";
            this.lblListaDisicplinas.Size = new System.Drawing.Size(267, 31);
            this.lblListaDisicplinas.TabIndex = 8;
            this.lblListaDisicplinas.Text = "Lista de Disciplinas";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabPorCod);
            this.tabControl.Controls.Add(this.tabPorNome);
            this.tabControl.Controls.Add(this.tabPorCurso);
            this.tabControl.Location = new System.Drawing.Point(84, 101);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1178, 540);
            this.tabControl.TabIndex = 15;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.grdListaDisciplinas);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Size = new System.Drawing.Size(1170, 514);
            this.tabGeral.TabIndex = 3;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // grdListaDisciplinas
            // 
            this.grdListaDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDisciplinas.Location = new System.Drawing.Point(39, 52);
            this.grdListaDisciplinas.Name = "grdListaDisciplinas";
            this.grdListaDisciplinas.Size = new System.Drawing.Size(1093, 446);
            this.grdListaDisciplinas.TabIndex = 14;
            // 
            // tabPorCod
            // 
            this.tabPorCod.Controls.Add(this.btnLimparDisc);
            this.tabPorCod.Controls.Add(this.btnProcurarDisc);
            this.tabPorCod.Controls.Add(this.label6);
            this.tabPorCod.Controls.Add(this.grdListaDisciplina);
            this.tabPorCod.Controls.Add(this.txtProcurarCodDisc);
            this.tabPorCod.Location = new System.Drawing.Point(4, 22);
            this.tabPorCod.Name = "tabPorCod";
            this.tabPorCod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorCod.Size = new System.Drawing.Size(1170, 514);
            this.tabPorCod.TabIndex = 0;
            this.tabPorCod.Text = "Por Código";
            this.tabPorCod.UseVisualStyleBackColor = true;
            // 
            // btnLimparDisc
            // 
            this.btnLimparDisc.Location = new System.Drawing.Point(670, 23);
            this.btnLimparDisc.Name = "btnLimparDisc";
            this.btnLimparDisc.Size = new System.Drawing.Size(108, 33);
            this.btnLimparDisc.TabIndex = 14;
            this.btnLimparDisc.Text = "Limpar";
            this.btnLimparDisc.UseVisualStyleBackColor = true;
            this.btnLimparDisc.Click += new System.EventHandler(this.btnLimparDisc_Click);
            // 
            // btnProcurarDisc
            // 
            this.btnProcurarDisc.Location = new System.Drawing.Point(546, 23);
            this.btnProcurarDisc.Name = "btnProcurarDisc";
            this.btnProcurarDisc.Size = new System.Drawing.Size(108, 33);
            this.btnProcurarDisc.TabIndex = 3;
            this.btnProcurarDisc.Text = "Procurar";
            this.btnProcurarDisc.UseVisualStyleBackColor = true;
            this.btnProcurarDisc.Click += new System.EventHandler(this.btnProcurarDisc_Click);
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
            // grdListaDisciplina
            // 
            this.grdListaDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDisciplina.Location = new System.Drawing.Point(33, 105);
            this.grdListaDisciplina.Name = "grdListaDisciplina";
            this.grdListaDisciplina.Size = new System.Drawing.Size(1093, 389);
            this.grdListaDisciplina.TabIndex = 13;
            // 
            // txtProcurarCodDisc
            // 
            this.txtProcurarCodDisc.Location = new System.Drawing.Point(93, 30);
            this.txtProcurarCodDisc.Name = "txtProcurarCodDisc";
            this.txtProcurarCodDisc.Size = new System.Drawing.Size(435, 20);
            this.txtProcurarCodDisc.TabIndex = 1;
            // 
            // tabPorNome
            // 
            this.tabPorNome.Controls.Add(this.btnLimparNomeDisc);
            this.tabPorNome.Controls.Add(this.txtProcurarNomeDisc);
            this.tabPorNome.Controls.Add(this.grdListaDisciplina1);
            this.tabPorNome.Controls.Add(this.btnProcurarNomeDisc);
            this.tabPorNome.Controls.Add(this.label7);
            this.tabPorNome.Location = new System.Drawing.Point(4, 22);
            this.tabPorNome.Name = "tabPorNome";
            this.tabPorNome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorNome.Size = new System.Drawing.Size(1170, 514);
            this.tabPorNome.TabIndex = 1;
            this.tabPorNome.Text = "Por Nome";
            this.tabPorNome.UseVisualStyleBackColor = true;
            // 
            // btnLimparNomeDisc
            // 
            this.btnLimparNomeDisc.Location = new System.Drawing.Point(600, 24);
            this.btnLimparNomeDisc.Name = "btnLimparNomeDisc";
            this.btnLimparNomeDisc.Size = new System.Drawing.Size(110, 28);
            this.btnLimparNomeDisc.TabIndex = 16;
            this.btnLimparNomeDisc.Text = "Limpar";
            this.btnLimparNomeDisc.UseVisualStyleBackColor = true;
            this.btnLimparNomeDisc.Click += new System.EventHandler(this.btnLimparNomeDisc_Click);
            // 
            // txtProcurarNomeDisc
            // 
            this.txtProcurarNomeDisc.Location = new System.Drawing.Point(77, 29);
            this.txtProcurarNomeDisc.Name = "txtProcurarNomeDisc";
            this.txtProcurarNomeDisc.Size = new System.Drawing.Size(381, 20);
            this.txtProcurarNomeDisc.TabIndex = 15;
            // 
            // grdListaDisciplina1
            // 
            this.grdListaDisciplina1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDisciplina1.Location = new System.Drawing.Point(33, 105);
            this.grdListaDisciplina1.Name = "grdListaDisciplina1";
            this.grdListaDisciplina1.Size = new System.Drawing.Size(1093, 382);
            this.grdListaDisciplina1.TabIndex = 14;
            // 
            // btnProcurarNomeDisc
            // 
            this.btnProcurarNomeDisc.Location = new System.Drawing.Point(475, 24);
            this.btnProcurarNomeDisc.Name = "btnProcurarNomeDisc";
            this.btnProcurarNomeDisc.Size = new System.Drawing.Size(110, 28);
            this.btnProcurarNomeDisc.TabIndex = 2;
            this.btnProcurarNomeDisc.Text = "Procurar";
            this.btnProcurarNomeDisc.UseVisualStyleBackColor = true;
            this.btnProcurarNomeDisc.Click += new System.EventHandler(this.btnProcurarNomeDisc_Click);
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
            this.tabPorCurso.Controls.Add(this.btnLimparDiscCurso);
            this.tabPorCurso.Controls.Add(this.cboPesquisaCursoDisc);
            this.tabPorCurso.Controls.Add(this.btnProcurarDiscCurso);
            this.tabPorCurso.Controls.Add(this.label1);
            this.tabPorCurso.Controls.Add(this.grdListaDisciplina2);
            this.tabPorCurso.Location = new System.Drawing.Point(4, 22);
            this.tabPorCurso.Name = "tabPorCurso";
            this.tabPorCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorCurso.Size = new System.Drawing.Size(1170, 514);
            this.tabPorCurso.TabIndex = 2;
            this.tabPorCurso.Text = "Por Curso";
            this.tabPorCurso.UseVisualStyleBackColor = true;
            // 
            // btnLimparDiscCurso
            // 
            this.btnLimparDiscCurso.Location = new System.Drawing.Point(567, 37);
            this.btnLimparDiscCurso.Name = "btnLimparDiscCurso";
            this.btnLimparDiscCurso.Size = new System.Drawing.Size(110, 28);
            this.btnLimparDiscCurso.TabIndex = 19;
            this.btnLimparDiscCurso.Text = "Limpar";
            this.btnLimparDiscCurso.UseVisualStyleBackColor = true;
            this.btnLimparDiscCurso.Click += new System.EventHandler(this.btnLimparDiscCurso_Click);
            // 
            // cboPesquisaCursoDisc
            // 
            this.cboPesquisaCursoDisc.FormattingEnabled = true;
            this.cboPesquisaCursoDisc.Location = new System.Drawing.Point(84, 42);
            this.cboPesquisaCursoDisc.Name = "cboPesquisaCursoDisc";
            this.cboPesquisaCursoDisc.Size = new System.Drawing.Size(360, 21);
            this.cboPesquisaCursoDisc.TabIndex = 18;
            // 
            // btnProcurarDiscCurso
            // 
            this.btnProcurarDiscCurso.Location = new System.Drawing.Point(451, 37);
            this.btnProcurarDiscCurso.Name = "btnProcurarDiscCurso";
            this.btnProcurarDiscCurso.Size = new System.Drawing.Size(110, 28);
            this.btnProcurarDiscCurso.TabIndex = 17;
            this.btnProcurarDiscCurso.Text = "Procurar";
            this.btnProcurarDiscCurso.UseVisualStyleBackColor = true;
            this.btnProcurarDiscCurso.Click += new System.EventHandler(this.btnProcurarDiscCurso_Click);
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
            // grdListaDisciplina2
            // 
            this.grdListaDisciplina2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDisciplina2.Location = new System.Drawing.Point(41, 100);
            this.grdListaDisciplina2.Name = "grdListaDisciplina2";
            this.grdListaDisciplina2.Size = new System.Drawing.Size(1093, 394);
            this.grdListaDisciplina2.TabIndex = 14;
            // 
            // FrmListaDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 593);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblListaDisicplinas);
            this.DoubleBuffered = true;
            this.Name = "FrmListaDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Disciplinas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaDisciplinas_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplinas)).EndInit();
            this.tabPorCod.ResumeLayout(false);
            this.tabPorCod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina)).EndInit();
            this.tabPorNome.ResumeLayout(false);
            this.tabPorNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina1)).EndInit();
            this.tabPorCurso.ResumeLayout(false);
            this.tabPorCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDisciplina2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaDisicplinas;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPorCod;
        private System.Windows.Forms.Button btnLimparDisc;
        private System.Windows.Forms.Button btnProcurarDisc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdListaDisciplina;
        private System.Windows.Forms.TextBox txtProcurarCodDisc;
        private System.Windows.Forms.TabPage tabPorNome;
        private System.Windows.Forms.Button btnLimparNomeDisc;
        private System.Windows.Forms.TextBox txtProcurarNomeDisc;
        private System.Windows.Forms.DataGridView grdListaDisciplina1;
        private System.Windows.Forms.Button btnProcurarNomeDisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPorCurso;
        private System.Windows.Forms.ComboBox cboPesquisaCursoDisc;
        private System.Windows.Forms.Button btnProcurarDiscCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdListaDisciplina2;
        private System.Windows.Forms.Button btnLimparDiscCurso;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.DataGridView grdListaDisciplinas;
    }
}