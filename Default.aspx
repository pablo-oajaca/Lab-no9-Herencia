<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_no9_Herencia._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
      <h1> Control de Alumnos </h1>
    </div>

    <div class="row">
        <div class="row">
                    <div class="col-xs-3" style="left: 0px; top: 0px">
                                Nombre
                                <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                            </div>
                        <div class="col-xs-3">
                            Apellido
                            <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
                        </div>
                        <div class="col-xs-6">
                            Dirección
                            <asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
                        </div>
           </div>
        <br />
        <div class="col-xs-6" style="background-color:aliceblue">
            Fecha de Nacimiento
            <asp:Calendar ID="CalendarNacimiento" runat="server"></asp:Calendar>    
        </div> 
        <div class="col-xs-6" style="background-color:aliceblue">
            <strong>Notas:</strong><br />
            Curso
            <asp:DropDownList ID="DropDownListCurso" runat="server">
                <asp:ListItem>Matematica</asp:ListItem>
                <asp:ListItem>Programación</asp:ListItem>
                <asp:ListItem>Electrónica</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Nota
            <asp:TextBox ID="TextBoxNota" runat="server"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBoxNota" ErrorMessage="Debe ingresar un número entre 1 y 100" MaximumValue="100" MinimumValue="1" Type="Integer" SetFocusOnError="True"></asp:RangeValidator>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Ingresar Nota" class="btn btn-primary btn-sm" OnClick="Button2_Click" />
        </div> 
    </div>
    <div>
        <asp:Button ID="Button1" runat="server" Text="Guardar datos" class="btn btn-warning btn-lg" OnClick="Button1_Click" />
    </div>

</asp:Content>