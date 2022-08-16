namespace SGHv1._0.FormsServicios
{
    partial class FrmCargarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargarServicio));
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneHabitacion = new System.Windows.Forms.Label();
            this.lblSeleccioneTipoDeServicio = new System.Windows.Forms.Label();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.lblServicios = new System.Windows.Forms.Label();
            this.lblServicioSeleccionado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarServicio = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(227, 126);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(188, 27);
            this.cmbHabitaciones.TabIndex = 0;
            this.cmbHabitaciones.Tag = "cmbHabitaciones";
            // 
            // lblSeleccioneHabitacion
            // 
            this.lblSeleccioneHabitacion.AutoSize = true;
            this.lblSeleccioneHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneHabitacion.Location = new System.Drawing.Point(12, 134);
            this.lblSeleccioneHabitacion.Name = "lblSeleccioneHabitacion";
            this.lblSeleccioneHabitacion.Size = new System.Drawing.Size(165, 19);
            this.lblSeleccioneHabitacion.TabIndex = 1;
            this.lblSeleccioneHabitacion.Tag = "SeleccioneHabitacion";
            this.lblSeleccioneHabitacion.Text = "Seleccione Habitación :";
            // 
            // lblSeleccioneTipoDeServicio
            // 
            this.lblSeleccioneTipoDeServicio.AutoSize = true;
            this.lblSeleccioneTipoDeServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneTipoDeServicio.Location = new System.Drawing.Point(12, 176);
            this.lblSeleccioneTipoDeServicio.Name = "lblSeleccioneTipoDeServicio";
            this.lblSeleccioneTipoDeServicio.Size = new System.Drawing.Size(197, 19);
            this.lblSeleccioneTipoDeServicio.TabIndex = 2;
            this.lblSeleccioneTipoDeServicio.Tag = "SeleccioneTipoDeServicio";
            this.lblSeleccioneTipoDeServicio.Text = "Seleccione Tipo de Servicio :";
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(227, 168);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(188, 27);
            this.cmbTipoServicio.TabIndex = 3;
            this.cmbTipoServicio.Tag = "cmbTipoServicio";
            this.cmbTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cmbTipoServicio_SelectedIndexChanged);
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(441, 67);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(609, 237);
            this.dgvServicios.TabIndex = 4;
            this.dgvServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
            this.dgvServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicios_CellContentClick);
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicios.Location = new System.Drawing.Point(700, 27);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(92, 26);
            this.lblServicios.TabIndex = 5;
            this.lblServicios.Tag = "Servicios";
            this.lblServicios.Text = "Servicios";
            // 
            // lblServicioSeleccionado
            // 
            this.lblServicioSeleccionado.AutoSize = true;
            this.lblServicioSeleccionado.Location = new System.Drawing.Point(224, 225);
            this.lblServicioSeleccionado.Name = "lblServicioSeleccionado";
            this.lblServicioSeleccionado.Size = new System.Drawing.Size(110, 14);
            this.lblServicioSeleccionado.TabIndex = 8;
            this.lblServicioSeleccionado.Tag = "servicioSeleccionado";
            this.lblServicioSeleccionado.Text = "servicioSeleccionado";
            this.lblServicioSeleccionado.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SGHv1._0.Properties.Resources._1486071980_1_79325;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 92);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit7;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(356, 225);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 78);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarServicio
            // 
            this.btnCargarServicio.FlatAppearance.BorderSize = 0;
            this.btnCargarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarServicio.Image = global::SGHv1._0.Properties.Resources.add_image8;
            this.btnCargarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarServicio.Location = new System.Drawing.Point(12, 225);
            this.btnCargarServicio.Name = "btnCargarServicio";
            this.btnCargarServicio.Size = new System.Drawing.Size(103, 101);
            this.btnCargarServicio.TabIndex = 6;
            this.btnCargarServicio.Tag = "CargarServicio";
            this.btnCargarServicio.Text = "Cargar Servicio";
            this.btnCargarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarServicio.UseVisualStyleBackColor = true;
            this.btnCargarServicio.Click += new System.EventHandler(this.btnCargarServicio_Click);
            // 
            // FrmCargarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1062, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblServicioSeleccionado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarServicio);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.cmbTipoServicio);
            this.Controls.Add(this.lblSeleccioneTipoDeServicio);
            this.Controls.Add(this.lblSeleccioneHabitacion);
            this.Controls.Add(this.cmbHabitaciones);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCargarServicio";
            this.Tag = "CargarServicio";
            this.Text = "Cargar Servicio";
            this.Load += new System.EventHandler(this.FrmCargarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.Label lblSeleccioneHabitacion;
        private System.Windows.Forms.Label lblSeleccioneTipoDeServicio;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.Button btnCargarServicio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblServicioSeleccionado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}