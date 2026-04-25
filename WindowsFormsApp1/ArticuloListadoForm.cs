using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista
{
    public partial class ArticuloListadoForm : Form
    {
        public ArticuloListadoForm()
        {
            InitializeComponent();
            fillCombos();
        }

        private void fillCombos()
        {
            cboMarca = MarcaBL.GetAll();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
