using System;
using System.Collections.Generic;
using System.Linq;

public class Grupo
{
    // Propiedades de la clase Grupo trakaaa
    public Guid Id { get; private set; } // Identificador único del grupo
    public string Nombre { get; set; } // Nombre del grupo
    public string Descripcion { get; set; } // Descripción opcional del grupo
    public DateTime FechaCreacion { get; private set; } // Fecha de creación del grupo

    // Lista de contactos en este grupo
    private List<Contacto> contactos;

    // Constructor
    public Grupo(string nombre, string descripcion = "")
    {
        Id = Guid.NewGuid(); // Generar ID único
        Nombre = nombre;
        Descripcion = descripcion;
        FechaCreacion = DateTime.Now;
        contactos = new List<Contacto>();
    }

    // Método para agregar un contacto al grupo
    public void AgregarContacto(Contacto contacto)
    {
        if (!contactos.Contains(contacto))
        {
            contactos.Add(contacto);
        }
        else
        {
            throw new Exception("El contacto ya existe en este grupo.");
        }
    }

    // Método para eliminar un contacto del grupo
    public void EliminarContacto(Contacto contacto)
    {
        if (contactos.Contains(contacto))
        {
            contactos.Remove(contacto);
        }
        else
        {
            throw new Exception("El contacto no existe en este grupo.");
        }
    }

    // Método para listar los contactos del grupo
    public List<Contacto> ListarContactos()
    {
        return new List<Contacto>(contactos); // Devuelve una copia de la lista
    }

    // Método para mostrar información del grupo
    public void MostrarInformacion()
    {
        Console.WriteLine($"Grupo: {Nombre}");
        Console.WriteLine($"Descripción: {Descripcion}");
        Console.WriteLine($"Fecha de Creación: {FechaCreacion.ToShortDateString()}");
        Console.WriteLine($"Número de Contactos: {contactos.Count}");
    }
}