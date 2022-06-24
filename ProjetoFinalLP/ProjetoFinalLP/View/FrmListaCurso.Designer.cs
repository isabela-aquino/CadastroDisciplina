namespace ProjetoFinalLP
{
    partial class FrmListaCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCurso));
            this.lblListaCursos = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeral = new System.Windows.Forms.TabPage();
            this.grdListaCursos = new System.Windows.Forms.DataGridView();
            this.tabPorCod = new System.Windows.Forms.TabPage();
            this.btnLimparCurso = new System.Windows.Forms.Button();
            this.btnProcurarCurso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grdListaCurso = new System.Windows.Forms.DataGridView();
            this.txtProcurarCodCurso = new System.Windows.Forms.TextBox();
            this.tabPorNome = new System.Windows.Forms.TabPage();
            this.btnLimparNomeCurso = new System.Windows.Forms.Button();
            this.txtProcurarNomeCurso = new System.Windows.Forms.TextBox();
            this.grdListaCurso1 = new System.Windows.Forms.DataGridView();
            this.btnProcurarNomeCurso = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCursos)).BeginInit();
            this.tabPorCod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCurso)).BeginInit();
            this.tabPorNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCurso1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaCursos
            // 
            this.lblListaCursos.AutoSize = true;
            this.lblListaCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblListaCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCursos.Location = new System.Drawing.Point(490, 28);
            this.lblListaCursos.Name = "lblListaCursos";
            this.lblListaCursos.Size = new System.Drawing.Size(218, 31);
            this.lblListaCursos.TabIndex = 14;
            this.lblListaCursos.Text = "Lista de Cursos";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeral);
            this.tabControl.Controls.Add(this.tabPorCod);
            this.tabControl.Controls.Add(this.tabPorNome);
            this.tabControl.Location = new System.Drawing.Point(76, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1178, 540);
            this.tabControl.TabIndex = 16;
            // 
            // tabGeral
            // 
            this.tabGeral.Controls.Add(this.grdListaCursos);
            this.tabGeral.Location = new System.Drawing.Point(4, 22);
            this.tabGeral.Name = "tabGeral";
            this.tabGeral.Size = new System.Drawing.Size(1170, 514);
            this.tabGeral.TabIndex = 2;
            this.tabGeral.Text = "Geral";
            this.tabGeral.UseVisualStyleBackColor = true;
            // 
            // grdListaCursos
            // 
            this.grdListaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCursos.Location = new System.Drawing.Point(39, 31);
            this.grdListaCursos.Name = "grdListaCursos";
            this.grdListaCursos.Size = new System.Drawing.Size(1093, 487);
            this.grdListaCursos.TabIndex = 14;
            // 
            // tabPorCod
            // 
            this.tabPorCod.Controls.Add(this.btnLimparCurso);
            this.tabPorCod.Controls.Add(this.btnProcurarCurso);
            this.tabPorCod.Controls.Add(this.label6);
            this.tabPorCod.Controls.Add(this.grdListaCurso);
            this.tabPorCod.Controls.Add(this.txtProcurarCodCurso);
            this.tabPorCod.Location = new System.Drawing.Point(4, 22);
            this.tabPorCod.Name = "tabPorCod";
            this.tabPorCod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorCod.Size = new System.Drawing.Size(1170, 514);
            this.tabPorCod.TabIndex = 0;
            this.tabPorCod.Text = "Por Código";
            this.tabPorCod.UseVisualStyleBackColor = true;
            // 
            // btnLimparCurso
            // 
            this.btnLimparCurso.Location = new System.Drawing.Point(670, 23);
            this.btnLimparCurso.Name = "btnLimparCurso";
            this.btnLimparCurso.Size = new System.Drawing.Size(108, 33);
            this.btnLimparCurso.TabIndex = 14;
            this.btnLimparCurso.Text = "Limpar";
            this.btnLimparCurso.UseVisualStyleBackColor = true;
            this.btnLimparCurso.Click += new System.EventHandler(this.btnLimparCurso_Click);
            // 
            // btnProcurarCurso
            // 
            this.btnProcurarCurso.Location = new System.Drawing.Point(546, 23);
            this.btnProcurarCurso.Name = "btnProcurarCurso";
            this.btnProcurarCurso.Size = new System.Drawing.Size(108, 33);
            this.btnProcurarCurso.TabIndex = 3;
            this.btnProcurarCurso.Text = "Procurar";
            this.btnProcurarCurso.UseVisualStyleBackColor = true;
            this.btnProcurarCurso.Click += new System.EventHandler(this.btnProcurarCurso_Click);
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
            // grdListaCurso
            // 
            this.grdListaCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCurso.Location = new System.Drawing.Point(33, 105);
            this.grdListaCurso.Name = "grdListaCurso";
            this.grdListaCurso.Size = new System.Drawing.Size(1093, 389);
            this.grdListaCurso.TabIndex = 13;
            // 
            // txtProcurarCodCurso
            // 
            this.txtProcurarCodCurso.Location = new System.Drawing.Point(93, 30);
            this.txtProcurarCodCurso.Name = "txtProcurarCodCurso";
            this.txtProcurarCodCurso.Size = new System.Drawing.Size(435, 20);
            this.txtProcurarCodCurso.TabIndex = 1;
            // 
            // tabPorNome
            // 
            this.tabPorNome.Controls.Add(this.btnLimparNomeCurso);
            this.tabPorNome.Controls.Add(this.txtProcurarNomeCurso);
            this.tabPorNome.Controls.Add(this.grdListaCurso1);
            this.tabPorNome.Controls.Add(this.btnProcurarNomeCurso);
            this.tabPorNome.Controls.Add(this.label7);
            this.tabPorNome.Location = new System.Drawing.Point(4, 22);
            this.tabPorNome.Name = "tabPorNome";
            this.tabPorNome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorNome.Size = new System.Drawing.Size(1170, 514);
            this.tabPorNome.TabIndex = 1;
            this.tabPorNome.Text = "Por Nome";
            this.tabPorNome.UseVisualStyleBackColor = true;
            // 
            // btnLimparNomeCurso
            // 
            this.btnLimparNomeCurso.Location = new System.Drawing.Point(600, 24);
            this.btnLimparNomeCurso.Name = "btnLimparNomeCurso";
            this.btnLimparNomeCurso.Size = new System.Drawing.Size(110, 28);
            this.btnLimparNomeCurso.TabIndex = 16;
            this.btnLimparNomeCurso.Text = "Limpar";
            this.btnLimparNomeCurso.UseVisualStyleBackColor = true;
            this.btnLimparNomeCurso.Click += new System.EventHandler(this.btnLimparNomeCurso_Click);
            // 
            // txtProcurarNomeCurso
            // 
            this.txtProcurarNomeCurso.Location = new System.Drawing.Point(77, 29);
            this.txtProcurarNomeCurso.Name = "txtProcurarNomeCurso";
            this.txtProcurarNomeCurso.Size = new System.Drawing.Size(381, 20);
            this.txtProcurarNomeCurso.TabIndex = 15;
            // 
            // grdListaCurso1
            // 
            this.grdListaCurso1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaCurso1.Location = new System.Drawing.Point(33, 105);
            this.grdListaCurso1.Name = "grdListaCurso1";
            this.grdListaCurso1.Size = new System.Drawing.Size(1093, 382);
            this.grdListaCurso1.TabIndex = 14;
            // 
            // btnProcurarNomeCurso
            // 
            this.btnProcurarNomeCurso.Location = new System.Drawing.Point(475, 24);
            this.btnProcurarNomeCurso.Name = "btnProcurarNomeCurso";
            this.btnProcurarNomeCurso.Size = new System.Drawing.Size(110, 28);
            this.btnProcurarNomeCurso.TabIndex = 2;
            this.btnProcurarNomeCurso.Text = "Procurar";
            this.btnProcurarNomeCurso.UseVisualStyleBackColor = true;
            this.btnProcurarNomeCurso.Click += new System.EventHandler(this.btnProcurarNomeCurso_Click);
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
            // FrmListaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 610);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblListaCursos);
            this.DoubleBuffered = true;
            this.Name = "FrmListaCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmListaCurso_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCursos)).EndInit();
            this.tabPorCod.ResumeLayout(false);
            this.tabPorCod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCurso)).EndInit();
            this.tabPorNome.ResumeLayout(false);
            this.tabPorNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaCurso1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblListaCursos;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPorCod;
        private System.Windows.Forms.Button btnLimparCurso;
        private System.Windows.Forms.Button btnProcurarCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdListaCurso;
        private System.Windows.Forms.TextBox txtProcurarCodCurso;
        private System.Windows.Forms.TabPage tabPorNome;
        private System.Windows.Forms.Button btnLimparNomeCurso;
        private System.Windows.Forms.TextBox txtProcurarNomeCurso;
        private System.Windows.Forms.DataGridView grdListaCurso1;
        private System.Windows.Forms.Button btnProcurarNomeCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabGeral;
        private System.Windows.Forms.DataGridView grdListaCursos;
    }
}