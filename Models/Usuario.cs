namespace TP06_Drucker_Daiksel.Models;

public class usuario
    {
    int Id {get; private set;}
    string Nombre { get; private set; }
    string Apellido{ get; private set; }
    string Email {get; private set;}
    string Contraseña {get; private set;}
    DateTime FechaNacimiento { get; private set; }
    string Foto {get; private set;}   

    public DatoPersonal(int id, string nombre, string apellido, string email, string contraseña, DateTime fechaNacimiento, string foto)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Contraseña = contraseña;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
    }


    public void obtenerEdad(){
        int edad;
        datetime hoy = datetime.today;

        edad = FechaNacimiento.Years - hoy.Years;
        
    if (FechaNacimiento.Date > fechaActual.AddYears(-edad))
    {
        edad--; 
    }

    
        
    }

}