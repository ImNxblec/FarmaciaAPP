using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaAPP.Views.Tabla_recetas
{
    public partial class frmRecetas : Form
    {
        public frmRecetas()
        {
            InitializeComponent();
        }

        private void ConfigurarDTGReceta()
        {
            DTGReceta.Columns.Add("Nombre", "Nombre");
            DTGReceta.Columns.Add("Apellido", "Apellido");
            DTGReceta.Columns.Add("Medicamento1", "Medicamento 1");
            DTGReceta.Columns.Add("Medicamento2", "Medicamento 2");
            DTGReceta.Columns.Add("Medicamento3", "Medicamento 3");
            DTGReceta.Columns.Add("Medicamento4", "Medicamento 4");
            DTGReceta.Columns.Add("Medicamento5", "Medicamento 5");
            DTGReceta.Columns.Add("Medicamento6", "Medicamento 6");
            DTGReceta.Columns.Add("DescripcionCorta", "Descripción Corta");
            DTGReceta.Columns.Add("FechaReceta", "Fecha Receta");
            DTGReceta.Columns.Add("Correo", "Correo");

        }

        private void CargarRecetas()
        {
            try
            {
                List<Receta> recetas = ConexionDB.ObtenerRecetas(); // Obtener las recetas de la base de datos

                // Limpiar las filas del DataGridView
                DTGReceta.Rows.Clear();

                // Verificar si hay recetas
                if (recetas.Count == 0)
                {
                    MessageBox.Show("No hay recetas para mostrar.");
                }

                // Agregar las recetas al DataGridView
                foreach (var receta in recetas)
                {
                    DTGReceta.Rows.Add(
                        receta.Nombre,
                        receta.Apellido,
                        receta.Medicamento1,
                        receta.Medicamento2,
                        receta.Medicamento3,
                        receta.Medicamento4,
                        receta.Medicamento5,
                        receta.Medicamento6,
                        receta.DescripcionCorta,
                        receta.FechaReceta.ToShortDateString(),
                        receta.Correo
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las recetas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRecetas_Load(object sender, EventArgs e)
        {
            ConfigurarDTGReceta();
            CargarRecetas();
        }
    }
}
