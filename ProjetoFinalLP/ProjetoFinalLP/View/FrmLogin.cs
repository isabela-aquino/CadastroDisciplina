using ProjetoFinalLP.Controller;
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
    public partial class FrmLogin : Form
    {
        csLogin login = new csLogin();
        csMD5 md5 = new csMD5();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastreSe fCadastreSe = new FrmCadastreSe();
            fCadastreSe.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login.setLogin(txtLogin.Text);
            string senhaBD = login.verificarExistenciaLogin();

            if (md5.ComparaMD5(txtSenha.Text, senhaBD) == false || (senhaBD == "não existe"))
            {
                MessageBox.Show("Usuário não cadastrado no Sistema. Verifique se a senha ou login estão corretos!", "Aviso", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
            }
            else
            {
                FrmLogin fLogin = new FrmLogin();
                fLogin.Close();
                MessageBox.Show("Login Realizado com sucesso!", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);                
                FrmPrincipal fPrincipal = new FrmPrincipal(txtLogin.Text, senhaBD);
                fPrincipal.Show();
                txtLogin.Text = "";
                txtSenha.Text = "";

            }
        }
    }
}
