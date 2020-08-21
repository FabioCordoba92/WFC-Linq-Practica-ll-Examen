<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <fieldset style="border-radius:8px;">
                <legend  style="border-radius:15px;background-color:gainsboro;padding:10px;">CONSULTA DE VENTAS</legend>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lbl_Consulta" runat="server" Text="Ingrese la cedula:"></asp:Label>
                &nbsp;<asp:TextBox ID="txt_Consulta" runat="server" placeholder="0-000-000" style="text-align: center"></asp:TextBox>
&nbsp;
                <asp:Label ID="lbl_Mensaje" runat="server" Text="" ForeColor="Red"></asp:Label>
                <br />
                <br />
                &nbsp;
                <asp:Button ID="btnConsulta" runat="server" Text="Consultar" Width="266px" OnClick="btnConsulta_Click" />
                <br />
                <br />
                <br />
            </fieldset>
            <br />
            <br />
            <br />
            <fieldset style="border-radius:8px;display:block;">
                <legend style="border-radius:15px;background-color:gainsboro;padding:10px;">RESULTADOS DE LA CONSULTA</legend>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lbl_Cedula" runat="server" Text="Cedula:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Cedula" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_Bonificacion" runat="server" Text="Bonificaion:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Bonificacion" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <br />
                <br />
&nbsp;
                <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Nombre" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_PorcComision" runat="server" Text="Porc. Comision:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_PorcComision" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <br />
                <br />
&nbsp;
                <asp:Label ID="lbl_Jefe" runat="server" Text="Jefe:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Jefe" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_VentasAnuales" runat="server" Text="Ventas Anuales:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_VentasAnuales" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <br />
                <br />
&nbsp;
                <asp:Label ID="lbl_Provincia" runat="server" Text="Provincia:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_Provincia" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_VentasAnioAnt" runat="server" Text="Ventas año Anterior:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_VentasAnioAnt" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <br />
                <br />
&nbsp;
                <asp:Label ID="lbl_Cuota" runat="server" Text="Cuota Anual:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_CuotaAnual" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lbl_PromedioMensual" runat="server" Text="Promedio mensual:" Width="170px"></asp:Label>
                <asp:TextBox ID="txt_PromedioMensual" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <br />
                <br />
                <br />
                <br />
            </fieldset>
            <br />
            <br />
            <fieldset  style="border-radius:8px;display:block;">
                <legend style="border-radius:15px;background-color:gainsboro;padding:10px;">REALIZAR CÁLCULOS</legend>
                <br />
                <br />
&nbsp;
                <asp:Label ID="lbl_Diferecias" runat="server" Text="Difrencia entre ventas anuales:" Width="250px"></asp:Label>
                <asp:TextBox ID="txt_DiferenciaAnual" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <asp:Button ID="btnCalcularComision" runat="server" Text="Calcular comosión" Width="266px" style="margin-left:30px;" OnClick="btnCalcularComision_Click"/>
                <br />
                <br />
                &nbsp;
                <asp:Label ID="lbl_Comision" runat="server" Text="La comisón es de:" Width="250px"></asp:Label>
                <asp:TextBox ID="txt_Comision" runat="server" ReadOnly="True" style="text-align: center"></asp:TextBox>
                <asp:Label ID="lbl_MensajeComision" runat="server" Text="" style="margin-left:30px;color:red;"></asp:Label>
                <br />
                <br />
                <br />


            </fieldset>
            <br />
            <asp:GridView ID="gridViewVentas" runat="server" visible="false" OnRowDataBound="gridViewVentas_RowDataBound">
            </asp:GridView>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
