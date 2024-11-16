using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaAPP
{
    public partial class InicioUsuario : Form
    {
        private Usuario _usuario;  // Variable privada para almacenar el usuario

        // Constructor que recibe un objeto Usuario
        public InicioUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;  // Asignar el usuario al campo privado
        }

        // Conexión a la base de datos
        string connectionString = "Server=DESKTOP-MV1NMJB\\SQLEXPRESS01;Database=APPFARMACIA;Trusted_Connection=True;";

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            // Ahora utilizamos los datos del usuario recibido en el constructor
            if (_usuario != null)
            {
                // Asignar los datos del usuario a los controles del formulario
                txtNombre.Text = _usuario.Nombre;
                txtApellido.Text = _usuario.Apellido;
                txtCorreo.Text = _usuario.CorreoElectronico;
                txtRol.Text = _usuario.Rol;
            }
            else
            {
                MessageBox.Show("El usuario no está disponible.");
            }
        }

        private void ObtenerDatosUsuario(string nombreUsuario)
        {
            // Consultar los datos del usuario desde la base de datos (si es necesario)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT NombreUsuario, Nombre, Apellido, Rol, CorreoElectronico FROM Usuarios WHERE NombreUsuario = @NombreUsuario";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Asignar los valores a los TextBox
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtApellido.Text = reader["Apellido"].ToString();
                            txtCorreo.Text = reader["CorreoElectronico"].ToString();
                            txtRol.Text = reader["Rol"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Este método no está siendo utilizado en el código actual.
        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {
            // Aquí podrías cargar cualquier dato adicional si es necesario al inicio
        }
    }
}

