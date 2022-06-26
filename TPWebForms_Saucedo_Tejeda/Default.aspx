<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Resto</h1>
    <hr>
    <h2>Mesas</h2>
    <br>

    <!--Vista de mesas-->

    <div class="row row-cols-1 row-cols-md-3">
                <asp:Repeater runat="server" ID="cartasMesa">
            <ItemTemplate>
        <div class="col mb-4">
            <div class="card text-white <%#Eval("Ocupada").Equals(true)? "bg-danger":"bg-success"%>">
                <div class="card-header">Mesa nro: <%#Eval("ID") %></div>
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Ocupada").Equals(true)? "Ocupada":"Disponible"%></h5>
                    <p class="card-text">
                        This is a wider card with supporting text below as a natural lead-in to
						additional content. This card has even longer content than the first to show that equal height
						action.
                    </p>
                    <button type="button" class="btn btn-light" data-toggle="modal" data-target="#exampleModal">Light</button>
                </div>
            </div>
        </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Numero de mesa</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    Aca iria el pedido y si no un boton para levantar pedido
		  <a type="button" class="btn btn-light" href="VistaPedido">Administrar pedido</a>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-primary">Guardar</button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
