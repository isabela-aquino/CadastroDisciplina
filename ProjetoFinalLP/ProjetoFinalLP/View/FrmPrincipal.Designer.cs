namespace ProjetoFinalLP
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnListaCursos = new System.Windows.Forms.Button();
            this.btnListaProfessores = new System.Windows.Forms.Button();
            this.btnListaDisicplina = new System.Windows.Forms.Button();
            this.btnCadastrarDisciplina = new System.Windows.Forms.Button();
            this.btnCadastrarCurso = new System.Windows.Forms.Button();
            this.btnCadastrarProfessor = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaCursos
            // 
            this.btnListaCursos.BackColor = System.Drawing.Color.White;
            this.btnListaCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCursos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnListaCursos.Image = ((System.Drawing.Image)(resources.GetObject("btnListaCursos.Image")));
            this.btnListaCursos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListaCursos.Location = new System.Drawing.Point(595, 348);
            this.btnListaCursos.Name = "btnListaCursos";
            this.btnListaCursos.Size = new System.Drawing.Size(138, 123);
            this.btnListaCursos.TabIndex = 15;
            this.btnListaCursos.Text = "Lista de Curso";
            this.btnListaCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaCursos.UseVisualStyleBackColor = false;
            this.btnListaCursos.Click += new System.EventHandler(this.btnListaCursos_Click);
            // 
            // btnListaProfessores
            // 
            this.btnListaProfessores.BackColor = System.Drawing.Color.White;
            this.btnListaProfessores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProfessores.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnListaProfessores.Image = ((System.Drawing.Image)(resources.GetObject("btnListaProfessores.Image")));
            this.btnListaProfessores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListaProfessores.Location = new System.Drawing.Point(372, 348);
            this.btnListaProfessores.Name = "btnListaProfessores";
            this.btnListaProfessores.Size = new System.Drawing.Size(138, 123);
            this.btnListaProfessores.TabIndex = 14;
            this.btnListaProfessores.Text = "Lista de Professores";
            this.btnListaProfessores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaProfessores.UseVisualStyleBackColor = false;
            this.btnListaProfessores.Click += new System.EventHandler(this.btnListaProfessores_Click);
            // 
            // btnListaDisicplina
            // 
            this.btnListaDisicplina.BackColor = System.Drawing.Color.White;
            this.btnListaDisicplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaDisicplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDisicplina.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnListaDisicplina.Image = ((System.Drawing.Image)(resources.GetObject("btnListaDisicplina.Image")));
            this.btnListaDisicplina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListaDisicplina.Location = new System.Drawing.Point(813, 348);
            this.btnListaDisicplina.Name = "btnListaDisicplina";
            this.btnListaDisicplina.Size = new System.Drawing.Size(138, 123);
            this.btnListaDisicplina.TabIndex = 13;
            this.btnListaDisicplina.Text = "Lista de Disciplinas";
            this.btnListaDisicplina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListaDisicplina.UseVisualStyleBackColor = false;
            this.btnListaDisicplina.Click += new System.EventHandler(this.btnListaDisicplina_Click);
            // 
            // btnCadastrarDisciplina
            // 
            this.btnCadastrarDisciplina.BackColor = System.Drawing.Color.White;
            this.btnCadastrarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarDisciplina.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarDisciplina.Image")));
            this.btnCadastrarDisciplina.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarDisciplina.Location = new System.Drawing.Point(813, 189);
            this.btnCadastrarDisciplina.Name = "btnCadastrarDisciplina";
            this.btnCadastrarDisciplina.Size = new System.Drawing.Size(138, 123);
            this.btnCadastrarDisciplina.TabIndex = 11;
            this.btnCadastrarDisciplina.Text = "Cadastro de Disciplina";
            this.btnCadastrarDisciplina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarDisciplina.UseVisualStyleBackColor = false;
            this.btnCadastrarDisciplina.Click += new System.EventHandler(this.btnCadastrarDisciplina_Click);
            // 
            // btnCadastrarCurso
            // 
            this.btnCadastrarCurso.BackColor = System.Drawing.Color.White;
            this.btnCadastrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCurso.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCurso.Image")));
            this.btnCadastrarCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarCurso.Location = new System.Drawing.Point(595, 189);
            this.btnCadastrarCurso.Name = "btnCadastrarCurso";
            this.btnCadastrarCurso.Size = new System.Drawing.Size(138, 123);
            this.btnCadastrarCurso.TabIndex = 10;
            this.btnCadastrarCurso.Text = "Cadastro de Curso";
            this.btnCadastrarCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCurso.UseVisualStyleBackColor = false;
            this.btnCadastrarCurso.Click += new System.EventHandler(this.btnCadastrarCurso_Click);
            // 
            // btnCadastrarProfessor
            // 
            this.btnCadastrarProfessor.BackColor = System.Drawing.Color.White;
            this.btnCadastrarProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProfessor.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCadastrarProfessor.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarProfessor.Image")));
            this.btnCadastrarProfessor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarProfessor.Location = new System.Drawing.Point(372, 189);
            this.btnCadastrarProfessor.Name = "btnCadastrarProfessor";
            this.btnCadastrarProfessor.Size = new System.Drawing.Size(138, 123);
            this.btnCadastrarProfessor.TabIndex = 9;
            this.btnCadastrarProfessor.Text = "Cadastro de Professor";
            this.btnCadastrarProfessor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarProfessor.UseVisualStyleBackColor = false;
            this.btnCadastrarProfessor.Click += new System.EventHandler(this.btnCadastrarProfessor_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mnuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuPrincipal.BackgroundImage")));
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1370, 38);
            this.mnuPrincipal.TabIndex = 17;
            this.mnuPrincipal.Text = "menuPrincipal";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.disciplinaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.cursoToolStripMenuItem.Text = "Curso";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 659);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.btnListaCursos);
            this.Controls.Add(this.btnListaProfessores);
            this.Controls.Add(this.btnListaDisicplina);
            this.Controls.Add(this.btnCadastrarDisciplina);
            this.Controls.Add(this.btnCadastrarCurso);
            this.Controls.Add(this.btnCadastrarProfessor);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroDisiciplina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListaCursos;
        private System.Windows.Forms.Button btnListaProfessores;
        private System.Windows.Forms.Button btnListaDisicplina;
        private System.Windows.Forms.Button btnCadastrarDisciplina;
        private System.Windows.Forms.Button btnCadastrarCurso;
        private System.Windows.Forms.Button btnCadastrarProfessor;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

