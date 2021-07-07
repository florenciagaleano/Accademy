using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Models;

namespace WindowsAppADONET
{
    public partial class pruebasDesprolijas : Form
    {
        public pruebasDesprolijas()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Author a = new Author()
            {
                Au_Id = "1234",
                Au_Lname = "Flor",
                Au_Fname = "Galeano",
                Address = "Sitio 4557",
                City = "Bs As",
                State = "BA",
                Phone = "28-75598",
                Zip = "5718",
                Contract = true
            };

            if(DacAuthor.Insert(a) > 0)
            {
                MessageBox.Show("Se agrego a la tabla");
            }
                    

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Author a = new Author()
            {
                Au_Id = "1234",
                Au_Lname = "Flor",
                Au_Fname = "Galeano",
                Address = "Sitio 4557",
                City = "Capital",
                State = "BA",
                Phone = "28-75598",
                Zip = "5718",
                Contract = true
            };

            if (DacAuthor.Update(a) > 0)
            {
                MessageBox.Show("Se modifico en la tabla");
            }
        }

        private void btnInsertarPub_Click(object sender, EventArgs e)
        {
            Publisher p = new Publisher("4", "Hemingway", "Nueva york", "NY", "EeUu");
            
            if(DacPublisher.Insert(p) > 0)
            {
                MessageBox.Show("Se agrego a la tabla");
            }

            gridPubs.DataSource = DacPublisher.Select_TraerTodos();
        }

        private void btnModificarPublicador_Click(object sender, EventArgs e)
        {

        }
    }
}
