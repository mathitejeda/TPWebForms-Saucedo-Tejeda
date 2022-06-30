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


    public partial class VistaPedido : System.Web.UI.Page
    {
        public List<Insumos> lista;

        protected void Page_Load(object sender, EventArgs e)
        {

            InsumosNegocio datos = new InsumosNegocio();
            lista = datos.listar();
            foreach (Insumos item in lista)
            {

                if (item.Tipo == 1)
                {
                    DdBebidas.Items.Add(item.Nombre);
                }
                if(item.Tipo == 2)
                {
                    DpEntradas.Items.Add(item.Nombre);

                }
                if (item.Tipo == 4)
                {
                    DpPostre.Items.Add(item.Nombre);

                }
                if (item.Tipo == 3) { 
                
                DpComida.Items.Add(item.Nombre);
                }


            }




        }


    }
}