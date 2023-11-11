using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// classes de acesso ao BD
using System.Data;
using System.Data.SqlClient;

namespace ProjetoAcademia.DAL
{
    internal class UsuarioDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO Usuario (Nome, Email, Senha)
            VALUES (@Nome, @Email, @Senha)";
            cmd.Parameters.AddWithValue("@Nome", usu.Nome);
            cmd.Parameters.AddWithValue("@Email", usu.Email);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public DataTable ConsultarTodos()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodUsuario AS Código, Nome, Email FROM USUARIO ORDER BY Nome", con.Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public DataTable PesquisarPorNome(BLL.Usuario usu)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT CodUsuario AS Código, Nome, Email FROM USUARIO WHERE Nome LIKE @Nome ORDER BY Nome ", con.Conectar());
            da.SelectCommand.Parameters.AddWithValue("@Nome", usu.Nome + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Desconectar();
            return dt;
        }

        public void Excluir(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM USUARIO WHERE CodUsuario = @CodUsuario";
            cmd.Parameters.AddWithValue("@CodUsuario", usu.Codusuario);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public BLL.Usuario Retornar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM USUARIO WHERE CODUSUARIO = @CODUSUARIO";
            cmd.Parameters.AddWithValue("@CODUSUARIO", usu.Codusuario);
            cmd.Connection = con.Conectar();
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                usu.Codusuario = Convert.ToInt16(dr["CODUSUARIO"]);
                usu.Nome = dr["NOME"].ToString();
                usu.Email = dr["EMAIL"].ToString();
                usu.Senha = dr["SENHA"].ToString();
            }

            dr.Close();
            con.Desconectar();
            return usu;
        }

        public void Atualizar(BLL.Usuario usu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"UPDATE USUARIO SET Nome = @Nome, Email = @Email, Senha = @Senha WHERE CodUsuario = @CodUsuario";
            cmd.Parameters.AddWithValue("@Nome", usu.Nome);
            cmd.Parameters.AddWithValue("@Email", usu.Email);
            cmd.Parameters.AddWithValue("@Senha", usu.Senha);
            cmd.Parameters.AddWithValue("@CodUsuario", usu.Codusuario);
            cmd.Connection = con.Conectar();
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
