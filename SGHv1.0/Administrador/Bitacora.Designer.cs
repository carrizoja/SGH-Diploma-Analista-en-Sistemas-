namespace SGHv1._0.Administrador
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            this.lstwBitacora = new System.Windows.Forms.ListView();
            this.lblBitacoraDelSistema = new System.Windows.Forms.Label();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblFormularioMostrar = new System.Windows.Forms.Label();
            this.lblUsuarioID = new System.Windows.Forms.Label();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.formularioSeleccionado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbFormulario = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.rbSOAP = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.rbBinario = new System.Windows.Forms.RadioButton();
            this.btnDeserializar = new System.Windows.Forms.Button();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstwBitacora
            // 
            this.lstwBitacora.HideSelection = false;
            this.lstwBitacora.Location = new System.Drawing.Point(12, 178);
            this.lstwBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.lstwBitacora.Name = "lstwBitacora";
            this.lstwBitacora.Size = new System.Drawing.Size(957, 341);
            this.lstwBitacora.TabIndex = 0;
            this.lstwBitacora.Tag = "lstwBitacora";
            this.lstwBitacora.UseCompatibleStateImageBehavior = false;
            this.lstwBitacora.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblBitacoraDelSistema
            // 
            this.lblBitacoraDelSistema.AutoSize = true;
            this.lblBitacoraDelSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitacoraDelSistema.Location = new System.Drawing.Point(512, 8);
            this.lblBitacoraDelSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBitacoraDelSistema.Name = "lblBitacoraDelSistema";
            this.lblBitacoraDelSistema.Size = new System.Drawing.Size(76, 20);
            this.lblBitacoraDelSistema.TabIndex = 1;
            this.lblBitacoraDelSistema.Tag = "Bitacora";
            this.lblBitacoraDelSistema.Text = "Bitacora";
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblFormularioMostrar);
            this.grpFiltros.Controls.Add(this.lblUsuarioID);
            this.grpFiltros.Controls.Add(this.lblUsuarioSeleccionado);
            this.grpFiltros.Controls.Add(this.formularioSeleccionado);
            this.grpFiltros.Controls.Add(this.lblUsuario);
            this.grpFiltros.Controls.Add(this.lblFormulario);
            this.grpFiltros.Controls.Add(this.btnFiltrar);
            this.grpFiltros.Controls.Add(this.cmbUsuarios);
            this.grpFiltros.Controls.Add(this.cmbFormulario);
            this.grpFiltros.Controls.Add(this.lblHasta);
            this.grpFiltros.Controls.Add(this.lblDesde);
            this.grpFiltros.Controls.Add(this.dtpHasta);
            this.grpFiltros.Controls.Add(this.dtpDesde);
            this.grpFiltros.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(12, 8);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(1009, 164);
            this.grpFiltros.TabIndex = 2;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // lblFormularioMostrar
            // 
            this.lblFormularioMostrar.AutoSize = true;
            this.lblFormularioMostrar.Location = new System.Drawing.Point(644, 65);
            this.lblFormularioMostrar.Name = "lblFormularioMostrar";
            this.lblFormularioMostrar.Size = new System.Drawing.Size(82, 19);
            this.lblFormularioMostrar.TabIndex = 15;
            this.lblFormularioMostrar.Tag = "FormularioMostrar";
            this.lblFormularioMostrar.Text = "Formulario";
            // 
            // lblUsuarioID
            // 
            this.lblUsuarioID.AutoSize = true;
            this.lblUsuarioID.Location = new System.Drawing.Point(647, 139);
            this.lblUsuarioID.Name = "lblUsuarioID";
            this.lblUsuarioID.Size = new System.Drawing.Size(75, 19);
            this.lblUsuarioID.TabIndex = 14;
            this.lblUsuarioID.Tag = "UsuarioID";
            this.lblUsuarioID.Text = "UsuarioID";
            this.lblUsuarioID.Visible = false;
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(101, 139);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(153, 19);
            this.lblUsuarioSeleccionado.TabIndex = 13;
            this.lblUsuarioSeleccionado.Tag = "UsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Text = "Usuario Seleccionado";
            this.lblUsuarioSeleccionado.Visible = false;
            // 
            // formularioSeleccionado
            // 
            this.formularioSeleccionado.AutoSize = true;
            this.formularioSeleccionado.Location = new System.Drawing.Point(101, 100);
            this.formularioSeleccionado.Name = "formularioSeleccionado";
            this.formularioSeleccionado.Size = new System.Drawing.Size(175, 19);
            this.formularioSeleccionado.TabIndex = 12;
            this.formularioSeleccionado.Tag = "FormularioSeleccionado";
            this.formularioSeleccionado.Text = "Formulario Seleccionado";
            this.formularioSeleccionado.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(647, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 19);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Tag = "Usuario";
            this.lblUsuario.Text = "Usuario";
            // 
            // lblFormulario
            // 
            this.lblFormulario.AutoSize = true;
            this.lblFormulario.Location = new System.Drawing.Point(644, 24);
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.Size = new System.Drawing.Size(82, 19);
            this.lblFormulario.TabIndex = 10;
            this.lblFormulario.Tag = "Formulario";
            this.lblFormulario.Text = "Formulario";
            this.lblFormulario.Visible = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(904, 100);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(90, 28);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Tag = "Filtrar";
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(744, 100);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(145, 27);
            this.cmbUsuarios.TabIndex = 7;
            this.cmbUsuarios.Tag = "cmbUsuarios";
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // cmbFormulario
            // 
            this.cmbFormulario.FormattingEnabled = true;
            this.cmbFormulario.Location = new System.Drawing.Point(744, 56);
            this.cmbFormulario.Name = "cmbFormulario";
            this.cmbFormulario.Size = new System.Drawing.Size(145, 27);
            this.cmbFormulario.TabIndex = 6;
            this.cmbFormulario.Tag = "cmbFormulario";
            this.cmbFormulario.SelectedIndexChanged += new System.EventHandler(this.cmbFormulario_SelectedIndexChanged);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(342, 56);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 19);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Tag = "Hasta";
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(48, 56);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 19);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Tag = "lblDesde";
            this.lblDesde.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(405, 50);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 27);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.Tag = "dtpHasta";
            this.dtpHasta.CloseUp += new System.EventHandler(this.dtpHasta_CloseUp);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(105, 50);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 27);
            this.dtpDesde.TabIndex = 0;
            this.dtpDesde.Tag = "dtpDesde";
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.bitacora;
            this.pictureBox1.Location = new System.Drawing.Point(1056, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 244);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit10;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1257, 526);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 78);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::SGHv1._0.Properties.Resources.clean26;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(437, 526);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 78);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Tag = "Limpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnDeserializar);
            this.groupBox1.Controls.Add(this.btnSerializar);
            this.groupBox1.Controls.Add(this.btnRuta);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1040, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serializacion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbJSON);
            this.groupBox2.Controls.Add(this.rbSOAP);
            this.groupBox2.Controls.Add(this.rbXML);
            this.groupBox2.Controls.Add(this.rbBinario);
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione";
            // 
            // rbJSON
            // 
            this.rbJSON.AutoSize = true;
            this.rbJSON.Location = new System.Drawing.Point(192, 20);
            this.rbJSON.Name = "rbJSON";
            this.rbJSON.Size = new System.Drawing.Size(54, 18);
            this.rbJSON.TabIndex = 3;
            this.rbJSON.TabStop = true;
            this.rbJSON.Text = "JSON";
            this.rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbSOAP
            // 
            this.rbSOAP.AutoSize = true;
            this.rbSOAP.Location = new System.Drawing.Point(131, 20);
            this.rbSOAP.Name = "rbSOAP";
            this.rbSOAP.Size = new System.Drawing.Size(56, 18);
            this.rbSOAP.TabIndex = 2;
            this.rbSOAP.TabStop = true;
            this.rbSOAP.Text = "SOAP";
            this.rbSOAP.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(78, 20);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(48, 18);
            this.rbXML.TabIndex = 1;
            this.rbXML.TabStop = true;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // rbBinario
            // 
            this.rbBinario.AutoSize = true;
            this.rbBinario.Location = new System.Drawing.Point(3, 19);
            this.rbBinario.Name = "rbBinario";
            this.rbBinario.Size = new System.Drawing.Size(70, 18);
            this.rbBinario.TabIndex = 0;
            this.rbBinario.TabStop = true;
            this.rbBinario.Text = "BINARIO";
            this.rbBinario.UseVisualStyleBackColor = true;
            // 
            // btnDeserializar
            // 
            this.btnDeserializar.Location = new System.Drawing.Point(188, 125);
            this.btnDeserializar.Name = "btnDeserializar";
            this.btnDeserializar.Size = new System.Drawing.Size(75, 23);
            this.btnDeserializar.TabIndex = 4;
            this.btnDeserializar.Text = "Deserializar";
            this.btnDeserializar.UseVisualStyleBackColor = true;
            this.btnDeserializar.Click += new System.EventHandler(this.btnDeserializar_Click);
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(107, 125);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(75, 23);
            this.btnSerializar.TabIndex = 3;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(231, 35);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(39, 23);
            this.btnRuta.TabIndex = 2;
            this.btnRuta.Text = "....";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(61, 37);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(164, 22);
            this.txtRuta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1328, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblBitacoraDelSistema);
            this.Controls.Add(this.lstwBitacora);
            this.Controls.Add(this.btnLimpiar);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.FrmBitacora_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstwBitacora;
        private System.Windows.Forms.Label lblBitacoraDelSistema;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFormulario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbFormulario;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Label formularioSeleccionado;
        private System.Windows.Forms.Label lblUsuarioID;
        private System.Windows.Forms.Label lblFormularioMostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJSON;
        private System.Windows.Forms.RadioButton rbSOAP;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.RadioButton rbBinario;
        private System.Windows.Forms.Button btnDeserializar;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}