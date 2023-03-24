using BLL;
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
                permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorDescricao(textBoxBuscarPermissao.Text);
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
