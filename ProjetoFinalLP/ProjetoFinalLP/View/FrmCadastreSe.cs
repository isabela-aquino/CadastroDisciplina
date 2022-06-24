using ProjetoFinalLP.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoFinalLP
{
    public partial class FrmCadastreSe : Form
    {
        csCadastrarSe cadastrar = new csCadastrarSe();
        csMD5 md5 = new csMD5();

        private void salvarCadastro()
        {
            string SenhaCripto = md5.RetornarMD5(txtSenha.Text);
            cadastrar.setCadastraLogin(txtLogin.Text);
            cadastrar.setCadastraPassword(SenhaCripto);
            cadastrar.setTipoUsuario(cboTipoUsuario.Text);
            

            if (cadastrar.verificarLogin() == false)
            {
                MessageBox.Show("Usuário já cadastrado no Sistema", "Aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                cboTipoUsuario.Text = "";
                txtLogin.Focus();
            }
            else
            {
                cadastrar.cadastrarUsuario();
                MessageBox.Show("Cadastro Realizado com sucesso!", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                Close();
            }
        }

        private bool validaDados()
        {
            if (txtLogin.Text.Trim().Length <= 3)
            {
                MessageBox.Show("O Login é obrigatório, informe", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtLogin.Focus();
                return false;
            }
            if (txtSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("A senha precisa ter mais de 6 caracteres!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtSenha.Focus();
                return false;
            }
            if (txtSenha.Text != txtConfirmarSenha.Text) {
                MessageBox.Show("As senhas precisam ser iguais!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtConfirmarSenha.Text = "";
                txtConfirmarSenha.Focus();
                return false;
            }
            
            return true;
        }

        public FrmCadastreSe()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (validaDados() == true)
            {
                salvarCadastro();
            }
        }
    }
}
