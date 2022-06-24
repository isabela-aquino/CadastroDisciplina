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
    public partial class FrmCadastroCurso : Form
    {
        csCursos cursos = new csCursos();
        private void habilitaControles(bool status)
        {
            txtNomeCurso.Enabled = status;
            txtDescricaoCurso.Enabled = status;
            nudQtdSemestre.Enabled = status;
        }

        private void limparControles()
        {
            txtCodCurso.Text = "";
            txtNomeCurso.Text = "";
            txtDescricaoCurso.Text = "";
            nudQtdSemestre.Text = "";
        }
        private void gerenciaBotoesBarra(bool status)
        {
            btnNovo.Enabled = status;
            btnAlterar.Enabled = status;
            btnExcluir.Enabled = status;
            btnSair.Enabled = status;
            btnSalvar.Enabled = !status;
            btnCancelar.Enabled = !status;
        }

        private void formataGrid()
        {
            grdCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdCurso.Columns[0].HeaderText = "Código";
            grdCurso.Columns[1].HeaderText = "Nome";

            grdCurso.Columns[0].Width = 60;
            grdCurso.Columns[1].Width = 280;
        }

        private void excluiCurso()
        {
            cursos.delete();
        }

        private void salvarCurso()
        {
            cursos.setCursoNome(txtNomeCurso.Text);
            cursos.setCursoDescricao(txtDescricaoCurso.Text);
            cursos.setCursoQtdSemestre(Convert.ToInt16(nudQtdSemestre.Text));

            if (cursos.getCursoId() == 0)
            {
                try
                {
                    cursos.inserir();
                }
                catch (Exception e)
                {
                    MessageBox.Show("O Curso " + txtNomeCurso.Text + " já está cadastrado no nosso Banco de Dados \n" + e.Message,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                cursos.update();
            }
        }

        private void preencheGrid()
        {
            grdCurso.DataSource = cursos.select();
            formataGrid();
        }

        private void preencheDadosControle()
        {
            cursos.selectCurso();
            txtCodCurso.Text = Convert.ToString(cursos.getCursoId());
            txtNomeCurso.Text = cursos.getCursoNome();
            txtDescricaoCurso.Text = cursos.getCursoDescricao();
            nudQtdSemestre.Text = Convert.ToString(cursos.getCursoQtdSemestre());

        }

        private bool validaDados()
        {
            if (txtNomeCurso.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Nome do Curso é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNomeCurso.Focus();
                return false;
            }
            if (nudQtdSemestre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Qtd de semestres é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                nudQtdSemestre.Focus();
                return false;
            }
            return true;
        }
        public FrmCadastroCurso()
        {
            InitializeComponent();
        }

        private void FrmCadastroCurso_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            gerenciaBotoesBarra(true);
            preencheGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cursos.setCursoId(0);
            habilitaControles(true);
            limparControles();
            gerenciaBotoesBarra(false);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados() == true)
            {
                salvarCurso();
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
                preencheGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a edição dos dados do Curso selecionado?", "Exclusão",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cursos.getCursoId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir o Curso selecionado?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiCurso();
                    limparControles();
                    preencheGrid();
                }
            }
            else
            {
                DialogResult retorno = MessageBox.Show("Selecione um curso para excluir!", "Aviso!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cursos.setCursoId(Convert.ToInt32(grdCurso.Rows[grdCurso.CurrentRow.Index].Cells[0].Value.ToString()));
            preencheDadosControle();
        }
    }
}
