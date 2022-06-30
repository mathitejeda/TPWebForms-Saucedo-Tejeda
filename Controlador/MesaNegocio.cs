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
        public void agregar(Mesa nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("insert into mesas(IDMozo) values(@id)");
                datos.setearParametro("@id", nueva.Mozo.ID);
                datos.EjecutarAccion();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public Mesa GetMesa(int id)
        {
            Mesa mesa = new Mesa();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta
                    (
                        "select m.ID, m.Ocupada, U.ID, U.Nombre, U.Apellidos " +
                        "from mesas as M " +
                        "join usuarios as U on m.IDmozo=U.ID " +
                        "where M.id = " + id
                    );
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                mesa.ID = datos.Lector.GetInt32(0);
                mesa.Ocupada = datos.Lector.GetBoolean(1);
                mesa.Mozo = new Usuario(datos.Lector.GetInt32(2), datos.Lector.GetString(3), datos.Lector.GetString(4));
                }

            }
            catch (System.Exception ex)
            {

                throw ex;
            }
            return mesa;
        }

    }
}
