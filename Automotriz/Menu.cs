
namespace Automotriz
{
    public class Menu
    {
        public Menu(){

        }

        public void menuPrincipal(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Menu Principal -----------------");
            Console.WriteLine("\n1. Regitro De Plantel");
            Console.WriteLine("2. Mostrar Plantel");
            Console.WriteLine("3. Orden de Servicio");
            Console.WriteLine("4. Cierre de Servicio");
            Console.WriteLine("5. Salir");
        }

        public void menuPlantel(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Registro Del Plantel -----------------");
            Console.WriteLine("\n1. Registrar Cliente");
            Console.WriteLine("2. Registrar Vehiculo");
            Console.WriteLine("3. Registrar Empleado");
            Console.WriteLine("4. Regresar al Menu Principal");
        }


        public void menuMostrarPlantel(){
            Console.Clear();
            Console.WriteLine("\n ---------------------- Mostrar Plantel -----------------");
            Console.WriteLine("\n1. Mostrar Clientes");
            Console.WriteLine("2. Mostrar Vehiculos");
            Console.WriteLine("3. Mostrar Empleados");
            Console.WriteLine("4. Regresar al Menu Principal");
        }

        public int PedirOpcion() {
            Console.Write("\nElige una opción:\t");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}