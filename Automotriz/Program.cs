using Automotriz;
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<long,Cliente> Clientes = new Dictionary<long,Cliente>();
        Dictionary<string,Vehiculo> Vehiculos = new Dictionary<string,Vehiculo>();
        List<Empleado> Empleados = new List<Empleado>();
        Dictionary<int,OrdenServicio> OrdenServicios = new Dictionary<int,OrdenServicio>();

        Menu inicio = new Menu();
        int opcion;

        do {
            inicio.menuPrincipal();
            opcion = inicio.PedirOpcion();

            switch (opcion) {
                
                case 1 :
                    inicio.menuPlantel();
                    int opcion1 = inicio.PedirOpcion();
                        switch(opcion1){

                            case 1:
                                Cliente nuevoCliente = new Cliente();
                                nuevoCliente.registrarCliente(Clientes,nuevoCliente);
                                break;
                            case 2:
                                Vehiculo nuevoVehiculo = new Vehiculo();
                                nuevoVehiculo.registrarVehiculo(Vehiculos,nuevoVehiculo);
                                break;
                            case 3:
                                Empleado nuevoEmpleado = new Empleado();
                                nuevoEmpleado.registrarEmpleado(Empleados,nuevoEmpleado);
                                break;
                        }
                    break;

                case 2:
                    inicio.menuMostrarPlantel();
                    int opcion2 = inicio.PedirOpcion();
                    switch(opcion2){

                        case 1:
                            Cliente nuevoCliente = new Cliente();
                            nuevoCliente.mostrarClientes(Clientes);
                            break;
                        case 2:
                            Vehiculo nuevoVehiculo = new Vehiculo();
                            nuevoVehiculo.mostrarVehiculo(Vehiculos);
                            break;
                        case 3:
                            Empleado nuevoEmpleado = new Empleado();
                            nuevoEmpleado.mostrarEmpleado(Empleados);
                            break;
                    }
                    break;

                case 3:
                    OrdenServicio nuevaOrden = new OrdenServicio();
                    nuevaOrden.crearOrdenServicio(Clientes,Vehiculos,Empleados,OrdenServicios,nuevaOrden);
                    nuevaOrden.datosOrden();
                    nuevaOrden.mostrarAprobacion();
                    break;
                
                case 4:
                    Console.Clear();
                    Console.WriteLine("Escribe el numero de Orden del Servicio");
                    int orden = int.Parse(Console.ReadLine());
                    if(OrdenServicios.ContainsKey(orden)){
                        OrdenServicios[orden].mostrarFactura();
                        OrdenServicios.Remove(orden);
                        break;
                    }
                    else{
                        Console.WriteLine("No hay orden registrada con ese numero");
                        Console.ReadKey();
                        break;
                    }
                    
            }
        }while (opcion != 5);

    }
}