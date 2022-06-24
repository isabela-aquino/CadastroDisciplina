using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace ProjetoFinalLP
{
    class csCursos
    {
        private ConexaoPostgres conexao = new ConexaoPostgres();

        private Int32 cursoId;
        private string cursoNome;
        private string cursoDescricao;
        private Int16 cursoQtdSemestre;

        public void setCursoId(Int32 valor)
        {
            cursoId = valor;
        }

        public Int32 getCursoId()
        {
            return cursoId;
        }

        public void setCursoNome(string valor)
        {
            cursoNome = valor;
        }

        public string getCursoNome()
        {
            return cursoNome;
        }

        public void setCursoDescricao(string valor)
        {
            cursoDescricao = valor;
        }

        public string getCursoDescricao()
        {
            return cursoDescricao;
        }

        public void setCursoQtdSemestre(Int16 valor)
        {
            cursoQtdSemestre = valor;
        }

        public Int16 getCursoQtdSemestre()
        {
            return cursoQtdSemestre;
        }

        public void inserir()
        {
            string sql = "INSERT INTO cadastro.curso(nome_curso, descricao_curso, qtd_semestre) ";
            sql += " VALUES(";
            sql += "'" + cursoNome + "', ";
            sql += "'" + cursoDescricao + "', ";
            sql += cursoQtdSemestre;
            sql += ")";
            conexao.executarSql(sql);
        }

        public void update()
        {
            string sql = "UPDATE cadastro.curso SET ";
            sql += "nome_curso ='" + cursoNome + "',";
            sql += "descricao_curso ='" + cursoDescricao + "',";
            sql += "qtd_semestre =" + cursoQtdSemestre;
            sql += " WHERE cod_curso = " + cursoId + ";";
            conexao.executarSql(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM cadastro.curso WHERE cod_curso = " + cursoId.ToString() + ";";
            conexao.executarSql(sql);
        }

        public DataTable select()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_curso, nome_curso FROM cadastro.curso;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }
        public DataTable selectListaCurso()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_curso, nome_curso, descricao_curso, qtd_semestre, qtd_disc FROM cadastro.curso;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selectCurso()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT  nome_curso, descricao_curso, qtd_semestre";
            sql += " FROM cadastro.curso ";
            sql += " WHERE cod_curso = " + cursoId.ToString() + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            cursoNome = dataset.Tables[0].Rows[0][0].ToString();
            cursoDescricao = dataset.Tables[0].Rows[0][1].ToString();
            cursoQtdSemestre = Convert.ToInt16(dataset.Tables[0].Rows[0][2].ToString());
        }

        public DataTable selectCodCurso(string codCurso)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select * ";
            sql += "FROM cadastro.curso ";
            sql += "WHERE cod_curso = " + Convert.ToInt32(codCurso) + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectNomeCurso(string nome)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select * FROM cadastro.curso";
            sql += " WHERE nome_curso LIKE '" + nome + "%';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
