using System.Data.SqlClient;
using Dapper;
namespace tp9.Models;
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=TP9; Trusted_Connection=True;";
    
    public static Usuario LoadUserData(){
        Usuario user = null;
        return user;
    }
    public static Usuario Login(string username, string contraseña)
    {
        Usuario devolver = null;
        string sql = "Select * From Usuario Where UserName = @pname and Contraseña = @pcon";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<Usuario>(sql, new{pname = username, pcon = contraseña});
        }
        return devolver;
    }
    public static void Registrarse(Usuario user)
    {
        string sql = "Insert into Usuario(UserName, Contraseña, Telefono, Mail, DNI) Values (@use, @con, @tel, @mail, @dni)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new{use = user.UserName, con = user.Contraseña, tel = user.Telefono, mail = user.Mail, dni = user.DNI});
        }
    }

    public static Usuario ReemplazarContraseña(string mail, string con)
    {
        Usuario devolver = null;
        string sql = "Update Usuario Set Contraseña = @pnewcon Where Mail = @pmail";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<Usuario>(sql, new{pnewcon = con, pmail = mail});
        }
        return devolver;
    }
    public static string BuscarUsuario(string username)
    {
        string devolver = null;
        string sql = "Select * From Usuario Where UserName = @pname";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<string>(sql, new{pname = username});
        }
        return devolver;
    }
    
}