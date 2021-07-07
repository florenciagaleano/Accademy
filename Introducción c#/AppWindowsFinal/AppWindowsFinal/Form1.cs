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

namespace AppWindowsFinal
{
    public partial class Form1 : Form
    {
        string nombre;
        string apellido;
        double sueldo;
        string puesto;
        int[] horas;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            sueldo = Convert.ToDouble(txtSueldo.Text);
            puesto = txtPuesto.Text;

            if(!Validar())
            {
                MessageBox.Show("La información ingresada no es válida");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre + " " + apellido + " - " + puesto);
        }

        private void btnIngresarHoras_Click(object sender, EventArgs e)
        {
            int totalHoras = CalcularHorasTrabajadas();
            float promedio = (float) totalHoras / 5;
            MessageBox.Show("Usted trabajo en total " + totalHoras + " horas\nPromedio de horas trabajadas: "+promedio.ToString() + InformarDiaQueTrabajoMenosDeCuatroHoras());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        #region Metodos
        private string InformarDiaQueTrabajoMenosDeCuatroHoras()
        {
            string ret = string.Empty;//si ningun dia trabajo <4 hs devuelve cadena vacia

            for (int i = 0; i < horas.Length; i++)
            {
                if(horas[i] < 4)
                {
                    ret += "\nEl día ";

                    switch(i)
                    {
                        case 0:
                            ret += "Lunes";
                            break;
                        case 1:
                            ret += "Martes";
                            break;
                        case 2:
                            ret += "Miercoles";
                            break;
                        case 3:
                            ret += "Jueves";
                            break;
                        case 4:
                            ret += "Viernes";
                            break;
                    }

                    ret += " trabajo menos de 4 horas";
                }
            }

            return ret;
        }

        private int CalcularHorasTrabajadas()
        {
            horas = new int[5];
            int acumulador = 0;
            for (int i = 0; i < horas.Length; i++)
            {
                horas[i]= Convert.ToInt32(Interaction.InputBox("Ingrese cantidad de horas trabajadas:"));
                acumulador += horas[i];
            }

            return acumulador;
        }

        private bool Validar()
        {
            if (sueldo > 0 && (puesto.ToLower() == "soporte tecnico" || puesto.ToLower() == "dba" || puesto.ToLower() == "desarrollador") && nombre.Length > 2 && nombre.Length < 50 && apellido.Length > 2 && apellido.Length < 50)
            {
                return true;
            }

            return false;
        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtPuesto.Clear();
            txtSueldo.Text = "0";//lo pongo en 0 porque si no se carga tira una excepción
        }

        #endregion
    }
}
