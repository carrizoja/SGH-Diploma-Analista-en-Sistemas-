namespace SGHv1._0.FormsReservas
{
    partial class FrmAdministracionDeReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracionDeReservas));
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbNumeroHabitacion = new System.Windows.Forms.ComboBox();
            this.lblAdministracionDeReservas = new System.Windows.Forms.Label();
            this.lblNumeroDeReserva = new System.Windows.Forms.Label();
            this.lblNumeroReserva = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCargarReserva = new System.Windows.Forms.Button();
            this.chbEsViajeLaboral = new System.Windows.Forms.CheckBox();
            this.chbConNinios = new System.Windows.Forms.CheckBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(11, 188);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(11, 230);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(140, 19);
            this.lblHabitacion.TabIndex = 2;
            this.lblHabitacion.Text = "Número Habitacion";
            this.lblHabitacion.Click += new System.EventHandler(this.LblHabitacion_Click);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(11, 284);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(121, 19);
            this.lblFechaIngreso.TabIndex = 8;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Location = new System.Drawing.Point(171, 284);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(291, 27);
            this.dtpFechaIngreso.TabIndex = 9;
            this.dtpFechaIngreso.Tag = "dtpFechaIngreso";
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.AutoSize = true;
            this.lblFechaEgreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEgreso.Location = new System.Drawing.Point(12, 329);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(118, 19);
            this.lblFechaEgreso.TabIndex = 10;
            this.lblFechaEgreso.Text = "Fecha de Egreso";
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEgreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEgreso.Location = new System.Drawing.Point(171, 327);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(291, 27);
            this.dtpFechaEgreso.TabIndex = 11;
            this.dtpFechaEgreso.Tag = "dtpFechaEgreso";
            this.dtpFechaEgreso.CloseUp += new System.EventHandler(this.dtpFechaEgreso_CloseUp);
            this.dtpFechaEgreso.ValueChanged += new System.EventHandler(this.dtpFechaEgreso_ValueChanged);
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDias.Location = new System.Drawing.Point(11, 374);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(124, 19);
            this.lblCantidadDias.TabIndex = 12;
            this.lblCantidadDias.Tag = "lblCantidadDeDias";
            this.lblCantidadDias.Text = "Cantidad de días:";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(495, 101);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(906, 453);
            this.dgvReservas.TabIndex = 18;
            this.dgvReservas.Tag = "dgvReservas";
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(171, 185);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(291, 27);
            this.cmbCliente.TabIndex = 19;
            this.cmbCliente.Tag = "cmbCliente";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(168, 374);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 19);
            this.lblCantidad.TabIndex = 20;
            this.lblCantidad.Tag = "lblCantidad";
            this.lblCantidad.Text = "cantidad";
            // 
            // cmbNumeroHabitacion
            // 
            this.cmbNumeroHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroHabitacion.FormattingEnabled = true;
            this.cmbNumeroHabitacion.Location = new System.Drawing.Point(171, 230);
            this.cmbNumeroHabitacion.Name = "cmbNumeroHabitacion";
            this.cmbNumeroHabitacion.Size = new System.Drawing.Size(291, 27);
            this.cmbNumeroHabitacion.TabIndex = 21;
            this.cmbNumeroHabitacion.Tag = "txtNumeroHabitacion";
            // 
            // lblAdministracionDeReservas
            // 
            this.lblAdministracionDeReservas.AutoSize = true;
            this.lblAdministracionDeReservas.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracionDeReservas.Location = new System.Drawing.Point(871, 54);
            this.lblAdministracionDeReservas.Name = "lblAdministracionDeReservas";
            this.lblAdministracionDeReservas.Size = new System.Drawing.Size(263, 26);
            this.lblAdministracionDeReservas.TabIndex = 25;
            this.lblAdministracionDeReservas.Tag = "lblAdministracionDeReservas";
            this.lblAdministracionDeReservas.Text = "Administración de Reservas";
            // 
            // lblNumeroDeReserva
            // 
            this.lblNumeroDeReserva.AutoSize = true;
            this.lblNumeroDeReserva.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeReserva.Location = new System.Drawing.Point(12, 146);
            this.lblNumeroDeReserva.Name = "lblNumeroDeReserva";
            this.lblNumeroDeReserva.Size = new System.Drawing.Size(137, 19);
            this.lblNumeroDeReserva.TabIndex = 26;
            this.lblNumeroDeReserva.Tag = "lblNumeroDeReserva";
            this.lblNumeroDeReserva.Text = "Número de Reserva";
            // 
            // lblNumeroReserva
            // 
            this.lblNumeroReserva.AutoSize = true;
            this.lblNumeroReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroReserva.Location = new System.Drawing.Point(168, 146);
            this.lblNumeroReserva.Name = "lblNumeroReserva";
            this.lblNumeroReserva.Size = new System.Drawing.Size(0, 18);
            this.lblNumeroReserva.TabIndex = 27;
            this.lblNumeroReserva.Tag = "lblNumeroReserva";
            this.lblNumeroReserva.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.calendar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 131);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit3;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(401, 497);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 76);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SGHv1._0.Properties.Resources.remove6;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(271, 490);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 83);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Tag = "Eliminar";
            this.btnEliminar.Text = "Cancelar Reserva";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SGHv1._0.Properties.Resources.modify3;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(127, 490);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(138, 83);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Tag = "Editar";
            this.btnEditar.Text = "Editar Reserva";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCargarReserva
            // 
            this.btnCargarReserva.FlatAppearance.BorderSize = 0;
            this.btnCargarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarReserva.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarReserva.Image = global::SGHv1._0.Properties.Resources.add_image3;
            this.btnCargarReserva.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarReserva.Location = new System.Drawing.Point(12, 497);
            this.btnCargarReserva.Name = "btnCargarReserva";
            this.btnCargarReserva.Size = new System.Drawing.Size(118, 86);
            this.btnCargarReserva.TabIndex = 16;
            this.btnCargarReserva.Text = "Cargar Reserva";
            this.btnCargarReserva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarReserva.UseVisualStyleBackColor = true;
            this.btnCargarReserva.Click += new System.EventHandler(this.btnCargarReserva_Click);
            // 
            // chbEsViajeLaboral
            // 
            this.chbEsViajeLaboral.AutoSize = true;
            this.chbEsViajeLaboral.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEsViajeLaboral.Location = new System.Drawing.Point(16, 429);
            this.chbEsViajeLaboral.Name = "chbEsViajeLaboral";
            this.chbEsViajeLaboral.Size = new System.Drawing.Size(122, 22);
            this.chbEsViajeLaboral.TabIndex = 31;
            this.chbEsViajeLaboral.Tag = "EsViajeLaboral";
            this.chbEsViajeLaboral.Text = "Es Viaje Laboral";
            this.chbEsViajeLaboral.UseVisualStyleBackColor = true;
            // 
            // chbConNinios
            // 
            this.chbConNinios.AutoSize = true;
            this.chbConNinios.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbConNinios.Location = new System.Drawing.Point(172, 429);
            this.chbConNinios.Name = "chbConNinios";
            this.chbConNinios.Size = new System.Drawing.Size(90, 22);
            this.chbConNinios.TabIndex = 32;
            this.chbConNinios.Tag = "ConNinios";
            this.chbConNinios.Text = "Con Niños";
            this.chbConNinios.UseVisualStyleBackColor = true;
            // 
            // FrmAdministracionDeReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1426, 615);
            this.Controls.Add(this.chbConNinios);
            this.Controls.Add(this.chbEsViajeLaboral);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNumeroReserva);
            this.Controls.Add(this.lblNumeroDeReserva);
            this.Controls.Add(this.lblAdministracionDeReservas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cmbNumeroHabitacion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnCargarReserva);
            this.Controls.Add(this.lblCantidadDias);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministracionDeReservas";
            this.Tag = "AdministracionDeReservas";
            this.Text = "Administración de Reservas";
            this.Load += new System.EventHandler(this.FrmCargarReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.Button btnCargarReserva;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbNumeroHabitacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAdministracionDeReservas;
        private System.Windows.Forms.Label lblNumeroDeReserva;
        private System.Windows.Forms.Label lblNumeroReserva;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chbEsViajeLaboral;
        private System.Windows.Forms.CheckBox chbConNinios;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}