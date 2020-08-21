using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WcfLinq_PracticaExamen
{

    [Table(Name = "VentasxPersonas")]
    public class Venta
    {

        //-----------------------------------------------------
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public string Cedula { get; set; }
        //-----------------------------------------------------
        [Column]
        public string Nombre { get; set; }
        //-----------------------------------------------------
        [Column]
        public string Jefe { get; set; }
        //-----------------------------------------------------
        [Column]
        public int Provincia { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 CuotaAnual { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 Bonificacion { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 PorcComision { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 VentasAnuales { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 VentasAnioAnt { get; set; }
        //-----------------------------------------------------
        [Column]
        public UInt64 PromedioMensual { get; set; }

    
    }
}