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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            Usuario usuario = new Usuario();
            usuario.Nome = "Ghabriell";
            usuario.NomeUsuario = "teste";
            usuario.Ativo = true;
            usuario.CPF = "123.456.789-01";
            usuario.Senha = "123456";
            usuario.Email = "Ghabriellhenrick@gmail.com";

            new UsuarioBLL().Inserir(usuario);
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
