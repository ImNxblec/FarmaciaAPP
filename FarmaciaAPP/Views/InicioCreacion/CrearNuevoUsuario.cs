using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // Para la conexión a la base de datos

namespace FarmaciaAPP
{
    public partial class CrearNuevoUsuario : Form
    {
        public CrearNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;
            string repetirContrasena = txtRepetirContrasena.Text;
            string rol = cmbRol.SelectedItem.ToString(); // Asumimos que tienes un ComboBox para seleccionar el rol

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(repetirContrasena) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (contrasena != repetirContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar en la base de datos
            GuardarUsuario(correo, usuario, contrasena, rol);
        }

        private void GuardarUsuario(string correo, string usuario, string contrasena, string rol)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "Server=DESKTOP-MV1NMJB\\SQLEXPRESS01;Database=APPFARMACIA;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios (Correo, Usuario, Contrasena, Rol) VALUES (@Correo, @Usuario, @Contrasena, @Rol)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContrasena.Checked)
            {
                // Muestra la contraseña
                txtContrasena.PasswordChar = '\0';
                txtRepetirContrasena.PasswordChar = '\0';
            }
            else
            {
                // Oculta la contraseña
                txtContrasena.PasswordChar = '*';
                txtRepetirContrasena.PasswordChar = '*';
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo electronico")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black; // Cambiar a color negro cuando empieza a escribir
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo electronico"; // Placeholder
                txtCorreo.ForeColor = Color.Gray; // Cambia el color a gris
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario"; // Placeholder
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contrasena")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black; // Cambia el color de texto
                txtContrasena.PasswordChar = '*'; // Muestra los asteriscos
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contrasena"; // Placeholder
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0'; // Deja que el texto se vea cuando no se ha ingresado nada
            }
        }

        private void txtRepetirContrasena_Enter(object sender, EventArgs e)
        {
            if (txtRepetirContrasena.Text == "Repetir contrasena")
            {
                txtRepetirContrasena.Text = "";
                txtRepetirContrasena.ForeColor = Color.Black; // Cambia el color de texto
                txtRepetirContrasena.PasswordChar = '*'; // Muestra los asteriscos
            }
        }

        private void txtRepetirContrasena_Leave(object sender, EventArgs e)
        {
            if (txtRepetirContrasena.Text == "")
            {
                txtRepetirContrasena.Text = "Repetir contrasena"; // Placeholder
                txtRepetirContrasena.ForeColor = Color.Gray;
                txtRepetirContrasena.PasswordChar = '\0'; // Deja que el texto se vea cuando no se ha ingresado nada
            }
        }

        private void lbInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearNuevoUsuario_Load(object sender, EventArgs e)
        {
            // Agregar los roles al ComboBox
            cmbRol.Items.Add("ADM");
            cmbRol.Items.Add("normal");
            cmbRol.SelectedIndex = 0;  // Seleccionar por defecto "normal"
        }
    }
}


