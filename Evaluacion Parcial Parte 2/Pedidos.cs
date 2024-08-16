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
    }
    
}
