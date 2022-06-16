<%@ Page Title="Usuarios" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda.Usuarios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Usuarios</h1>
    <hr>
    <asp:GridView ID="dgvUsuarios" CssClass="table" runat="server">
        <Columns>
            <asp:BoundField HeaderText="ID" DataField="..." />
            <asp:BoundField HeaderText="Nivel" DataField="..." />
            <asp:BoundField HeaderText="Nombre" DataField="..." />
            <asp:BoundField HeaderText="Usuario" DataField="..." />
            <asp:BoundField HeaderText="Turno"  DataField="..."/>
            <asp:DynamicField HeaderText="Accion" />
        </Columns>
    </asp:GridView>

</asp:Content>