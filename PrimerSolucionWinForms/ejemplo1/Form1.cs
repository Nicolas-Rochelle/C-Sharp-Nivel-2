using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hola Mundo");
            string texto = txtNombre.Text;

            string textoEdad = textEdad.Text;
            
            labelSaludo.Text = "Hola Tu nombre es:  " + texto + " y tu edad es: " + textoEdad + " , ahr.. ";

        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("gracias por usar la app");
        }
    }
}
