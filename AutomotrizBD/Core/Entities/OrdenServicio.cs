namespace Core.Entities
{
    public class OrdenServicio : BaseEntiti
    {
    public string NumeroOrdenServicio {get; set;}
    public DateTime FechaOrdenServicio {get; set;}
    public int IdClienteFK {get; set;}
    public Cliente Cliente {get; set;}
    public string DiagnosticoCliente {get; set;}
    public int IdVehiculoFK {get; set;}
    public Vehiculo Vehiculo {get; set;}
    public ICollection<Empleado> Empleados { get; set; }
    public ICollection<OrdenAprovacion> OrdenesAprovacion { get; set; }
    public ICollection<ExpertoDiagnostico> ExpertosDiagnosticos { get; set; }
    public int IdFactura {get; set;}
    public Factura Factura {get; set;}
    }
}