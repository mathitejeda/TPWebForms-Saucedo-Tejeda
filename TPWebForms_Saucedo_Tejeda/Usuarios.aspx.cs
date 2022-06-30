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


          
                try
                {
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellidos = txtApellido.Text;
                    nuevo.IDTipo = 1;
                    nuevo.usuario = txtUsuario.Text;
                    nuevo.contrasenia = txtContrasenia.Text;
                    agregar.agregar(nuevo);

                }
                catch (Exception ex)
                {

                    throw ex;
                }


        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosNegocio eliminar = new UsuariosNegocio();
            eliminar.eliminar(Convert.ToInt32(txteliminar.Text));
            Response.Redirect("Usuarios.aspx");

        }


        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
            Usuario user = new Usuario();
            UsuariosNegocio negocio = new UsuariosNegocio();
            user = negocio.Seleccionar(Convert.ToInt32(txtmodificar.Text));
            txtname.Text = user.Nombre;
            txtsecond.Text = user.Apellidos;
            txtuser.Text = user.usuario;
            txtpass.Text = user.contrasenia;
            txttipe.Text = Convert.ToString(user.IDTipo);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {


            Usuario user = new Usuario();
            UsuariosNegocio negocio = new UsuariosNegocio();


            try
            {
            user.ID = Convert.ToInt32(txtmodificar.Text);
            user.Nombre = txtname.Text;
            user.Apellidos = txtsecond.Text;
            user.usuario = txtuser.Text;
            user.contrasenia = txtpass.Text;
            user.IDTipo = Convert.ToInt32(txttipe.Text);
            negocio.modificar(user);
                Response.Redirect("Usuarios.aspx");
                user = null;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            



        }


    }
}