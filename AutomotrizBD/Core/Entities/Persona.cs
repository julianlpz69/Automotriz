namespace Core.Entities
{
    public class Persona : BaseEntiti
    {
        public string NombrePersona {get; set;}
        public string ApellidosPersona {get; set;}
        public string CedulaPersona {get; set;}
        public string TelefonoPersona {get; set;}
        public string DireccionPersona {get; set;}
        public string EmailPersona {get; set;}
        public DateTime FechaRegistroPersona {get; set;}
    }
}