namespace SGHv1._0.FormsHabitacion
{
    partial class AdministracionHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministracionHabitaciones));
            this.lblAdministracionHabitaciones = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipoHabitacion = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.lblLibre = new System.Windows.Forms.Label();
            this.txtNumeroHab = new System.Windows.Forms.TextBox();
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lblCategoriaHabitacion = new System.Windows.Forms.Label();
            this.cmbCategoriaHabitacion = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarHabitacion = new System.Windows.Forms.Button();
            this.btnEditarHabitacion = new System.Windows.Forms.Button();
            this.btnAgregarNuevaHabitacion = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdministracionHabitaciones
            // 
            this.lblAdministracionHabitaciones.AutoSize = true;
            this.lblAdministracionHabitaciones.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracionHabitaciones.Location = new System.Drawing.Point(519, 61);
            this.lblAdministracionHabitaciones.Name = "lblAdministracionHabitaciones";
            this.lblAdministracionHabitaciones.Size = new System.Drawing.Size(302, 26);
            this.lblAdministracionHabitaciones.TabIndex = 0;
            this.lblAdministracionHabitaciones.Text = "Administración de Habitaciones";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(12, 180);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 19);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Tag = "Numero";
            this.lblNumero.Text = "Numero:";
            // 
            // lblTipoHabitacion
            // 
            this.lblTipoHabitacion.AutoSize = true;
            this.lblTipoHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoHabitacion.Location = new System.Drawing.Point(12, 222);
            this.lblTipoHabitacion.Name = "lblTipoHabitacion";
            this.lblTipoHabitacion.Size = new System.Drawing.Size(141, 19);
            this.lblTipoHabitacion.TabIndex = 2;
            this.lblTipoHabitacion.Tag = "TipoHabitacion";
            this.lblTipoHabitacion.Text = "Tipo de Habitación:";
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(353, 118);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(617, 434);
            this.dgvHabitaciones.TabIndex = 3;
            this.dgvHabitaciones.Tag = "dgvHabitaciones";
            this.dgvHabitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            this.dgvHabitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHabitaciones_CellContentClick);
            // 
            // lblLibre
            // 
            this.lblLibre.AutoSize = true;
            this.lblLibre.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibre.Location = new System.Drawing.Point(12, 340);
            this.lblLibre.Name = "lblLibre";
            this.lblLibre.Size = new System.Drawing.Size(47, 19);
            this.lblLibre.TabIndex = 4;
            this.lblLibre.Tag = "Libre";
            this.lblLibre.Text = "Libre:";
            // 
            // txtNumeroHab
            // 
            this.txtNumeroHab.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHab.Location = new System.Drawing.Point(224, 180);
            this.txtNumeroHab.Name = "txtNumeroHab";
            this.txtNumeroHab.Size = new System.Drawing.Size(121, 27);
            this.txtNumeroHab.TabIndex = 5;
            this.txtNumeroHab.Tag = "txtNumeroHab";
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(224, 219);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(121, 27);
            this.cmbTipoHabitacion.TabIndex = 6;
            this.cmbTipoHabitacion.Tag = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoHabitacion_SelectedIndexChanged);
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSi.Location = new System.Drawing.Point(224, 340);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(40, 23);
            this.rbSi.TabIndex = 12;
            this.rbSi.TabStop = true;
            this.rbSi.Tag = "rbSi";
            this.rbSi.Text = "SI";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(295, 340);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 23);
            this.rbNo.TabIndex = 13;
            this.rbNo.TabStop = true;
            this.rbNo.Tag = "rbNo";
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lblCategoriaHabitacion
            // 
            this.lblCategoriaHabitacion.AutoSize = true;
            this.lblCategoriaHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaHabitacion.Location = new System.Drawing.Point(12, 259);
            this.lblCategoriaHabitacion.Name = "lblCategoriaHabitacion";
            this.lblCategoriaHabitacion.Size = new System.Drawing.Size(176, 19);
            this.lblCategoriaHabitacion.TabIndex = 14;
            this.lblCategoriaHabitacion.Tag = "CategoriaHabitacion";
            this.lblCategoriaHabitacion.Text = "Categoria de Habitación:";
            // 
            // cmbCategoriaHabitacion
            // 
            this.cmbCategoriaHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaHabitacion.FormattingEnabled = true;
            this.cmbCategoriaHabitacion.Location = new System.Drawing.Point(224, 258);
            this.cmbCategoriaHabitacion.Name = "cmbCategoriaHabitacion";
            this.cmbCategoriaHabitacion.Size = new System.Drawing.Size(121, 27);
            this.cmbCategoriaHabitacion.TabIndex = 15;
            this.cmbCategoriaHabitacion.Tag = "cmbCategoriaHabitacion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 300);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Tag = "Precio";
            this.lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(224, 300);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 27);
            this.txtPrecio.TabIndex = 17;
            this.txtPrecio.Tag = "txtPrecio";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit2;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(246, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 78);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.room;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 121);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Image = global::SGHv1._0.Properties.Resources.clean23;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(114, 473);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(128, 79);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Tag = "LimpiarCampos";
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnEliminarHabitacion
            // 
            this.btnEliminarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnEliminarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHabitacion.Image = global::SGHv1._0.Properties.Resources.remove5;
            this.btnEliminarHabitacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarHabitacion.Location = new System.Drawing.Point(132, 387);
            this.btnEliminarHabitacion.Name = "btnEliminarHabitacion";
            this.btnEliminarHabitacion.Size = new System.Drawing.Size(83, 73);
            this.btnEliminarHabitacion.TabIndex = 10;
            this.btnEliminarHabitacion.Tag = "CancelarHabitacion";
            this.btnEliminarHabitacion.Text = "Borrar";
            this.btnEliminarHabitacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarHabitacion.UseVisualStyleBackColor = true;
            this.btnEliminarHabitacion.Click += new System.EventHandler(this.btnEliminarHabitacion_Click);
            // 
            // btnEditarHabitacion
            // 
            this.btnEditarHabitacion.FlatAppearance.BorderSize = 0;
            this.btnEditarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHabitacion.Image = global::SGHv1._0.Properties.Resources.modify2;
            this.btnEditarHabitacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarHabitacion.Location = new System.Drawing.Point(16, 473);
            this.btnEditarHabitacion.Name = "btnEditarHabitacion";
            this.btnEditarHabitacion.Size = new System.Drawing.Size(83, 79);
            this.btnEditarHabitacion.TabIndex = 9;
            this.btnEditarHabitacion.Tag = "EditarHabitacion";
            this.btnEditarHabitacion.Text = "Editar ";
            this.btnEditarHabitacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarHabitacion.UseVisualStyleBackColor = true;
            this.btnEditarHabitacion.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregarNuevaHabitacion
            // 
            this.btnAgregarNuevaHabitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarNuevaHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaHabitacion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNuevaHabitacion.Image = global::SGHv1._0.Properties.Resources.add_image2;
            this.btnAgregarNuevaHabitacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarNuevaHabitacion.Location = new System.Drawing.Point(16, 385);
            this.btnAgregarNuevaHabitacion.Name = "btnAgregarNuevaHabitacion";
            this.btnAgregarNuevaHabitacion.Size = new System.Drawing.Size(79, 75);
            this.btnAgregarNuevaHabitacion.TabIndex = 8;
            this.btnAgregarNuevaHabitacion.Tag = "AgregarNuevaHabitacion";
            this.btnAgregarNuevaHabitacion.Text = "Agregar  ";
            this.btnAgregarNuevaHabitacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarNuevaHabitacion.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaHabitacion.Click += new System.EventHandler(this.btnAgregarNuevaHabitacion_Click);
            // 
            // AdministracionHabitaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(982, 564);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbCategoriaHabitacion);
            this.Controls.Add(this.lblCategoriaHabitacion);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarHabitacion);
            this.Controls.Add(this.btnEditarHabitacion);
            this.Controls.Add(this.btnAgregarNuevaHabitacion);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.txtNumeroHab);
            this.Controls.Add(this.lblLibre);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.lblTipoHabitacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblAdministracionHabitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministracionHabitaciones";
            this.Text = "AdministracionHabitaciones";
            this.Load += new System.EventHandler(this.AdministracionHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdministracionHabitaciones;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipoHabitacion;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label lblLibre;
        private System.Windows.Forms.TextBox txtNumeroHab;
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.Button btnAgregarNuevaHabitacion;
        private System.Windows.Forms.Button btnEditarHabitacion;
        private System.Windows.Forms.Button btnEliminarHabitacion;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lblCategoriaHabitacion;
        private System.Windows.Forms.ComboBox cmbCategoriaHabitacion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}