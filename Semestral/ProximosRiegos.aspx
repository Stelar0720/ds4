<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProximosRiegos.aspx.cs" Inherits="Semestral.ProximosRiegos" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Próximos Riegos</h2>
    <div class="form-container">
        <asp:DropDownList ID="ddlUsuarios" runat="server" CssClass="form-control"></asp:DropDownList>
        <asp:Button ID="btnVerProximosRiegos" runat="server" Text="Ver Próximos Riegos" CssClass="btn btn-primary" OnClick="btnVerProximosRiegos_Click" />
    </div>

    <h2>Listado de Próximos Riegos</h2>
    <asp:GridView ID="gvProximosRiegos" runat="server" CssClass="grid-view" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>

