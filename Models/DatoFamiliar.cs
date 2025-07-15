
using System;
namespace TP06_Drucker_Daiksel.Models;
public class DatoFamiliar
{
    
    public int Id { get; private set; }

    public int IdUsuario { get; private set; }

    public string Nombre { get; private set; }

    public string Apellido { get; private set; }

    public string Parentesco { get; private set; } 

    public string Descripcion { get; private set; } 

    
    public DatoFamiliar()
    {
    }

    
    public DatoFamiliar(int id, int idUsuario, string nombre, string apellido, string parentesco, string descripcion)
    {
        Id = id;
        IdUsuario = idUsuario;
        Nombre = nombre;
        Apellido = apellido;
        Parentesco = parentesco;
        Descripcion = descripcion;
    }
}