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
    public class csLogin
    {

        private ConexaoPostgres conexao = new ConexaoPostgres();

        private string login;
        private string password;
        public string tipoUsuario;

        public void setLogin(string valor)
        {
            login = valor;
        }

        public string getLogin()
        {
            return login;
        }

        public void setPassword(string valor)
        {
            password = valor;
        }

        public string getPassword()
        {
            return password;
        }

        public string verificarExistenciaLogin()
        {
            
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataSet dataset = new DataSet();
            DataTable dt = new DataTable();
            string sql = "SELECT  login, senha, tipo_usuario";
            sql += " FROM cadastro.login ";
            sql += " WHERE login = '" + getLogin() + "';" ;
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return "não existe";
            }
            else {
                return dataset.Tables[0].Rows[0][1].ToString().Replace(" ", "");
            }

        }

        public void selectTipoUsuario(string login, string senha)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT  login, senha, tipo_usuario";
            sql += " FROM cadastro.login ";
            sql += " WHERE login = '" + login + "' and senha = '" + senha + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            tipoUsuario = dataset.Tables[0].Rows[0][2].ToString().Replace(" ", "");
        }

    }
}
