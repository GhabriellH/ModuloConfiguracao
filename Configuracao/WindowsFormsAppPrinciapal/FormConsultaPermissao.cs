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
    public partial class FormConsultaPermissao : Form
    {
        public int Id;
        public FormConsultaPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPe_Click(object sender, EventArgs e)
        {
            try
            {
                permissaoBindingSource.DataSource = new PermissaoBLL().BuscarTodos(textBoxBuscarPermissao.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSelecionarPe_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count > 0)
                {
                    Id = ((Permissao)permissaoBindingSource.Current).Id;
                    Close();
                }
                else
                    MessageBox.Show("Não existe registro para ser selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonCancelarPe_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
