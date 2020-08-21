using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfLinq_PracticaExamen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IMetodos
    {

        private double diferenciaAnual { get; set; }
        private double comision { get; set; }
        private bool validacion { get; set; }

        Empresa bd = new Empresa();


        public List<Venta> ObtenerVentasPorIdentificacion(string cedula)
        {
            var consulta = from vt in bd.Ventas
                           where vt.Cedula.Equals(cedula)
                           select vt;

            return consulta.ToList();

        }
        //-------------------------------------------------------------------------------
        public double CalcularDiferenciaAnual(double anioAnterior, double anioActual)
        {
            diferenciaAnual = (anioActual - anioAnterior);

            return diferenciaAnual;
        }
        //-------------------------------------------------------------------------------
        public double CalcularComision(double ventasAnuales, double cuotaAnual)
        {
            const int divisible = 100;
            const double porcentaje = 0.05;


            if (ventasAnuales > cuotaAnual)
            {
                comision = (ventasAnuales * (porcentaje / divisible));
            }

            return comision;

        }
        

    }
}