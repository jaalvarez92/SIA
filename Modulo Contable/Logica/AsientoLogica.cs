using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using AccesoDatos;

namespace Logica
{
    public static class AsientoLogica
    {
        public static Entities ObtenerAsientos(DateTime FechaInicio, DateTime FechaFinal)
        {
            return ConsultarAsientoDA.ObtenerAsientos(FechaInicio, FechaFinal);
        }
    }
}
