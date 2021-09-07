<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="ASP_NET_SQLCONEXION_SQLCOMMAND.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css/estilos.css" /> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="Contenido_Alta">
        <h1 id="altas">ALTAS</h1>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="Red">INTRODUZCA SU NOMBRE</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mail"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox3" ForeColor="Red" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"> MAIL INCORRECTO</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="BtnAlta" runat="server" Text="Alta" BackColor="#00A653" Width="81px" OnClick="BtnAlta_Click" ForeColor="White" /> <asp:Label ID="Label4" runat="server" ForeColor="#00A653"></asp:Label>
            <br />
            <br />
         <asp:HyperLink ID="HyperLink4" runat="server" Text="Retornar" NavigateUrl="~/Default.aspx"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
