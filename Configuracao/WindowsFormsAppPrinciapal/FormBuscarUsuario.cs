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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
            
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                new UsuarioBLL().ValidarPermissao(2);
                using (FormCadastroUsuario frm = new FormCadastroUsuario())
                {
                    frm.ShowDialog();
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluido.");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonExcluirGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idGrupoUsuario = ((GrupoUsuario)gruposUsuariosBindingSource.Current).Id;
                int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                new UsuarioBLL().RemoverGrupoUsuario(idUsuario, idGrupoUsuario);
                gruposUsuariosBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;
            using (FormCadastroUsuario frm = new FormCadastroUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
             try
            {
                using (FormConsultaGrupoUsuario frm = new FormConsultaGrupoUsuario()) 
                {
                    frm.ShowDialog();

                    if(frm.Id != 0)
                    {
                        int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                        new UsuarioBLL().AdicionarGrupoUsuario(idUsuario, frm.Id);
                    }
                }
                buttonBuscar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
