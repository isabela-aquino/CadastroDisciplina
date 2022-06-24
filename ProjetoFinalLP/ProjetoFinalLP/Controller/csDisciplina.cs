using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;


namespace ProjetoFinalLP
{
    class csDisciplina
    {
        private Int32 disciplinaId;
        private string disciplinaNome;
        private Int16 disciplinaQtdAulas;
        private Int32 disciplinaCodProf;
        private Int32 disciplinaCodCurso;
        private DateTime disciplinaDataInicio;
        private DateTime disciplinaDataEncerramento;

        private ConexaoPostgres conexao = new ConexaoPostgres();

        public void setDisciplinaId(Int32 valor)
        {
            disciplinaId = valor;
        }

        public Int32 getDisciplinaId()
        {
            return disciplinaId;
        }

        public void setDisciplinaNome(string valor)
        {
            disciplinaNome = valor;
        }

        public string getDisciplinaNome()
        {
            return disciplinaNome;
        }

        public void setQtdAulas(Int16 valor)
        {
            disciplinaQtdAulas = valor;
        }

        public Int16 getQtdAulas()
        {
            return disciplinaQtdAulas;
        }

        public void setCodProfDisc(Int32 valor)
        {
            disciplinaCodProf = valor;
        }

        public Int32 getCodProfDisc()
        {
            return disciplinaCodProf;
        }

        public void setCodCursoDisc(Int32 valor)
        {
            disciplinaCodCurso = valor;
        }

        public Int32 getCodCursoDisc()
        {
            return disciplinaCodCurso;
        }
        public void setDataInicio(DateTime valor)
        {
            disciplinaDataInicio = valor;
        }

        public DateTime getDataInicio()
        {
            return disciplinaDataInicio;
        }

        public void setDataEncerramento(DateTime valor)
        {
            disciplinaDataEncerramento = valor;
        }

        public DateTime getDataEncerramento()
        {
            return disciplinaDataEncerramento;
        }

        public void inserir()
        {
            string sql = "INSERT INTO cadastro.disciplina(nome_disciplina, data_inicio, data_encerramento, ";
            sql += "qtd_aulas, cod_prof, cod_curso) VALUES(";
            sql += "'" + disciplinaNome + "', ";
            sql += "'" + disciplinaDataInicio.ToString("yyyy-MM-dd") + "', ";
            sql += "'" + disciplinaDataEncerramento.ToString("yyyy-MM-dd") + "', ";
            sql += disciplinaQtdAulas + ", ";
            sql += disciplinaCodProf + ", ";
            sql += disciplinaCodCurso;
            sql += ")";
            conexao.executarSql(sql);
        }

        public void update()
        {
            string sql = "UPDATE cadastro.disciplina SET ";
            sql += "nome_disciplina ='" + disciplinaNome + "',";
            sql += "data_inicio ='" + disciplinaDataInicio.ToString("yyyy-MM-dd") + "',";
            sql += "data_encerramento ='" + disciplinaDataEncerramento.ToString("yyyy-MM-dd") + "',";
            sql += "qtd_aulas =" + disciplinaQtdAulas + ", ";
            sql += "cod_prof =" + disciplinaCodProf + ",";
            sql += "cod_curso = " + disciplinaCodCurso;
            sql += " WHERE cod_disciplina = " + disciplinaId + ";";
            conexao.executarSql(sql);
        }


        public void delete()
        {
            string sql = "DELETE FROM cadastro.disciplina WHERE cod_disciplina = " + disciplinaId.ToString() + ";";
            conexao.executarSql(sql);
        }

        public DataTable select()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_disciplina, nome_disciplina from cadastro.disciplina;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectListaDisciplina()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_disciplina, nome_disciplina, data_inicio, data_encerramento, qtd_aulas, p.nome_professor, c.nome_curso ";
            sql += "FROM cadastro.professor p INNER JOIN  cadastro.disciplina d ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso; ";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }


        public void selectDisciplina()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT  nome_disciplina, data_inicio, data_encerramento, qtd_aulas, cod_prof, cod_curso ";
            sql += " FROM cadastro.disciplina ";
            sql += " WHERE cod_disciplina = " + disciplinaId.ToString() + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            disciplinaNome = dataset.Tables[0].Rows[0][0].ToString();
            disciplinaDataInicio = Convert.ToDateTime(dataset.Tables[0].Rows[0][1].ToString());
            disciplinaDataEncerramento = Convert.ToDateTime(dataset.Tables[0].Rows[0][2].ToString());
            disciplinaQtdAulas = Convert.ToInt16(dataset.Tables[0].Rows[0][3].ToString());
            disciplinaCodProf = Convert.ToInt32(dataset.Tables[0].Rows[0][4].ToString());
            disciplinaCodCurso = Convert.ToInt32(dataset.Tables[0].Rows[0][5].ToString());
        }

        public DataTable selectCodDisciplina(string codDisc)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_disciplina, nome_disciplina, data_inicio, data_encerramento, qtd_aulas, p.nome_professor, c.nome_curso ";
            sql += "FROM cadastro.professor p INNER JOIN  cadastro.disciplina d ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso ";
            sql += "WHERE cod_disciplina = " + Convert.ToInt32(codDisc) + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectNomeDisciplina(string nome)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_disciplina, nome_disciplina, data_inicio, data_encerramento, qtd_aulas, p.nome_professor, c.nome_curso ";
            sql += "FROM cadastro.professor p INNER JOIN  cadastro.disciplina d ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso ";
            sql += "WHERE nome_disciplina LIKE '" + nome + "%';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectCursoDisciplina(string curso)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT d.cod_disciplina, d.nome_disciplina, d.data_inicio, d.data_encerramento, ";
            sql += "d.qtd_aulas, c.nome_curso, p.nome_professor";
            sql += " FROM cadastro.curso c INNER JOIN  cadastro.disciplina d ON d.cod_curso=c.cod_curso ";
            sql += "INNER JOIN cadastro.professor p ON d.cod_prof = p.cod_professor ";
            sql += " WHERE c.nome_curso = '" + curso + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

    }
}
