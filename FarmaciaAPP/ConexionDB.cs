using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaAPP
{
    public class ConexionDB
    {
        private static string connectionString = "Server=DESKTOP-MV1NMJB\\SQLEXPRESS01;Database=APPFARMACIA;Trusted_Connection=True;";

        // Método para obtener la conexión a la base de datos
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        // Método para obtener un usuario de la base de datos
        public static Usuario ObtenerUsuario(string username)
        {
            // Cadena de conexión
            string connectionString = "Server=DESKTOP-MV1NMJB\\SQLEXPRESS01;Database=APPFARMACIA;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta SQL para obtener los datos del usuario
                string query = "SELECT Username, Contrasena, Rol FROM Usuarios WHERE Username = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);  // Usamos 'Username' en lugar de 'NombreUsuario'

                try
                {
                    connection.Open();  // Abrir conexión a la base de datos
                    SqlDataReader reader = command.ExecuteReader();  // Ejecutar consulta

                    if (reader.HasRows)
                    {
                        reader.Read();  // Leer el primer registro (el único, en este caso)

                        // Crear y devolver el objeto Usuario
                        return new Usuario
                        {
                            Username = reader["Username"].ToString(),  // Usamos 'Username' en lugar de 'NombreUsuario'
                            Contrasena = reader["Contrasena"].ToString(),
                            Rol = reader["Rol"].ToString()
                        };
                    }
                    else
                    {
                        // Si no hay registros, el usuario no se encuentra
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Si ocurre un error en la conexión o ejecución, mostrar el mensaje
                    MessageBox.Show("Error al obtener usuario: " + ex.Message);
                    return null;
                }
            }
        }



        public static bool VerificarConexionBD()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Intentar abrir la conexión
                    return true;  // Si la conexión se abrió correctamente, devolver true
                }
                catch (Exception)
                {
                    return false;  // Si ocurre un error, devolver false
                }
            }
        }
    }
}
