using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    ServiceReference1.MetodosClient proxy = new ServiceReference1.MetodosClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        //El mensaje se inicia vacio para que no sea visible al cargarse la pagina
        lbl_Mensaje.Text = "";
        lbl_MensajeComision.Text = "";
        
    }

    //--En el siguiente evento del boton para realizar consultas (btnConsulta) básicamente si está vacio indica un mensaje par asistir al usuario
    //  caso contrario procede a enviar por parametro el dato y a llenar el gridview
    protected void btnConsulta_Click(object sender, EventArgs e)
    {
        txt_DiferenciaAnual.Text = String.Empty;
        txt_Comision.Text = String.Empty;

        if (txt_Consulta.Text == String.Empty)
        {
            lbl_Mensaje.Text = "Debe  ingresar un valor";
        }
        else
        {
            gridViewVentas.DataSource = proxy.ObtenerVentasPorIdentificacion(txt_Consulta.Text);
            gridViewVentas.DataBind();

            if (AlertaryLimpiar())
            {
                //--Se pasan los parametros de los datos para las operaciones de diferencias anuales 
                //  y calculo de comision

                txt_DiferenciaAnual.Text =  Convert.ToString(proxy.CalcularDiferenciaAnual(
                                            Convert.ToDouble(txt_VentasAnioAnt.Text),
                                            Convert.ToDouble(txt_VentasAnuales.Text)));
            }
           
        }

    }

    //------------------------------------------------------------------------------------------------------
    
    //--Este medoto genera un aviso en un label si la tabla está vacia (lo que quiere decir que no se encontró ningun dato al dar click en (buscar)
    //  de tal forma que el label muestra un mensaje indicando quen no se encontraron resultados y posteriormente limpia el contenido de los textBox
    //  en caso de que contenga datos de una busqueda anterior

    public bool AlertaryLimpiar()
    {
        if (gridViewVentas.Rows.Count.ToString() == "0")
        {

            lbl_Mensaje.Text = "No se encontraron resultados para: " + txt_Consulta.Text;
            txt_Cedula.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Jefe.Text = string.Empty;
            txt_Provincia.Text = string.Empty;
            txt_CuotaAnual.Text = string.Empty;
            txt_Bonificacion.Text = string.Empty;
            txt_PorcComision.Text = string.Empty;
            txt_VentasAnuales.Text = string.Empty;
            txt_VentasAnioAnt.Text = string.Empty;
            txt_PromedioMensual.Text = string.Empty;
            txt_DiferenciaAnual.Text = string.Empty;
            txt_Comision.Text = string.Empty;

            return false;
        }
        else
        {
            return true;
        }

       
    }
    //------------------------------------------------------------------------------------------------------

    //--Este metodo toma cada dato contenido en cada celda y lo pasa a los textbox segun corresponda
    protected void gridViewVentas_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            txt_Cedula.Text = e.Row.Cells[1].Text.Trim();
            txt_Nombre.Text = e.Row.Cells[4].Text.Trim();
            txt_Jefe.Text = e.Row.Cells[3].Text.Trim();
            txt_Provincia.Text = e.Row.Cells[7].Text.Trim();
            txt_CuotaAnual.Text = e.Row.Cells[2].Text.Trim();
            txt_Bonificacion.Text = e.Row.Cells[0].Text.Trim();
            txt_PorcComision.Text = e.Row.Cells[5].Text.Trim();
            txt_VentasAnuales.Text = e.Row.Cells[9].Text.Trim();
            txt_VentasAnioAnt.Text = e.Row.Cells[8].Text.Trim();
            txt_PromedioMensual.Text = e.Row.Cells[6].Text.Trim();

        }

    }
    //------------------------------------------------------------------------------------------------------

    protected void btnCalcularComision_Click(object sender, EventArgs e)
    {
        txt_Comision.Text = Convert.ToString(proxy.CalcularComision(
                            Convert.ToDouble(txt_VentasAnuales.Text),
                            Convert.ToDouble(txt_CuotaAnual.Text)));

        if (txt_Comision.Text == String.Empty || txt_Comision.Text == "0")
        {
            lbl_MensajeComision.Text = "Sus ventas anuales son menores que su cuota anual";
        }
    }
}

