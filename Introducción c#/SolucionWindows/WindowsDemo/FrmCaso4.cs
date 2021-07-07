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
    public partial class FrmCaso4 : Form
    {
        string nombre;
        string sexo;
        string rol;

        public FrmCaso4()
        {
            InitializeComponent();
        }

        private void FrmCaso4_Load(object sender, EventArgs e)
        {
            nombre = Interaction.InputBox("Ingrese nombre:");
            sexo = Interaction.InputBox("Ingrese sexo:");
            rol = Interaction.InputBox("Ingrese rol:");

            if(ValidarDatos())
            {
                ImprimirDatos();
            }
            else
            {
                MessageBox.Show("Mensaje incorrecto!");
            }
        }

        private void ImprimirDatos()
        {
            txtDatos.Text = $"Usuario: {nombre} - Sexo: {sexo} - Rol: {rol}";
        }

        private bool ValidarDatos()
        {
            sexo = sexo.ToLower();
            rol = rol.ToLower();

            if((sexo == "femenino" || sexo == "masculino") && (rol == "administrador" ||rol == "estandar" || rol == "invitado"))
            {
                return true;
            }

            return false;
        }
    }
}
