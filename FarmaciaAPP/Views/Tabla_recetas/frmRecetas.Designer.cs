namespace FarmaciaAPP.Views.Tabla_recetas
{
    partial class frmRecetas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTGReceta = new System.Windows.Forms.DataGridView();
            this.ID_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICAMENTO_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_RECETA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTGReceta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 259);
            this.panel1.TabIndex = 0;
            // 
            // DTGReceta
            // 
            this.DTGReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_RECETA,
            this.NOMBRE,
            this.APELLIDO,
            this.MEDICAMENTO_1,
            this.MEDICAMENTO_2,
            this.MEDICAMENTO_3,
            this.MEDICAMENTO_4,
            this.MEDICAMENTO_5,
            this.MEDICAMENTO_6,
            this.DESCRIPCION,
            this.FECHA_RECETA,
            this.CORREO});
            this.DTGReceta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGReceta.Location = new System.Drawing.Point(0, 0);
            this.DTGReceta.Name = "DTGReceta";
            this.DTGReceta.Size = new System.Drawing.Size(551, 259);
            this.DTGReceta.TabIndex = 0;
            // 
            // ID_RECETA
            // 
            this.ID_RECETA.HeaderText = "ID";
            this.ID_RECETA.Name = "ID_RECETA";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // MEDICAMENTO_1
            // 
            this.MEDICAMENTO_1.HeaderText = "MEDICAMENTO 1";
            this.MEDICAMENTO_1.Name = "MEDICAMENTO_1";
            // 
            // MEDICAMENTO_2
            // 
            this.MEDICAMENTO_2.HeaderText = "MEDICAMENTO 2";
            this.MEDICAMENTO_2.Name = "MEDICAMENTO_2";
            // 
            // MEDICAMENTO_3
            // 
            this.MEDICAMENTO_3.HeaderText = "MEDICAMENTO 3";
            this.MEDICAMENTO_3.Name = "MEDICAMENTO_3";
            // 
            // MEDICAMENTO_4
            // 
            this.MEDICAMENTO_4.HeaderText = "MEDICAMENTO 4";
            this.MEDICAMENTO_4.Name = "MEDICAMENTO_4";
            // 
            // MEDICAMENTO_5
            // 
            this.MEDICAMENTO_5.HeaderText = "MEDICAMENTO 5";
            this.MEDICAMENTO_5.Name = "MEDICAMENTO_5";
            // 
            // MEDICAMENTO_6
            // 
            this.MEDICAMENTO_6.HeaderText = "MEDICAMENTO 6";
            this.MEDICAMENTO_6.Name = "MEDICAMENTO_6";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // FECHA_RECETA
            // 
            this.FECHA_RECETA.HeaderText = "FECHA";
            this.FECHA_RECETA.Name = "FECHA_RECETA";
            // 
            // CORREO
            // 
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            // 
            // frmRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 259);
            this.Controls.Add(this.panel1);
            this.Name = "frmRecetas";
            this.Text = "frmRecetas";
            this.Load += new System.EventHandler(this.frmRecetas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DTGReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICAMENTO_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_RECETA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
    }
}