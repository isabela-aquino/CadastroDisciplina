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
    public partial class FrmCadastroProfessor : Form
    {
        csPessoa pessoa = new csPessoa();
        csProfessores professor = new csProfessores();

        private void habilitaControles(bool status)
        {
            txtNomeProf.Enabled = status;
            txtDataNascimentoProf.Enabled = status;
            txtSalario.Enabled = status;
        }

        private void limparControles()
        {
            txtCodProf.Text = "";
            txtNomeProf.Text = "";
            txtDataNascimentoProf.Text = "";
            txtSalario.Text = "";
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
            grdProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProfessor.Columns[0].HeaderText = "Código";
            grdProfessor.Columns[1].HeaderText = "Nome";

            grdProfessor.Columns[0].Width = 60;
            grdProfessor.Columns[1].Width = 340;
        }

        private void excluiProfessor()
        {
            professor.delete();
        }
        
        private void salvarProfessor()
        {
            professor.setPessoaNome(txtNomeProf.Text);
            professor.setPessoaDataNasc(Convert.ToDateTime(txtDataNascimentoProf.Text));
            professor.setProfessorSalario(Convert.ToDouble(txtSalario.Text));

            if (professor.getProfessorId() == 0)
            {
                try
                {
                    professor.inserir();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, 
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                professor.update();
            }
        }
        private void preencheGrid()
        {
            grdProfessor.DataSource = professor.select();
            formataGrid();
        }

        private void preencheDadosControle()
        {
            professor.selectProfessor();
            txtCodProf.Text = Convert.ToString(professor.getProfessorId());
            txtNomeProf.Text = Convert.ToString(professor.getPessoaNome());
            txtDataNascimentoProf.Text = Convert.ToString(professor.getPessoaDataNasc());
            txtSalario.Text = Convert.ToString(professor.getProfessorSalario());

        }

        private bool validaDados()
        {
            if (txtNomeProf.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Nome do Professor é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNomeProf.Focus();
                return false;
            }
            if (txtSalario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Salario é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtSalario.Focus();
                return false;
            }
            return true;
        }

        public FrmCadastroProfessor()
        {
            InitializeComponent();
        }

        private void FrmCadastroProfessor_Load(object sender, EventArgs e)
        {
            habilitaControles(false);
            gerenciaBotoesBarra(true);
            preencheGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            professor.setProfessorId(0);
            grdProfessor.ClearSelection();
            habilitaControles(true);
            limparControles();
            gerenciaBotoesBarra(false);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            habilitaControles(true);
            gerenciaBotoesBarra(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (professor.getProfessorId() != 0)
            {
                DialogResult retorno = MessageBox.Show("Deseja excluir o Professor selecionado?", "Exclusão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retorno == DialogResult.Yes)
                {
                    excluiProfessor();
                    limparControles();
                    preencheGrid();
                }
            }
            else
            {
                DialogResult retorno = MessageBox.Show("Selecione um Professor para excluir!", "Aviso!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaDados() == true)
            {
                salvarProfessor();
                habilitaControles(false);
                limparControles();
                gerenciaBotoesBarra(true);
                preencheGrid();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar a edição dos dados do Professor selecionado?", "Exclusão",
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

        private void grdProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            professor.setProfessorId(Convert.ToInt32(grdProfessor.Rows[grdProfessor.CurrentRow.Index].Cells[0].Value.ToString()));
            preencheDadosControle();
        }
    }
}
