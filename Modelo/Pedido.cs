using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {
        public int ID { get; set; }
        public List<Insumos> Insumos { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
    }
}
