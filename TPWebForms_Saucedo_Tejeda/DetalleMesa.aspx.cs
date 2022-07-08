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
        public Pedido pedido { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
            id = Convert.ToInt32(Request.QueryString["id"]);
            MesaNegocio mesaNegocio = new MesaNegocio();
            Mesa mesa = mesaNegocio.GetMesa(id);

            PedidoNegocio pedidoNegocio = new PedidoNegocio();
                pedido = pedidoNegocio.Listar(id);

            tituloMesa.Text = "Mesa nro: " + mesa.ID;
                tbxMesero.Text = mesa.Mozo.Nombre + " " +mesa.Mozo.Apellidos;
                tbxEstado.Text = mesa.Ocupada ? "ocupada" : "Disponible";
                listadoPedido.DataSource = pedido.Insumos;
                listadoPedido.DataBind();
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