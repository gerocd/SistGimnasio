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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private LogicaClientes Recuperar()
        {
            LogicaClientes Cliente = new LogicaClientes();

            Cliente.Nombre = txtNombre.Text;
            Cliente.Apellido = txtApellido.Text;
            Cliente.DNI = txtDni.Text;
            Cliente.Telefono = txtTelefono.Text;
            Cliente.Id = int.Parse(txtId.Text);
            
            return Cliente;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LogicaClientes class1Agregar = new LogicaClientes();
            class1Agregar.Agregar(Recuperar());      
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LogicaClientes objCliente = new LogicaClientes();
            dgvClientes.DataSource = objCliente.mostrartablaL();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            LogicaClientes Cliente = new LogicaClientes();
            string codigo = txtId.Text;
            Cliente.Modificar(Recuperar(), codigo);
            
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";          
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvClientes.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvClientes.SelectedCells[2].Value.ToString();
            txtDni.Text = dgvClientes.SelectedCells[3].Value.ToString();
            txtTelefono.Text = dgvClientes.SelectedCells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LogicaClientes agrClientes = new LogicaClientes();
            string codigo = txtId.Text;
            agrClientes.Eliminar(codigo);
            
            txtId.Text = "";          
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LogicaClientes ocliente = new LogicaClientes();
            LogicaClientes oCliente = new LogicaClientes();
            string codigo = txtId.Text;
            oCliente = ocliente.Consultar(codigo);

            
            txtId.Text = oCliente.Id.ToString(); 
            txtNombre.Text = oCliente.Nombre;
            txtApellido.Text = oCliente.Apellido;
            txtDni.Text = oCliente.DNI;
            txtTelefono.Text = oCliente.Telefono;

            rdbBuscar.Checked = false;


        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
        }

       
    }
}
