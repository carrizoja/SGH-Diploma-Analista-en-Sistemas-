namespace SGHv1._0.FormsServicios
{
    partial class FrmRoomService
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoomService));
            this.dgvRoomService = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbDisponibilidadSI = new System.Windows.Forms.RadioButton();
            this.rbDisponibilidadNO = new System.Windows.Forms.RadioButton();
            this.rbComida = new System.Windows.Forms.RadioButton();
            this.rbBebida = new System.Windows.Forms.RadioButton();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.gbDisponibilidad = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblRoomService = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnEliminarRoomService = new System.Windows.Forms.Button();
            this.btnModificarRoomService = new System.Windows.Forms.Button();
            this.btnAgregarRoomService = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomService)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.gbDisponibilidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomService
            // 
            this.dgvRoomService.AllowUserToAddRows = false;
            this.dgvRoomService.AllowUserToDeleteRows = false;
            this.dgvRoomService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomService.Location = new System.Drawing.Point(359, 117);
            this.dgvRoomService.Name = "dgvRoomService";
            this.dgvRoomService.ReadOnly = true;
            this.dgvRoomService.Size = new System.Drawing.Size(534, 474);
            this.dgvRoomService.TabIndex = 0;
            this.dgvRoomService.Tag = "dgvRoomService";
            this.dgvRoomService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomService_CellContentClick);
            this.dgvRoomService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomService_CellContentClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(125, 204);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 27);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Tag = "txtDescripcion";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(125, 247);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(180, 27);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Tag = "txtPrecio";
            // 
            // rbDisponibilidadSI
            // 
            this.rbDisponibilidadSI.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponibilidadSI.Location = new System.Drawing.Point(119, 18);
            this.rbDisponibilidadSI.Name = "rbDisponibilidadSI";
            this.rbDisponibilidadSI.Size = new System.Drawing.Size(78, 25);
            this.rbDisponibilidadSI.TabIndex = 13;
            this.rbDisponibilidadSI.TabStop = true;
            this.rbDisponibilidadSI.Tag = "rbDisponibilidadSI";
            this.rbDisponibilidadSI.Text = "SI";
            this.rbDisponibilidadSI.UseVisualStyleBackColor = true;
            // 
            // rbDisponibilidadNO
            // 
            this.rbDisponibilidadNO.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDisponibilidadNO.Location = new System.Drawing.Point(224, 18);
            this.rbDisponibilidadNO.Name = "rbDisponibilidadNO";
            this.rbDisponibilidadNO.Size = new System.Drawing.Size(66, 25);
            this.rbDisponibilidadNO.TabIndex = 14;
            this.rbDisponibilidadNO.TabStop = true;
            this.rbDisponibilidadNO.Tag = "rbDisponibilidadNO";
            this.rbDisponibilidadNO.Text = "NO";
            this.rbDisponibilidadNO.UseVisualStyleBackColor = true;
            // 
            // rbComida
            // 
            this.rbComida.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComida.Location = new System.Drawing.Point(117, 11);
            this.rbComida.Name = "rbComida";
            this.rbComida.Size = new System.Drawing.Size(99, 25);
            this.rbComida.TabIndex = 16;
            this.rbComida.TabStop = true;
            this.rbComida.Tag = "rbComida";
            this.rbComida.Text = "Comida";
            this.rbComida.UseVisualStyleBackColor = true;
            // 
            // rbBebida
            // 
            this.rbBebida.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBebida.Location = new System.Drawing.Point(222, 11);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(79, 25);
            this.rbBebida.TabIndex = 17;
            this.rbBebida.TabStop = true;
            this.rbBebida.Tag = "rbBebida";
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 212);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Tag = "Descripcion";
            this.lblDescripcion.Text = "Descripcion :";
            this.lblDescripcion.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 255);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 19);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Tag = "Precio";
            this.lblPrecio.Text = "Precio :";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbComida);
            this.gbTipo.Controls.Add(this.rbBebida);
            this.gbTipo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(8, 295);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(345, 44);
            this.gbTipo.TabIndex = 23;
            this.gbTipo.TabStop = false;
            this.gbTipo.Tag = "gbTipo";
            this.gbTipo.Text = "Tipo";
            // 
            // gbDisponibilidad
            // 
            this.gbDisponibilidad.Controls.Add(this.rbDisponibilidadNO);
            this.gbDisponibilidad.Controls.Add(this.rbDisponibilidadSI);
            this.gbDisponibilidad.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponibilidad.Location = new System.Drawing.Point(6, 345);
            this.gbDisponibilidad.Name = "gbDisponibilidad";
            this.gbDisponibilidad.Size = new System.Drawing.Size(347, 49);
            this.gbDisponibilidad.TabIndex = 24;
            this.gbDisponibilidad.TabStop = false;
            this.gbDisponibilidad.Tag = "gbDisponibilidad";
            this.gbDisponibilidad.Text = "Disponibilidad";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblRoomService
            // 
            this.lblRoomService.AutoSize = true;
            this.lblRoomService.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomService.Location = new System.Drawing.Point(554, 66);
            this.lblRoomService.Name = "lblRoomService";
            this.lblRoomService.Size = new System.Drawing.Size(135, 26);
            this.lblRoomService.TabIndex = 26;
            this.lblRoomService.Tag = "RoomService";
            this.lblRoomService.Text = "Room Service";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 127);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(250, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 77);
            this.btnSalir.TabIndex = 22;
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
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Image = global::SGHv1._0.Properties.Resources.clean21;
            this.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(128, 514);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(116, 77);
            this.btnLimpiarCampos.TabIndex = 21;
            this.btnLimpiarCampos.Tag = "LimpiarCampos";
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnEliminarRoomService
            // 
            this.btnEliminarRoomService.FlatAppearance.BorderSize = 0;
            this.btnEliminarRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarRoomService.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRoomService.Image = global::SGHv1._0.Properties.Resources.remove3;
            this.btnEliminarRoomService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarRoomService.Location = new System.Drawing.Point(138, 434);
            this.btnEliminarRoomService.Name = "btnEliminarRoomService";
            this.btnEliminarRoomService.Size = new System.Drawing.Size(86, 74);
            this.btnEliminarRoomService.TabIndex = 20;
            this.btnEliminarRoomService.Tag = "EliminarRoomService";
            this.btnEliminarRoomService.Text = "Eliminar";
            this.btnEliminarRoomService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarRoomService.UseVisualStyleBackColor = true;
            this.btnEliminarRoomService.Click += new System.EventHandler(this.btnEliminarRoomService_Click);
            // 
            // btnModificarRoomService
            // 
            this.btnModificarRoomService.FlatAppearance.BorderSize = 0;
            this.btnModificarRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarRoomService.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarRoomService.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificarRoomService.Image = global::SGHv1._0.Properties.Resources.modify;
            this.btnModificarRoomService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarRoomService.Location = new System.Drawing.Point(10, 514);
            this.btnModificarRoomService.Name = "btnModificarRoomService";
            this.btnModificarRoomService.Size = new System.Drawing.Size(96, 77);
            this.btnModificarRoomService.TabIndex = 19;
            this.btnModificarRoomService.Tag = "ModificarRoomService";
            this.btnModificarRoomService.Text = "Modificar";
            this.btnModificarRoomService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarRoomService.UseVisualStyleBackColor = true;
            this.btnModificarRoomService.Click += new System.EventHandler(this.btnModificarRoomService_Click);
            // 
            // btnAgregarRoomService
            // 
            this.btnAgregarRoomService.BackgroundImage = global::SGHv1._0.Properties.Resources.add_image;
            this.btnAgregarRoomService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarRoomService.FlatAppearance.BorderSize = 0;
            this.btnAgregarRoomService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarRoomService.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRoomService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarRoomService.Location = new System.Drawing.Point(10, 423);
            this.btnAgregarRoomService.Name = "btnAgregarRoomService";
            this.btnAgregarRoomService.Size = new System.Drawing.Size(96, 85);
            this.btnAgregarRoomService.TabIndex = 18;
            this.btnAgregarRoomService.Tag = "AgregarRoomService";
            this.btnAgregarRoomService.Text = "Agregar";
            this.btnAgregarRoomService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarRoomService.UseVisualStyleBackColor = true;
            this.btnAgregarRoomService.Click += new System.EventHandler(this.btnAgregarRoomService_Click);
            // 
            // FrmRoomService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(905, 603);
            this.Controls.Add(this.lblRoomService);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDisponibilidad);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarRoomService);
            this.Controls.Add(this.btnModificarRoomService);
            this.Controls.Add(this.btnAgregarRoomService);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgvRoomService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRoomService";
            this.Tag = "RoomService";
            this.Text = "Room Service";
            this.Load += new System.EventHandler(this.GestionDeBuffet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomService)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbDisponibilidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomService;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbDisponibilidadSI;
        private System.Windows.Forms.RadioButton rbDisponibilidadNO;
        private System.Windows.Forms.RadioButton rbComida;
        private System.Windows.Forms.RadioButton rbBebida;
        private System.Windows.Forms.Button btnAgregarRoomService;
        private System.Windows.Forms.Button btnModificarRoomService;
        private System.Windows.Forms.Button btnEliminarRoomService;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.GroupBox gbDisponibilidad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRoomService;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}