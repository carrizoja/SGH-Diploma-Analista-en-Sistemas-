namespace SGHv1._0.LimpiezaHabitaciones
{
    partial class GestionLimpiezaHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLimpiezaHabitaciones));
            this.cmbEmpleadosLimpieza = new System.Windows.Forms.ComboBox();
            this.lblEmpleadoLimpieza = new System.Windows.Forms.Label();
            this.lblHabitaciones = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.dgvPlanilla = new System.Windows.Forms.DataGridView();
            this.lblPlanilla = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrarPlanilla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarHabitacion = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmpleadosLimpieza
            // 
            this.cmbEmpleadosLimpieza.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleadosLimpieza.FormattingEnabled = true;
            this.cmbEmpleadosLimpieza.Location = new System.Drawing.Point(15, 55);
            this.cmbEmpleadosLimpieza.Name = "cmbEmpleadosLimpieza";
            this.cmbEmpleadosLimpieza.Size = new System.Drawing.Size(179, 26);
            this.cmbEmpleadosLimpieza.TabIndex = 0;
            this.cmbEmpleadosLimpieza.Tag = "cmbEmpleadosLimpieza";
            this.cmbEmpleadosLimpieza.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleadosLimpieza_SelectedIndexChanged);
            // 
            // lblEmpleadoLimpieza
            // 
            this.lblEmpleadoLimpieza.AutoSize = true;
            this.lblEmpleadoLimpieza.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleadoLimpieza.Location = new System.Drawing.Point(24, 24);
            this.lblEmpleadoLimpieza.Name = "lblEmpleadoLimpieza";
            this.lblEmpleadoLimpieza.Size = new System.Drawing.Size(152, 18);
            this.lblEmpleadoLimpieza.TabIndex = 1;
            this.lblEmpleadoLimpieza.Text = "Empleado de Limpieza :";
            // 
            // lblHabitaciones
            // 
            this.lblHabitaciones.AutoSize = true;
            this.lblHabitaciones.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitaciones.Location = new System.Drawing.Point(385, 24);
            this.lblHabitaciones.Name = "lblHabitaciones";
            this.lblHabitaciones.Size = new System.Drawing.Size(102, 19);
            this.lblHabitaciones.TabIndex = 3;
            this.lblHabitaciones.Tag = "lblHabitaciones";
            this.lblHabitaciones.Text = "Habitaciones ";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(224, 55);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.Size = new System.Drawing.Size(401, 169);
            this.dgvHabitaciones.TabIndex = 5;
            // 
            // dgvPlanilla
            // 
            this.dgvPlanilla.AllowUserToAddRows = false;
            this.dgvPlanilla.AllowUserToDeleteRows = false;
            this.dgvPlanilla.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanilla.Location = new System.Drawing.Point(631, 55);
            this.dgvPlanilla.Name = "dgvPlanilla";
            this.dgvPlanilla.ReadOnly = true;
            this.dgvPlanilla.Size = new System.Drawing.Size(401, 169);
            this.dgvPlanilla.TabIndex = 6;
            this.dgvPlanilla.Tag = "dgvPlanilla";
            this.dgvPlanilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanilla_CellContentClick);
            this.dgvPlanilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanilla_CellContentClick);
            // 
            // lblPlanilla
            // 
            this.lblPlanilla.AutoSize = true;
            this.lblPlanilla.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilla.Location = new System.Drawing.Point(796, 24);
            this.lblPlanilla.Name = "lblPlanilla";
            this.lblPlanilla.Size = new System.Drawing.Size(60, 19);
            this.lblPlanilla.TabIndex = 7;
            this.lblPlanilla.Tag = "lblPlanilla";
            this.lblPlanilla.Text = "Planilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGHv1._0.Properties.Resources.cleaning_16813;
            this.pictureBox1.Location = new System.Drawing.Point(41, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 144);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrarPlanilla
            // 
            this.btnBorrarPlanilla.FlatAppearance.BorderSize = 0;
            this.btnBorrarPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPlanilla.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPlanilla.Image = global::SGHv1._0.Properties.Resources.remove8;
            this.btnBorrarPlanilla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrarPlanilla.Location = new System.Drawing.Point(769, 230);
            this.btnBorrarPlanilla.Name = "btnBorrarPlanilla";
            this.btnBorrarPlanilla.Size = new System.Drawing.Size(117, 75);
            this.btnBorrarPlanilla.TabIndex = 11;
            this.btnBorrarPlanilla.Tag = "BorrarPlanilla";
            this.btnBorrarPlanilla.Text = "Borrar Planilla";
            this.btnBorrarPlanilla.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarPlanilla.UseVisualStyleBackColor = true;
            this.btnBorrarPlanilla.Click += new System.EventHandler(this.btnBorrarSeleccionada_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit5;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(977, 228);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 77);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarHabitacion
            // 
            this.btnAgregarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarHabitacion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHabitacion.Image = global::SGHv1._0.Properties.Resources.add_image4;
            this.btnAgregarHabitacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarHabitacion.Location = new System.Drawing.Point(365, 228);
            this.btnAgregarHabitacion.Name = "btnAgregarHabitacion";
            this.btnAgregarHabitacion.Size = new System.Drawing.Size(140, 77);
            this.btnAgregarHabitacion.TabIndex = 8;
            this.btnAgregarHabitacion.Tag = "AgregarHabitacion";
            this.btnAgregarHabitacion.Text = "Agregar Habitacion";
            this.btnAgregarHabitacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarHabitacion.Click += new System.EventHandler(this.btnAgregarHabitacion_Click);
            // 
            // GestionLimpiezaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1056, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrarPlanilla);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarHabitacion);
            this.Controls.Add(this.lblPlanilla);
            this.Controls.Add(this.dgvPlanilla);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.lblHabitaciones);
            this.Controls.Add(this.lblEmpleadoLimpieza);
            this.Controls.Add(this.cmbEmpleadosLimpieza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionLimpiezaHabitaciones";
            this.Text = "GestionLimpiezaHabitaciones";
            this.Load += new System.EventHandler(this.GestionLimpiezaHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmpleadosLimpieza;
        private System.Windows.Forms.Label lblEmpleadoLimpieza;
        private System.Windows.Forms.Label lblHabitaciones;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.DataGridView dgvPlanilla;
        private System.Windows.Forms.Label lblPlanilla;
        private System.Windows.Forms.Button btnAgregarHabitacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarPlanilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}