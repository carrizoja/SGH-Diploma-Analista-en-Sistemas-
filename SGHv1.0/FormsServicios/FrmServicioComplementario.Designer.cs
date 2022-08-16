namespace SGHv1._0.FormsServicios
{
    partial class FrmServicioComplementario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicioComplementario));
            this.dgvServicioComplementario = new System.Windows.Forms.DataGridView();
            this.gbDisponibilidad = new System.Windows.Forms.GroupBox();
            this.rbDisponibilidadNO = new System.Windows.Forms.RadioButton();
            this.rbDisponibilidadSI = new System.Windows.Forms.RadioButton();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHorasAlquiler = new System.Windows.Forms.Label();
            this.txtHorasAlquiler = new System.Windows.Forms.TextBox();
            this.lblServiciosComplementarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnModificarServicio = new System.Windows.Forms.Button();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioComplementario)).BeginInit();
            this.gbDisponibilidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicioComplementario
            // 
            this.dgvServicioComplementario.AllowUserToAddRows = false;
            this.dgvServicioComplementario.AllowUserToDeleteRows = false;
            this.dgvServicioComplementario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicioComplementario.Location = new System.Drawing.Point(355, 116);
            this.dgvServicioComplementario.Name = "dgvServicioComplementario";
            this.dgvServicioComplementario.ReadOnly = true;
            this.dgvServicioComplementario.Size = new System.Drawing.Size(535, 474);
            this.dgvServicioComplementario.TabIndex = 0;
            this.dgvServicioComplementario.Tag = "dgvServicioComplementario";
            this.dgvServicioComplementario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvServicioComplementario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbDisponibilidad
            // 
            this.gbDisponibilidad.Controls.Add(this.rbDisponibilidadNO);
            this.gbDisponibilidad.Controls.Add(this.rbDisponibilidadSI);
            this.gbDisponibilidad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponibilidad.Location = new System.Drawing.Point(12, 378);
            this.gbDisponibilidad.Name = "gbDisponibilidad";
            this.gbDisponibilidad.Size = new System.Drawing.Size(337, 49);
            this.gbDisponibilidad.TabIndex = 35;
            this.gbDisponibilidad.TabStop = false;
            this.gbDisponibilidad.Tag = "gbDisponibilidad";
            this.gbDisponibilidad.Text = "Disponibilidad";
            // 
            // rbDisponibilidadNO
            // 
            this.rbDisponibilidadNO.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponibilidadNO.Location = new System.Drawing.Point(241, 18);
            this.rbDisponibilidadNO.Name = "rbDisponibilidadNO";
            this.rbDisponibilidadNO.Size = new System.Drawing.Size(66, 25);
            this.rbDisponibilidadNO.TabIndex = 14;
            this.rbDisponibilidadNO.TabStop = true;
            this.rbDisponibilidadNO.Tag = "rbDisponibilidadNO";
            this.rbDisponibilidadNO.Text = "NO";
            this.rbDisponibilidadNO.UseVisualStyleBackColor = true;
            // 
            // rbDisponibilidadSI
            // 
            this.rbDisponibilidadSI.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponibilidadSI.Location = new System.Drawing.Point(127, 18);
            this.rbDisponibilidadSI.Name = "rbDisponibilidadSI";
            this.rbDisponibilidadSI.Size = new System.Drawing.Size(78, 25);
            this.rbDisponibilidadSI.TabIndex = 13;
            this.rbDisponibilidadSI.TabStop = true;
            this.rbDisponibilidadSI.Tag = "rbDisponibilidadSI";
            this.rbDisponibilidadSI.Text = "SI";
            this.rbDisponibilidadSI.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AcceptsTab = true;
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(139, 263);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 27);
            this.txtPrecio.TabIndex = 26;
            this.txtPrecio.Tag = "txtPrecio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 267);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 19);
            this.lblPrecio.TabIndex = 27;
            this.lblPrecio.Tag = "Precio";
            this.lblPrecio.Text = "Precio :";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(139, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 27);
            this.txtDescripcion.TabIndex = 25;
            this.txtDescripcion.Tag = "txtDescripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 215);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 19);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Tag = "Descripcion";
            this.lblDescripcion.Text = "Descripcion :";
            // 
            // lblHorasAlquiler
            // 
            this.lblHorasAlquiler.AutoSize = true;
            this.lblHorasAlquiler.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasAlquiler.Location = new System.Drawing.Point(12, 323);
            this.lblHorasAlquiler.Name = "lblHorasAlquiler";
            this.lblHorasAlquiler.Size = new System.Drawing.Size(108, 19);
            this.lblHorasAlquiler.TabIndex = 36;
            this.lblHorasAlquiler.Tag = "HorasAlquiler";
            this.lblHorasAlquiler.Text = "Horas Alquiler :";
            // 
            // txtHorasAlquiler
            // 
            this.txtHorasAlquiler.AcceptsTab = true;
            this.txtHorasAlquiler.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasAlquiler.Location = new System.Drawing.Point(139, 320);
            this.txtHorasAlquiler.Name = "txtHorasAlquiler";
            this.txtHorasAlquiler.Size = new System.Drawing.Size(180, 27);
            this.txtHorasAlquiler.TabIndex = 27;
            this.txtHorasAlquiler.Tag = "txtHorasAlquiler";
            // 
            // lblServiciosComplementarios
            // 
            this.lblServiciosComplementarios.AutoSize = true;
            this.lblServiciosComplementarios.BackColor = System.Drawing.Color.Transparent;
            this.lblServiciosComplementarios.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiciosComplementarios.Location = new System.Drawing.Point(495, 58);
            this.lblServiciosComplementarios.Name = "lblServiciosComplementarios";
            this.lblServiciosComplementarios.Size = new System.Drawing.Size(258, 26);
            this.lblServiciosComplementarios.TabIndex = 38;
            this.lblServiciosComplementarios.Tag = "ServiciosComplementarios";
            this.lblServiciosComplementarios.Text = "Servicios Complementarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.sombrilla;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 123);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(253, 515);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 75);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Tag = "LimpiarCampos";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Image = global::SGHv1._0.Properties.Resources.clean22;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(139, 516);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(125, 74);
            this.btnLimpiarCampos.TabIndex = 32;
            this.btnLimpiarCampos.Tag = "LimpiarCampos";
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.FlatAppearance.BorderSize = 0;
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Image = global::SGHv1._0.Properties.Resources.remove4;
            this.btnEliminarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarServicio.Location = new System.Drawing.Point(139, 436);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(118, 74);
            this.btnEliminarServicio.TabIndex = 31;
            this.btnEliminarServicio.Tag = "EliminarServicio";
            this.btnEliminarServicio.Text = "Eliminar";
            this.btnEliminarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.FlatAppearance.BorderSize = 0;
            this.btnModificarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarServicio.Image = global::SGHv1._0.Properties.Resources.modify1;
            this.btnModificarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarServicio.Location = new System.Drawing.Point(30, 516);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(90, 77);
            this.btnModificarServicio.TabIndex = 30;
            this.btnModificarServicio.Tag = "ModificarServicio";
            this.btnModificarServicio.Text = "Modificar ";
            this.btnModificarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarServicio.UseVisualStyleBackColor = true;
            this.btnModificarServicio.Click += new System.EventHandler(this.btnModificarServicio_Click);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.FlatAppearance.BorderSize = 0;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Image = global::SGHv1._0.Properties.Resources.add_image1;
            this.btnAgregarServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarServicio.Location = new System.Drawing.Point(12, 433);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(125, 77);
            this.btnAgregarServicio.TabIndex = 29;
            this.btnAgregarServicio.Tag = "AgregarServicio";
            this.btnAgregarServicio.Text = "Agregar ";
            this.btnAgregarServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // FrmServicioComplementario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(905, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblServiciosComplementarios);
            this.Controls.Add(this.txtHorasAlquiler);
            this.Controls.Add(this.lblHorasAlquiler);
            this.Controls.Add(this.gbDisponibilidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.btnModificarServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgvServicioComplementario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmServicioComplementario";
            this.Text = "FrmServicioComplementarios";
            this.Load += new System.EventHandler(this.FrmServicioComplementario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioComplementario)).EndInit();
            this.gbDisponibilidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicioComplementario;
        private System.Windows.Forms.GroupBox gbDisponibilidad;
        private System.Windows.Forms.RadioButton rbDisponibilidadNO;
        private System.Windows.Forms.RadioButton rbDisponibilidadSI;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnModificarServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHorasAlquiler;
        private System.Windows.Forms.TextBox txtHorasAlquiler;
        private System.Windows.Forms.Label lblServiciosComplementarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}