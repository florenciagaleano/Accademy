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
    public partial class FrmMetodos : Form
    {
        public FrmMetodos()
        {
            InitializeComponent();
        }

        private void btnTestVoid_Click(object sender, EventArgs e)
        {
            Imprimir();

            //string nombre = Interaction.InputBox("Ingrese nombre:");
            //Imprimir(nombre);
            Imprimir(txtNombre.Text);
        }

        #region Metodos

        private void Imprimir()
        {
            string nombre = Interaction.InputBox("Ingrese nombre:");

            MessageBox.Show("Bienvenido " + nombre);
        }

        private void Imprimir(string nombre)
        {
            MessageBox.Show("Bienvenido " + nombre);
        }

        private string Imprimir_fn(string nombre)
        {
            string saludo = "Bienvenido " + nombre;
            return saludo;
        }

        private int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        #endregion

        private void btnTestFuncion_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            MessageBox.Show(Imprimir_fn(nombre));
        }

        private void btnRefactorizarMetodo_Click(object sender, EventArgs e)
        {
            int numero1 = 10;
            int numero2 = 22;

            int resultado = 0;
            resultado = Suma(numero1, numero2);
            MessageBox.Show(resultado.ToString());
        }

        
    }
}
