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
    public partial class FrmListaProfessores : Form
    {
        csProfessores professor = new csProfessores();

        csCursos curso = new csCursos();

        public Int32 mes;

        private void PreencheComboboxCurso()
        {
            cboPesquisaCurso.DataSource = curso.select();
            cboPesquisaCurso.DisplayMember = "nome_curso";
            cboPesquisaCurso.ValueMember = "cod_curso";

            cboPesquisaCurso.SelectedIndex = -1;
        }

        private void formataGrid()
        {
            grdListaProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaProfessores.Columns[0].HeaderText = "Id";
            grdListaProfessores.Columns[1].HeaderText = "Nome do Professor";
            grdListaProfessores.Columns[2].HeaderText = "Data de Nascimento";
            grdListaProfessores.Columns[3].HeaderText = "salario";

            grdListaProfessores.Columns[0].Width = 150;
            grdListaProfessores.Columns[1].Width = 330;
            grdListaProfessores.Columns[2].Width = 280;
            grdListaProfessores.Columns[3].Width = 280;
        }

        private void preencheGrid()
        {
            grdListaProfessores.DataSource = professor.selectListaProfessor();
           
            formataGrid();
        }
        public FrmListaProfessores()
        {
            InitializeComponent();
        }

        private void frmListaProfessores_Load(object sender, EventArgs e)
        {
            preencheGrid();
            PreencheComboboxCurso();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            grdListaProfessor.DataSource = professor.selectCodProfessor(txtProcurarCod.Text);

            grdListaProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaProfessor.Columns[0].HeaderText = "Id";
            grdListaProfessor.Columns[1].HeaderText = "Nome do Professor";
            grdListaProfessor.Columns[2].HeaderText = "Data de Nascimento";
            grdListaProfessor.Columns[3].HeaderText = "salario";

            grdListaProfessor.Columns[0].Width = 150;
            grdListaProfessor.Columns[1].Width = 335;
            grdListaProfessor.Columns[2].Width = 280;
            grdListaProfessor.Columns[3].Width = 280;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaProfessor.RowCount; i++)
            {
                grdListaProfessor.Rows[i].DataGridView.Columns.Clear();
            }

            txtProcurarCod.Text = "";
        }

        private void btnProcurar1_Click(object sender, EventArgs e)
        {
            
            grdProfessor2.DataSource = professor.selectCursoProfessor(cboPesquisaCurso.Text);
            grdProfessor2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProfessor2.Columns[0].HeaderText = "Id";
            grdProfessor2.Columns[1].HeaderText = "Nome do Professor";
            grdProfessor2.Columns[2].HeaderText = "Data de Nascimento";
            grdProfessor2.Columns[3].HeaderText = "salario";

            grdProfessor2.Columns[0].Width = 150;
            grdProfessor2.Columns[1].Width = 335;
            grdProfessor2.Columns[2].Width = 280;
            grdProfessor2.Columns[3].Width = 280;
        }

        private void btnProcurarNome_Click(object sender, EventArgs e)
        {
            grdListaProfessor1.DataSource = professor.selectNomeProfessor(txtProcurarNome.Text);
            
            grdListaProfessor1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaProfessor1.Columns[0].HeaderText = "Id";
            grdListaProfessor1.Columns[1].HeaderText = "Nome do Professor";
            grdListaProfessor1.Columns[2].HeaderText = "Data de Nascimento";
            grdListaProfessor1.Columns[3].HeaderText = "salario";

            grdListaProfessor1.Columns[0].Width = 150;
            grdListaProfessor1.Columns[1].Width = 335;
            grdListaProfessor1.Columns[2].Width = 280;
            grdListaProfessor1.Columns[3].Width = 280;
        }

        private void btnLimparNome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaProfessor1.RowCount; i++)
            {
                grdListaProfessor1.Rows[i].DataGridView.Columns.Clear();
            }
            txtProcurarNome.Text = "";
        }

        private void btnProcurarMes_Click(object sender, EventArgs e)
        {

            grdListaProfessor2.DataSource = professor.selectAniversárioProfessor(cboMes.Text);
            grdListaProfessor2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grdListaProfessor2.Columns[0].HeaderText = "Id";
            grdListaProfessor2.Columns[1].HeaderText = "Nome do Professor";
            grdListaProfessor2.Columns[2].HeaderText = "Data de Nascimento";

            grdListaProfessor2.Columns[0].Width = 200;
            grdListaProfessor2.Columns[1].Width = 460;
            grdListaProfessor2.Columns[2].Width = 350;
        }

        private void btnLimparCurso_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdProfessor2.RowCount; i++)
            {
                grdProfessor2.Rows[i].DataGridView.Columns.Clear();
            }
            cboPesquisaCurso.Text = "";
        }

        private void btnLimparAniversario_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdListaProfessor2.RowCount; i++)
            {
                grdListaProfessor2.Rows[i].DataGridView.Columns.Clear();
            }
            cboMes.Text = "";
        }
    }
}
