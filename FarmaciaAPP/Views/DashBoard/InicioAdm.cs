using FarmaciaAPP.Views.Facturas;
using FarmaciaAPP.Views.Tabla_recetas;
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

        private void btnGenerarReceta_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario Factura (o Receta) y pasar el usuario
            Factura facturaForm = new Factura(usuario); // Pasamos el usuario para usar sus datos

            // Ocultar el formulario de InicioAdm
            this.Hide();

            // Mostrar el formulario de Factura (Receta)
            facturaForm.Show();
        }

        private void btnVerRecetas_Click(object sender, EventArgs e)
        {
            frmRecetas frm = new frmRecetas();
            frm.ShowDialog();
        }
    }
}


