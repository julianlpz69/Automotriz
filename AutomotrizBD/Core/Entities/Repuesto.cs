namespace Core.Entities
{
    public class Repuesto : BaseEntiti
    {
        public int CodigoRepuesto {get; set;}
        public double ValorRepuesto {get; set;}
        public int StockRepuesto {get; set;}
        public ICollection<RepuestoOrden> RepuestoOrdenes { get; set; }

    }
}