using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;

namespace Logica
{
    public class BDLogica
    {

        public void EjecutarScript(String pEsquema)
        {
            ManejadorBaseDatos.Instancia.EjecutarScript(pEsquema);
        }
    }
}
