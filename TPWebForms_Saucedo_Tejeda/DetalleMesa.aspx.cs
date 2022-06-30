using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;

namespace TPWebForms_Saucedo_Tejeda
{
    public partial class DetalleMesa : Page
    {
        public int id { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            id = Convert.ToInt32(Request.QueryString["id"]);
            MesaNegocio mesaNegocio = new MesaNegocio();
            Mesa mesa = mesaNegocio.GetMesa(id);
            tituloMesa.Text = "Mesa nro: " + mesa.ID;
                tbxMesero.Text = mesa.Mozo.Nombre + " " +mesa.Mozo.Apellidos;
                tbxEstado.Text = mesa.Ocupada ? "ocupada" : "Disponible";
            }
            catch (Exception ex)
            {

                throw ex;
            }


            if (!IsPostBack)
            {

            }
        }
    }
}