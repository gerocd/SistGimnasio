using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using SistGimnasio.CPresentacion;

namespace SistGimnasio.CPresentacion
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"C:\Users\patri\OneDrive\Escritorio\Facultad\Lab 2 etapa\Grupo6\SistDrugstoreGrupo6\SistGimnasio\bin\Debug\" + txtUsuarioR.Text + ".txt", true);
                RegistrarUsuario.WriteLine(txtContraseñaR.Text);
                RegistrarUsuario.Close();

                MessageBox.Show(" Se registro correctamente ");

                frmLogin formLogin = new frmLogin();
                formLogin.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show(" Ocurrio un error" + x, "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            this.Hide();
        }

        private void txtContraseñaR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
