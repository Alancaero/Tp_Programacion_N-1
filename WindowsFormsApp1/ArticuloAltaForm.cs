using Dominio;
using LogicaNegocio;
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
    public partial class ArticuloAltaForm : Form
    {
        public ArticuloAltaForm()
        {
            InitializeComponent();
            fillCombos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {             
                ArticuloBL.Guardar(txtCodigo.Text, txtNombre.Text, cboMarca.Text, cboCategoria.Text, txtPrecio.Text, txtDescripcion.Text);
                MessageBox.Show("Artículo guardado exitosamente.");
                Limpiar();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void fillCombos()
        {
            var listaMarcas = MarcaBL.GetMarcas();

            foreach (Marca marca in listaMarcas)
            {
                cboMarca.Items.Add(marca.Descripcion);
            }

            var listaCategorias = CategoriaBL.GetCategorias();
            foreach (Categoria categoria in listaCategorias)
            {
                cboCategoria.Items.Add(categoria.Descripcion);
            }
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            cboMarca.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
