using System;

public class Contacto
{
    // OK comenzamos Propiedades de la clase
    public Guid Id { get; set; } // Identificador único del contacto
    public string Nombre { get; set; } // Nombre del contacto
    public string Apellido { get; set; } // Apellido del contacto
    public string Telefono { get; set; } // Número de teléfono del contacto
    public string CorreoElectronico { get; set; } // Correo electrónico del contacto
    public string Direccion { get; set; } // Dirección del contacto
    public DateTime FechaNacimiento { get; set; } // Fecha de nacimiento del contacto
    public DateTime FechaCreacion { get; set; } // Fecha en la que se creó el contacto

    // Constructor para inicializar las propiedades de la clase
    public Contacto(string nombre, string apellido, string telefono, string correoElectronico, string direccion, DateTime fechaNacimiento)
    {
        Id = Guid.NewGuid(); // Asigna un identificador único
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        CorreoElectronico = correoElectronico;
        Direccion = direccion;
        FechaNacimiento = fechaNacimiento;
        FechaCreacion = DateTime.Now; // La fecha de creación se establece en el momento actual
    }

    // Método para mostrar la información del contacto
    public void MostrarInformacion()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre} {Apellido}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine($"Correo Electrónico: {CorreoElectronico}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Fecha de Creación: {FechaCreacion.ToShortDateString()}");

    }
}
