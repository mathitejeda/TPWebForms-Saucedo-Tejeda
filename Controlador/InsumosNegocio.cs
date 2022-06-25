using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    class InsumosNegocio
    {
        public List<InsumosNegocio> listar()
        {
            List<InsumosNegocio> listaProductos = new List<InsumosNegocio>();
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
                aux.Stock = (int)datos.Lector["IDTipo"];
                lista.Add(aux);

            }
            return listaProductos;


            
        }
    }
}
