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
        public List<Usuarios> listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta("SELECT u.ID, u.IDTipo, u.Nombre, u.Apellido, u.usuario, u.cotraseña, u., c.Descripcion Categoria from " +
                "Usuarios AS u");
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Usuarios aux = new Usuarios();
                aux.ID = (int)datos.Lector["ID"];
                aux.IDTipo = (int)datos.Lector["iDTipo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Apellidos = (string)datos.Lector["Apellido"];
                aux.usuario = (string)datos.Lector["Usuario"];
                aux.contrasenia = (string)datos.Lector["Contraseña"];
                lista.Add(aux);
            }
            return lista;
        }

        
    }
}
