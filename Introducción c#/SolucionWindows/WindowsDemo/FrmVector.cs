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
    public partial class FrmVector : Form
    {
        float[] sueldos;
        string[] nombres;
        public FrmVector()
        {
            InitializeComponent();
        }

        #region Metodos

        private void cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Interaction.InputBox("Ingrese nombre:");
                sueldos[i] = float.Parse(Interaction.InputBox("Ingrese sueldo:"));
            }
        }

        private void MostrarNombres()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                listBox1.Items.Add(nombres[i] + " - "+sueldos[i]);
            }
        }

        #endregion

        private void btnCarga_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnMostrarNombres_Click(object sender, EventArgs e)
        {
            MostrarNombres();
        }
    }
}
