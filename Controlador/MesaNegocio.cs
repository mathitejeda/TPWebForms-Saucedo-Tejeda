using Modelo;
using System.Collections.Generic;

namespace Controlador
{
    public class MesaNegocio
    {
        public List<Mesa> listar()
        {
            List<Mesa> listaMesas = new List<Mesa>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta
                (
                    "select m.ID, m.Ocupada, U.ID, U.Nombre, U.Apellidos " +
                    "from mesas as m " +
                    "join usuarios as U on m.IDmozo=U.ID"
                );
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Mesa aux = new Mesa();
                aux.ID = datos.Lector.GetInt32(0);
                aux.Ocupada = datos.Lector.GetBoolean(1);
                aux.Mozo = new Usuario(datos.Lector.GetInt32(2), datos.Lector.GetString(3), datos.Lector.GetString(4));
                listaMesas.Add(aux);
            }
            return listaMesas;
        }
        public void agregar(Usuario mozo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("insert into mesas(IDMozo) values(@id)");
                datos.setearParametro("@id", mozo.ID);
                datos.EjecutarAccion();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
