using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Models;
using Datos;
using Microsoft.VisualBasic;

namespace AppWindowsVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //gridVendedores.ClearSelection();
            gridVendedores.DataSource = DacVendedor.Listar();
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            int auxId = Convert.ToInt32(Interaction.InputBox("Ingrese id a buscar:"));
            gridVendedores.DataSource = DacVendedor.TraerPorId(auxId);
        }

        private void btnInsertarVendedor_Click(object sender, EventArgs e)
        {
            Vendedor aux = PedirDatos();

            if(DacVendedor.Insert(aux) > 0)
            {
                MessageBox.Show("Vendedor ingresado a la base!");
                gridVendedores.ClearSelection();
                gridVendedores.DataSource = DacVendedor.Listar();
            }
            else
            {
                MessageBox.Show("No se pudo insertar al vendedor en la base");
            }
        }

        private Vendedor PedirDatos()
        {
            Vendedor v = new Vendedor();
            v.Nombre = Interaction.InputBox("Ingrese nombre del vendedor:");
            v.Apellido = Interaction.InputBox("Ingrese apellido del vendedor:");
            v.Dni = Interaction.InputBox("Ingrese DNI del vendedor:");
            v.Comision = Convert.ToDecimal(Interaction.InputBox("Ingrese comision del vendedor:"));

            return v;
        }

        private void btnTraerPorComision_Click(object sender, EventArgs e)
        {
            decimal auxDecimal = Convert.ToDecimal(Interaction.InputBox("Ingrese comision a buscar:"));
            gridVendedores.DataSource = DacVendedor.TraerPorComision(auxDecimal);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Vendedor auxVendedor = PedirDatos();
            auxVendedor.Id = Convert.ToInt32(Interaction.InputBox("Ingrese id del vendedor:"));
            if (DacVendedor.Update(auxVendedor) > 0)
            {
                MessageBox.Show("Se modifico al vendedor");
                gridVendedores.DataSource = DacVendedor.Listar();
            }
            else
            {
                MessageBox.Show("No se encontro ningun empleado con el id ingresado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int auxId = Convert.ToInt32(Interaction.InputBox("Ingrese id del vendedor:"));
            if(DacVendedor.Delete(auxId) > 0)
            {
                MessageBox.Show("Se elimino al vendedor");
                gridVendedores.DataSource = DacVendedor.Listar();
            }
            else
            {
                MessageBox.Show("No se encontro ningun empleado con el id ingresado");
            }
        }
    }
}
