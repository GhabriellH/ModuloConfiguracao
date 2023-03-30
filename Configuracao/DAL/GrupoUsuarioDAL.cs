using Models;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data.Common;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO GrupoUsuario(NomeGrupo)
                                    VALUES(@NomeGrupo)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um grupo de usuario no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "UPDATE GrupoUsuario SET NomeGrupo=@NomeGrupo WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _grupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@Id", _grupoUsuario.Id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar um grupo de usuario no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _idGrupoUsuario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM GrupoUsuario WHERE Id = @Id", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", _idGrupoUsuario);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        RemoverTodasPermissoes(_idGrupoUsuario, transaction);
                        RemoverTodosUsuarios(_idGrupoUsuario, transaction);
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir um grupo de usuario no banco de dados", ex);
                    }

                }
            }
        }

        private void RemoverTodosUsuarios(int _idGrupoUsuario, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM UsuarioGrupoUsuario WHERE IdGrupoUsuario = @IdGrupoUsuario", cn))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                       
                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Ocorreu erro ao tentar excluir um grupo de usuario no banco de dados", ex);
                    }

                }
            }
        }

        private void RemoverTodasPermissoes(int _idGrupoUsuario, SqlTransaction _transaction)
        {
            SqlTransaction transaction = _transaction;

            try
            {
                using (SqlConnection cn2 = new SqlConnection(Conexao.StringDeConexao))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM PermissaoGrupoUsuario WHERE IdGrupoUsuario = @IdGrupoUsuario", cn2))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                        if (_transaction == null)
                        {
                            cn2.Open();
                            transaction = cn2.BeginTransaction();
                        }
                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Ocorreu erro ao tentar excluir as permissões de um grupo de usuario no banco de dados", ex);
            }
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupoUsuario.Permissoes = new PermissaoDAL().BuscarporIdGrupoUsuario(grupoUsuario.Id);
                        grupoUsuarios.Add(grupoUsuario);
                    }
                }
                return grupoUsuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos usuários do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario WHERE NomeGrupo LIKE @NomeGrupo";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@NomeGrupo", "%" + _nomeGrupo + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupoUsuarios.Add(grupoUsuario);
                    }
                }
                return grupoUsuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupos de usuários do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["ID"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                    }
                }
                return grupoUsuario;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os usuários por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoUsuario> BuscarPorIdUsuario(int _idUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT GrupoUsuario.Id, GrupoUsuario.NomeGrupo FROM GrupoUsuario
                                    INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.Id = UsuarioGrupoUsuario.IdGrupoUsuario
                                    WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["ID"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupoUsuarios.Add(grupoUsuario);

                    }
                }
                return grupoUsuarios;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar os grupos de usuários por id do banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool PermissaoPertenceAoGrupo(int _idGrupoUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 FROM PermissaoGrupoUsuario
                                    WHERE IdPermissao = @IdPermissao AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar existência de permissao vinculado a um grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarPermissao(int _idGrupoUsuario, int _idPermissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"INSERT INTO PermissaoGrupoUsuario(IdPermissao, IdGrupoUsuario) 
                                    VALUES(@IdPermissao, @IdGrupoUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular uma permissao a um grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void RemoverPermissao(int _idPermissao, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM PermissaoGrupoUsuario 
                                    WHERE IdPermissao = @IdPermissao AND IdGrupoUsuario = @IdGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar remover uma permissao de um grupo no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

    }
}

