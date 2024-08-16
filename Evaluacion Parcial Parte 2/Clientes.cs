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
            FechaRegistro = fechaRegistro;
        }
        public static void MostrarDetalles(List<Clientes> listaClientes)
        {
            Console.Clear();
            foreach (Clientes cliente in listaClientes)
            {
                if (cliente is ClienteEstandar clienteEstandar)
                {
                    Console.WriteLine("Cliente Estándar.");
                    Console.WriteLine($"Nombre: {clienteEstandar.Nombre}. Correo:{clienteEstandar.Correo}. Dirección: {clienteEstandar.Direccion}. Fecha de Registro: {clienteEstandar.FechaRegistro}.");
                }
                else if (cliente is ClientePremium clientePremium)
                {
                    Console.WriteLine("Cliente Premium. (Descuento especial del 10%)");
                    Console.WriteLine($"Nombre: {clientePremium.Nombre}. Correo:{clientePremium.Correo}. Dirección: {clientePremium.Direccion}. Fecha de Registro: {clientePremium.FechaRegistro}.");
                }
            }
            Console.ReadKey();
        }
        public static void Buscar(List<Clientes>listaClientes)
        {
            Console.WriteLine("Ingrese el nombre del cliente que desea buscar.");
            string clienteBuscar=Console.ReadLine();
            Clientes buscar= listaClientes.Find(p=>p.Nombre==clienteBuscar);
            if ( buscar == null )
            {
                Console.WriteLine("Cliente inexistente.");
                Console.ReadKey();
            }
            else
            {
                if (buscar is ClientePremium clientePremium)
                {
                    Console.WriteLine("Cliente Premium. (Descuento especial del 10%)");
                    Console.WriteLine($"Nombre:{clientePremium.Nombre} Correo:{clientePremium.Correo} Direccion:{clientePremium.Direccion} Fecha de registro:{clientePremium.FechaRegistro}");
                }
                else if (buscar is ClienteEstandar clienteEstandar)
                {
                    Console.WriteLine("Cliente Estándar.");
                    Console.WriteLine($"Nombre: {clienteEstandar.Nombre}. Correo:{clienteEstandar.Correo}. Dirección: {clienteEstandar.Direccion}. Fecha de Registro: {clienteEstandar.FechaRegistro}.");
                }

            }
        }
    }
}
