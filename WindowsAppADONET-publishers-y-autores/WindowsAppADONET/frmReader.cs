using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Datos;

namespace WindowsAppADONET
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            gridAuthor.DataSource = DacAuthor.Select_TraerTodos();
        }
    }
}
