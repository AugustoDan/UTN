using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DetallePresupuesto
    {
        public Producto Productos { get; set; }
        public int Cantidad { get; set; }
        public DetallePresupuesto(Producto p, int cant)
        {
            Productos = p;
            Cantidad = cant;
        }

        public double CalcularSubTotal()
        {
            return Productos.Precio * Cantidad;
        }
    }
}
