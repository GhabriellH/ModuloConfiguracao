using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        private void ValidarDados(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.NomeGrupo.Length <= 10)
                throw new Exception("A senha deve ter mais de 10 caracteres.");
        }
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDAL().Inserir(_grupoUsuario);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDAL().Alterar(_grupoUsuario);
        }
        public void Excluir(int _id)
        {
            new GrupoUsuarioDAL().Excluir(_id);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public List<GrupoUsuario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            return new GrupoUsuarioDAL().BuscarPorNomeGrupo(_nomeGrupo);
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            return new GrupoUsuarioDAL().BuscarPorId(_id);
        }

        public void RemoverPermissao(int _idPermissao, int _idGrupoUsuario)
        {
            new GrupoUsuarioDAL().RemoverPermissao(_idPermissao, _idGrupoUsuario);
        }
    }
}
