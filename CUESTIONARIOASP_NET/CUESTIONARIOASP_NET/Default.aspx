<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CUESTIONARIOASP_NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/estilos.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img alt="" src="img/cuestionario.png" style="height: 105px; width: 443px" /><br />
            <br />
            2<label> ¿Que es un diagrama de Clase?</label>
            <br />
            <label>Seleccione una:</label>
            </br>
          <asp:RadioButton ID="RadioButton1" runat="server" Text= "a) Muestra un conjunto de elementos, como las clases y sus tipos, junto con sus contenidos y relaciones" />
            </br>
            <asp:RadioButton ID="RadioButton2" runat="server" Text= "b) Es un gráfico de elementos clasificadores conectados por varias relaciones en tre tablas de la base de datos.." />
            </br>
            <asp:RadioButton ID="RadioButton3" runat="server" Text= "c) Ambas son correctas" />
            </br>
           <asp:RadioButton ID="RadioButton4" runat="server" Text= "d) Ambas son falsas" />
            <br />
            </br>
            6<label> Características de .NET</label><br />
            <label>Seleccione una:</label>
            <br />
          <asp:RadioButton ID="RadioButton5" runat="server" Text= "a)  No condiciona la elección del lenguaje" OnCheckedChanged="RadioButton5_CheckedChanged" />
            <br />
            <asp:RadioButton ID="RadioButton6" runat="server" Text= "b)  El código fuente no se compila" />
            <br />
            <asp:RadioButton ID="RadioButton7" runat="server" Text= "c) Es un lenguaje interpretado" />
            <br />
           <asp:RadioButton ID="RadioButton8" runat="server" Text= "d) Ambas son falsas" />
    
            <br />
            <br />
            3<label> ¿Que es el modelado de clases?</label><br />
            <label>Seleccione una:</label>
            <br />
          <asp:RadioButton ID="RadioButton9" runat="server" Text= "a)  El modelado de datos consiste en interpretar cada una delas clases y objetos y los elementos, atributos y propiedades contienen." OnCheckedChanged="RadioButton5_CheckedChanged" />
            <br />
            <asp:RadioButton ID="RadioButton10" runat="server" Text= "b)  Tiene que haber un modelado en el Vocabulario, es decir, identificar los conceptos que usan los usuarios (casos de uso)" />
            <br />
            <asp:RadioButton ID="RadioButton11" runat="server" Text= "c) Ambas son correctas" />
            <br />
           <asp:RadioButton ID="RadioButton12" runat="server" Text= "d) Ambas son falsas" />
    
            <br />
            <br />
            <br />
            4<label> Una clase debe: </label>
            <br />
            <label>Seleccione una:</label>
            <br />
          <asp:RadioButton ID="RadioButton13" runat="server" Text= "a)   Contener un conjunto mayor de métodos, el mayor posible" OnCheckedChanged="RadioButton5_CheckedChanged" />
            <br />
            <asp:RadioButton ID="RadioButton14" runat="server" Text= "b)  Ser compleja, compacta y única e indivisible" />
            <br />
            <asp:RadioButton ID="RadioButton15" runat="server" Text= "c)  Las dos anteriores podrían ser ciertas" />
            <br />
           <asp:RadioButton ID="RadioButton16" runat="server" Text= "d)  Ninguna es del todo cierta" />
            <br />
           <asp:RadioButton ID="RadioButton17" runat="server" /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="&quot;FALTA LA RESPUESTA&quot;" ControlToValidate="TextBox1" ForeColor="#FF3300">INTRODUCCE UNA RESPUESTA</asp:RequiredFieldValidator>
    
            <br />
            <br />
            Introduce el rango adecuado entre(10 y 20)<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="ERROR DE RANGO" ForeColor="Red" MaximumValue="20" MinimumValue="10" Type="Integer">EL VALOR NO ESTÁ EN EL RANGO PERMITIDO</asp:RangeValidator>
            <br />
            <br />
            Contraseña:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Comprueba contraseña:<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="CompareValidator" ForeColor="Red">LAS CONTRASEÑAS NO COINCIDEN</asp:CompareValidator>
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            Introduce un Email:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="RegularExpressionValidator" ForeColor="#FF3300" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$">Email incrrecto</asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Ver Respuesta" BackColor="Silver" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
    
        </div>
       
    </form>
</body>
</html>
