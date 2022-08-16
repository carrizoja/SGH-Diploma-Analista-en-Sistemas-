namespace SGHv1._0.Administrador
{
    partial class GUIIdiomas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIIdiomas));
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbListarIdiomas = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneIdioma = new System.Windows.Forms.Label();
            this.palabraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sGHDataSetPalabra = new SGHv1._0.SGHDataSetPalabra();
            this.palabraTableAdapter = new SGHv1._0.SGHDataSetPalabraTableAdapters.PalabraTableAdapter();
            this.txtNombreIdioma = new System.Windows.Forms.TextBox();
            this.sGHDataSet = new SGHv1._0.SGHDataSet();
            this.palabraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.palabraTableAdapter1 = new SGHv1._0.SGHDataSetTableAdapters.PalabraTableAdapter();
            this.gbAgregarIdioma = new System.Windows.Forms.GroupBox();
            this.lblPalabras = new System.Windows.Forms.Label();
            this.dgvPalabras = new System.Windows.Forms.DataGridView();
            this.dgvTraduccion = new System.Windows.Forms.DataGridView();
            this.lblTraducciones = new System.Windows.Forms.Label();
            this.lblIdiomaSeleccionado = new System.Windows.Forms.Label();
            this.lblCodigoIdioma = new System.Windows.Forms.Label();
            this.lblIdiomaCodigoSeleccionado = new System.Windows.Forms.Label();
            this.txtEdicionPalabra = new System.Windows.Forms.TextBox();
            this.txtEdicionTraduccion = new System.Windows.Forms.TextBox();
            this.lblIdTraduccion = new System.Windows.Forms.Label();
            this.lblIdPalabra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescarDgvTraducciones = new System.Windows.Forms.Button();
            this.btnRefrescarDgvPalabras = new System.Windows.Forms.Button();
            this.btnEliminarPalabra = new System.Windows.Forms.Button();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.btnEliminarTraduccion = new System.Windows.Forms.Button();
            this.btnAgregarTraduccion = new System.Windows.Forms.Button();
            this.btnModificarPalabra = new System.Windows.Forms.Button();
            this.btnAgregarIdioma = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarIdioma = new System.Windows.Forms.Button();
            this.btnModificarTraduccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.palabraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGHDataSetPalabra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabraBindingSource1)).BeginInit();
            this.gbAgregarIdioma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(167, 10);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(54, 18);
            this.lblIdioma.TabIndex = 6;
            this.lblIdioma.Tag = "lblIdioma";
            this.lblIdioma.Text = "Idioma:";
            // 
            // cmbListarIdiomas
            // 
            this.cmbListarIdiomas.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListarIdiomas.FormattingEnabled = true;
            this.cmbListarIdiomas.Location = new System.Drawing.Point(12, 42);
            this.cmbListarIdiomas.Name = "cmbListarIdiomas";
            this.cmbListarIdiomas.Size = new System.Drawing.Size(121, 26);
            this.cmbListarIdiomas.TabIndex = 9;
            this.cmbListarIdiomas.Tag = "cmbListarIdiomas";
            this.cmbListarIdiomas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSeleccioneIdioma
            // 
            this.lblSeleccioneIdioma.AutoSize = true;
            this.lblSeleccioneIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneIdioma.Location = new System.Drawing.Point(12, 10);
            this.lblSeleccioneIdioma.Name = "lblSeleccioneIdioma";
            this.lblSeleccioneIdioma.Size = new System.Drawing.Size(122, 18);
            this.lblSeleccioneIdioma.TabIndex = 10;
            this.lblSeleccioneIdioma.Tag = "lblSeleccionaIdioma";
            this.lblSeleccioneIdioma.Text = "Seleccione Idioma:";
            // 
            // palabraBindingSource
            // 
            this.palabraBindingSource.DataMember = "Palabra";
            this.palabraBindingSource.DataSource = this.sGHDataSetPalabra;
            // 
            // sGHDataSetPalabra
            // 
            this.sGHDataSetPalabra.DataSetName = "SGHDataSetPalabra";
            this.sGHDataSetPalabra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palabraTableAdapter
            // 
            this.palabraTableAdapter.ClearBeforeFill = true;
            // 
            // txtNombreIdioma
            // 
            this.txtNombreIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreIdioma.Location = new System.Drawing.Point(75, 31);
            this.txtNombreIdioma.Name = "txtNombreIdioma";
            this.txtNombreIdioma.Size = new System.Drawing.Size(114, 26);
            this.txtNombreIdioma.TabIndex = 12;
            this.txtNombreIdioma.Tag = "txtNombreIdioma";
            // 
            // sGHDataSet
            // 
            this.sGHDataSet.DataSetName = "SGHDataSet";
            this.sGHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palabraBindingSource1
            // 
            this.palabraBindingSource1.DataMember = "Palabra";
            this.palabraBindingSource1.DataSource = this.sGHDataSet;
            // 
            // palabraTableAdapter1
            // 
            this.palabraTableAdapter1.ClearBeforeFill = true;
            // 
            // gbAgregarIdioma
            // 
            this.gbAgregarIdioma.Controls.Add(this.txtNombreIdioma);
            this.gbAgregarIdioma.Controls.Add(this.btnAgregarIdioma);
            this.gbAgregarIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregarIdioma.Location = new System.Drawing.Point(936, 13);
            this.gbAgregarIdioma.Name = "gbAgregarIdioma";
            this.gbAgregarIdioma.Size = new System.Drawing.Size(201, 168);
            this.gbAgregarIdioma.TabIndex = 13;
            this.gbAgregarIdioma.TabStop = false;
            this.gbAgregarIdioma.Tag = "AgregarIdioma";
            this.gbAgregarIdioma.Text = "Ingrese nombre de idioma:";
            // 
            // lblPalabras
            // 
            this.lblPalabras.AutoSize = true;
            this.lblPalabras.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabras.Location = new System.Drawing.Point(165, 210);
            this.lblPalabras.Name = "lblPalabras";
            this.lblPalabras.Size = new System.Drawing.Size(54, 18);
            this.lblPalabras.TabIndex = 14;
            this.lblPalabras.Tag = "Palabras";
            this.lblPalabras.Text = "Palabra";
            // 
            // dgvPalabras
            // 
            this.dgvPalabras.AllowUserToAddRows = false;
            this.dgvPalabras.AllowUserToDeleteRows = false;
            this.dgvPalabras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalabras.Location = new System.Drawing.Point(12, 250);
            this.dgvPalabras.Name = "dgvPalabras";
            this.dgvPalabras.ReadOnly = true;
            this.dgvPalabras.Size = new System.Drawing.Size(552, 307);
            this.dgvPalabras.TabIndex = 15;
            this.dgvPalabras.Tag = "dgvPalabras";
            this.dgvPalabras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dgvPalabras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dgvTraduccion
            // 
            this.dgvTraduccion.AllowUserToAddRows = false;
            this.dgvTraduccion.AllowUserToDeleteRows = false;
            this.dgvTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraduccion.Location = new System.Drawing.Point(586, 250);
            this.dgvTraduccion.Name = "dgvTraduccion";
            this.dgvTraduccion.ReadOnly = true;
            this.dgvTraduccion.Size = new System.Drawing.Size(539, 307);
            this.dgvTraduccion.TabIndex = 16;
            this.dgvTraduccion.Tag = "dgvTraduccion";
            this.dgvTraduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            this.dgvTraduccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // lblTraducciones
            // 
            this.lblTraducciones.AutoSize = true;
            this.lblTraducciones.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraducciones.Location = new System.Drawing.Point(699, 210);
            this.lblTraducciones.Name = "lblTraducciones";
            this.lblTraducciones.Size = new System.Drawing.Size(76, 18);
            this.lblTraducciones.TabIndex = 17;
            this.lblTraducciones.Tag = "Traducciones";
            this.lblTraducciones.Text = "Traduccion";
            // 
            // lblIdiomaSeleccionado
            // 
            this.lblIdiomaSeleccionado.AutoSize = true;
            this.lblIdiomaSeleccionado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaSeleccionado.Location = new System.Drawing.Point(240, 10);
            this.lblIdiomaSeleccionado.Name = "lblIdiomaSeleccionado";
            this.lblIdiomaSeleccionado.Size = new System.Drawing.Size(130, 18);
            this.lblIdiomaSeleccionado.TabIndex = 18;
            this.lblIdiomaSeleccionado.Tag = "lblIdiomaSeleccionado";
            this.lblIdiomaSeleccionado.Text = "idiomaSeleccionado";
            this.lblIdiomaSeleccionado.Visible = false;
            // 
            // lblCodigoIdioma
            // 
            this.lblCodigoIdioma.AutoSize = true;
            this.lblCodigoIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoIdioma.Location = new System.Drawing.Point(167, 42);
            this.lblCodigoIdioma.Name = "lblCodigoIdioma";
            this.lblCodigoIdioma.Size = new System.Drawing.Size(59, 18);
            this.lblCodigoIdioma.TabIndex = 19;
            this.lblCodigoIdioma.Tag = "lblCodigoIdioma";
            this.lblCodigoIdioma.Text = "Codigo :";
            // 
            // lblIdiomaCodigoSeleccionado
            // 
            this.lblIdiomaCodigoSeleccionado.AutoSize = true;
            this.lblIdiomaCodigoSeleccionado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaCodigoSeleccionado.Location = new System.Drawing.Point(240, 42);
            this.lblIdiomaCodigoSeleccionado.Name = "lblIdiomaCodigoSeleccionado";
            this.lblIdiomaCodigoSeleccionado.Size = new System.Drawing.Size(162, 18);
            this.lblIdiomaCodigoSeleccionado.TabIndex = 20;
            this.lblIdiomaCodigoSeleccionado.Tag = "lblCodigoIdiomaSeleccionado";
            this.lblIdiomaCodigoSeleccionado.Text = "Cod Idioma Seleccionado";
            this.lblIdiomaCodigoSeleccionado.Visible = false;
            // 
            // txtEdicionPalabra
            // 
            this.txtEdicionPalabra.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicionPalabra.Location = new System.Drawing.Point(262, 207);
            this.txtEdicionPalabra.Name = "txtEdicionPalabra";
            this.txtEdicionPalabra.Size = new System.Drawing.Size(187, 26);
            this.txtEdicionPalabra.TabIndex = 21;
            this.txtEdicionPalabra.Tag = "txtEdicionPalabra";
            // 
            // txtEdicionTraduccion
            // 
            this.txtEdicionTraduccion.Enabled = false;
            this.txtEdicionTraduccion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicionTraduccion.Location = new System.Drawing.Point(830, 207);
            this.txtEdicionTraduccion.Name = "txtEdicionTraduccion";
            this.txtEdicionTraduccion.Size = new System.Drawing.Size(167, 26);
            this.txtEdicionTraduccion.TabIndex = 22;
            this.txtEdicionTraduccion.Tag = "txtEdicionTraduccion";
            // 
            // lblIdTraduccion
            // 
            this.lblIdTraduccion.AutoSize = true;
            this.lblIdTraduccion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTraduccion.Location = new System.Drawing.Point(699, 178);
            this.lblIdTraduccion.Name = "lblIdTraduccion";
            this.lblIdTraduccion.Size = new System.Drawing.Size(89, 18);
            this.lblIdTraduccion.TabIndex = 24;
            this.lblIdTraduccion.Tag = "idTraduccion";
            this.lblIdTraduccion.Text = "id Traduccion";
            this.lblIdTraduccion.Visible = false;
            // 
            // lblIdPalabra
            // 
            this.lblIdPalabra.AutoSize = true;
            this.lblIdPalabra.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPalabra.Location = new System.Drawing.Point(28, 153);
            this.lblIdPalabra.Name = "lblIdPalabra";
            this.lblIdPalabra.Size = new System.Drawing.Size(68, 18);
            this.lblIdPalabra.TabIndex = 27;
            this.lblIdPalabra.Tag = "idPalabra";
            this.lblIdPalabra.Text = "id Palabra";
            this.lblIdPalabra.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 151);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRefrescarDgvTraducciones
            // 
            this.btnRefrescarDgvTraducciones.Enabled = false;
            this.btnRefrescarDgvTraducciones.FlatAppearance.BorderSize = 0;
            this.btnRefrescarDgvTraducciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescarDgvTraducciones.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarDgvTraducciones.Image = global::SGHv1._0.Properties.Resources.refresh;
            this.btnRefrescarDgvTraducciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescarDgvTraducciones.Location = new System.Drawing.Point(1044, 178);
            this.btnRefrescarDgvTraducciones.Name = "btnRefrescarDgvTraducciones";
            this.btnRefrescarDgvTraducciones.Size = new System.Drawing.Size(81, 70);
            this.btnRefrescarDgvTraducciones.TabIndex = 31;
            this.btnRefrescarDgvTraducciones.Tag = "RefrescarDgvTraducciones";
            this.btnRefrescarDgvTraducciones.Text = "Refrescar";
            this.btnRefrescarDgvTraducciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescarDgvTraducciones.UseVisualStyleBackColor = true;
            this.btnRefrescarDgvTraducciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefrescarDgvPalabras
            // 
            this.btnRefrescarDgvPalabras.FlatAppearance.BorderSize = 0;
            this.btnRefrescarDgvPalabras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescarDgvPalabras.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarDgvPalabras.Image = global::SGHv1._0.Properties.Resources.refresh;
            this.btnRefrescarDgvPalabras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescarDgvPalabras.Location = new System.Drawing.Point(15, 178);
            this.btnRefrescarDgvPalabras.Name = "btnRefrescarDgvPalabras";
            this.btnRefrescarDgvPalabras.Size = new System.Drawing.Size(100, 70);
            this.btnRefrescarDgvPalabras.TabIndex = 30;
            this.btnRefrescarDgvPalabras.Tag = "RefrescarDgvPalabras";
            this.btnRefrescarDgvPalabras.Text = "Refrescar";
            this.btnRefrescarDgvPalabras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescarDgvPalabras.UseVisualStyleBackColor = true;
            this.btnRefrescarDgvPalabras.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnEliminarPalabra
            // 
            this.btnEliminarPalabra.Enabled = false;
            this.btnEliminarPalabra.FlatAppearance.BorderSize = 0;
            this.btnEliminarPalabra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPalabra.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPalabra.Image = global::SGHv1._0.Properties.Resources.remove9;
            this.btnEliminarPalabra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarPalabra.Location = new System.Drawing.Point(343, 564);
            this.btnEliminarPalabra.Name = "btnEliminarPalabra";
            this.btnEliminarPalabra.Size = new System.Drawing.Size(106, 95);
            this.btnEliminarPalabra.TabIndex = 29;
            this.btnEliminarPalabra.Tag = "EliminarPalabra";
            this.btnEliminarPalabra.Text = "Eliminar Palabra";
            this.btnEliminarPalabra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarPalabra.UseVisualStyleBackColor = true;
            this.btnEliminarPalabra.Click += new System.EventHandler(this.btnEliminarPalabra_Click);
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.FlatAppearance.BorderSize = 0;
            this.btnAgregarPalabra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPalabra.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPalabra.Image = global::SGHv1._0.Properties.Resources.add_image5;
            this.btnAgregarPalabra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarPalabra.Location = new System.Drawing.Point(106, 562);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(103, 96);
            this.btnAgregarPalabra.TabIndex = 28;
            this.btnAgregarPalabra.Tag = "AgregarPalabra";
            this.btnAgregarPalabra.Text = "Agregar Palabra";
            this.btnAgregarPalabra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // btnEliminarTraduccion
            // 
            this.btnEliminarTraduccion.Enabled = false;
            this.btnEliminarTraduccion.FlatAppearance.BorderSize = 0;
            this.btnEliminarTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTraduccion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTraduccion.Image = global::SGHv1._0.Properties.Resources.remove10;
            this.btnEliminarTraduccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarTraduccion.Location = new System.Drawing.Point(918, 563);
            this.btnEliminarTraduccion.Name = "btnEliminarTraduccion";
            this.btnEliminarTraduccion.Size = new System.Drawing.Size(88, 93);
            this.btnEliminarTraduccion.TabIndex = 26;
            this.btnEliminarTraduccion.Tag = "EliminarTraduccion";
            this.btnEliminarTraduccion.Text = "Eliminar Traduccion";
            this.btnEliminarTraduccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarTraduccion.UseVisualStyleBackColor = true;
            this.btnEliminarTraduccion.Click += new System.EventHandler(this.btnEliminarTraduccion_Click);
            // 
            // btnAgregarTraduccion
            // 
            this.btnAgregarTraduccion.Enabled = false;
            this.btnAgregarTraduccion.FlatAppearance.BorderSize = 0;
            this.btnAgregarTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTraduccion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTraduccion.Image = global::SGHv1._0.Properties.Resources.add_image6;
            this.btnAgregarTraduccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarTraduccion.Location = new System.Drawing.Point(651, 562);
            this.btnAgregarTraduccion.Name = "btnAgregarTraduccion";
            this.btnAgregarTraduccion.Size = new System.Drawing.Size(121, 94);
            this.btnAgregarTraduccion.TabIndex = 25;
            this.btnAgregarTraduccion.Tag = "AgregarTraduccion";
            this.btnAgregarTraduccion.Text = "Agregar Traduccion";
            this.btnAgregarTraduccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarTraduccion.UseVisualStyleBackColor = true;
            this.btnAgregarTraduccion.Click += new System.EventHandler(this.btnAgregarTraduccion_Click);
            // 
            // btnModificarPalabra
            // 
            this.btnModificarPalabra.Enabled = false;
            this.btnModificarPalabra.FlatAppearance.BorderSize = 0;
            this.btnModificarPalabra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPalabra.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPalabra.Image = global::SGHv1._0.Properties.Resources.modify4;
            this.btnModificarPalabra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarPalabra.Location = new System.Drawing.Point(215, 562);
            this.btnModificarPalabra.Name = "btnModificarPalabra";
            this.btnModificarPalabra.Size = new System.Drawing.Size(114, 95);
            this.btnModificarPalabra.TabIndex = 23;
            this.btnModificarPalabra.Tag = "ModificarPalabra";
            this.btnModificarPalabra.Text = "Modificar Palabra";
            this.btnModificarPalabra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarPalabra.UseVisualStyleBackColor = true;
            this.btnModificarPalabra.Click += new System.EventHandler(this.btnModificarPalabra_Click);
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.FlatAppearance.BorderSize = 0;
            this.btnAgregarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIdioma.Image = global::SGHv1._0.Properties.Resources.add_image7;
            this.btnAgregarIdioma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarIdioma.Location = new System.Drawing.Point(108, 63);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(81, 95);
            this.btnAgregarIdioma.TabIndex = 1;
            this.btnAgregarIdioma.Tag = "AgregarIdioma";
            this.btnAgregarIdioma.Text = "Agregar Idioma";
            this.btnAgregarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarIdioma.UseVisualStyleBackColor = true;
            this.btnAgregarIdioma.Click += new System.EventHandler(this.btnAgregarIdioma_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit6;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(1056, 573);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 77);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Tag = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarIdioma
            // 
            this.btnBorrarIdioma.FlatAppearance.BorderSize = 0;
            this.btnBorrarIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarIdioma.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarIdioma.Image = global::SGHv1._0.Properties.Resources.remove7;
            this.btnBorrarIdioma.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrarIdioma.Location = new System.Drawing.Point(15, 74);
            this.btnBorrarIdioma.Name = "btnBorrarIdioma";
            this.btnBorrarIdioma.Size = new System.Drawing.Size(100, 76);
            this.btnBorrarIdioma.TabIndex = 3;
            this.btnBorrarIdioma.Tag = "BorrarIdioma";
            this.btnBorrarIdioma.Text = "Borrar Idioma";
            this.btnBorrarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarIdioma.UseVisualStyleBackColor = true;
            this.btnBorrarIdioma.Click += new System.EventHandler(this.btnBorrarIdioma_Click);
            // 
            // btnModificarTraduccion
            // 
            this.btnModificarTraduccion.Enabled = false;
            this.btnModificarTraduccion.FlatAppearance.BorderSize = 0;
            this.btnModificarTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTraduccion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTraduccion.Image = global::SGHv1._0.Properties.Resources.modify5;
            this.btnModificarTraduccion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarTraduccion.Location = new System.Drawing.Point(771, 564);
            this.btnModificarTraduccion.Name = "btnModificarTraduccion";
            this.btnModificarTraduccion.Size = new System.Drawing.Size(141, 94);
            this.btnModificarTraduccion.TabIndex = 2;
            this.btnModificarTraduccion.Tag = "ModificarTraduccion";
            this.btnModificarTraduccion.Text = "Modificar Traduccion";
            this.btnModificarTraduccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarTraduccion.UseVisualStyleBackColor = true;
            this.btnModificarTraduccion.Click += new System.EventHandler(this.btnModificarTraduccion_Click);
            // 
            // GUIIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1137, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefrescarDgvTraducciones);
            this.Controls.Add(this.btnRefrescarDgvPalabras);
            this.Controls.Add(this.btnEliminarPalabra);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.lblIdPalabra);
            this.Controls.Add(this.btnEliminarTraduccion);
            this.Controls.Add(this.btnAgregarTraduccion);
            this.Controls.Add(this.lblIdTraduccion);
            this.Controls.Add(this.btnModificarPalabra);
            this.Controls.Add(this.txtEdicionTraduccion);
            this.Controls.Add(this.txtEdicionPalabra);
            this.Controls.Add(this.lblIdiomaCodigoSeleccionado);
            this.Controls.Add(this.lblCodigoIdioma);
            this.Controls.Add(this.lblIdiomaSeleccionado);
            this.Controls.Add(this.lblTraducciones);
            this.Controls.Add(this.dgvTraduccion);
            this.Controls.Add(this.dgvPalabras);
            this.Controls.Add(this.lblPalabras);
            this.Controls.Add(this.gbAgregarIdioma);
            this.Controls.Add(this.lblSeleccioneIdioma);
            this.Controls.Add(this.cmbListarIdiomas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnBorrarIdioma);
            this.Controls.Add(this.btnModificarTraduccion);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIIdiomas";
            this.Text = "GUIIdiomas";
            this.Load += new System.EventHandler(this.GUIIdiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.palabraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGHDataSetPalabra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sGHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabraBindingSource1)).EndInit();
            this.gbAgregarIdioma.ResumeLayout(false);
            this.gbAgregarIdioma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalabras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarIdioma;
        private System.Windows.Forms.Button btnModificarTraduccion;
        private System.Windows.Forms.Button btnBorrarIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbListarIdiomas;
        private System.Windows.Forms.Label lblSeleccioneIdioma;
        private SGHDataSetPalabra sGHDataSetPalabra;
        private System.Windows.Forms.BindingSource palabraBindingSource;
        private SGHDataSetPalabraTableAdapters.PalabraTableAdapter palabraTableAdapter;
        private System.Windows.Forms.TextBox txtNombreIdioma;
        private SGHDataSet sGHDataSet;
        private System.Windows.Forms.BindingSource palabraBindingSource1;
        private SGHDataSetTableAdapters.PalabraTableAdapter palabraTableAdapter1;
        private System.Windows.Forms.GroupBox gbAgregarIdioma;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.DataGridView dgvPalabras;
        private System.Windows.Forms.DataGridView dgvTraduccion;
        private System.Windows.Forms.Label lblTraducciones;
        private System.Windows.Forms.Label lblIdiomaSeleccionado;
        private System.Windows.Forms.Label lblCodigoIdioma;
        private System.Windows.Forms.Label lblIdiomaCodigoSeleccionado;
        private System.Windows.Forms.TextBox txtEdicionPalabra;
        private System.Windows.Forms.TextBox txtEdicionTraduccion;
        private System.Windows.Forms.Button btnModificarPalabra;
        private System.Windows.Forms.Label lblIdTraduccion;
        private System.Windows.Forms.Button btnAgregarTraduccion;
        private System.Windows.Forms.Button btnEliminarTraduccion;
        private System.Windows.Forms.Label lblIdPalabra;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.Button btnEliminarPalabra;
        private System.Windows.Forms.Button btnRefrescarDgvPalabras;
        private System.Windows.Forms.Button btnRefrescarDgvTraducciones;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}