namespace SGHv1._0.FormsReservas
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.lblListadoDeReservas = new System.Windows.Forms.Label();
            this.lblReservaSeleccionada = new System.Windows.Forms.Label();
            this.lblNroReservaSeleccionada = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblNroHabitacion = new System.Windows.Forms.Label();
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.lblNroDias = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnImprimirListadoReservas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRealizarCheckIn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(12, 38);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.Size = new System.Drawing.Size(1160, 328);
            this.dgvReservas.TabIndex = 3;
            this.dgvReservas.Tag = "dgvReservas";
            this.dgvReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblListadoDeReservas
            // 
            this.lblListadoDeReservas.AutoSize = true;
            this.lblListadoDeReservas.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoDeReservas.Location = new System.Drawing.Point(484, 9);
            this.lblListadoDeReservas.Name = "lblListadoDeReservas";
            this.lblListadoDeReservas.Size = new System.Drawing.Size(192, 26);
            this.lblListadoDeReservas.TabIndex = 4;
            this.lblListadoDeReservas.Tag = "lblListadoDeReservas";
            this.lblListadoDeReservas.Text = "Listado de Reservas";
            // 
            // lblReservaSeleccionada
            // 
            this.lblReservaSeleccionada.AutoSize = true;
            this.lblReservaSeleccionada.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaSeleccionada.Location = new System.Drawing.Point(12, 405);
            this.lblReservaSeleccionada.Name = "lblReservaSeleccionada";
            this.lblReservaSeleccionada.Size = new System.Drawing.Size(159, 19);
            this.lblReservaSeleccionada.TabIndex = 5;
            this.lblReservaSeleccionada.Tag = "ReservaSeleccionada";
            this.lblReservaSeleccionada.Text = "Reserva Seleccionada :";
            // 
            // lblNroReservaSeleccionada
            // 
            this.lblNroReservaSeleccionada.AutoSize = true;
            this.lblNroReservaSeleccionada.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroReservaSeleccionada.Location = new System.Drawing.Point(246, 405);
            this.lblNroReservaSeleccionada.Name = "lblNroReservaSeleccionada";
            this.lblNroReservaSeleccionada.Size = new System.Drawing.Size(88, 19);
            this.lblNroReservaSeleccionada.TabIndex = 6;
            this.lblNroReservaSeleccionada.Tag = "NumeroReservaSeleccionada";
            this.lblNroReservaSeleccionada.Text = "Nro Reserva";
            this.lblNroReservaSeleccionada.Visible = false;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(12, 466);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(90, 19);
            this.lblHabitacion.TabIndex = 7;
            this.lblHabitacion.Tag = "Habitacion";
            this.lblHabitacion.Text = "Habitacion :";
            // 
            // lblNroHabitacion
            // 
            this.lblNroHabitacion.AutoSize = true;
            this.lblNroHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroHabitacion.Location = new System.Drawing.Point(246, 466);
            this.lblNroHabitacion.Name = "lblNroHabitacion";
            this.lblNroHabitacion.Size = new System.Drawing.Size(111, 19);
            this.lblNroHabitacion.TabIndex = 8;
            this.lblNroHabitacion.Tag = "Habitacion";
            this.lblNroHabitacion.Text = "Nro Habitacion";
            this.lblNroHabitacion.Visible = false;
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDias.Location = new System.Drawing.Point(12, 502);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(129, 19);
            this.lblCantidadDias.TabIndex = 9;
            this.lblCantidadDias.Tag = "CantidadDias";
            this.lblCantidadDias.Text = "Cantidad de Días :";
            // 
            // lblNroDias
            // 
            this.lblNroDias.AutoSize = true;
            this.lblNroDias.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDias.Location = new System.Drawing.Point(246, 502);
            this.lblNroDias.Name = "lblNroDias";
            this.lblNroDias.Size = new System.Drawing.Size(66, 19);
            this.lblNroDias.TabIndex = 10;
            this.lblNroDias.Tag = "NroDias";
            this.lblNroDias.Text = "Nro Dias";
            this.lblNroDias.Visible = false;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(12, 436);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(120, 19);
            this.lblNombreCliente.TabIndex = 11;
            this.lblNombreCliente.Tag = "NombreCliente";
            this.lblNombreCliente.Text = "Nombre Cliente :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(246, 436);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Tag = "Nombre";
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // btnImprimirListadoReservas
            // 
            this.btnImprimirListadoReservas.FlatAppearance.BorderSize = 0;
            this.btnImprimirListadoReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimirListadoReservas.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirListadoReservas.Image = global::SGHv1._0.Properties.Resources.pdf;
            this.btnImprimirListadoReservas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimirListadoReservas.Location = new System.Drawing.Point(987, 422);
            this.btnImprimirListadoReservas.Name = "btnImprimirListadoReservas";
            this.btnImprimirListadoReservas.Size = new System.Drawing.Size(124, 77);
            this.btnImprimirListadoReservas.TabIndex = 13;
            this.btnImprimirListadoReservas.Tag = "ImprimirListadoReservas";
            this.btnImprimirListadoReservas.Text = "Generar PDF";
            this.btnImprimirListadoReservas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimirListadoReservas.UseVisualStyleBackColor = true;
            this.btnImprimirListadoReservas.Click += new System.EventHandler(this.btnImprimirListadoReservas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit4;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1105, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 77);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Tag = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRealizarCheckIn
            // 
            this.btnRealizarCheckIn.Enabled = false;
            this.btnRealizarCheckIn.FlatAppearance.BorderSize = 0;
            this.btnRealizarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarCheckIn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCheckIn.Image = global::SGHv1._0.Properties.Resources.check_in;
            this.btnRealizarCheckIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizarCheckIn.Location = new System.Drawing.Point(913, 422);
            this.btnRealizarCheckIn.Name = "btnRealizarCheckIn";
            this.btnRealizarCheckIn.Size = new System.Drawing.Size(81, 95);
            this.btnRealizarCheckIn.TabIndex = 1;
            this.btnRealizarCheckIn.Tag = "btnRealizarCheckIn";
            this.btnRealizarCheckIn.Text = "Realizar Check In";
            this.btnRealizarCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizarCheckIn.UseVisualStyleBackColor = true;
            this.btnRealizarCheckIn.Click += new System.EventHandler(this.btnRealizarCheckIn_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1184, 529);
            this.Controls.Add(this.btnImprimirListadoReservas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblNroDias);
            this.Controls.Add(this.lblCantidadDias);
            this.Controls.Add(this.lblNroHabitacion);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblNroReservaSeleccionada);
            this.Controls.Add(this.lblReservaSeleccionada);
            this.Controls.Add(this.lblListadoDeReservas);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizarCheckIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.CheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRealizarCheckIn;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Label lblListadoDeReservas;
        private System.Windows.Forms.Label lblReservaSeleccionada;
        private System.Windows.Forms.Label lblNroReservaSeleccionada;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblNroHabitacion;
        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.Label lblNroDias;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnImprimirListadoReservas;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}