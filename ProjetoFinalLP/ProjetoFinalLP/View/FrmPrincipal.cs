using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalLP
{
    public partial class FrmPrincipal : Form
    {
        csLogin login = new csLogin();
        public string loginUsuario;
        public string senhaUsuario;

        public FrmPrincipal(string login, string senha)
        {
            InitializeComponent();
            loginUsuario = login;
            senhaUsuario = senha;
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            FrmCadastroProfessor fCadastroProfessor = new FrmCadastroProfessor();
            fCadastroProfessor.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            FrmCadastroDisciplina fCadastroDisciplina = new FrmCadastroDisciplina();
            fCadastroDisciplina.Show();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            FrmCadastroCurso fCadastroCurso= new FrmCadastroCurso();
            fCadastroCurso.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProfessor fCadastroProfessor = new FrmCadastroProfessor();
            fCadastroProfessor.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCurso fCadastroCurso = new FrmCadastroCurso();
            fCadastroCurso.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroDisciplina fCadastroDisciplina = new FrmCadastroDisciplina();
            fCadastroDisciplina.Show();
        }

        private void btnListaDisicplina_Click(object sender, EventArgs e)
        {
            FrmListaDisciplinas fListaDisciplinas = new FrmListaDisciplinas();
            fListaDisciplinas.Show();
        }

        private void btnListaProfessores_Click(object sender, EventArgs e)
        {
            FrmListaProfessores fListaProfessores = new FrmListaProfessores();
            fListaProfessores.Show();
        }

        private void btnListaCursos_Click(object sender, EventArgs e)
        {
            FrmListaCurso fListaCurso = new FrmListaCurso();
            fListaCurso.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            login.selectTipoUsuario(loginUsuario, senhaUsuario);
            if (login.tipoUsuario == "Aluno")
            {
                btnCadastrarCurso.Enabled = false;
                btnCadastrarDisciplina.Enabled = false;
                btnCadastrarProfessor.Enabled = false;
                professorToolStripMenuItem.Enabled = false;
                cursoToolStripMenuItem.Enabled = false;
                disciplinaToolStripMenuItem.Enabled = false;
            }
            else if (login.tipoUsuario == "Professor")
            {
                btnCadastrarCurso.Enabled = false;
                btnCadastrarDisciplina.Enabled = false;
                cursoToolStripMenuItem.Enabled = false ;
                disciplinaToolStripMenuItem.Enabled = false;
            }
            else if (login.tipoUsuario == "Coordenador")
            {
                cursoToolStripMenuItem.Enabled = false;
                btnCadastrarCurso.Enabled = false;
            }
        }
    }
}
