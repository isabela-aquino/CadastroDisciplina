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
    public partial class FrmListaCurso : Form
    {
        csCursos cursos = new csCursos();
       

        private void formataGrid()
        {
            grdListaCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaCursos.Columns[0].HeaderText = "Id";
            grdListaCursos.Columns[1].HeaderText = "Nome do Curso";
            grdListaCursos.Columns[2].HeaderText = "Descrição";
            grdListaCursos.Columns[3].HeaderText = "Qtd. Semestre";
            grdListaCursos.Columns[4].HeaderText = "Qtd. Disciplina";

            grdListaCursos.Columns[0].Width = 50;
            grdListaCursos.Columns[1].Width = 270;
            grdListaCursos.Columns[2].Width = 380;
            grdListaCursos.Columns[3].Width = 170;
            grdListaCursos.Columns[4].Width = 160;
        }

        private void preencheGrid()
        {
            grdListaCursos.DataSource = cursos.selectListaCurso();
            formataGrid();
        }

        public FrmListaCurso()
        {
            InitializeComponent();
        }

        private void FrmListaCurso_Load(object sender, EventArgs e)
        {
            preencheGrid();
        }

        private void btnProcurarCurso_Click(object sender, EventArgs e)
        {
            grdListaCurso.DataSource = cursos.selectCodCurso(txtProcurarCodCurso.Text);

            grdListaCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaCurso.Columns[0].HeaderText = "Id";
            grdListaCurso.Columns[1].HeaderText = "Nome do Curso";
            grdListaCurso.Columns[2].HeaderText = "Descrição";
            grdListaCurso.Columns[3].HeaderText = "Qtd. Semestre";
            grdListaCurso.Columns[4].HeaderText = "Qtd. Disciplina";

            grdListaCurso.Columns[0].Width = 50;
            grdListaCurso.Columns[1].Width = 270;
            grdListaCurso.Columns[2].Width = 380;
            grdListaCurso.Columns[3].Width = 170;
            grdListaCurso.Columns[4].Width = 160;
        }

        private void btnLimparCurso_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaCurso.RowCount; i++)
            {
                grdListaCurso.Rows[i].DataGridView.Columns.Clear();
            }
            txtProcurarCodCurso.Text = "";
        }

        private void btnProcurarNomeCurso_Click(object sender, EventArgs e)
        {
            grdListaCurso1.DataSource = cursos.selectNomeCurso(txtProcurarNomeCurso.Text);

            grdListaCurso1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaCurso1.Columns[0].HeaderText = "Id";
            grdListaCurso1.Columns[1].HeaderText = "Nome do Curso";
            grdListaCurso1.Columns[2].HeaderText = "Descrição";
            grdListaCurso1.Columns[3].HeaderText = "Qtd. Semestre";
            grdListaCurso1.Columns[4].HeaderText = "Qtd. Disciplina";

            grdListaCurso1.Columns[0].Width = 50;
            grdListaCurso1.Columns[1].Width = 270;
            grdListaCurso1.Columns[2].Width = 380;
            grdListaCurso1.Columns[3].Width = 170;
            grdListaCurso1.Columns[4].Width = 160;
        }

        private void btnLimparNomeCurso_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaCurso1.RowCount; i++)
            {
                grdListaCurso1.Rows[i].DataGridView.Columns.Clear();
            }
            txtProcurarNomeCurso.Text = "";
        }
    }
}
