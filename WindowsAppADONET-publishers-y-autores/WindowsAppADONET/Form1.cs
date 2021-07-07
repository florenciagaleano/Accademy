using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsAppADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {   //CONEXION A LA BASE DE DATOS.

            //--especificar la cadena de conexion.
            string cadena = "Data Source=.;Initial Catalog=pubs;Integrated Security=True"; //Pasamos la cadena de conexion. No es una buena práctica pasarla harcodeada.

            //--crear un objeto de conexion.
            SqlConnection connection = new SqlConnection(cadena);

            try
            {
                //--intentamos abrir la conexion:
                connection.Open();
            }
            //-- podemos tener varios catch.
            catch (SqlException exobj) // excepcion de sqlServer.
            {
                //--le mostramos el error al usuario.
                MessageBox.Show("¡Ocurrió un error en la conexión!\n" + exobj.Message);
            }
            catch (Exception exobj) // excepcion generica, siempre es la última.
            {
                //--le mostramos el error al usuario.
                MessageBox.Show("¡Ocurrió un error en la conexión!\n" + exobj.Message);
            }
        }
    }
}
