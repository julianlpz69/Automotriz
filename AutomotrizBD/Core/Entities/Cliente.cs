namespace Core.Entities
{
    public class Cliente : Persona
    {
        public string EstadoCliente {get; set;}
        public ICollection<Vehiculo> Vehiculos { get; set; }
        public ICollection<OrdenServicio> OrdenesServicios { get; set; }


   
    }
}