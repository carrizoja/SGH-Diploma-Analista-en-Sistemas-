namespace SGHv1._0.Administrador
{
    partial class GestionDeCambios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeCambios));
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.lblSeleccioneUnCriterio = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblAuditoriaCliente = new System.Windows.Forms.Label();
            this.listViewGestionCambios = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInsert.Location = new System.Drawing.Point(15, 108);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(121, 22);
            this.rbInsert.TabIndex = 0;
            this.rbInsert.TabStop = true;
            this.rbInsert.Tag = "rbInsert";
            this.rbInsert.Text = "Insert / Update";
            this.rbInsert.UseVisualStyleBackColor = true;
            this.rbInsert.CheckedChanged += new System.EventHandler(this.rbInsert_CheckedChanged);
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDelete.Location = new System.Drawing.Point(16, 154);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(68, 22);
            this.radioDelete.TabIndex = 2;
            this.radioDelete.TabStop = true;
            this.radioDelete.Tag = "rbDelete";
            this.radioDelete.Text = "Delete";
            this.radioDelete.UseVisualStyleBackColor = true;
            // 
            // lblSeleccioneUnCriterio
            // 
            this.lblSeleccioneUnCriterio.AutoSize = true;
            this.lblSeleccioneUnCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccioneUnCriterio.Location = new System.Drawing.Point(12, 63);
            this.lblSeleccioneUnCriterio.Name = "lblSeleccioneUnCriterio";
            this.lblSeleccioneUnCriterio.Size = new System.Drawing.Size(234, 18);
            this.lblSeleccioneUnCriterio.TabIndex = 3;
            this.lblSeleccioneUnCriterio.Tag = "SeleccioneUnCriterio";
            this.lblSeleccioneUnCriterio.Text = "Seleccione un criterio de consulta:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(16, 203);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(84, 41);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Tag = "Aplicar";
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblAuditoriaCliente
            // 
            this.lblAuditoriaCliente.AutoSize = true;
            this.lblAuditoriaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuditoriaCliente.Location = new System.Drawing.Point(396, 9);
            this.lblAuditoriaCliente.Name = "lblAuditoriaCliente";
            this.lblAuditoriaCliente.Size = new System.Drawing.Size(283, 24);
            this.lblAuditoriaCliente.TabIndex = 5;
            this.lblAuditoriaCliente.Tag = "AuditoriaSobreTablaCliente";
            this.lblAuditoriaCliente.Text = "Auditoria sobre tabla Clientes";
            // 
            // listViewGestionCambios
            // 
            this.listViewGestionCambios.HideSelection = false;
            this.listViewGestionCambios.Location = new System.Drawing.Point(266, 63);
            this.listViewGestionCambios.Name = "listViewGestionCambios";
            this.listViewGestionCambios.Size = new System.Drawing.Size(964, 452);
            this.listViewGestionCambios.TabIndex = 6;
            this.listViewGestionCambios.Tag = "listViewGestionCambios";
            this.listViewGestionCambios.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.auditoria;
            this.pictureBox1.Location = new System.Drawing.Point(9, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 255);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(651, 534);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 26);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Tag = "Limpiar";
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1146, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 10;
            this.button1.Tag = "Limpiar";
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionDeCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1242, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewGestionCambios);
            this.Controls.Add(this.lblAuditoriaCliente);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.lblSeleccioneUnCriterio);
            this.Controls.Add(this.radioDelete);
            this.Controls.Add(this.rbInsert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionDeCambios";
            this.Tag = "GestionDeCambios";
            this.Text = "Gestion De Cambios";
            this.Load += new System.EventHandler(this.GestionDeCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.Label lblSeleccioneUnCriterio;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblAuditoriaCliente;
        private System.Windows.Forms.ListView listViewGestionCambios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
    }
}