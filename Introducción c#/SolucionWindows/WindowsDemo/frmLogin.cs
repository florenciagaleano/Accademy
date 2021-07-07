using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDemo
{
    public partial class frmLogin : Form
    {
        string nombre;
        string contraseña;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            contraseña = txtPassword.Text;

            if(nombre == "Juan" && contraseña == "1234")
            {
                MessageBox.Show("Bienvenido!");
            }else
            {
                MessageBox.Show("Usuario inválido");
            }
        }
    }
}
