<%@ Page Title="Detalle meda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleMesa.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda.DetalleMesa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestion de mesas</h2>
    <h3>
        <asp:Label runat="server" ID="tituloMesa" Text="label"></asp:Label></h3>
    <ul style="list-style: none;">
        <li>Mesero a cargo: <asp:textbox runat="server" ID="tbxMesero"></asp:textbox> </li>
        <li>Estado: <asp:textbox runat="server" ID="tbxEstado"></asp:textbox> </li>
    </ul>
</asp:Content>
