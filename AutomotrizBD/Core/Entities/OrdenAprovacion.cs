namespace Core.Entities
{
    public class OrdenAprovacion : BaseEntiti
    {
        public string NumeroOrdenAprovacion {get; set;}
        public DateTime FechaOrdenAprovacion {get; set;}
        public int IdEmpleadoFK {get; set;}
        public Empleado Empleado {get; set;}
        public int IdOrdenServicioFK {get; set;}
        public OrdenServicio OrdenServicio {get; set;}
        public ICollection<RepuestoOrden> RepuestoOrdenes { get; set; }

    }
}