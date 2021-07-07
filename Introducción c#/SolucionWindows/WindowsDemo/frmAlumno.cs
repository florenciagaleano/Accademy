using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class frmAlumno : Form
    {
        string nombre;
        string apellido;
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);

            lblMensaje.Text = nombre + ", " + apellido + " "+ edad;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre + " " + apellido, "Nombre completo");
        }

        private void btnIngresarCiudad_Click(object sender, EventArgs e)
        {
            string ciudad = Interaction.InputBox("Ingrese la ciudad en donde vive: ");
            MessageBox.Show("Usted vive en: " + ciudad);
        }
    }
}
