﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="ASP_NET_SQLCONEXION_SQLCOMMAND.consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css/estilos.css" /> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="consultas">CONSULTAS</h1>
             <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de usuario"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="Red">NOMBRE DE USUARIO INCORRECTO</asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="BtnConsultas" runat="server" Text="Consultas" BackColor="#3366FF" OnClick="BtnConsultas_Click" ForeColor="White" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" ForeColor="DarkBlue"></asp:Label>
            <br />
            <br />
         <asp:HyperLink ID="HyperLink4" runat="server" Text="Retornar" NavigateUrl="~/Default.aspx"></asp:HyperLink>
        </div>
    </form>
</body>
</html>
