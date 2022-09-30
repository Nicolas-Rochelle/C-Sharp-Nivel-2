using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class FormPrimerPractica : Form
    {
        public FormPrimerPractica()
        {
            InitializeComponent();
        }

        private void FormPrimerPractica_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a c#");
        }

        private void FormPrimerPractica_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau chau... ");
        }

        private void BtnBOTON_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("se disparo el evento clik, atencion ");
            //this.BackColor = Color.Blue;

            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo , atencion");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("presiono el boton derecho , atencion "); 
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio , atencion ");

            if (txtBox.Text == "")
                txtBox.BackColor = Color.Red;
            else
                txtBox.BackColor = System.Drawing.SystemColors.Control;



        }

        private void lbletiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lbletiqueta.BackColor = Color.Cyan;

            lbletiqueta.Cursor = Cursors.Hand;
        }

        private void lbletiqueta_MouseLeave(object sender, EventArgs e)
        {
            lbletiqueta.BackColor = System.Drawing.SystemColors.Control;
            lbletiqueta.Cursor = Cursors.Arrow;
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtBox2.Text.Length + " Caracteres");
        }
    }
}
