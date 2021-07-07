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
    public partial class FrmEj2 : Form
    {
        public FrmEj2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtNum1.Text);
            int num2 = Convert.ToInt32(txtNum2.Text);
            int num3 = Convert.ToInt32(txtNum3.Text);

            if(num1 < 10 && num2 < 10 && num3 < 10)
            {
                MessageBox.Show("Todos los numeros son menores a diez");
            }
        }
    }
}
