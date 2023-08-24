using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.ProgramacionOrientadaEventos.Laboratorio2.Tarea2
{
    internal class Venta
    {
        public Electrodomestico Electrodomestico { get; set; }
        public int PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public Cliente Cliente { get; set; }

        public Venta(Electrodomestico electrodomestico, int precioVenta, int cantidad, Cliente cliente)
        {
            Electrodomestico = electrodomestico;
            PrecioVenta = precioVenta;
            Cantidad = cantidad;
            Cliente = cliente;
        }
        public override string ToString()
        {
            return "Electrodomestico: " + Electrodomestico.Nombre + " Precio de venta: $" + PrecioVenta + " Cantidad: " + Cantidad + " Cliente: " + Cliente.Nombre;
        }
    }
}
