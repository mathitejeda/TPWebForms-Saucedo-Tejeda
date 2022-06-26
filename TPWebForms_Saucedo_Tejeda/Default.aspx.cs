using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace TPWebForms_Saucedo_Tejeda
{
    public partial class _Default : Page
    {
        public List<Mesa> mesas;
        protected void Page_Load(object sender, EventArgs e)
        {
            MesaNegocio mesaNegocio = new MesaNegocio();
            try
            {
                mesas = mesaNegocio.listar();
                Session.Add("listaMesas",mesas);
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
        }
    }
}