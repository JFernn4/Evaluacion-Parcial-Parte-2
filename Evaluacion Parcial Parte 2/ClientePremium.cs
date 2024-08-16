using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Parcial_Parte_2
{
    internal class ClientePremium : Clientes
    {
        public ClientePremium(string nombre, string correo, string direccion, string fechaRegistro) : base(nombre, correo, direccion, fechaRegistro)
        {
        }
        public static void Registrar(List<Clientes>listaClientes)
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente que va a registrar.");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del cliente que va a registrar.");
            string correo = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del cliente que va a registrar.");
            string direccion = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de registro.");
            string fechaRegistro = Console.ReadLine();
            ClientePremium clientePremium = new ClientePremium(nombre, correo, direccion, fechaRegistro);
            listaClientes.Add(clientePremium);
        }
    }
}
