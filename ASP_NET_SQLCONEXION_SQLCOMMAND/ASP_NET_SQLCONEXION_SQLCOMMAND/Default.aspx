<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_NET_SQLCONEXION_SQLCOMMAND.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <link rel="stylesheet" href="css/estilos.css" /> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Contenido_Default">
        <asp:HyperLink ID="HyperLink1" runat="server" Text="Alta de Usuario" NavigateUrl="~/alta.aspx"></asp:HyperLink>
        <br />
         <br />
         <asp:HyperLink ID="HyperLink2" runat="server" Text="Consulta de Usuario" NavigateUrl="~/consulta.aspx"></asp:HyperLink>
         <br />
          <br />
         <asp:HyperLink ID="HyperLink3" runat="server" Text="Baja de Usuario" NavigateUrl="~/baja.aspx"></asp:HyperLink>
         <br />
         <br />
         <asp:HyperLink ID="HyperLink4" runat="server" Text="Modificación de Usuario" NavigateUrl="~/modificacion.aspx"></asp:HyperLink>
         <br />
         <br />
        </div>
    </form>
</body>
</html>
