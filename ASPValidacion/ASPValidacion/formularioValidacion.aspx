<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formularioValidacion.aspx.cs" Inherits="ASPValidacion.formularioValidacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/StyleSheet.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label1" runat="server" Text="Nombre de usuario:" Width="250px"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtNombreUsuario" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombreUsuario" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtClave" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtClave" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label3" runat="server" Text="Repita la clave:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtRepClave" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las claves deben ser iguales" ControlToCompare="txtClave" ControlToValidate="txtRepClave" ForeColor="Red"></asp:CompareValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label4" runat="server" Text="Correo electrónico:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtEmail" CssClass="ancho" runat="server"></asp:TextBox><br />              
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Introduce un email valido" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Display = "Dynamic" ControlToValidate="txtEmail" ForeColor="Red"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtApellido" CssClass="ancho" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtNombre" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label7" runat="server" Text="Pais de Origen:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:DropDownList ID="ddlPais" CssClass="ancho" AutoPostBack="True" runat="server">
                        <asp:ListItem Selected="True" Value="Argentina"> Argentina </asp:ListItem>
                        <asp:ListItem Value="Spain"> España </asp:ListItem>
                        <asp:ListItem Value="Portugal"> Portugal </asp:ListItem>
                        <asp:ListItem Value="Francia"> Francia</asp:ListItem>
                        <asp:ListItem Value="USA"> Estado Unidos </asp:ListItem>
                    </asp:DropDownList><br />
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label8" runat="server" Text="Provincia:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtProvincia" CssClass="ancho" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label9" runat="server" Text="Código Postal:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtCP" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Está fuera de rango" MaximumValue="34000" MinimumValue="33000" ControlToValidate="txtCP" ForeColor="Red" Type="Integer">No está dentro del rango</asp:RangeValidator>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label10" runat="server" Text="Género: "></asp:Label>
                </div>
                <div class="controles">
                    <asp:Panel ID="Panel1" CssClass="ancho" runat="server" Width="250px">
                        <asp:RadioButton ID="p1a" runat="server" GroupName="p1" Text="&nbsp&nbsp Hombre" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1b" runat="server" GroupName="p1" Text="&nbsp&nbsp Mujer" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1c" runat="server" GroupName="p1" Text="&nbsp&nbsp Otro" AutoPostBack="true" Checked="True" /><br />
                    </asp:Panel>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label11" runat="server" Text="Fecha de nacimiento:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:Calendar ID="calFechaNacimiento" runat="server"></asp:Calendar><br />                  
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label12" runat="server" Text="Comentarios:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtComentarios" CssClass="ancho" runat="server" Height="100px" TextMode="MultiLine" Wrap="False"></asp:TextBox>
                </div>
            </div>
            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label13" runat="server" Text="&nbsp"></asp:Label>
                </div>
                <div class="controles">
                    <asp:CheckBox ID="chkTerminos" runat="server" Text="Acepto los términos y condiciones" /><br />
                    <asp:Label ID="Label15" runat="server" CssClass="validacion" Text="&nbsp" ForeColor="Red"></asp:Label>
                </div>
            </div>
            <div class="titulos">
                    <asp:Label ID="Label14" runat="server" Text="&nbsp"></asp:Label>
                </div>
            <div class="controles">
                <asp:Button ID="btnAceptar" CssClass="boton" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
            </div>
            <div class="filas validacion">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Blue" />
            </div>
        </div>        
    </form>
</body>
</html>
