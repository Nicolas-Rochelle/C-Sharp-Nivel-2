using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class frmVerDetalle : Form
    {
        private Articulo seleccionado = null;
      
        public frmVerDetalle()
        {
            InitializeComponent();
        }

        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.seleccionado = articulo;
            Text = " Detalle ";
        }

        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblPrecioDetalle.Text = seleccionado.Precio.ToString();
                lblCategoriaDetalle.Text = seleccionado.Categoria.ToString();
                lblMarcaDetalle.Text = seleccionado.Marca.ToString();
                lblDescripcionDetalle.Text = seleccionado.Descripcion;
                lblNombreDetalle.Text = seleccionado.Nombre;
                lblCodigoDetalle.Text = seleccionado.Codigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }        
        }
    }
}
