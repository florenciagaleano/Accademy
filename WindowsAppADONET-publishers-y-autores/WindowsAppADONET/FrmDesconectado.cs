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
    public partial class FrmDesconectado : Form
    {
        public FrmDesconectado()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            gridAutores.DataSource = DacAuthor.Select_TraerTodosDS();
        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            string aud_id = txtId.Text;

            gridAutores.DataSource = DacAuthor.Select_TraerPorId(aud_id);
        }
    }
}
