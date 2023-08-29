namespace Core.Entities
{
    public class RepuestoOrden : BaseEntiti
    {
        public int CantidadRepuesto { get; set; } 
        public string EstadoRepuesto {get; set;}
        public int IdRespuestoFK { get; set; }      
        public Repuesto Repuesto { get; set; }  
        public int IdOrdenAprovacionFK {get; set;}
        public OrdenAprovacion OrdenAprovacion {get; set;}
    }
}