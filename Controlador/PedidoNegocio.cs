using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
    public class PedidoNegocio
    {
        public Pedido Listar(int idmesa)
        {
            Pedido pedido = new Pedido();
            AccesoDatos datos = new AccesoDatos();
            datos.SetConsulta
                (
                    "select P.ID, P.Total " +
                    "from pedido as P " +
                    "where p.idmesa = "+idmesa+" and p.estado = 1"
                );
            datos.EjecutarLectura();
            while (datos.Lector.Read())
            {
                pedido.ID = datos.Lector.GetInt32(0);
                pedido.Total = datos.Lector.GetDecimal(1);
            }
            datos.CerrarConexion();
            datos.SetConsulta
                (
                    "select DP.idinsumo, ins.nombre, dp.precio ,DP.cantidad " +
                    "from detallePedido as DP " +
                    "inner join insumos as ins on ins.id=DP.idinsumo " +
                    "inner join pedido as P on DP.idpedido="+ pedido.ID +
                    " where p.idmesa = "+idmesa
                );
            datos.EjecutarLectura();
            pedido.Insumos = new List<Insumos>();
            while (datos.Lector.Read())
            {
                Insumos aux = new Insumos(datos.Lector.GetInt32(0),datos.Lector.GetString(1),datos.Lector.GetDecimal(2),datos.Lector.GetInt32(3));
                pedido.Insumos.Add(aux);
            }
            return pedido;
        }
        public void AgregarItem(int idpedido,int iditem)
        {

        }
    }
}
