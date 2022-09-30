using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (Exception ex ) //<------ excepcion generica ( tiene incluida todas las excepciones.
            {
                MessageBox.Show("Ocurrio un error en la ejecucion...");
                
            }
            finally
            {
                //instucciones...
                //operacion sensible...
            }
        }
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a / b;
                return r;   
                
            }
            catch (Exception ex)
            {
                //guardar registro de error en archivo...
                throw ex;
            }
        }


    }
}
