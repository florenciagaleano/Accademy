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
    public partial class FrmEj3 : Form
    {
        public FrmEj3()
        {
            InitializeComponent();
        }

        private void FrmEj3_Load(object sender, EventArgs e)
        {
            //De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
            //a)  Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
            //b) Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
            //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            int ant = Convert.ToInt32(txtAntiguedad.Text);

            if(sueldo < 500 && ant >= 10)
            {
                sueldo = sueldo + sueldo * 20 / 100;
            }else if(sueldo < 500 && ant < 10)
            {
                sueldo = sueldo + sueldo * 5 / 100;
            }

            MessageBox.Show(sueldo.ToString());
        }
    }
}
