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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("ya existe esta ventana abierta");
                    return;
                }
            }

            //para navegar a otra ventana 
            Form1 ventana = new Form1(); //form1 es la ventana, es un objeto 
            ventana.MdiParent = this;   
            ventana.Show(); // ShowDialog(); para que muestre pero no permita volver a la ventana anterior

        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();

        }
    }
}
