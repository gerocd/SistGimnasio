using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SistGimnasio.CLogica;

namespace SistGimnasio.CDatos
{
    internal class EstudianteD
    {
        public DataTable mostrartablaD()
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = colegio; integrated security = true");
            string _cadena = "SELECT * FROM Estudiante";
            SqlDataReader leer;
            conexion.Open();
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand(_cadena, conexion);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Close();
            return tabla;
        }

        public void AgregarD(LogicaEstudiante agrEstudiante)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = colegio; integrated security = true");
            string cadena = "insert into Estudiante(ID, DNI, Nombre, Apellido, Edad, CursoID) values ('" + agrEstudiante.ID + "','" + agrEstudiante.DNI + "','" + agrEstudiante.Nombre + "','" + agrEstudiante.Apellido + "','" + agrEstudiante.Edad + "','" + agrEstudiante.CursoID + "')";
            conexion.Open();

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente ");
            conexion.Close();
        }

        public void EliminarD(string ID)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = colegio; integrated security = true");
            string cadena = " Delete from Estudiante where ID =" + ID;
            conexion.Open();

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado correctamente ");
            conexion.Close();
        }

        public void ModificarD(LogicaEstudiante agrEstudiante, string ID)
        {
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = colegio; integrated security = true");
            conexion.Open();

            string cadena = "update Estudiante set DNI='" + agrEstudiante.DNI + "', Nombre='" + agrEstudiante.Nombre + "',Apellido=" + agrEstudiante.Apellido + ",Edad ='" + agrEstudiante.Edad + "',CursoID ='" + agrEstudiante.CursoID + "' where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);

            int cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                agrEstudiante.DNI = "";
                agrEstudiante.Nombre = "";
                agrEstudiante.Apellido = "";
                agrEstudiante.Edad = "";
                agrEstudiante.CursoID = "";
                MessageBox.Show("Se modificaron los datos del estudiante");
            }
            else
            {
                MessageBox.Show("No existe un estudiante con el dato ingresado");
            }
            conexion.Close();
        }

        public LogicaEstudiante ConsultarD(string ID)
        {
            LogicaEstudiante oEstudiante = new LogicaEstudiante();
            SqlConnection conexion = new SqlConnection("server = COMPU01\\SQLEXPRESS ; database = colegio; integrated security = true");
            conexion.Open();
            string cadena = "select ID, DNI, Nombre, Apellido, Edad, CursoID from Estudiante where ID=" + ID;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                oEstudiante.ID = leer[0].ToString();
                oEstudiante.DNI = leer[1].ToString();
                oEstudiante.Nombre = leer[2].ToString();
                oEstudiante.Apellido = leer[3].ToString();
                oEstudiante.Edad = leer[4].ToString();
                oEstudiante.CursoID = leer[5].ToString();
            }
            conexion.Close();
            return oEstudiante;
        }
    }
}


