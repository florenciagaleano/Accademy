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
    public partial class FrmCaso1y2 : Form
    {
        public FrmCaso1y2()
        {
            InitializeComponent();
        }

        private void btnCalcularArea_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CalcularArea().ToString());
        }

        private double CalcularArea()
        {
            return Convert.ToDouble(txtArea.Text) * Convert.ToDouble(txtBase.Text);
        }

        private void btnVerTabla_Click(object sender, EventArgs e)
        {
            ImprimirTabla();
        }

        private void ImprimirTabla()
        {
            int res = 0;
            for (int i = 0; i < 10; i++)
            {
                res = Convert.ToInt32(numericUpDownNumero.Value) * i;
                string aMostrar = numericUpDownNumero.Value.ToString() + " * " + i.ToString() + " = " + res.ToString();
                lstTablas.Items.Add(aMostrar);
            }
        }
    }
}
