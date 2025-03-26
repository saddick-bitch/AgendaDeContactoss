namespace EL
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public string Destinatario { get; set; }

        public Notificacion(int id, string mensaje, DateTime fechaEnvio, string destinatario)
        {
            Id = id;
            Mensaje = mensaje;
            FechaEnvio = fechaEnvio;
            Destinatario = destinatario;
        }

        public override string ToString()
        {
            return $"[{FechaEnvio}] Para: {Destinatario} - {Mensaje}";
        }
    }
}
 
 }
