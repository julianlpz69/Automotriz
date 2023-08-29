namespace Core.Entities
{
    public class Empleado : Persona
    {
        public string EspacialidadEmpleado {get; set;}
        public int IdCargoEmpleadoFK {get; set;}
        public CargoEmpleado CargoEmpleado {get; set;}
        public int IdOrdenServicioFK {get; set;}
        public OrdenServicio OrdenServicio {get; set;}

         public ICollection<EmpleadoDiagnostico> EmpleadoDiagnosticos { get; set; }
    }
}