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
        private static string connectionString = "Server=PC19_LAB1\\SQLEXPRESS;Database=APPFARMACIA;Trusted_Connection=True;";

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
            string connectionString = "Server=PC19_LAB1\\SQLEXPRESS;Database=APPFARMACIA;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Consulta SQL para obtener los datos del usuario
                string query = "SELECT NombreUsuario, Nombre, Apellido, Rol, CorreoElectronico, Contrasena FROM Usuarios WHERE NombreUsuario = @Username";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);  // Usamos 'NombreUsuario' para que coincida con la base de datos

                try
                {
                    connection.Open();  // Abrir conexión a la base de datos
                    SqlDataReader reader = command.ExecuteReader();  // Ejecutar consulta

                    if (reader.HasRows)
                    {
                        reader.Read();  // Leer el primer registro (el único, en este caso)

                        // Crear y devolver el objeto Usuario con todos los datos
                        return new Usuario
                        {
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Rol = reader["Rol"].ToString(),
                            CorreoElectronico = reader["CorreoElectronico"].ToString(),
                            Contrasena = reader["Contrasena"].ToString()
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


        public static void InsertarReceta(Receta receta)
        {
            using (SqlConnection con = new SqlConnection("Server=PC19_LAB1\\SQLEXPRESS;Database=APPFARMACIA;Trusted_Connection=True;"))
            {
                string query = "INSERT INTO Recetas (Nombre, Apellido, Medicamento1, Medicamento2, Medicamento3, Medicamento4, Medicamento5, Medicamento6, DescripcionCorta, FechaReceta, Correo) " +
                               "VALUES (@Nombre, @Apellido, @Medicamento1, @Medicamento2, @Medicamento3, @Medicamento4, @Medicamento5, @Medicamento6, @DescripcionCorta, @FechaReceta, @Correo)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", receta.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", receta.Apellido);
                cmd.Parameters.AddWithValue("@Medicamento1", receta.Medicamento1);
                cmd.Parameters.AddWithValue("@Medicamento2", receta.Medicamento2);
                cmd.Parameters.AddWithValue("@Medicamento3", receta.Medicamento3);
                cmd.Parameters.AddWithValue("@Medicamento4", receta.Medicamento4);
                cmd.Parameters.AddWithValue("@Medicamento5", receta.Medicamento5);
                cmd.Parameters.AddWithValue("@Medicamento6", receta.Medicamento6);
                cmd.Parameters.AddWithValue("@DescripcionCorta", receta.DescripcionCorta);
                cmd.Parameters.AddWithValue("@FechaReceta", receta.FechaReceta);
                cmd.Parameters.AddWithValue("@Correo", receta.Correo);

                con.Open();
                cmd.ExecuteNonQuery();  // Ejecuta el comando SQL
            }
        }

        public static List<Receta> ObtenerRecetas()
        {
            List<Receta> recetas = new List<Receta>();

            using (SqlConnection conn = new SqlConnection("Server=PC19_LAB1\\SQLEXPRESS;Database=APPFARMACIA;Trusted_Connection=True;"))
            {
                string query = "SELECT * FROM Recetas";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Receta receta = new Receta
                    {
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Medicamento1 = reader["Medicamento1"].ToString(),
                        Medicamento2 = reader["Medicamento2"].ToString(),
                        Medicamento3 = reader["Medicamento3"].ToString(),
                        Medicamento4 = reader["Medicamento4"].ToString(),
                        Medicamento5 = reader["Medicamento5"].ToString(),
                        Medicamento6 = reader["Medicamento6"].ToString(),
                        DescripcionCorta = reader["DescripcionCorta"].ToString(),
                        FechaReceta = Convert.ToDateTime(reader["FechaReceta"]),
                        Correo = reader["Correo"].ToString()
                    };

                    recetas.Add(receta);
                }
            }

            return recetas;
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
