using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using SistGimnasio.CLogica;
using System.Windows.Forms;

namespace SistGimnasio.CDatos
{
    internal class FacturacionD
    {
        public DataTable mostrartablaDF()
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = dbGimnasio; integrated security = true");
            string _cadena = "SELECT * FROM Facturacion";
            SqlDataReader leer;
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand(_cadena, conexion);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Close();
            return tabla;
        }

        public void AgregarDF(LogicaFact agrFactura)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = dbGimnasio; integrated security = true");
            //insert into (NOMBRE DE LA TABLA) (COLUMNAS DE LA TABLA) values (DATOS QUE SE AGREGAN ('"+ string +"') ("+ int +"))
            string cadena = "insert into Facturacion(Id,Cantidad,Pack,Precio_Unitario) values (" + agrFactura.Id + "," + agrFactura.Cantidad + ",'" + agrFactura.Pack + "','" + agrFactura.PrecioUnitario + "')";
            conexion.Open();

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("Los datos se guardaron correctamente ");
            conexion.Close();
        }

        public void EliminarDF(string codigoF)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = dbGimnasio; integrated security = true");
            //insert into (NOMBRE DE LA TABLA) (COLUMNAS DE LA TABLA) values (DATOS QUE SE AGREGAN ('"+ string +"') ("+ int +"))
            string cadena = " Delete from Facturacion where Id =" + codigoF;
            conexion.Open();

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show(" Plan eliminado correctamente ");
            conexion.Close();
        }

        public void ModificarDF(LogicaFact agrFactura, string codigoF)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = dbGimnasio; integrated security = true");
            conexion.Open();

            string cadena = "update Facturacion set Cantidad='" + agrFactura.Cantidad + "', Pack='" + agrFactura.Pack + "',DNI=" + agrFactura.PrecioUnitario + ",Telefono ='" + agrFactura.ImporteFinal + "' where Id=" + codigoF; /* el where dni es la referencia para modificar */
            SqlCommand comando = new SqlCommand(cadena, conexion);

            int cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {

                agrFactura.Cantidad = 0;
                agrFactura.Pack = "";
                agrFactura.PrecioUnitario = "";               
                MessageBox.Show("Se modificó el plan. ");
            }
            else
            {
                MessageBox.Show("No existe un plan con el -ID- ingresado");              
            }

            conexion.Close();
        }

        public LogicaFact mostrarF()
        {
            LogicaFact ofactura = new LogicaFact();
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = dbGimnasio; integrated security = true");

            string cadena = "SELECT * FROM Facturacion";

            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {           
                ofactura.Cantidad = int.Parse(registro["Cantidad"].ToString());
                ofactura.Pack = registro["Pack"].ToString();
                ofactura.PrecioUnitario = registro["Precio_Unitario"].ToString();
            }

            conexion.Close();
            return ofactura;
        }

    }
}
