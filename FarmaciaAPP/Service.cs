using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FarmaciaAPP
{
    public class Service
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ToString();

        // Registrar un nuevo usuario
        public bool RegistrarUsuario(string nombre, string apellido, string correo, string usuario, string contrasena, string rol)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Nombre, Apellido, CorreoElectronico, Usuario, Contraseña, Rol) VALUES (@Nombre, @Apellido, @Correo, @Usuario, @Contraseña, @Rol)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Correo", correo);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contrasena);
                command.Parameters.AddWithValue("@Rol", rol);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Iniciar sesión
        public bool IniciarSesion(string usuario, string contrasena, out string rol)
        {
            rol = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contrasena);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    rol = reader["Rol"].ToString();
                    return true;
                }
                return false;
            }
        }

        // Generar una receta
        public bool GenerarReceta(int usuarioID, string nombreReceta, string detalles)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Recetas (UsuarioID, NombreReceta, Detalles, FechaGeneracion) VALUES (@UsuarioID, @NombreReceta, @Detalles, @FechaGeneracion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UsuarioID", usuarioID);
                command.Parameters.AddWithValue("@NombreReceta", nombreReceta);
                command.Parameters.AddWithValue("@Detalles", detalles);
                command.Parameters.AddWithValue("@FechaGeneracion", DateTime.Now);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        // Consultar recetas
        public SqlDataReader ConsultarRecetas(int usuarioID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT NombreReceta, Detalles, FechaGeneracion FROM Recetas WHERE UsuarioID = @UsuarioID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UsuarioID", usuarioID);

            connection.Open();
            return command.ExecuteReader();
        }
    }
}
