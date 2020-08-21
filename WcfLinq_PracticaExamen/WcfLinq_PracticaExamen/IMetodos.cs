using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfLinq_PracticaExamen
{
    [ServiceContract]
    interface IMetodos
    {

        [OperationContract]
        List<Venta> ObtenerVentasPorIdentificacion(string cedula);

        //-------------------------------------------------------------------------------
        [OperationContract]
        double CalcularDiferenciaAnual(double anioAnterior, double anioActual);

        //-------------------------------------------------------------------------------
        [OperationContract]
        double CalcularComision(double ventasAnuales, double cuotaAnual);

      
    }
}
