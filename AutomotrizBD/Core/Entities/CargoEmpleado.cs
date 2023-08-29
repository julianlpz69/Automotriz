namespace Core.Entities
{
    public class CargoEmpleado : BaseEntiti
    {
        public string DescripcionCargo {get; set;}
        public ICollection<Empleado> Empleados { get; set; }
    }
}