using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace WinFormsAdoNET
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;
        public frmAltaDisco()
        {
            InitializeComponent();
        }
        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscoService negocio = new DiscoService();  
            try
            {
                if(disco == null)
                    disco = new Disco();    

                disco.Titulo = txtNombre.Text;
                disco.CantidadCanciones = int.Parse(txtNumero.Text);
                disco.UrlImagenTapa = txturlimagen.Text;
                disco.Edicion = (TipoEdicion)cboEdicion.SelectedItem;
                disco.Estilo = (Estilo)cboEstilo.SelectedItem;

                if(disco.id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");
                }
                //guardo imagen si la levanto localmemnte;
                if(archivo != null && (txturlimagen.Text.ToUpper().Contains("HTTP")));
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
           TipoEdicionNegocio tipoEdicionNegocio = new TipoEdicionNegocio();
           EstiloNegocio estiloNegocio = new EstiloNegocio();
            try
            {   
                cboEstilo.DataSource =  estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion"; 
                cboEdicion.DataSource = tipoEdicionNegocio.listar();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Descripcion";

                if(disco != null)
                {
                    txtNombre.Text = disco.Titulo;
                    txtNumero.Text = disco.CantidadCanciones.ToString();
                    txturlimagen.Text = disco.UrlImagenTapa;
                    cargarImagen(disco.UrlImagenTapa);
                    cboEdicion.SelectedValue = disco.Edicion.id;
                    cboEstilo.SelectedValue = disco.Estilo.id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

           
        }

        private void txturlimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txturlimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                PbxDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                PbxDiscos.Load("https://image.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg| png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txturlimagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                

            }
        }
    }
}
