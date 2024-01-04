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
using SistGimnasio.CLogica;


namespace SistGimnasio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {       
            try
            {
                TextReader Inicio = new StreamReader(txtUsuario.Text + ".txt");
                if (Inicio.ReadLine() == txtContraseña.Text)
                {

                    MessageBox.Show("Se inicio sesion correctamente");

                    frmMenu formMenu = new frmMenu();
                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Usuario o Contraseña incorrectos" + x, "Error");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {         
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro formRegistro = new frmRegistro();
            formRegistro.Show();
            this.Hide();
        }
    }
}
