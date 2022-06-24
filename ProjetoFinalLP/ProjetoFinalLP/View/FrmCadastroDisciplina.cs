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
    public partial class FrmCadastroDisciplina : Form
    {
        csDisciplina disciplina = new csDisciplina();
        private void habilitaControles(bool status)
        {
            txtNomeDisciplina.Enabled = status;
            txtQtdAulas.Enabled = status;
            txtCodProfDisc.Enabled = status;
            txtCodCursoDisc.Enabled = status;
            txtDataInicio.Enabled = status;
            txtDataEncerramento.Enabled = status;
        }

        private void limparControles()
        {
            txtNomeDisciplina.Text = "";
            txtCodDisciplina.Text = "";
            txtQtdAulas.Text = "";
            txtCodProfDisc.Text = "";
            txtCodCursoDisc.Text = "";
            txtDataInicio.Text = "";
            txtDataEncerramento.Text = "";
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
            grdDisciplina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDisciplina.Columns[0].HeaderText = "Código";
            grdDisciplina.Columns[1].HeaderText = "Nome";

            grdDisciplina.Columns[0].Width = 60;
            grdDisciplina.Columns[1].Width = 280;
        }

        private void excluiDisciplina()
        {
            disciplina.delete();
        }

        private void salvarDisciplina()
        {
            disciplina.setDisciplinaNome(txtNomeDisciplina.Text);
            disciplina.setCodCursoDisc(Convert.ToInt32(txtCodCursoDisc.Text));
            disciplina.setCodProfDisc(Convert.ToInt32(txtCodProfDisc.Text));
            disciplina.setQtdAulas(Convert.ToInt16(txtQtdAulas.Text));
            disciplina.setDataInicio(Convert.ToDateTime(txtDataInicio.Text));
            disciplina.setDataEncerramento(Convert.ToDateTime(txtDataEncerramento.Text));

            if (disciplina.getDisciplinaId() == 0)
            {
                try
                {
                    disciplina.inserir();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                disciplina.update();
            }
        }

        private void preencheGrid()
        {
            grdDisciplina.DataSource = disciplina.select();
            formataGrid();
        }

        private void preencheDadosControle()
        {
            disciplina.selectDisciplina();
            txtCodDisciplina.Text = Convert.ToString(disciplina.getDisciplinaId());
            txtNomeDisciplina.Text = disciplina.getDisciplinaNome();
            txtQtdAulas.Text = Convert.ToString(disciplina.getQtdAulas());
            txtCodCursoDisc.Text = Convert.ToString(disciplina.getCodCursoDisc());
            txtCodProfDisc.Text = Convert.ToString(disciplina.getCodProfDisc());
            txtDataEncerramento.Text = Convert.ToString(disciplina.getDataEncerramento());
            txtDataInicio.Text = Convert.ToString(disciplina.getDataInicio());
       
        }

        private bool validaDados()
        {
            if (txtNomeDisciplina.Text.Trim().Length <= 5)
            {
                MessageBox.Show("Nome do disciplina é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNomeDisciplina.Focus();
                return false;
            }
            if (txtQtdAulas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Qtd de aula da disciplina é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtQtdAulas.Focus();
                return false;
            }

            if (Convert.ToDateTime(txtDataInicio.Text) <= DateTime.Today)
            {
                MessageBox.Show("A data precisa ser maior que a atual", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDataInicio.Focus();
                return false;

            }

            if (Convert.ToDateTime(txtDataEncerramento.Text) <= Convert.ToDateTime(txtDataInicio.Text))
            {
                MessageBox.Show("A data de encerramento precisa ser maior que a de inicio", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtDataEncerramento.Focus();
                return false;

            }

            return true;
        }

        public FrmCadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            disciplina.setDisciplinaId(0);
            habilitaControles(true);
            limparControles();
            gerenciaBotoesBarra(false);
        }

        private void FrmCadastroDisciplina_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            gerenciaBotoesBarra(true);
            preencheGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (disciplina.getDisciplinaId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir a Disciplina selecionado?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiDisciplina();
                    limparControles();
                    preencheGrid();
                }
            }
            else
            {
                DialogResult retorno = MessageBox.Show("Selecione uma Disciplina para excluir!", "Aviso!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados() == true)
            {
                salvarDisciplina();
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
                preencheGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a edição dos dados da Disciplina selecionado?", "Exclusão",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdDisciplina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            disciplina.setDisciplinaId(Convert.ToInt32(grdDisciplina.Rows[grdDisciplina.CurrentRow.Index].Cells[0].Value.ToString()));
            preencheDadosControle();
        }
    }
}
