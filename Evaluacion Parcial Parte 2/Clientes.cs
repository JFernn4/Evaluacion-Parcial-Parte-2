using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Parcial_Parte_2
{
    internal class Clientes
    {
        public string Nombre { get; set; }
        public string Correo { get; set; } 
        public string Direccion { get; set; }
        public string FechaRegistro { get; set; }

        public Clientes(string nombre, string correo, string direccion, string fechaRegistro)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
            FechaRegistro = fecha;
        }
    }
}
