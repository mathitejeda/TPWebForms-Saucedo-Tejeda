using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace TPWebForms_Saucedo_Tejeda
{
    public partial class _Default : Page
    {
        public List<Mesa> mesas;
        public List<Usuario> usuarios;
        protected void Page_Load(object sender, EventArgs e)
        {
            MesaNegocio mesaNegocio = new MesaNegocio();
            UsuariosNegocio usuariosNegocio = new UsuariosNegocio();
            try
            {
                mesas = mesaNegocio.listar();
                Session.Add("listaMesas", mesas);
                usuarios = usuariosNegocio.listar();
                Session.Add("usuarios", usuarios);
            }
            catch (Exception ex)
            {
                //TODO: Aca deberia redireccionar a una pagina aparte que muestre el error
                throw ex;
            }
            if (!IsPostBack)
            {
            cartasMesa.DataSource = mesas;
            cartasMesa.DataBind();
            ddlUsuarios.DataSource = usuarios;
            ddlUsuarios.DataValueField = "ID";
            ddlUsuarios.DataTextField = "Nombre";
            ddlUsuarios.DataBind();
            }

        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            MesaNegocio mesaNegocio = new MesaNegocio();
            try
            {
                Mesa nueva = new Mesa();
                int idMozo = Convert.ToInt32(ddlUsuarios.SelectedValue);
                List<Usuario>aux = (List<Usuario>)Session["usuarios"];
                int posMozo = aux.FindIndex( x => x.ID.Equals(idMozo));
                nueva.Mozo = aux[posMozo];
                mesaNegocio.agregar(nueva);
                Response.Redirect("default.aspx");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}