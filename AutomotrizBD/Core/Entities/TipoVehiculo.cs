namespace Core.Entities
{
    public class TipoVehiculo : BaseEntiti
    {
        public string DescripcinVehiculo {get; set;}
        public int CantidadPuestosVehiculo {get; set;}
        public ICollection<Vehiculo> Vehiculos { get; set; }

    }
}