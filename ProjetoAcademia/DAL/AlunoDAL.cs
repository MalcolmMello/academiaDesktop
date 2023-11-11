using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    internal class AlunoDAL
    {
        Conexao con = new Conexao();
        public void Cadastrar(BLL.Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Aluno (Nome, Email, Cpf, Telefone)
            VALUES (@Nome, @Email, @Cpf, @Telefone)";
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Email", aluno.Email);
            cmd.Parameters.AddWithValue("@Cpf", aluno.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodAluno AS Código, Nome, Email, Cpf, Telefone FROM Aluno ORDER BY Nome", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable PesquisarPorNome(BLL.Aluno aluno)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodAluno AS Código, Nome, Email, Cpf, Telefone FROM Aluno WHERE Nome LIKE @Nome ORDER BY Nome ", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", aluno.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM ALUNO WHERE CodAluno = @CodAluno";
            cmd.Parameters.AddWithValue("@CodAluno", aluno.CodAluno);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Aluno Retornar(BLL.Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ALUNO WHERE CodAluno = @CODALUNO";
            cmd.Parameters.AddWithValue("@CODALUNO", aluno.CodAluno);
            cmd.Connection = con.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                aluno.CodAluno = Convert.ToInt16(dr["CODALUNO"]);
                aluno.Nome = dr["NOME"].ToString();
                aluno.Email = dr["EMAIL"].ToString();
                aluno.Cpf = dr["CPF"].ToString();
                aluno.Telefone = dr["TELEFONE"].ToString();
            }

            dr.Close();
            con.Desconectar();
            return aluno;
        }

        public void Atualizar(BLL.Aluno aluno)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE ALUNO SET Nome = @Nome, Email = @Email, Cpf = @Cpf, Telefone = @Telefone WHERE CodAluno = @CodAluno";
            cmd.Parameters.AddWithValue("@Nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@Email", aluno.Email);
            cmd.Parameters.AddWithValue("@Cpf", aluno.Cpf);
            cmd.Parameters.AddWithValue("@Telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@CodAluno", aluno.CodAluno);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

    }
}
