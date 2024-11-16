using System;
using System.Windows.Forms;
using FarmaciaAPP.Servicios; // Asegúrate de tener la referencia a los servicios

namespace FarmaciaAPP.Views.Facturas
{
    public partial class Factura : Form
    {
        private Usuario usuario;

        // Constructor que recibe un objeto Usuario
        public Factura(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario; // Asignamos el usuario recibido al campo
            CargarDatosUsuario();  // Llamamos al método para cargar los datos del usuario
        }

        // Método que carga los datos del usuario en los controles del formulario
        private void CargarDatosUsuario()
        {
            if (usuario != null)
            {
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtCorreo.Text = usuario.CorreoElectronico;
            }
            else
            {
                MessageBox.Show("Datos del usuario no disponibles.");
            }
        }

        private void btnConsultarMedicamento_Click(object sender, EventArgs e)
        {
            ConsultarMedicamento();
        }

        private async void ConsultarMedicamento()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMedicamento1.Text))
                {
                    MessageBox.Show("Por favor, ingresa el nombre de un medicamento para consultar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consultar información sobre el medicamento
                string pregunta = $"¿Qué es {txtMedicamento1.Text.Trim()} y para qué sirve?";
                string respuesta = await OpenAI.ConsultarOpenAi(pregunta);

                // Mostrar respuesta en el RichTextBox
                richTextBoxIndicaciones.Text = $"{txtMedicamento1.Text}: {respuesta}\n\n{richTextBoxIndicaciones.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al consultar la IA: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            // Crear un objeto Receta con los datos del formulario
            Receta receta = new Receta()
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Medicamento1 = txtMedicamento1.Text.Trim(),
                Medicamento2 = txtMedicamento2.Text.Trim(),
                Medicamento3 = txtMedicamento3.Text.Trim(),
                Medicamento4 = txtMedicamento4.Text.Trim(),
                Medicamento5 = txtMedicamento5.Text.Trim(),
                Medicamento6 = txtMedicamento6.Text.Trim(),
                DescripcionCorta = richTextBoxIndicaciones.Text.Trim(),
                FechaReceta = dateTimePickerFechaReceta.Value,
                Correo = txtCorreo.Text.Trim()
            };

            // Llamar a la función InsertarReceta para guardar la receta en la base de datos
            ConexionDB.InsertarReceta(receta);

            // Mensaje de confirmación
            MessageBox.Show("Receta guardada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Factura_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cerrar el formulario de InicioAdm cuando se cierre Factura
            this.Owner?.Close();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se carga el formulario
        }
    }
}


