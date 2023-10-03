using System.Data.SqlClient;
using Dapper;
namespace tp9.Models;
public static class BD
{
    private static string _connectionString = @"Server=localhost; DataBase=UserLogin; Trusted_Connection=True;";
    public static Usuario Login(string username, string contraseña)
    {
        Usuario devolver = null;
        string sql = "Select * From Usuario Where UserName = @name and Contraseña = @con";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<Usuario>(sql, new{pname = username, pcon = contraseña});
        }
        return devolver;
    }
    public static void Registrarse(Usuario user)
    {
        string sql = "Insert into Usuario(UserName, Contraseña, Telefono, Mail, FechaNacimiento) Values (@IdPartido, @Apellido, @Nombre, @FechaNacimiento, @Foto, @Postulacion)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, user);
        }
    }

    public static Usuario ReemplazarContraseña(string mail, string con)
    {
        Usuario devolver = null;
        string sql = "Update Usuario Set Contraseña = @newcon Where Mail = @mail";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<Usuario>(sql, new{pnewcon = con, pmail = mail});
        }
        return devolver;
    }
    public static string BuscarUsuario(string username)
    {
        string devolver = null;
        string sql = "Select * From Usuario Where UserName = @name";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            devolver = db.QueryFirstOrDefault<string>(sql, new{pname = username});
        }
        return devolver;
    }
    
}