using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceGenerarAsiento
{
    [ServiceContract]
    public interface IERPAsientos
    {

        [OperationContract]
        int ingresarNuevoAsiento(int pIdTipoAsiento, DateTime pFechaContabilizado, DateTime pFechaDocumento, string pReferencia1, string pReferencia2);

        [OperationContract]
        int ingresarCuentasAsiento(int pIdAsiento, int pIdCuenta, int pMontoLocal, int pMontoSistema, bool pDebeHaber);
    }
}
