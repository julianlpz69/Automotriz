namespace Core.Entities
{
    public class EmpleadoDiagnostico : BaseEntiti
    {
        public string Descripcion {get; set;}
        public DateTime FechaDiagnosticoExperto {get; set;}
        public int IdEmpleadoFK {get; set;}
        public Empleado Empleado {get; set;}
        public int IdOrdenServicioFK {get; set;}
        public OrdenServicio OrdenServicio {get; set;}        
    }
}