namespace Core.Entities
{
    public class Vehiculo : BaseEntiti
    {
        public string PlacaVehiculo {get; set;}
        public string MarcaVehiculo {get; set;}
        public string KilometrajeVehiculo {get; set;}
        public string ModeloVehiculo {get; set;}
        public string ColorVehiculo {get; set;}
        public string EstadoVehiculo {get; set;}
        public DateTime FechaIngresoVehiculo {get; set;}
        public string FechaSalidaVehiculo {get; set;}
        public string ObservacionesVehiculo {get; set;}
        public int IdTipoVehiculoFK {get; set;}
        public TipoVehiculo TipoVehiculo {get; set;}
        public int IdClienteFK {get; set;}
        public Cliente Cliente {get; set;}
        public ICollection<OrdenServicio> OrdenesServicio { get; set; }

    }
}                       