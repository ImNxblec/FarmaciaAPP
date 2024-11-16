using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaAPP
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsername.Text.Trim();  // Usamos txtUsuario
            string contrasena = txtContrasena.Text;

            // Verificar las credenciales
            Usuario usuario = ConexionDB.ObtenerUsuario(nombreUsuario);

            if (usuario != null)
            {
                // Verificar si la contraseña es correcta
                if (usuario.Contrasena == contrasena)
                {
                    // Redirigir a la pantalla correspondiente según el rol
                    if (usuario.Rol == "ADM")
                    {
                        // Crear la instancia de InicioAdm y pasar el objeto Usuario
                        InicioAdm inicioAdm = new InicioAdm(usuario);  // Ahora pasa el usuario al constructor
                        inicioAdm.Show();
                        this.Hide(); // Ocultar el formulario de inicio de sesión
                    }
                    else
                    {
                        // Crear la instancia de InicioUsuario y pasar el objeto Usuario
                        InicioUsuario inicioUsuario = new InicioUsuario(usuario);  // Pasamos el usuario al constructor
                        inicioUsuario.Show();
                        this.Hide(); // Ocultar el formulario de inicio de sesión
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbCrearModificarI_Click(object sender, EventArgs e)
        {
            // Ocultar el formulario de inicio de sesión en lugar de cerrarlo
            this.Hide();

            // Crear una nueva instancia del formulario CrearNuevoUsuario
            CrearNuevoUsuario frmCrearUsuario = new CrearNuevoUsuario();

            // Abrir el formulario CrearNuevoUsuario de manera modal
            frmCrearUsuario.ShowDialog();

            // Mostrar de nuevo el formulario de inicio de sesión después de cerrar CrearNuevoUsuario
            this.Show();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarContrasena.Checked)
            {
                // Muestra la contraseña
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                // Oculta la contraseña
                txtContrasena.PasswordChar = '*';
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Usuario")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Usuario";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contrasena")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.PasswordChar = '*'; // Muestra los asteriscos
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contrasena";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0'; // Deja que el texto se vea cuando no se ha ingresado nada
            }
        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {
            bool conexionExitosa = ConexionDB.VerificarConexionBD();  // Verificar la conexión a la base de datos

            if (!conexionExitosa)
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Por favor, intente más tarde.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();  // Cerrar la aplicación si no se pudo conectar
            }
            // Aquí puedes agregar código de inicialización si es necesario, pero actualmente no hace falta nada
        }
    }
}
