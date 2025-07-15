namespace TP06_Drucker_Daiksel.Models;

public class Usuario
    {
    public int Id {get; private set;}
    public string Nombre { get; private set; }
    public string Apellido{ get; private set; }
    public string Email {get; private set;}
    public string Contraseña {get; private set;}
    public DateTime FechaNacimiento { get; private set; }
    public string Foto {get; private set;}   

    public Usuario(int id, string nombre, string apellido, string email, string contraseña, DateTime fechaNacimiento, string foto)
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
        DateTime hoy = DateTime.Today;

        edad = FechaNacimiento.Year - hoy.Year;
        
    if (FechaNacimiento.Date > DateTime.Now.AddYears(-edad))
    {
        edad--; 
    }

    
        
    }

}