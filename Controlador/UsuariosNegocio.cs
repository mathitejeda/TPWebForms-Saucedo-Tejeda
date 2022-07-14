using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class UsuariosNegocio
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta("SELECT u.ID, u.IDTipo, u.Nombre, u.Apellidos, u.usuario, u.Contrasenia from Usuarios AS u");
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Usuario aux = new Usuario();
                aux.ID = (int)datos.Lector["ID"];
                aux.IDTipo = (Int16)datos.Lector["iDTipo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Apellidos = (string)datos.Lector["Apellidos"];
                aux.usuario = (string)datos.Lector["Usuario"];
                aux.contrasenia = (string)datos.Lector["Contrasenia"];
                lista.Add(aux);
            }
            return lista;
        }

        public void eliminar(int iD)
        {

            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("delete from usuarios where Id = @iD");
                datos.setearParametro("@iD", iD);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void agregar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("Insert into usuarios values(@IDTipo,@Nombre,@Apellido,@usuario,@contrasenia)");
                datos.setearParametro("IDTipo", usuario.IDTipo);
                datos.setearParametro("@nombre", usuario.Nombre);
                datos.setearParametro("@Apellido", usuario.Apellidos);
                datos.setearParametro("@usuario", usuario.usuario);
                datos.setearParametro("@contrasenia", usuario.contrasenia);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void modificar(Usuario modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("update usuarios set IDTipo = @IDTipo, Nombre = @Nombre, Apellidos = @Apellidos, usuario = @usuarios, contrasenia = @contrasenia where ID = @ID");
                datos.setearParametro("ID", modificar.ID);
                datos.setearParametro("@IDTipo", modificar.IDTipo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@Apellidos", modificar.Apellidos);
                datos.setearParametro("@usuarios", modificar.usuario);
                datos.setearParametro("@contrasenia", modificar.contrasenia);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Usuario Seleccionar(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta("SELECT  u.ID, u.IDTipo, u.Nombre, u.Apellidos, u.usuario, u.Contrasenia from Usuarios AS u");
            datos.EjecutarLectura();
            List<Usuario> lista = new List<Usuario>();
                Usuario dev = new Usuario();
            

            while (datos.Lector.Read())
            {
                Usuario aux = new Usuario();
                aux.ID = (int)datos.Lector["ID"];
                aux.IDTipo = (Int16)datos.Lector["iDTipo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Apellidos = (string)datos.Lector["Apellidos"];
                aux.usuario = (string)datos.Lector["Usuario"];
                aux.contrasenia = (string)datos.Lector["Contrasenia"];
                lista.Add(aux);
            }

            foreach (Usuario item in lista)
            {
                if(item.ID == ID)
                {
                    dev = item;
                }

            }

                return dev;
      

        }


    }

}
