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
    public partial class MarcaGestionForm : Form
    {

        private Marca _marcaSeleccionada;
        public MarcaGestionForm()
        {
            InitializeComponent();
            dgvMarcas.AutoGenerateColumns = false;            
            CargarGrilla();
        }        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _marcaSeleccionada = null;
            txtMarca.Clear(); 
            txtMarca.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_marcaSeleccionada == null)
                {            
                    MarcaBL.Agregar(txtMarca.Text);
                    MessageBox.Show("Marca creada correctamente");
                    txtMarca.Enabled = false;
                }
                else
                {
                    MarcaBL.Modificar(_marcaSeleccionada.Id, txtMarca.Text);
                    MessageBox.Show("Marca modificada correctamente");
                }

                CargarGrilla();
                txtMarca.Clear();
                _marcaSeleccionada = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarGrilla()
        {
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = MarcaBL.GetMarcas();
        }
       
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca para modificar.");
                return;
            }
            txtMarca.Enabled = true;
            _marcaSeleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            txtMarca.Text = _marcaSeleccionada.Descripcion;            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una marca para eliminar.");
                return;
            }

            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            DialogResult resp = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta marca?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    MarcaBL.Eliminar(marca.Id);
                    MessageBox.Show("Marca eliminada correctamente");

                    CargarGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
