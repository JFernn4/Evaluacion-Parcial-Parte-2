using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_Parcial_Parte_2
{
    internal class Pedidos
    {
        public int Numero { get; set; }
        public string Fecha { get; set; }
        public Clientes Clientes { get; set; }

        public Pedidos(int numero, string fecha, Clientes clientes)
        {
            Numero = numero;
            Fecha = fecha;
            Clientes = clientes;
        }
        public static void Registrar(List<Pedidos> listaPedidos, List<Clientes> listaClientes)
       {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            string nombreCliente= Console.ReadLine();
            Clientes cliente= listaClientes.Find(p=>p.Nombre==nombreCliente);
            if (cliente==null)
            {
                Console.WriteLine("Cliente inexistente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ingrese el número de pedido.");
                int numero= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha del pedido.");
                string fecha= Console.ReadLine();
                Pedidos pedido= new Pedidos(numero, fecha, cliente);
            }
        }
        public static void MostrarDetalles(List<Pedidos> listaPedidos, List<Clientes> listaClientes)
        {
            Console.Clear();
            foreach (Pedidos pedido in listaPedidos)
            {
                if (pedido.Clientes is ClienteEstandar)
                {
                    Console.WriteLine($"Número: {pedido.Numero}. Fecha: {pedido.Fecha}. Cliente: {pedido.Clientes.Nombre}.");
                    Console.ReadKey();
                }
                else if (pedido.Clientes is ClientePremium)
                {
                    Console.WriteLine($"Número: {pedido.Numero}. Fecha: {pedido.Fecha}. Cliente: {pedido.Clientes.Nombre}. (Descuento del 10%)");
                    Console.ReadKey();
                }
            }
        }
        public static void Buscar(List<Pedidos> listaPedidos, List<Clientes> listaClientes)
        {
            Console.Clear( );
            Console.WriteLine("Ingrese el número del pedido que desea buscar");
            int pedidoBuscar= Convert.ToInt32(Console.ReadLine());
            Pedidos buscar = listaPedidos.Find(p => p.Numero == pedidoBuscar);
            if ( buscar == null )
            {
                Console.WriteLine("No se ha encontrado el pedido.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Numero:{buscar.Numero} Fecha:{buscar.Fecha} Cliente:{buscar.Clientes}.");
                Console.ReadKey();
            }

        }
    }
    
}
