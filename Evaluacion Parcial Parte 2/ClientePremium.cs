using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Parcial_Parte_2
{
    internal class ClientePremium : Clientes
    {
        public ClientePremium(string nombre, string correo, string direccion) : base(nombre, correo, direccion)
        {
        }
    }
}
