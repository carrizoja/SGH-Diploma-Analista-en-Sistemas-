namespace SGHv1._0.Reportes
{
    partial class GananciasGeneradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GananciasGeneradas));
            this.grbFiltroPorFecha = new System.Windows.Forms.GroupBox();
            this.cmbPorCategoria = new System.Windows.Forms.ComboBox();
            this.lblPorCategoria = new System.Windows.Forms.Label();
            this.cmbPorTipo = new System.Windows.Forms.ComboBox();
            this.lblPorTipo = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lstReservas = new System.Windows.Forms.ListView();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.lblTotalCalculado = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            this.grbFiltroPorFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltroPorFecha
            // 
            this.grbFiltroPorFecha.Controls.Add(this.cmbPorCategoria);
            this.grbFiltroPorFecha.Controls.Add(this.lblPorCategoria);
            this.grbFiltroPorFecha.Controls.Add(this.cmbPorTipo);
            this.grbFiltroPorFecha.Controls.Add(this.lblPorTipo);
            this.grbFiltroPorFecha.Controls.Add(this.btnAplicar);
            this.grbFiltroPorFecha.Controls.Add(this.lblHasta);
            this.grbFiltroPorFecha.Controls.Add(this.lblDesde);
            this.grbFiltroPorFecha.Controls.Add(this.dtpHasta);
            this.grbFiltroPorFecha.Controls.Add(this.dtpDesde);
            this.grbFiltroPorFecha.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFiltroPorFecha.Location = new System.Drawing.Point(29, 13);
            this.grbFiltroPorFecha.Name = "grbFiltroPorFecha";
            this.grbFiltroPorFecha.Size = new System.Drawing.Size(796, 115);
            this.grbFiltroPorFecha.TabIndex = 0;
            this.grbFiltroPorFecha.TabStop = false;
            this.grbFiltroPorFecha.Tag = "FiltroPorFecha";
            this.grbFiltroPorFecha.Text = "Filtro por Fecha";
            this.grbFiltroPorFecha.Enter += new System.EventHandler(this.grbFiltroPorFecha_Enter);
            // 
            // cmbPorCategoria
            // 
            this.cmbPorCategoria.FormattingEnabled = true;
            this.cmbPorCategoria.Location = new System.Drawing.Point(557, 83);
            this.cmbPorCategoria.Name = "cmbPorCategoria";
            this.cmbPorCategoria.Size = new System.Drawing.Size(134, 26);
            this.cmbPorCategoria.TabIndex = 10;
            this.cmbPorCategoria.Tag = "PorCategoria";
            // 
            // lblPorCategoria
            // 
            this.lblPorCategoria.AutoSize = true;
            this.lblPorCategoria.Location = new System.Drawing.Point(452, 88);
            this.lblPorCategoria.Name = "lblPorCategoria";
            this.lblPorCategoria.Size = new System.Drawing.Size(90, 18);
            this.lblPorCategoria.TabIndex = 9;
            this.lblPorCategoria.Tag = "PorCategoria";
            this.lblPorCategoria.Text = "Por Categoria";
            // 
            // cmbPorTipo
            // 
            this.cmbPorTipo.FormattingEnabled = true;
            this.cmbPorTipo.Location = new System.Drawing.Point(229, 83);
            this.cmbPorTipo.Name = "cmbPorTipo";
            this.cmbPorTipo.Size = new System.Drawing.Size(134, 26);
            this.cmbPorTipo.TabIndex = 8;
            this.cmbPorTipo.Tag = "PorTipo";
            // 
            // lblPorTipo
            // 
            this.lblPorTipo.AutoSize = true;
            this.lblPorTipo.Location = new System.Drawing.Point(156, 88);
            this.lblPorTipo.Name = "lblPorTipo";
            this.lblPorTipo.Size = new System.Drawing.Size(58, 18);
            this.lblPorTipo.TabIndex = 7;
            this.lblPorTipo.Tag = "PorTipo";
            this.lblPorTipo.Text = "Por Tipo";
            // 
            // btnAplicar
            // 
            this.btnAplicar.FlatAppearance.BorderSize = 0;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Image = global::SGHv1._0.Properties.Resources.apply;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAplicar.Location = new System.Drawing.Point(716, 29);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(63, 72);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Tag = "Aplicar";
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(382, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(43, 18);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Tag = "Hasta";
            this.lblHasta.Text = "Hasta";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(36, 35);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(46, 18);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Tag = "Desde";
            this.lblDesde.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(431, 29);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(260, 26);
            this.dtpHasta.TabIndex = 1;
            this.dtpHasta.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(88, 29);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(275, 26);
            this.dtpDesde.TabIndex = 0;
            // 
            // lstReservas
            // 
            this.lstReservas.HideSelection = false;
            this.lstReservas.Location = new System.Drawing.Point(12, 144);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(1002, 290);
            this.lstReservas.TabIndex = 8;
            this.lstReservas.UseCompatibleStateImageBehavior = false;
            this.lstReservas.SelectedIndexChanged += new System.EventHandler(this.lstReservas_SelectedIndexChanged);
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecaudado.Location = new System.Drawing.Point(13, 455);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(117, 18);
            this.lblTotalRecaudado.TabIndex = 9;
            this.lblTotalRecaudado.Tag = "TotalRecaudado";
            this.lblTotalRecaudado.Text = "Total Recaudado :";
            // 
            // lblTotalCalculado
            // 
            this.lblTotalCalculado.AutoSize = true;
            this.lblTotalCalculado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCalculado.Location = new System.Drawing.Point(145, 455);
            this.lblTotalCalculado.Name = "lblTotalCalculado";
            this.lblTotalCalculado.Size = new System.Drawing.Size(98, 18);
            this.lblTotalCalculado.TabIndex = 10;
            this.lblTotalCalculado.Tag = "TotalCalculado";
            this.lblTotalCalculado.Text = "TotalCalculado";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::SGHv1._0.Properties.Resources.exit9;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(957, 452);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(57, 84);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.FlatAppearance.BorderSize = 0;
            this.btnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPDF.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPDF.Image = global::SGHv1._0.Properties.Resources.pdf1;
            this.btnGenerarPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerarPDF.Location = new System.Drawing.Point(804, 452);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(102, 81);
            this.btnGenerarPDF.TabIndex = 6;
            this.btnGenerarPDF.Tag = "GenerarPDF";
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::SGHv1._0.Properties.Resources.clean25;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(645, 452);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 78);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Tag = "Limpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // GananciasGeneradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1046, 548);
            this.Controls.Add(this.lblTotalCalculado);
            this.Controls.Add(this.lblTotalRecaudado);
            this.Controls.Add(this.lstReservas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbFiltroPorFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GananciasGeneradas";
            this.Tag = "GananciasGeneradas";
            this.Text = "Ganancias Generadas";
            this.Load += new System.EventHandler(this.GananciasGeneradas_Load);
            this.grbFiltroPorFecha.ResumeLayout(false);
            this.grbFiltroPorFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltroPorFecha;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerarPDF;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lstReservas;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.Label lblTotalCalculado;
        private System.Windows.Forms.ComboBox cmbPorCategoria;
        private System.Windows.Forms.Label lblPorCategoria;
        private System.Windows.Forms.ComboBox cmbPorTipo;
        private System.Windows.Forms.Label lblPorTipo;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.HelpProvider helpProvider2;
    }
}