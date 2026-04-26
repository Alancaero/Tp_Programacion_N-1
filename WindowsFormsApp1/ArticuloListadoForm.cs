using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using LogicaNegocio;

namespace Vista
{
    public partial class ArticuloListadoForm : Form
    {
        public ArticuloListadoForm()
        {
            InitializeComponent();
            fillCombos();
            dgvArticulos.AutoGenerateColumns = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var articulos = ArticuloBL.GetByFilter(txtCodigo.Text, txtNombre.Text, cboMarca.Text, cboCategoria.Text);

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulos;

            if (articulos.Count == 0)
            {
                MessageBox.Show("No se encontraron artículos con los filtros ingresados.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            cboMarca.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
        }
    }
}
