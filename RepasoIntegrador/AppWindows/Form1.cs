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

namespace AppWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            gridProfesores.ClearSelection();
            gridProfesores.DataSource = DacProfesor.Listar();
        }

        private void btnTraerPorId_Click(object sender, EventArgs e)
        {
            gridProfesores.ClearSelection();
            gridProfesores.DataSource = DacProfesor.TraerPorId(txtId.Text);
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            DacProfesor.Insert(PedirDatos());
            gridProfesores.ClearSelection();
            gridProfesores.DataSource = DacProfesor.Listar();
        }

        private Profesor PedirDatos()
        {
            Profesor p = new Profesor();

            p.Nombre = Interaction.InputBox("Ingrese nombre:"); 
            p.Apellido = Interaction.InputBox("Ingrese apellido:");
            p.DNI = Interaction.InputBox("Ingrese DNI:");
            p.Titulo = Interaction.InputBox("Ingrese titulo:");

            return p;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Profesor p = PedirDatos();
            p.Id = Convert.ToInt32(Interaction.InputBox("Ingrese id"));
            DacProfesor.Update(p);
            MessageBox.Show("Modificacion realizada");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int auxId = Convert.ToInt32(Interaction.InputBox("Ingrese id"));
            DacProfesor.Delete(auxId);
            MessageBox.Show("Baja realizada");

        }
    }
}
