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
    public partial class Usuarios : System.Web.UI.Page
    {
       public List<Usuario> users;
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            users = negocio.listar();
            dgvUsuarios.DataSource = users;
            dgvUsuarios.DataBind();

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            UsuariosNegocio agregar = new UsuariosNegocio();

            nuevo.Nombre = txtNombre.Text;
            nuevo.IDTipo = 1;
            nuevo.Apellidos = "Saucedo";
            nuevo.usuario = "Nah";
            nuevo.contrasenia = "12345";
            agregar.agregar(nuevo);

            
        }
    }
}