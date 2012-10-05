using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public static class AsientoDA
    {
        public static Entities ObtenerAsientos(DateTime FechaInicio, DateTime FechaFinal)
        {
            Entity parametros = new Entity();
            parametros.Set("p_Fecha_inicio", FechaInicio);
            parametros.Set("p_Fecha_fin", FechaFinal);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("consultar_asiento", parametros);
            Entities resultado_table = (Entities)resultado.Get("table");
            return resultado_table;
        }

        public static Entity IngresarAsiento(DateTime pFechaDocumento) {
            Entity parametros = new Entity();
            parametros.Set("pFechaContabilizado", DateTime.Now);
            parametros.Set("pFechaDocumento", pFechaDocumento);
            Entity resultado = ManejadorBaseDatos.Instancia.EjecutarSP("consultar_asiento", parametros);
            return resultado;
        }

    }
}
