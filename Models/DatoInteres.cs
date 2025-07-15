namespace TP06_Drucker_Daiksel.Models;

public class DatoInteres
{
public int Id{ get; private set; }
public int IdUsuario{ get; private set; }
public int TipoInteres{ get; private set; }
public string Interes { get; private set; }    

    public DatoInteres()
    {
    }

    public DatoInteres(int id, int idUsuario, int tipoInteres, string interes)
    {
        Id = id;
        IdUsuario = idUsuario;
        TipoInteres = tipoInteres;
        Interes = interes;
    }
}