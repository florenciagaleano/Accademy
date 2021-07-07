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
    public partial class FrmEj1 : Form
    {
        public FrmEj1()
        {
            InitializeComponent();
        }

        private void btnPromociono_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota1.Text);
            double nota3 = Convert.ToDouble(txtNota1.Text);
            double promedio = (nota1 + nota2 + nota3) / 3;
            if(promedio >= 7)
            {
                MessageBox.Show("Promocionado");
            }
        }
    }
}
