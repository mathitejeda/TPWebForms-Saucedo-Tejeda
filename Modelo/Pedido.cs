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
        public List<Insumos> { get; set; }
        public decimal total { get; set; }
        public bool estado { get; set; }
    }
}
