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
    public partial class FrmEj4 : Form
    {
        public FrmEj4()
        {
            InitializeComponent();
        }

        private void btnNavidad_Click(object sender, EventArgs e)
        {
            if(dateTimePickerFecha.Value.Day == 24 && dateTimePickerFecha.Value.Month == 12)
            {
                MessageBox.Show("Es navidad!");
            }else
            {
                MessageBox.Show("No es navidad");
            }
        }


    }
}
