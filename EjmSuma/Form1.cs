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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ventana = "Ventana";
            Ventana form = new Ventana();
            if (ventanaAbierta(ventana) == false)
            {
                form.MdiParent = this;
                form.Show();
            }
            if (ventanaAbierta(ventana) == true)
            {
                bienvenida.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void pestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ventana2 = "Ventana2";
            Ventana2 ven = new Ventana2();
            if (ventanaAbierta(ventana2) == false)
            { 
                ven.MdiParent = this;
                ven.Show();
            }
            if (ventanaAbierta(ventana2) == true)
            {
                bienvenida.Visible = false;
            }
        }
        private bool ventanaAbierta(String nombreVen)
        {
            bool va = false;

            foreach (Form ventana in MdiChildren)
            {
                if (ventana.Name.Equals(nombreVen))
                {
                    ventana.Focus();
                    va = true;
                }
            }
            return va;
        }
    }
}
