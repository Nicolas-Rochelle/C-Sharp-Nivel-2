using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaApp
{
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {      //guardo en variables las casillas de texto
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text; 
            string edad = "EDAD: " + txtEdad.Text;
            string direccion ="DIRECCION " +txtDireccion.Text;
            string nombreCompleto = "Apellido y Nombre: " + apellido +" "+ nombre; 
             //agrego el texto de las casillas a la lsita
            //listBox.Items.Add(apellido);
            //listBox.Items.Add(nombre);
            listBox.Items.Add(edad);
            listBox.Items.Add(direccion);
            listBox.Items.Add(nombreCompleto);
            //valido si las casillas tienen texto, si no , las marco en rojo
            if(txtApellido.Text.Length == 0) { txtApellido.BackColor = Color.Red; }
            if (txtNombre.Text.Length == 0) { txtNombre.BackColor = Color.Red; }    
            if (txtDireccion.Text.Length == 0) { txtDireccion.BackColor = Color.Red; }  
            if (txtEdad.Text.Length == 0 ) { txtEdad.BackColor = Color.Red; }


        }
         
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {    //valido que la casilla de edad solo ingrese numeros
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                //agregar mensaje aca que solo numeros.
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
