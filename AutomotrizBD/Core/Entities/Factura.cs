namespace Core.Entities
{
    public class Factura : BaseEntiti
    {
        public string IdOrdenServicioFK {get; set;}
        public OrdenServicio OrdenServicio {get; set;}
        public string NumeroFactura {get; set;}
        public DateTime FechaFactura {get; set;}
        public double Iva = 0.19;
        public double ManoObra = 0.10;
    }
}