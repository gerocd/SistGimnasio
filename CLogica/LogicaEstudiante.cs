using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using SistGimnasio.CDatos;
using SistGimnasio.CPresentacion;

namespace SistGimnasio.CLogica
{
    internal class LogicaEstudiante
    {
        /* ------ Estudiante ------ */
        public int ID { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int CursoID { get; set; }

        /* ------------- Conexion Logica - Sql - Mostrar Estudiante -------------*/
        public DataTable mostrartablaL()
        {
            EstudianteD EstudianteD = new EstudianteD();
            DataTable tabla = new DataTable();
            tabla = EstudianteD.mostrartablaD();
            return tabla;
        }

        /* ------------- Conexion Logica - Sql - Consultar Estudiante -------------*/
        public LogicaEstudiante Consultar(string ID)
        {
            EstudianteD oEstudianteD = new EstudianteD();
            LogicaEstudiante oEstudiante = new LogicaEstudiante();
            oEstudiante = oEstudianteD.ConsultarD(ID);
            return oEstudiante;
        }

        /* ------------- Conexion Logica - Sql - Agregar Estudiante -------------*/
        public void Agregar(LogicaEstudiante agrEstudiante)
        {
            EstudianteD sqlclass2 = new EstudianteD();
            sqlclass2.AgregarD(agrEstudiante);
        }

        /* ------------- Conexion Logica - Sql - Eliminar Estudiante -------------*/
        public void Eliminar(string ID)
        {
            EstudianteD sqlclass2 = new EstudianteD();
            sqlclass2.EliminarD(ID);
        }

        /* ------------- Conexion Logica - Sql - Modificar Estudiante -------------*/
        public void Modificar(LogicaEstudiante agrEstudiante, string ID)
        {
            EstudianteD sqlclass2 = new EstudianteD();
            sqlclass2.ModificarD(agrEstudiante, ID);
        }
    }
}
