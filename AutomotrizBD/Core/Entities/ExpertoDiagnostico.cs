namespace Core.Entities
{
    public class ExpertoDiagnostico : BaseEntiti
    {
        public string Descripcion {get; set;}
        public DateTime FechaDiagnosticoExperto {get; set;}
        public int IdExpertoFK {get; set;}
        public Experto Experto {get; set;}
        public int IdOrdenServicioFK {get; set;}
        public OrdenServicio OrdenServicio {get; set;}        
    }
}