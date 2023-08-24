using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.ProgramacionOrientadaEventos.Laboratorio2.Tarea2
{
    internal class Electrodomestico
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int CantidadDisponible { get; set; }

        public Electrodomestico(string nombre, int precio, int cantidadDisponible)
        {
            Nombre = nombre;
            Precio = precio;
            CantidadDisponible = cantidadDisponible;
        }

        public override string ToString()
        {
            return Nombre + " Precio: $" + Precio + "Cantidad disponible: $" + CantidadDisponible;

        }
    }
}
