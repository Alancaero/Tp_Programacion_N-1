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
        private Articulo _articulo;
        private string rutaImagen;

        public ArticuloAltaForm()
        {
            InitializeComponent();
            fillCombos();
        }

        public ArticuloAltaForm(Articulo articulo)
        {
            InitializeComponent();
            fillCombos();
            _articulo = articulo;
            CargarArticulo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {             

                if(_articulo == null)
                {
                    ArticuloBL.Guardar(txtCodigo.Text, txtNombre.Text, cboMarca.Text, cboCategoria.Text, txtPrecio.Text, txtDescripcion.Text, rutaImagen);
                    MessageBox.Show("Artículo guardado exitosamente.");
                    Limpiar();
                } else
                {
                    ArticuloBL.Modificar(_articulo.Id, txtCodigo.Text, txtNombre.Text, cboMarca.Text, cboCategoria.Text, txtPrecio.Text, txtDescripcion.Text, rutaImagen);
                    MessageBox.Show("Artículo modificado exitosamente.");
                    Close();
                }
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
            txtUrlImagen.Clear();
            cboMarca.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;

            rutaImagen = string.Empty;
            pbxImagen.Image = Properties.Resources._noImagen_Lobo_Idolo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            rutaImagen = txtUrlImagen.Text;
            cargarImagen(rutaImagen);
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png|jpeg|*.jpeg";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = archivo.FileName;
                pbxImagen.Load(rutaImagen);

                txtUrlImagen.Text = rutaImagen; 
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(imagen))
                {
                    pbxImagen.Load(imagen);
                }
            }
            catch (Exception)
            {
                pbxImagen.Image = Properties.Resources._noImagen_Lobo_Idolo;
            }
        }
        private void CargarArticulo()
        {
            if (_articulo == null)
                return;

            txtCodigo.Text = _articulo.Codigo;
            txtNombre.Text = _articulo.Nombre;
            txtPrecio.Text = _articulo.Precio.ToString();
            txtDescripcion.Text = _articulo.Descripcion;

            cboMarca.Text = _articulo.Marca?.Descripcion;
            cboCategoria.Text = _articulo.Categoria?.Descripcion;
        }
    }
}
