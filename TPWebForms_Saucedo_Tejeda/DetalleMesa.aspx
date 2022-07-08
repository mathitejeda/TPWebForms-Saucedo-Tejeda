<%@ Page Title="Detalle meda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleMesa.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda.DetalleMesa" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestion de mesas</h2>
    <h3>
        <asp:Label runat="server" ID="tituloMesa" Text="label"></asp:Label></h3>
    <p>
        <%if (pedido.ID == 0)
          { %>
        <h4>Esta mesa no tiene ningun pedido activo!</h4>
        <asp:Button runat="server" ID="btnGenerarPedido" Text="Generar pedido" />
        <%}
          else
          {%>
        <asp:Repeater runat="server" ID="listadoPedido">
            <ItemTemplate>
                <ul>
                    <li>
                        <%#Eval("nombre") + ": "%><%#Eval("Cantidad") %>
                    </li>
                </ul>
            </ItemTemplate>
        </asp:Repeater>
        <%} %>
    </p>
    <ul style="list-style: none;">
        <li>Mesero a cargo:
            <asp:TextBox runat="server" ID="tbxMesero"></asp:TextBox>
        </li>
        <li>Estado:
            <asp:TextBox runat="server" ID="tbxEstado"></asp:TextBox>
        </li>
    </ul>
</asp:Content>
