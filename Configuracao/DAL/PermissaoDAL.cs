using Models;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PermissaoDAL
    {
        SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
        public void Inserir(Permissao _permissao)
        {
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Permissao(Descricao)
                                    VALUES(@Descricao)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma permissao no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Permissao _permissao)
        {
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE Permissao SET Nome=@Nome WHERE Id=@Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma permissao no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Permissao WHERE Id=@Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma permissao no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarTodos()
        {
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos as permissões do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            Permissao permissao = new Permissao();
            List<Permissao> permissoes = new List<Permissao>();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as permissões por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao BuscarPorId(int _id)
        {
            Permissao permissao = new Permissao();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao FROM Permissao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                    }
                }
                return permissao;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as permissões por descrição do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        internal List<Permissao> BuscarporIdGrupoUsuario(int _idGrupoUsuario)
        {
            Permissao permissao = new Permissao();
            List<Permissao> permissoes = new List<Permissao>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao.Id, Permissao.Descricao FROM Permissao
                                    INNER JOIN PermissaoGrupoUsuario ON Permissao.Id = PermissaoGrupoUsuario.IdPermissao
                                    WHERE PermissaoGrupoUsuario.IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@idGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["ID"]);
                        permissao.Descricao = rd["Descricao"].ToString();
                        permissoes.Add(permissao);

                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar as permissões de usuários por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
