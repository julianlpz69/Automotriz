
namespace Automotriz
{
    public class OrdenServicio
    {
        public int numOrden { get; set; }
        public string fecha { get; set; }
        public long idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string placaVehiculo { get; set; }
        public long kilometraje { get; set; }
        public string diagnosticoCliente { get; set; }
        public long idEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string especialidadEmpleado { get; set; }
        public long idExperto { get; set; }
        public string nombreExperto { get; set; }
        public string diagnosticoExperto { get; set; }
        public int item { get; set; }
        public string repuesto { get; set; }
        public int valorUnitario { get; set; }
        public int valorTotal { get; set; }
        public string estado { get; set; }


        public OrdenServicio(){}


        public int Randoms(int min,int max){
            Random randons = new Random();
            return randons.Next(min,max);
        }

        public void crearOrdenServicio(Dictionary<long,Cliente> Clientes, Dictionary<string,Vehiculo> Vehiculos, List<Empleado> Empleados,Dictionary<int,OrdenServicio> OrdenServicios, OrdenServicio transporte){
            Console.Clear();

            numOrden = Randoms(1000,2000);
            fecha = DateTime.UtcNow.ToString("MM-dd-yyyy");

            Cliente clienter = new Cliente();
            clienter.mostrarClientes(Clientes);
            Console.WriteLine("\nEscribe la cedula del Cliente al que pertenece la Orden");
            idCliente = long.Parse(Console.ReadLine());
            nombreCliente = Clientes[idCliente].nombre;

            Console.Clear();
            Vehiculo vehiculor = new Vehiculo();
            vehiculor.mostrarVehiculo(Vehiculos);
            Console.WriteLine("\nEscribe la placa del Vehiculo al que pertenece la Orden");
            placaVehiculo = Console.ReadLine();
            kilometraje = Vehiculos[placaVehiculo].kilometraje;

            Console.Clear();
            Console.WriteLine("\nEscribe el Diagnostico del Cliente sobre el Vehiculo");
            diagnosticoCliente = Console.ReadLine();

            int llaveEmpleado = Randoms(0,Empleados.Count);

            idEmpleado = Empleados[llaveEmpleado].cedula;
            nombreEmpleado = Empleados[llaveEmpleado].nombre;
            especialidadEmpleado = Empleados[llaveEmpleado].especialidad;

            idExperto = 569841;
            nombreExperto = "Roberto Gomez Bolaños";

            int num = Randoms(0,5);

            if(num == 0){
                diagnosticoExperto = "Esto va a hacer Cabum toca cambiarle el Aire Acondicionado";
                item = 2;
                repuesto = "Aire";
                valorUnitario = 20000;
                valorTotal = 40000;
                estado = "Proceso";
            }

            if(num == 1){
                diagnosticoExperto = "Pailas eso es el Motor na que hacer";
                item = 1;
                repuesto = "Motor";
                valorUnitario = 500000;
                valorTotal = 500000;
                estado = "Proceso";
            }

            if(num == 2){
                diagnosticoExperto = "Se jodio el coso ese, eso es lo que tiene";
                item = 2;
                repuesto = "el Coso";
                valorUnitario = 35000;
                valorTotal = 70000;
                estado = "Proceso";
            }

            if(num == 3){
                diagnosticoExperto = "Se daño la caja, es que usted quiere andar como cohete";
                item = 1;
                repuesto = "Caja";
                valorUnitario = 200000;
                valorTotal = 200000;
                estado = "Proceso";
            }

            if(num == 4){
                diagnosticoExperto = "Le sale mas barato comprarselo Nuevo";
                item = 1;
                repuesto = "Auto Nuevo";
                valorUnitario = 100000;
                valorTotal = 100000;
                estado = "Proceso";
            }
            OrdenServicios.Add(numOrden,transporte);
        }

        public void datosOrden(){
            Console.Clear();
            Console.WriteLine("----------------Datos De La Orden----------------");
            Console.WriteLine($"Numero de Orden: {numOrden}");
            Console.WriteLine($"Fecha de Orden: {fecha}");
            Console.WriteLine($"Id Cliente: {idCliente}");
            Console.WriteLine($"Nombre Cliente: {nombreCliente}");

            Console.WriteLine("\n----------------Datos Del Vehiculo----------------");
            Console.WriteLine($"Numero de Placa: {placaVehiculo}");
            Console.WriteLine($"Kilometraje: {kilometraje}");

            Console.WriteLine("\n----------------Diagnostico Cliente----------------");
            Console.WriteLine($"{diagnosticoCliente}");

            Console.WriteLine("\n----------------Personal a Cargo----------------");
            Console.WriteLine($"Id Empleado: {idEmpleado}");
            Console.WriteLine($"Nombre Empleado: {nombreEmpleado}");
            Console.WriteLine($"Especialidad Empleado: {especialidadEmpleado}");

            Console.WriteLine("\n----------------Diagnostico Experto----------------");
            Console.WriteLine($"Id Experto: {idExperto}");
            Console.WriteLine($"Nombre Experto: {nombreExperto}");
            Console.WriteLine($"Diagnostico: {diagnosticoExperto}");
            Console.ReadKey();
        }

        public void mostrarAprobacion(){

            Console.Clear();
            Console.WriteLine($"Numero de Orden: {numOrden}");
            Console.WriteLine($"Fecha: {fecha}");
            Console.WriteLine($"Id Empleado: {idEmpleado}");

            Console.WriteLine("\n----------------Detalles Aprovacion----------------");
            Console.WriteLine("\nItem\tRepuesto\tValor Unitario\tValor Total\tEstado");
            Console.WriteLine($"\n{item}\t{repuesto}\t{valorUnitario}\t{valorTotal}\t{estado}");
            Console.ReadKey();
        }

        public void mostrarFactura(){

            Console.Clear();
            Console.WriteLine("\n----------------FACUTURA----------------");
            Console.WriteLine($"Numero de Orden: {numOrden}");
            Console.WriteLine($"Numero Factura: {Randoms(1000,2000)}");
            Console.WriteLine($"Id Cliente: {idCliente}");

            Console.WriteLine("\n----------------Detalles Factura----------------");
            Console.WriteLine("Item\tRepuesto\tValor Unitario\tSub Total");
            Console.WriteLine($"{item}\t{repuesto}\t{valorUnitario}\t{valorTotal}");

            Console.WriteLine($"\nIva 19%: {valorTotal*0.19}");
            Console.WriteLine($"Mano de Obra: {valorTotal*0.10}");
            Console.WriteLine($"Total a Pagar: {valorTotal+valorTotal*0.19+valorTotal*0.10}");

            Console.WriteLine($"\nEnter Para Confirmar Pago");

            Console.ReadKey();
        }

    }
}