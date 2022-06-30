<%@ Page Title="Pedido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaPedido.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda.VistaPedido" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--TODO: Poner un hover para que cuando paso el cursor por arriba de la carta avise que podes ir a otro lado-->
    <h1>Pedido</h1>
    <hr>
    <h4>Bebidas</h4>
    <hr>
    <div class="card mb-3" style="max-width: 540px;" data-toggle="modal" data-target="#exampleModal">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="..." alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">Bebidas</h5>
                    <p class="card-text">
                        <asp:DropDownList ID="DdBebidas" runat="server"> </asp:DropDownList>
                    </p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>
    <hr>
    <h4>Entradas</h4>
    <hr>
    <div class="card mb-3" style="max-width: 540px;" data-toggle="modal" data-target="#exampleModal">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="..." alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">
<asp:DropDownList ID="DpEntradas" runat="server"> </asp:DropDownList>
                    </p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>
    <hr>
    <h4>Comida</h4>
    <hr>
    <div class="card mb-3" style="max-width: 540px;" data-toggle="modal" data-target="#exampleModal">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="..." alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">
<asp:DropDownList ID="DpComida" runat="server"> </asp:DropDownList>
                    </p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>
    <hr>
    <span class="h4">Postre</span>
    <hr>
    <div class="card mb-3" style="max-width: 540px;" data-toggle="modal" data-target="#exampleModal">
        <div class="row no-gutters">
            <div class="col-md-4">
                <img src="..." alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">Card title</h5>
                    <p class="card-text">
<asp:DropDownList ID="DpPostre" runat="server"> </asp:DropDownList>
                    </p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                </div>
            </div>
        </div>
    </div>

    <!-- Modal -->

</asp:Content>

