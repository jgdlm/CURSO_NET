<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario de Contacto.aspx.cs" Inherits="FORMULARIO_DE_VALIDACION_ASP_NET.Formulario_de_Contacto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" href="css/estilos.css" /> 
    <title>Formulario de Contacto</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Nombre de Usuario:"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox1" ForeColor="Red">DEBE DE INTRODUCCIR EL NOMBRE DE USUARIO</asp:RequiredFieldValidator>
             <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
             <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Repita la Clave:"></asp:Label><asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="CompareValidator" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ForeColor="Red">LAS CONTRASEÑAS NO COINCIDEN</asp:CompareValidator>
             <br />
            <br />
             <asp:Label ID="Label4" runat="server" Text="Correo Electrónico:"></asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox4" ForeColor="Red" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$">DIRECCIÓN DE CORREO ELECTRÓNICO INCORRECTA</asp:RegularExpressionValidator>
             <br />
            <br />
             <asp:Label ID="Label5" runat="server" Text="Apellido:"></asp:Label><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox5" ForeColor="Red">INTRODUZCA SU APELLIDO</asp:RequiredFieldValidator>
             <br />
            <br />
             <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox6" ForeColor="Red">INTRODUZCA SU NOMBRE</asp:RequiredFieldValidator>
             <br />
            <br />
             <asp:Label ID="Label7" runat="server" Text="Pais de origen:"></asp:Label><asp:DropDownList ID="DropDownList1" runat="server">
                 <asp:ListItem>Argentina</asp:ListItem>
                  <asp:ListItem>España</asp:ListItem>
                  <asp:ListItem>Portugal</asp:ListItem>
                  <asp:ListItem>Francia</asp:ListItem>
                  <asp:ListItem>Reino Unido</asp:ListItem>
             </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" Text="SELECCIONE UN PAIS" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
             <br />
            <br />
             <asp:Label ID="Label8" runat="server" Text="Provincia:"></asp:Label><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="TextBox7" ForeColor="Red">INTRODUZCA UNA PROVINCIA</asp:RequiredFieldValidator>
             <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Código Postal:"></asp:Label><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" Type="Integer" Text="INTRODUZCA UN CÓDIGO POSTAL CUYO RANGO ES 33011 AL 32210" ControlToValidate="TextBox8" ForeColor="Red" MaximumValue="33011" MinimumValue="32210"></asp:RangeValidator>

             <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Sexo:"></asp:Label><asp:RadioButton ID="RadioButton1" runat="server" Text="Hombre" GroupName="Sexo" Checked="True" />
             <asp:RadioButton ID="RadioButton2" runat="server" Text="Mujer" GroupName="Sexo" />
             <br />
             <br />
            <asp:Label ID="Label11" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
             <br />
            <asp:Label ID="Label12" runat="server" Text="(dd/mm/aaaa)"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
             <br />
            <asp:Label ID="Label13" runat="server" Text="Comentarios"></asp:Label><textarea id="TextArea1" cols="20" rows="2"></textarea>
            <br />
            <asp:Label ID="Label14" runat="server" Text="Acepto los terminos <br/>
        y condiciones"></asp:Label><asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" /><asp:Label ID="Label16" runat="server" ForeColor="#FF3300"></asp:Label>
            <br />
            <br />
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="71px" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
