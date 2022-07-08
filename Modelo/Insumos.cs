using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Insumos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Tipo { get; set; }

        public int Cantidad { get; set; }
        public Insumos() { }
        public Insumos(int id, string nombre, decimal precio, int cantidad)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad; 
        }
    }
}
