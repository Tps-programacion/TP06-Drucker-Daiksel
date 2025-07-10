using System;
using Microsoft.Data.SqlClient;
using Dapper;
namespace TP06_Drucker_Daiksel.Models;
public static class BD
{
    private static string _conectionString = @"Server=localhost";
    public static int login(string email, string contraseña){
        int id = -1;
        using(SqlConnection connection = new SqlConnection(_conectionString)){
            string query = "SELECT Id FROM Usuario WHERE Email = @pEmail AND Contraseña = @pContraseña;";
            id = connection.QueryFirstOrDefault<int>(query,new {pEmail = email, pContraseña=contraseña});  
        }
        return id;
    }

    public static usuario GetUsuario(int id){
        usuario usuBuscado = null;
         using(SqlConnection connection = new SqlConnection(_conectionString)){
            string query = "SELECT * FROM Usuario WHERE Id = @pid;";
            usuBuscado = connection.QueryFirstOrDefault<usuario>(query,new {pid = id});  
        }
        return usuBuscado;
    }

    public static List<DatoFamiliar> GetDatoFamiliar(int id){
        list<DatoFamiliar> datos = new list<DatoFamiliar>();
        using(SqlConnection connection = new SqlConnection(_conectionString)){
        string query = "SELECT * FROM DatoFamiliar WHERE IdUser = @pid;";
        datos = connection.QueryFirstOrDefault<DatoFamiliar>(query,new {pid = id});  
        }
        return datos;
    }
}
