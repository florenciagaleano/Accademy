using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatosBL;

namespace WindowsSegura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;

            AdminSeguridad admin = new AdminSeguridad();

            bool resultado = admin.Autenticar(nombre, password);

            if(resultado)
            {
                MessageBox.Show("Bienvenido al sistema!");
            }else
            {
                MessageBox.Show("Usuario inválido");
            }
        }
    }
}
