namespace Core.Entities
{
    public class Experto : Persona
    {
        
        public string EspecialidadExperto {get; set;}
        public ICollection<ExpertoDiagnostico> ExpertoDiagnosticos { get; set; }

    }
}