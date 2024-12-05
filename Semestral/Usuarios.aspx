<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Semestral.Usuarios" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registrar Usuario</h2>
    <div class="form-container">
        <asp:TextBox ID="txtNombreUsuario" runat="server" Placeholder="Nombre" CssClass="form-control"></asp:TextBox>
        <asp:TextBox ID="txtEmailUsuario" runat="server" Placeholder="Email" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnRegistrarUsuario" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrarUsuario_Click" />
    </div>

    <h2>Usuarios Registrados</h2>
    <asp:GridView ID="gvUsuarios" runat="server" CssClass="grid-view" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>



