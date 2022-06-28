<%@ Page Title="Usuarios" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TPWebForms_Saucedo_Tejeda.Usuarios" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Usuarios</h1>
    <hr>
    <asp:GridView ID="dgvUsuarios" CssClass="table" runat="server">
    </asp:GridView>

    <!-- Button trigger modal (botones)-->
<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
  Agregar
</button>
   <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal2">
  Eliminar
</button>
      <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModal3">
  Modificiar
</button>

<!-- Modal Agregar-->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Agregar empleado</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
              <h6>Nombre</h6>
              <asp:TextBox ID="txtNombre" runat="server" />
          <h6>Apellido</h6>
          <asp:TextBox ID="txtApellido" runat="server" />
          <h6>Usuario</h6>
          <asp:TextBox ID="txtUsuario" runat="server" />
          <h6>Contrasenia</h6>
          <asp:TextBox ID="txtContrasenia" runat="server" />
         <h6>Tipo</h6>
          <asp:TextBox ID="txtTipo" runat="server" />
      </div>
      <div class="modal-footer">
          <div>
          </div>
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
          <asp:Button ID="btnConfirmar" Text="Confirmar" CssClass="btn btn-primary" runat="server" OnClick="btnConfirmar_Click" />
      </div>
    </div>
  </div>
</div>

    <!-- Modal Eliminar-->
<div class="modal fade" id="exampleModal2" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel2">Eliminar empleado</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
              <h6>ID</h6>
              <asp:TextBox ID="txteliminar" runat="server" />
      </div>
      <div class="modal-footer">
          <div>
          </div>
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
          
          <asp:Button ID="btnEliminar" Text="Confirmar" CssClass="btn btn-primary" runat="server" OnClick="btnEliminar_Click" />
      </div>
    </div>
  </div>
</div>

        <!-- Modal Modiciar-->
<div class="modal fade" id="exampleModal3" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel3">Modificar Empleado</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
      <div class="modal-body">
              <h6>ID</h6>
              <asp:TextBox ID="txtmodificar" runat="server" />
                        <h6>Nombre</h6>
              <asp:TextBox ID="txtname" runat="server" />
          <h6>Apellido</h6>
          <asp:TextBox ID="txtsecond" runat="server" />
          <h6>Usuario</h6>
          <asp:TextBox ID="txtuser" runat="server" />
          <h6>Contrasenia</h6>
          <asp:TextBox ID="txtpass" runat="server" />
         <h6>Tipo</h6>
          <asp:TextBox ID="txttipe" runat="server" />
      </div>
      <div class="modal-footer">
          <div>
          </div>   
          
          <asp:Button ID="btnbuscar" Text="Buscar" CssClass="btn btn-success" runat="server" OnClick="btnbuscar_Click" />

        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
          <asp:Button ID="btnModificar" Text="Confirmar" CssClass="btn btn-primary" runat="server" OnClick="btnModificar_Click"  />
            </ContentTemplate>
        </asp:UpdatePanel>
          
      </div>
    </div>
  </div>
</div>


</asp:Content>