using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.ProgramacionOrientadaEventos.Laboratorio2.Tarea2
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string HistorialCompras { get; set; }

        public Cliente(string nombre, string direccion, string historialCompras)
        {
            Nombre = nombre;
            Direccion = direccion;
            HistorialCompras = historialCompras;

        }
        public override string ToString()
        {
            return Nombre;
            return Direccion;
            return HistorialCompras;
        }
    }
}
