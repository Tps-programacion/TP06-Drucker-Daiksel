namespace TP06_Drucker_Daiksel.Models;

public class DatoInteres
{
int Id{ get; private set; }
int IdUsuario{ get; private set; }
int TipoInteres{ get; private set; }
string Interes { get; private set; }    

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