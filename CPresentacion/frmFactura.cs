using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistGimnasio.CLogica;

namespace SistGimnasio.CPresentacion
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }    

        private LogicaFact RecuperarF()
        {
            LogicaFact Factura = new LogicaFact();

            Factura.Id = int.Parse(txtIdf.Text);
            Factura.Cantidad = int.Parse(txtCantidad.Text);
            Factura.Pack = txtPack.Text;
            Factura.PrecioUnitario = txtPrecioUnitario.Text;                    

            return Factura;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaFact LogicaFactAgregar = new LogicaFact();
            LogicaFactAgregar.AgregarF(RecuperarF());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            LogicaFact agrFactura = new LogicaFact();
            string codigo = txtIdf.Text;
            agrFactura.EliminarF(codigo);
            
            txtIdf.Text = "";
            txtCantidad.Text = "";
            txtPack.Text = "";
            txtPrecioUnitario.Text = "";          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogicaFact objFact = new LogicaFact();
            dgvFactura.DataSource = objFact.mostrartablaLF();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        double num1;
        double num2;
        private void button5_Click(object sender, EventArgs e)
        {
            double multiplicacion;
            num1 = Convert.ToDouble(txtCantidad.Text);
            num2 = Convert.ToDouble(txtPrecioUnitario.Text);

            multiplicacion = num1 * num2;
            txtBuscarPlan.Text = Convert.ToString(multiplicacion);
        }
    }
}
