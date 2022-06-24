using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace ProjetoFinalLP
{ 
    public class csCadastrarSe
    {
        private ConexaoPostgres conexao = new ConexaoPostgres();

        private Int16 codLogin;
        private string cadastraLogin;
        private string cadastraPassword;
        private string tipoUsuario;

        public void setCadastraCod(Int16 valor)
        {
            codLogin = valor;
        }

        public Int16 getCadastraCod()
        {
            return codLogin;
        }

        public void setCadastraLogin(String valor)
        {
            cadastraLogin = valor;
        }

        public string getCadastraLogin()
        {
            return cadastraLogin;
        }

        public void setCadastraPassword(String valor)
        {
            cadastraPassword = valor;
        }

        public string getCadastraPassword()
        {
            return cadastraPassword;
        }

        public void setTipoUsuario(String valor)
        {
            tipoUsuario = valor;
        }

        public string getTipoUsuario()
        {
            return tipoUsuario;
        }

        public bool verificarLogin()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            string sql = "SELECT  login, senha, tipo_usuario";
            sql += " FROM cadastro.login ";
            sql += " WHERE login = '" + getCadastraLogin() + "' and senha ='" + getCadastraPassword() + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;           
        }

        public void cadastrarUsuario()
        {
            string sql = "INSERT INTO cadastro.login(login, senha, tipo_usuario) ";
            sql += "VALUES(";
            sql += "'" + getCadastraLogin() + "', ";
            sql += "'" + getCadastraPassword() + "', ";
            sql += "'" + getTipoUsuario() + "'";
            sql += ")";
            conexao.executarSql(sql);
        }

    }
}
