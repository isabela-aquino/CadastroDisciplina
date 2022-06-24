using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;


namespace ProjetoFinalLP
{
    class csProfessores : csPessoa
    {
        private csPessoa pessoa = new csPessoa();
        private ConexaoPostgres conexao = new ConexaoPostgres();


        private Int32 professorId;
        private double professorSalario;

        public void setProfessorId(Int32 valor)
        {
            professorId = valor;
        }

        public Int32 getProfessorId()
        {
            return professorId;
        }

        public void setProfessorSalario(double valor)
        {
            professorSalario = valor;
        }

        public double getProfessorSalario()
        {
            return professorSalario;
        }

        public void inserir()
        {
            string sql = "INSERT INTO cadastro.professor(nome_professor, data_nasc, salario) ";
            sql += "VALUES(";
            sql += "'" + getPessoaNome() + "', ";
            sql += "'" + getPessoaDataNasc() + "', ";
            sql += professorSalario.ToString().Replace(",", ".");
            sql += ")";
            conexao.executarSql(sql);
        }
       
       
        public void update()
        {
            string sql = "UPDATE cadastro.professor SET ";
            sql += "nome_professor ='" + getPessoaNome() + "',";
            sql += "data_nasc ='" + getPessoaDataNasc().ToString("yyyy-MM-dd") + "',";
            sql += "salario =" + professorSalario.ToString().Replace(",", ".");
            sql += " WHERE cod_professor = " + professorId + ";";
            conexao.executarSql(sql);
        }

        public void delete()
        {
            string sql = "DELETE FROM cadastro.professor WHERE cod_professor = " + professorId.ToString() + ";";
            conexao.executarSql(sql);
        }

        public DataTable select()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_professor, nome_professor from cadastro.professor;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectListaProfessor()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_professor, nome_professor, data_nasc, CAST(salario AS NUMERIC(15,2)) FROM cadastro.professor;";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public void selectProfessor()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataSet dataset = new DataSet();
            string sql = "SELECT  nome_professor, data_nasc, CAST(salario AS NUMERIC(15,2))";
            sql += " FROM cadastro.professor ";
            sql += " WHERE cod_professor = " + professorId.ToString() + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(dataset);

            setPessoaNome(dataset.Tables[0].Rows[0][0].ToString());
            setPessoaDataNasc(Convert.ToDateTime(dataset.Tables[0].Rows[0][1].ToString())); 
            professorSalario = Convert.ToDouble(dataset.Tables[0].Rows[0][2].ToString());
            
        }

        public DataTable selectCodProfessor(string codProf)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_professor, nome_professor, data_nasc, CAST(salario AS NUMERIC(15,2)) FROM cadastro.professor WHERE cod_professor=";
            sql += Convert.ToInt32(codProf) + ";";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectCursoProfessor(string curso)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select p.* ";
            sql += "FROM cadastro.professor p INNER JOIN  cadastro.disciplina d";
            sql += " ON p.cod_professor=d.cod_prof INNER JOIN cadastro.curso c ON c.cod_curso = d.cod_curso";
            sql += " where nome_curso = '" + curso + "';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }

        public DataTable selectNomeProfessor(string nome)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "Select cod_professor, nome_professor, data_nasc, CAST(salario AS NUMERIC(15,2)) FROM cadastro.professor";
            sql += " WHERE nome_professor LIKE '" + nome + "%';";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }


        public DataTable selectAniversárioProfessor(string mes)
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable tabela = new DataTable();
            string sql = "SELECT * FROM rotinas.aniversariantes_do_mes('" + mes + "');";
            adapter = conexao.executaRetornaDados(sql);
            adapter.Fill(tabela);
            return tabela;
        }
    }
}
