using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsDemo
{
    public partial class FrmCase3 : Form
    {
        public FrmCase3()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre =  "";
            string apellido = "";
            DateTime nacimiento = default;

            GuardarDatos(ref nombre,ref apellido,ref nacimiento);
            Imprimir(nombre, apellido);
            Imprimir(nombre, apellido,CalcularEdad(nacimiento));
        }

        private void GuardarDatos(ref string nombre,ref string apellido,ref DateTime nacimiento)
        {
            nacimiento = dateTimePickerNacimiento.Value;
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
        }

        private void Imprimir(string nombre, string apellido)
        {
            MessageBox.Show(nombre + ", " + apellido);
        }

        private void Imprimir(string nombre, string apellido,int edad)
        {
            MessageBox.Show(nombre + ", " + apellido + " tiene " + edad.ToString() + " años");
        }

        private int CalcularEdad(DateTime nacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            return fechaActual.Year - nacimiento.Year;
        }
    }
}
