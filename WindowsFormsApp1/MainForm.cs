using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            lblMensaje.Dock = DockStyle.Fill;
        }

        private void ListadoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            Form formListado = new ArticuloListadoForm();
            formListado.MdiParent = this;
            formListado.Dock = DockStyle.Fill;
            formListado.Show();
        }

        private void AgregarYModificarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            Form formAlta= new ArticuloAltaForm();
            formAlta.MdiParent = this;
            formAlta.Dock = DockStyle.Fill;
            formAlta.Show();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestionDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = false;
            Form formMarcas = new MarcaGestionForm();
            formMarcas.MdiParent = this;
            formMarcas.Dock = DockStyle.Fill;
            formMarcas.Show();
        }
    }
}
