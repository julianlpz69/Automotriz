using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automotriz
{
    public class Empleado
    {
        public long cedula { get; set; }
        public string nombre { get; set; }
        public long numMovil { get; set; }
        public string especialidad { get; set; }

    

        public Empleado(){}

        public Empleado(long Cedula, string Nombre, long NumMovil, string Especialidad){

            cedula = Cedula;
            nombre = Nombre;
            numMovil = NumMovil;
            especialidad = Especialidad;
          
        }


        public void registrarEmpleado( List<Empleado> Empleados, Empleado empleado){

            Console.Clear();
            Console.Write("\nIngresa la Cedula del Empleado\t");
            cedula = long.Parse(Console.ReadLine());
            Console.Write("\nIngresa el Nombre del Cliente\t");
            nombre = (Console.ReadLine());
            Console.Write("\nIngresa el numero de Celular del Clienter\t");
            numMovil = long.Parse(Console.ReadLine());
            Console.Write("\nIngresa la Especialidad del Empleado\t");
            especialidad = Console.ReadLine();
        
            Empleados.Add(empleado);
        }

        public void mostrarEmpleado(List<Empleado> Empleados){

            Console.Clear();
            Console.WriteLine($"------------------------EMPLEADOS-----------------------------");
            Console.WriteLine($"\nCedula\tNombres\tCelular\tEspecialidad");
            foreach (var elemens in Empleados){
                Console.WriteLine($"\n{elemens.cedula}\t{elemens.nombre}\t{elemens.numMovil}\t{elemens.especialidad}");
            }
            Console.ReadKey();
        }
    }
}