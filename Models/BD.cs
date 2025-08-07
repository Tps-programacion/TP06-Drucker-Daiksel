using System;
using Microsoft.Data.SqlClient;
using Dapper;
namespace TP06_Drucker_Daiksel.Models;
public static class BD
{
    private static string _conectionString = @"Server=localhost;Database=BaseDatosTP06;Trusted_Connection=True; TrustServerCertificate = true" ;
public static int login(string email, string contraseña){
    int? id = -1;
    using (SqlConnection connection = new SqlConnection(_conectionString))
    {
        string query = "SELECT Id FROM Usuario WHERE Email = @pEmail AND Contraseña = @pContraseña;";
        id = connection.QueryFirstOrDefault<int?>(query, new { pEmail = email, pContraseña = contraseña });  
    }
    return id ?? -1;
}
    public static Usuario GetUsuario(int id){
        Usuario usuBuscado;
         using(SqlConnection connection = new SqlConnection(_conectionString)){
            string query = "SELECT * FROM Usuario WHERE Id = @pid;";
            usuBuscado = connection.QueryFirstOrDefault<Usuario>(query,new {pid = id});  
        }
        return usuBuscado;
    }

    public static List<DatoFamiliar> GetDatoFamiliar(int id){
        List<DatoFamiliar> datos = new List<DatoFamiliar>();
        using(SqlConnection connection = new SqlConnection(_conectionString)){
        string query = "SELECT * FROM DatoFamiliar WHERE IdUsuario = @pid;";
        datos = connection.Query<DatoFamiliar>(query,new {pid = id}).ToList();  
        }
        return datos;
    }
        public static List<DatoInteres> GetDatoInteres(int id){
            List<DatoInteres> datos = new List<DatoInteres>();
            using(SqlConnection connection = new SqlConnection(_conectionString)){
            string query = "SELECT * FROM DatoInteres WHERE IdUsuario = @pid;";
            datos = connection.Query<DatoInteres>(query, new {pid = id}).ToList();  
            }
            return datos;
        }
}
