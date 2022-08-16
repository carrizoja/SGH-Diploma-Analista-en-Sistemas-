namespace SGHv1._0.FormsCuentas
{
    partial class FrmVerEstadoCuentaHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEstadoCuentaHabitaciones));
            this.lblSeleccioneHabitacion = new System.Windows.Forms.Label();
            this.cmbHabitaciones = new System.Windows.Forms.ComboBox();
            this.dgvConsumos = new System.Windows.Forms.DataGridView();
            this.lblEstadoDeCuenta = new System.Windows.Forms.Label();
            this.lblHuespedActual = new System.Windows.Forms.Label();
            this.lblNombreHuesped = new System.Windows.Forms.Label();
            this.lblTotalEnPesos = new System.Windows.Forms.Label();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRealizarCheckOut = new System.Windows.Forms.Button();
            this.btnConsultarConsumos = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccioneHabitacion
            // 
            this.lblSeleccioneHabitacion.AutoSize = true;
            this.lblSeleccioneHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneHabitacion.Location = new System.Drawing.Point(12, 77);
            this.lblSeleccioneHabitacion.Name = "lblSeleccioneHabitacion";
            this.lblSeleccioneHabitacion.Size = new System.Drawing.Size(165, 19);
            this.lblSeleccioneHabitacion.TabIndex = 2;
            this.lblSeleccioneHabitacion.Tag = "SeleccioneHabitacion";
            this.lblSeleccioneHabitacion.Text = "Seleccione Habitación :";
            // 
            // cmbHabitaciones
            // 
            this.cmbHabitaciones.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHabitaciones.FormattingEnabled = true;
            this.cmbHabitaciones.Location = new System.Drawing.Point(203, 77);
            this.cmbHabitaciones.Name = "cmbHabitaciones";
            this.cmbHabitaciones.Size = new System.Drawing.Size(141, 27);
            this.cmbHabitaciones.TabIndex = 3;
            this.cmbHabitaciones.Tag = "cmbHabitaciones";
            this.cmbHabitaciones.SelectedIndexChanged += new System.EventHandler(this.cmbHabitaciones_SelectedIndexChanged);
            // 
            // dgvConsumos
            // 
            this.dgvConsumos.AllowUserToAddRows = false;
            this.dgvConsumos.AllowUserToDeleteRows = false;
            this.dgvConsumos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumos.Location = new System.Drawing.Point(414, 77);
            this.dgvConsumos.Name = "dgvConsumos";
            this.dgvConsumos.ReadOnly = true;
            this.dgvConsumos.Size = new System.Drawing.Size(428, 197);
            this.dgvConsumos.TabIndex = 5;
            this.dgvConsumos.Tag = "dgvConsumos";
            this.dgvConsumos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumos_CellContentClick);
            this.dgvConsumos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumos_CellContentClick);
            // 
            // lblEstadoDeCuenta
            // 
            this.lblEstadoDeCuenta.AutoSize = true;
            this.lblEstadoDeCuenta.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDeCuenta.Location = new System.Drawing.Point(500, 32);
            this.lblEstadoDeCuenta.Name = "lblEstadoDeCuenta";
            this.lblEstadoDeCuenta.Size = new System.Drawing.Size(273, 26);
            this.lblEstadoDeCuenta.TabIndex = 9;
            this.lblEstadoDeCuenta.Text = "Estado de cuenta Habitacion";
            // 
            // lblHuespedActual
            // 
            this.lblHuespedActual.AutoSize = true;
            this.lblHuespedActual.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuespedActual.Location = new System.Drawing.Point(12, 128);
            this.lblHuespedActual.Name = "lblHuespedActual";
            this.lblHuespedActual.Size = new System.Drawing.Size(120, 19);
            this.lblHuespedActual.TabIndex = 10;
            this.lblHuespedActual.Tag = "HuespedActual";
            this.lblHuespedActual.Text = "Huesped Actual :";
            // 
            // lblNombreHuesped
            // 
            this.lblNombreHuesped.AutoSize = true;
            this.lblNombreHuesped.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHuesped.Location = new System.Drawing.Point(199, 128);
            this.lblNombreHuesped.Name = "lblNombreHuesped";
            this.lblNombreHuesped.Size = new System.Drawing.Size(118, 19);
            this.lblNombreHuesped.TabIndex = 11;
            this.lblNombreHuesped.Tag = "NombreHuesped";
            this.lblNombreHuesped.Text = "Nombre Hesped";
            this.lblNombreHuesped.Visible = false;
            // 
            // lblTotalEnPesos
            // 
            this.lblTotalEnPesos.AutoSize = true;
            this.lblTotalEnPesos.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnPesos.Location = new System.Drawing.Point(12, 181);
            this.lblTotalEnPesos.Name = "lblTotalEnPesos";
            this.lblTotalEnPesos.Size = new System.Drawing.Size(107, 19);
            this.lblTotalEnPesos.TabIndex = 12;
            this.lblTotalEnPesos.Tag = "TotalEnPesos";
            this.lblTotalEnPesos.Text = "Total en Pesos:";
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.Location = new System.Drawing.Point(205, 181);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(112, 19);
            this.lblTotalCalculado.TabIndex = 13;
            this.lblTotalCalculado.Tag = "TotalCalculado";
            this.lblTotalCalculado.Text = "Total Calculado";
            this.lblTotalCalculado.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::SGHv1._0.Properties.Resources.clean24;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(505, 288);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 76);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Tag = "Limpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(782, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(58, 76);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRealizarCheckOut
            // 
            this.btnRealizarCheckOut.FlatAppearance.BorderSize = 0;
            this.btnRealizarCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarCheckOut.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarCheckOut.Image = global::SGHv1._0.Properties.Resources.sign_out_option_icon_icons_com_73413;
            this.btnRealizarCheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizarCheckOut.Location = new System.Drawing.Point(246, 281);
            this.btnRealizarCheckOut.Name = "btnRealizarCheckOut";
            this.btnRealizarCheckOut.Size = new System.Drawing.Size(98, 90);
            this.btnRealizarCheckOut.TabIndex = 7;
            this.btnRealizarCheckOut.Tag = "RealizarCheckOut";
            this.btnRealizarCheckOut.Text = "Realizar CheckOut";
            this.btnRealizarCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizarCheckOut.UseVisualStyleBackColor = true;
            this.btnRealizarCheckOut.Click += new System.EventHandler(this.btnRealizarCheckOut_Click);
            // 
            // btnConsultarConsumos
            // 
            this.btnConsultarConsumos.FlatAppearance.BorderSize = 0;
            this.btnConsultarConsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarConsumos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarConsumos.Image = global::SGHv1._0.Properties.Resources.check;
            this.btnConsultarConsumos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarConsumos.Location = new System.Drawing.Point(12, 266);
            this.btnConsultarConsumos.Name = "btnConsultarConsumos";
            this.btnConsultarConsumos.Size = new System.Drawing.Size(103, 105);
            this.btnConsultarConsumos.TabIndex = 6;
            this.btnConsultarConsumos.Tag = "ConsultarConsumos";
            this.btnConsultarConsumos.Text = "Consultar consumos";
            this.btnConsultarConsumos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultarConsumos.UseVisualStyleBackColor = true;
            this.btnConsultarConsumos.Click += new System.EventHandler(this.btnConsultarConsumos_Click);
            // 
            // FrmVerEstadoCuentaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(852, 376);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalCalculado);
            this.Controls.Add(this.lblTotalEnPesos);
            this.Controls.Add(this.lblNombreHuesped);
            this.Controls.Add(this.lblHuespedActual);
            this.Controls.Add(this.lblEstadoDeCuenta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRealizarCheckOut);
            this.Controls.Add(this.btnConsultarConsumos);
            this.Controls.Add(this.dgvConsumos);
            this.Controls.Add(this.cmbHabitaciones);
            this.Controls.Add(this.lblSeleccioneHabitacion);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerEstadoCuentaHabitaciones";
            this.Text = "Ver Estado de Cuenta en Habitaciones";
            this.Load += new System.EventHandler(this.FrmVerEstadoCuentaHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccioneHabitacion;
        private System.Windows.Forms.ComboBox cmbHabitaciones;
        private System.Windows.Forms.DataGridView dgvConsumos;
        private System.Windows.Forms.Button btnConsultarConsumos;
        private System.Windows.Forms.Button btnRealizarCheckOut;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEstadoDeCuenta;
        private System.Windows.Forms.Label lblHuespedActual;
        private System.Windows.Forms.Label lblNombreHuesped;
        private System.Windows.Forms.Label lblTotalEnPesos;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}