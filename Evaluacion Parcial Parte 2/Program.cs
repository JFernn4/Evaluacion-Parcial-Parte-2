﻿using Evaluacion_Parcial_Parte_2;

List<Clientes>listaClientes=new List<Clientes>();
List<Pedidos>listaPedidos=new List<Pedidos>();
bool menu = true;
int opcion = 0;
while(menu)
{
    MostrarMenu();
    opcion=Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                ClienteEstandar.Registrar(listaClientes);
                break;
            }
        case 2:
            {
                break;
            }
        case 3:
            {
                break;
            }
        case 4:
            {
                break;
            }
        case 5:
            {
                break;
            }
        case 6:
            {
                break;
            }
        case 7:
            {
                break;
            }
        case 8:
            {
                menu=false; 
                break;
            }
    }
}
static void MostrarMenu()
{
    Console.Clear();
    Console.WriteLine("1. Registrar Cliente Estándar.");
    Console.WriteLine("2. Registrar Cliente Premium.");
    Console.WriteLine("3. Registrar Pedido.");
    Console.WriteLine("4. Mostrar Detalles de Clientes.");
    Console.WriteLine("5. Mostrar Detalles de Pedidos.");
    Console.WriteLine("6. Buscar Cliente por Nombre.");
    Console.WriteLine("7. Buscar Pedido por Número.");
    Console.WriteLine("8. Salir.");
}