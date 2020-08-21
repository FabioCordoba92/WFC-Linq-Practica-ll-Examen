using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WcfLinq_PracticaExamen
{
    [Database (Name = "FABCORVA")]
    public class Empresa : DataContext
    {
        public Empresa() : base(Configuracion.CadenaConexion) { }
        public Table<Venta> Ventas;

    }
}