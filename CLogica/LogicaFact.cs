using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using SistGimnasio.CPresentacion;
using SistGimnasio.CDatos;

namespace SistGimnasio.CLogica
{
    internal class LogicaFact
    {
        /* ------ Factura ------ */
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public string Pack { get; set; }
        public string PrecioUnitario { get; set; }
        public string ImporteFinal { get; set; }

        /* ------------- Conexion Logica - Sql - Mostrar Tabla -------------*/
        public DataTable mostrartablaLF()
        {
            FacturacionD FacturaD = new FacturacionD();
            DataTable tabla = new DataTable();
            tabla = FacturaD.mostrartablaDF();
            return tabla;
        }

        /* ------------- Conexion Logica - Sql - Agregar Factura-------------*/
        public void AgregarF(LogicaFact agrFactura)
        {
            FacturacionD sqlclass2 = new FacturacionD(); 
            sqlclass2.AgregarDF(agrFactura); 
        }

        /* ------------- Conexion Logica - Sql - Eliminar Factura -------------*/
        public void EliminarF(string codigo)
        {
            FacturacionD sqlclass2 = new FacturacionD(); 
            sqlclass2.EliminarDF(codigo); 
        }

    }
}

