namespace FarmaciaAPP
{
    partial class CrearNuevoUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbInicio = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtRepetirContrasena = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "REGISTRO DE USUARIO";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.lbInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInicio.Location = new System.Drawing.Point(125, 345);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(109, 13);
            this.lbInicio.TabIndex = 13;
            this.lbInicio.Text = "Ya tiene una cuenta?";
            this.lbInicio.Click += new System.EventHandler(this.lbInicio_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(69, 68);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(222, 26);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.Text = "Correo electronico";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContrasena.Location = new System.Drawing.Point(69, 148);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(222, 26);
            this.txtContrasena.TabIndex = 11;
            this.txtContrasena.Text = "Contrasena";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistrar.Location = new System.Drawing.Point(138, 297);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 35);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Guardar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chkMostrarContrasena.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkMostrarContrasena.Location = new System.Drawing.Point(69, 220);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(117, 17);
            this.chkMostrarContrasena.TabIndex = 9;
            this.chkMostrarContrasena.Text = "Mostrar contrasena";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(69, 108);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 26);
            this.txtUsuario.TabIndex = 15;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRepetirContrasena.Location = new System.Drawing.Point(69, 188);
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.Size = new System.Drawing.Size(222, 26);
            this.txtRepetirContrasena.TabIndex = 16;
            this.txtRepetirContrasena.Text = "Repetir contrasena";
            this.txtRepetirContrasena.Enter += new System.EventHandler(this.txtRepetirContrasena_Enter);
            this.txtRepetirContrasena.Leave += new System.EventHandler(this.txtRepetirContrasena_Leave);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(69, 243);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(222, 21);
            this.cmbRol.TabIndex = 17;
            // 
            // CrearNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 421);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtRepetirContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInicio);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.chkMostrarContrasena);
            this.Name = "CrearNuevoUsuario";
            this.Text = "CrearNuevoUsuario";
            this.Load += new System.EventHandler(this.CrearNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbInicio;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtRepetirContrasena;
        private System.Windows.Forms.ComboBox cmbRol;
    }
}