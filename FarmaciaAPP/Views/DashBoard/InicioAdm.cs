using System;
using System.Windows.Forms;

namespace FarmaciaAPP
{
    public partial class InicioAdm : Form
    {
        // Campo para almacenar el usuario que se pasará desde el formulario anterior
        private Usuario usuario;

        // Constructor que acepta un objeto Usuario
        public InicioAdm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;  // Asignar el objeto Usuario al campo
            CargarDatosUsuario();
        }

        private void InicioAdm_Load(object sender, EventArgs e)
        {
            // Los datos ya se cargan en el constructor, no es necesario hacer otra búsqueda aquí.
        }

        private void CargarDatosUsuario()
        {
            if (usuario != null)
            {
                // Asignar los datos del usuario a los controles en el formulario
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtCorreo.Text = usuario.CorreoElectronico;
                txtRol.Text = usuario.Rol;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
}

