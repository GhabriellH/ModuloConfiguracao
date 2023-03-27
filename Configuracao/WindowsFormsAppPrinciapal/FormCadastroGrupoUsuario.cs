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
    public partial class FormCadastroGrupoUsuario : Form
    {
        public int Id;
        public FormCadastroGrupoUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void FormCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                grupoUsuarioBindingSource.AddNew();
            else
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorId(Id);
        }

        private void buttonSalvarGU_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            grupoUsuarioBindingSource.EndEdit();
            if (Id == 0)
                grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
            else
                grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);

            MessageBox.Show("Registro salvo com sucesso!");
            Close();
        }

        private void buttonExcluirGU_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormCadastroGrupoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
