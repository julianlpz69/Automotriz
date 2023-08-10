using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Cliente
    {
         public long cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long numMovil { get; set; }
        public string gmail { get; set; }
        public string fecha { get; set; }

        public Cliente(){}
        public Cliente(long Cedula, string Nombre, string Apellido, long NumMovil, string Gmail, string Fecha){

            cedula = Cedula;
            nombre = Nombre;
            apellido = Apellido;
            numMovil = NumMovil;
            gmail = Gmail;
            fecha = Fecha;
        }
        public void registrarCliente( Dictionary<long,Cliente> Clientes, Cliente cliente){

            Console.Clear();
            Console.Write("\nIngresa la Cedula del Cliente\t");
            cedula = long.Parse(Console.ReadLine());
            Console.Write("\nIngresa el Nombre del Cliente\t");
            nombre = (Console.ReadLine());
            Console.Write("\nIngresa el Apellido del Cliente\t");
            apellido = Console.ReadLine();
            Console.Write("\nIngresa el numero de Celular del Clienter\t");
            numMovil = long.Parse(Console.ReadLine());
            Console.Write("\nIngresa el Gmail del Cliente\t");
            gmail = Console.ReadLine();
            fecha = DateTime.UtcNow.ToString("MM-dd-yyyy");

            Clientes.Add(cedula,cliente);
        }

        public void mostrarClientes(Dictionary<long,Cliente> Clientes){

            Console.Clear();
            Console.WriteLine($"------------------------CLIENTES-----------------------------");
            Console.WriteLine($"\nCedula\tNombres\tApellidos\tCelular\tGmail\tFecha de Registro");
            foreach (var elemens in Clientes.Values){
                Console.WriteLine($"\n{elemens.cedula}\t{elemens.nombre}\t{elemens.apellido}\t{elemens.numMovil}\t{elemens.gmail}\t{elemens.fecha}");
            }
            Console.ReadKey();
        }
    }
}