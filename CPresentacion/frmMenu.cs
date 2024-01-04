using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistGimnasio.CPresentacion;

namespace SistGimnasio.CPresentacion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.Show();
            this.Hide();

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            frmFactura factura = new frmFactura();
            factura.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void rdbSalir_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
