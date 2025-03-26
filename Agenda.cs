using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System;


}
public class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>();
    }

    public void AgregarContacto(Contacto contacto)
    {
        if (!contactos.Any(c => c.Telefono == contacto.Telefono))
            contactos.Add(contacto);
        else
            throw new Exception("El contacto con este teléfono ya existe.");
    }

    public void EliminarContacto(Guid id)
    {
        var contacto = contactos.FirstOrDefault(c => c.Id == id);
        if (contacto != null)
            contactos.Remove(contacto);
        else
            throw new Exception("Contacto no encontrado.");
    }

    public Contacto BuscarPorNombre(string nombre)
    {
        return contactos.FirstOrDefault(c => c.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public Contacto BuscarPorTelefono(string telefono)
    {
        return contactos.FirstOrDefault(c => c.Telefono == telefono);
    }

    public List<Contacto> ListarContactos()
    {
        return contactos;
    }
}
