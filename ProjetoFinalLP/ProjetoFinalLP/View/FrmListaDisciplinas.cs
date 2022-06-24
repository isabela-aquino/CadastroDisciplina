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
    public partial class FrmListaDisciplinas : Form
    {
        csDisciplina disciplina = new csDisciplina();
        csCursos curso = new csCursos();
        

        private void PreencheComboboxCurso()
        {
            cboPesquisaCursoDisc.DataSource = curso.select();
            cboPesquisaCursoDisc.DisplayMember = "nome_curso";
            cboPesquisaCursoDisc.ValueMember = "cod_curso";

            cboPesquisaCursoDisc.SelectedIndex = -1;
        }
        private void formataGrid()
        {
            grdListaDisciplinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaDisciplinas.Columns[0].HeaderText = "Id";
            grdListaDisciplinas.Columns[1].HeaderText = "Nome da Disciplina";
            grdListaDisciplinas.Columns[2].HeaderText = "Data de Inicio";
            grdListaDisciplinas.Columns[3].HeaderText = "Data de Encerramento";
            grdListaDisciplinas.Columns[4].HeaderText = "Quantidade de Aulas";
            grdListaDisciplinas.Columns[5].HeaderText = "Nome Professor";
            grdListaDisciplinas.Columns[6].HeaderText = "Nome Curso";

            grdListaDisciplinas.Columns[0].Width = 60;
            grdListaDisciplinas.Columns[1].Width = 200;
            grdListaDisciplinas.Columns[2].Width = 150;
            grdListaDisciplinas.Columns[3].Width = 150;
            grdListaDisciplinas.Columns[4].Width = 150;
            grdListaDisciplinas.Columns[5].Width = 160;
            grdListaDisciplinas.Columns[6].Width = 160;

        }

        private void preencheGrid()
        {
            grdListaDisciplinas.DataSource = disciplina.selectListaDisciplina();

            formataGrid();
        }
        public FrmListaDisciplinas()
        {
            InitializeComponent();
        }

        private void FrmListaDisciplinas_Load(object sender, EventArgs e)
        {
            preencheGrid();
            PreencheComboboxCurso();
        }

        private void btnProcurarDisc_Click(object sender, EventArgs e)
        {
            grdListaDisciplina.DataSource = disciplina.selectCodDisciplina(txtProcurarCodDisc.Text);
            grdListaDisciplina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaDisciplina.Columns[0].HeaderText = "Id";
            grdListaDisciplina.Columns[1].HeaderText = "Nome da Disciplina";
            grdListaDisciplina.Columns[2].HeaderText = "Data de Inicio";
            grdListaDisciplina.Columns[3].HeaderText = "Data de Encerramento";
            grdListaDisciplina.Columns[4].HeaderText = "Quantidade de Aulas";
            grdListaDisciplina.Columns[5].HeaderText = "Nome Professor";
            grdListaDisciplina.Columns[6].HeaderText = "Nome Curso";

            grdListaDisciplina.Columns[0].Width = 60;
            grdListaDisciplina.Columns[1].Width = 200;
            grdListaDisciplina.Columns[2].Width = 150;
            grdListaDisciplina.Columns[3].Width = 150;
            grdListaDisciplina.Columns[4].Width = 150;
            grdListaDisciplina.Columns[5].Width = 160;
            grdListaDisciplina.Columns[6].Width = 160;
        }

        private void btnLimparDisc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaDisciplina.RowCount; i++)
            {
                grdListaDisciplina.Rows[i].DataGridView.Columns.Clear();
            }
            txtProcurarCodDisc.Text = "";
        }

        private void btnProcurarNomeDisc_Click(object sender, EventArgs e)
        {
            grdListaDisciplina1.DataSource = disciplina.selectNomeDisciplina(txtProcurarNomeDisc.Text);

            grdListaDisciplina1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaDisciplina1.Columns[0].HeaderText = "Id";
            grdListaDisciplina1.Columns[1].HeaderText = "Nome da Disciplina";
            grdListaDisciplina1.Columns[2].HeaderText = "Data de Inicio";
            grdListaDisciplina1.Columns[3].HeaderText = "Data de Encerramento";
            grdListaDisciplina1.Columns[4].HeaderText = "Quantidade de Aulas";
            grdListaDisciplina1.Columns[5].HeaderText = "Nome Professor";
            grdListaDisciplina1.Columns[6].HeaderText = "Nome Curso";

            grdListaDisciplina1.Columns[0].Width = 60;
            grdListaDisciplina1.Columns[1].Width = 200;
            grdListaDisciplina1.Columns[2].Width = 150;
            grdListaDisciplina1.Columns[3].Width = 150;
            grdListaDisciplina1.Columns[4].Width = 150;
            grdListaDisciplina1.Columns[5].Width = 160;
            grdListaDisciplina1.Columns[6].Width = 160;
        }

        private void btnLimparNomeDisc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaDisciplina1.RowCount; i++)
            {
                grdListaDisciplina1.Rows[i].DataGridView.Columns.Clear();
            }
            txtProcurarNomeDisc.Text = "";
        }

        private void btnProcurarDiscCurso_Click(object sender, EventArgs e)
        {
            grdListaDisciplina2.DataSource = disciplina.selectCursoDisciplina(cboPesquisaCursoDisc.Text);
            grdListaDisciplina2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaDisciplina2.Columns[0].HeaderText = "Id";
            grdListaDisciplina2.Columns[1].HeaderText = "Nome da Disciplina";
            grdListaDisciplina2.Columns[2].HeaderText = "Data de Inicio";
            grdListaDisciplina2.Columns[3].HeaderText = "Data de Encerramento";
            grdListaDisciplina2.Columns[4].HeaderText = "Quantidade de Aulas";
            
            grdListaDisciplina2.Columns[5].HeaderText = "Nome Curso";
            grdListaDisciplina2.Columns[6].HeaderText = "Nome Professor";

            grdListaDisciplina2.Columns[0].Width = 60;
            grdListaDisciplina2.Columns[1].Width = 200;
            grdListaDisciplina2.Columns[2].Width = 150;
            grdListaDisciplina2.Columns[3].Width = 150;
            grdListaDisciplina2.Columns[4].Width = 150;
            grdListaDisciplina2.Columns[5].Width = 160;
            grdListaDisciplina2.Columns[6].Width = 160;
        }

        private void btnLimparDiscCurso_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaDisciplina2.RowCount; i++)
            {
                grdListaDisciplina2.Rows[i].DataGridView.Columns.Clear();
            }

            cboPesquisaCursoDisc.Text = "";
        }
    }
}
