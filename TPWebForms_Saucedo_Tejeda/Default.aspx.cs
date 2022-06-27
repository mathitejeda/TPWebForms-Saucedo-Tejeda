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
                //usuarios = usuariosNegocio.listar();
            }
            catch (Exception ex)
            {
                //TODO: Aca deberia redireccionar a una pagina aparte que muestre el error
                throw ex;
            }
            if (!IsPostBack)
            {

            }
            cartasMesa.DataSource = mesas;
            cartasMesa.DataBind();
            listaUsuarios.DataSource = usuarios;
            listaUsuarios.DataBind();
        }

        protected void agregarMesa(object sender, EventArgs e)
        {
            MesaNegocio mesaNegocio = new MesaNegocio();
            try
            {
                //todo: sacar el hardcode, la idea es que se use la lista de usuarios
                mesaNegocio.agregar(mesas[0].Mozo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}