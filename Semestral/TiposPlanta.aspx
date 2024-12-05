<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TiposPlanta.aspx.cs" Inherits="Semestral.TiposPlanta" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registrar Tipo de Planta</h2>
    <div class="form-container">
        <asp:TextBox ID="txtTipoPlanta" runat="server" Placeholder="Nombre de Planta" CssClass="form-control"></asp:TextBox>
        <asp:Button ID="btnRegistrarTipoPlanta" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrarTipoPlanta_Click" />
    </div>

    <h2>Plantas Registradas</h2>
    <asp:GridView ID="gvTiposPlanta" runat="server" CssClass="grid-view" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>



