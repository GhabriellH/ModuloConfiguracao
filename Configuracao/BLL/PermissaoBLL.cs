using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public int Id;
        private void ValidarDados(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 10)
                throw new Exception("A senha deve ter mais de 10 caracteres.");
        }
        public void Inserir(Permissao _permissao)
        {
            new PermissaoDAL().Inserir(_permissao);
        }
        public void Alterar(Permissao _permissao)
        {
            new PermissaoDAL().Alterar(_permissao);
        }
        public void Excluir(int _id)
        {
            new PermissaoDAL().Excluir(_id);
        }
        public List<Permissao> BuscarTodos(string _descricao)
        {
            return new PermissaoDAL().BuscarTodos();
        }
        public Permissao BuscarPorDescricao(string _descricao)
        {
            return new PermissaoDAL().BuscarPorDescricao(_descricao);
        }
        public Permissao BuscarPorId(int _id)
        {
            return new PermissaoDAL().BuscarPorId(_id);
        }

        public void AdicionarPermissao(int _idGrupoUsuario, int _idPermissao)
        {
            if (!new GrupoUsuarioDAL().PermissaoPertenceAoGrupo(_idGrupoUsuario, _idPermissao))
                new GrupoUsuarioDAL().AdicionarPermissao(_idGrupoUsuario, _idPermissao);
        }

    }
}
