<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Riego.aspx.cs" Inherits="Semestral.Riego" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Registrar Riego</h2>
    <div class="form-container">
        <asp:DropDownList ID="ddlUsuarios" runat="server" CssClass="form-control"></asp:DropDownList>
        <asp:DropDownList ID="ddlPlantas" runat="server" CssClass="form-control"></asp:DropDownList>
        <asp:Button ID="btnRegistrarRiego" runat="server" Text="Registrar Riego" CssClass="btn btn-primary" OnClick="btnRegistrarRiego_Click" />
    </div>

    <h2>Riegos Registrados</h2>
    <asp:GridView ID="gvRiegos" runat="server" CssClass="grid-view" AutoGenerateColumns="true"></asp:GridView>
</asp:Content>

