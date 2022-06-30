using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class InsumosNegocio
    {
        public List<Insumos> listar()
        {
           
            List<Insumos> lista = new List<Insumos>();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta("Select I.ID, I.nombre, I.PRECIO, I.STOCK, I.IDTIPO FROM INSUMOS AS I");
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                Insumos aux = new Insumos();
                aux.ID = (int)datos.Lector["ID"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Precio = (int)datos.Lector["Precio"];
                aux.Stock = (int)datos.Lector["Stock"];
                aux.Tipo = (int)datos.Lector["IDTipo"];
                lista.Add(aux);

            }
            return lista;

        }

        public void agregar(Insumos insumo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("Insert into insumos values(@nombre,@precio,@stock,@IDTipo)");
                datos.setearParametro("@nombre", insumo.Nombre);
                datos.setearParametro("@precio", insumo.Precio);
                datos.setearParametro("@stock", insumo.Stock);
                datos.setearParametro("@IDTipo", insumo.Tipo);
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.SetConsulta("delete from Insumos where Id = @id");
                datos.setearParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Insumos modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("update Insumo set nombre = @nombre, precio = @precio, stock = @stock, tipo = @IDTipo");
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@stock", modificar.Stock);
                datos.setearParametro("@IDTipo", modificar.Tipo);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
