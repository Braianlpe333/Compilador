using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjmSuma
{
    public partial class Ventana : Form
    {

        public Ventana()
        {
            InitializeComponent();
            consola.Visible = false;
            ubicacionlb.Visible = false;
            textoconsola.Visible = false;
            ubicacion.Visible = false;
            salida.Visible = false;
            textosalida.Visible = false;
            carga.Visible = false;
            buscar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consola_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textosalida.Clear();
            textoconsola.Clear();
            ponerBlanco();
            string texto = comboBox1.Text;

            if (texto.Equals("Ingreso Manual"))
            {
                consola.Visible = true;
                textoconsola.Visible = true;
                carga.Visible = true;
                salida.Visible = true;
                textosalida.Visible = true;
            }
            if (texto.Equals("Carga desde Archivo"))
            {
                salida.Visible = true;
                textosalida.Visible = true;
                buscar.Visible = true;
                ubicacionlb.Visible = true;
                ubicacion.Visible = true;
            }
        }

        private void ponerBlanco()
        {
            consola.Visible = false;
            ubicacionlb.Visible = false;
            textoconsola.Visible = false;
            ubicacion.Visible = false;
            salida.Visible = false;
            textosalida.Visible = false;
            carga.Visible = false;
            buscar.Visible = false;
        }

        private void carga_Click(object sender, EventArgs e)
        {
            textosalida.Clear();
            string direccion = "C:/Users/user/Desktop/EJMTEXTO/archivo.txt";
            StreamWriter escribir = new StreamWriter(@direccion);//El true es para no sobreescribir datos en caso de querer eliminarlo y ya
            try
            {
                escribir.WriteLine(textoconsola.Text);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();
            StreamReader leer = new StreamReader(@direccion);
            string linea;
            try
            {
                linea = leer.ReadLine();
                int n=1;
                while (linea != null)
                {
                    textosalida.AppendText(n + "  "+linea + "\n");
                    n = n + 1;
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show(Singleton.Instance.mensaje);
            }
            leer.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            //string direccion = "C:/Users/user/Desktop/EJMTEXTO/archivo.txt";
            textosalida.Clear();
            string direccion = ubicacion.Text;
            StreamReader leer = new StreamReader(@direccion);
            string linea;
            try
            {
                linea = leer.ReadLine();
                int n = 1;
                while (linea != null)
                {
                    textosalida.AppendText(n + "  " + linea + "\n");
                    n = n + 1;
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show(Singleton.Instance.mensaje);
            }
            leer.Close();
        }

        private void ubicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
