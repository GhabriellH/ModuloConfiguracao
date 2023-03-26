using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrinciapal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void FormBuscarGrupoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscarGU_Click(object sender, EventArgs e)
        {
            grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTodos();
        }

        private void buttonAlterarGU_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscarGU_Click(null, null);
        }

        private void buttonAdicionarGU_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscarGU_Click(null, null);
        }

        private void buttonExcluirGU_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluido.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(id);
            grupoUsuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaPermissao frm = new FormConsultaPermissao())
                {
                    frm.ShowDialog();

                    if (frm.Id != 0)
                    {
                        int idGrupoUsuario = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                        new GrupoUsuarioBLL().AdicionarPermissao(idGrupoUsuario, frm.Id);
                    }
                }
                buttonBuscarGU_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            try
            {
                int idGrupoUsuario = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                int idPermissao = ((Permissao)permissoesBindingSource.Current).Id;
                new GrupoUsuarioBLL().RemoverPermissao(idPermissao, idGrupoUsuario);
                grupoUsuarioBindingSource.RemoveCurrent();
                MessageBox.Show("Registro excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
