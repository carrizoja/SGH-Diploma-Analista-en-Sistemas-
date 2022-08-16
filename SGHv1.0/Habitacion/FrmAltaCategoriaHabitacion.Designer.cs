namespace SGHv1._0.Habitacion
{
    partial class FrmAltaCategoriaHabitacion
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
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblIngresarNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigoCategoriaHabitacion = new System.Windows.Forms.Label();
            this.txtCodigoCategoriaHabitacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(287, 116);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(216, 31);
            this.txtNombreCategoria.TabIndex = 0;
            // 
            // lblIngresarNombre
            // 
            this.lblIngresarNombre.AutoSize = true;
            this.lblIngresarNombre.Location = new System.Drawing.Point(79, 119);
            this.lblIngresarNombre.Name = "lblIngresarNombre";
            this.lblIngresarNombre.Size = new System.Drawing.Size(164, 25);
            this.lblIngresarNombre.TabIndex = 1;
            this.lblIngresarNombre.Text = "Ingrese Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(331, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 54);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Tag = "Agregar";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigoCategoriaHabitacion
            // 
            this.lblCodigoCategoriaHabitacion.AutoSize = true;
            this.lblCodigoCategoriaHabitacion.Location = new System.Drawing.Point(79, 48);
            this.lblCodigoCategoriaHabitacion.Name = "lblCodigoCategoriaHabitacion";
            this.lblCodigoCategoriaHabitacion.Size = new System.Drawing.Size(157, 25);
            this.lblCodigoCategoriaHabitacion.TabIndex = 3;
            this.lblCodigoCategoriaHabitacion.Text = "Ingrese Codigo";
            // 
            // txtCodigoCategoriaHabitacion
            // 
            this.txtCodigoCategoriaHabitacion.Location = new System.Drawing.Point(287, 48);
            this.txtCodigoCategoriaHabitacion.Name = "txtCodigoCategoriaHabitacion";
            this.txtCodigoCategoriaHabitacion.Size = new System.Drawing.Size(216, 31);
            this.txtCodigoCategoriaHabitacion.TabIndex = 4;
            // 
            // FrmAltaCategoriaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 306);
            this.Controls.Add(this.txtCodigoCategoriaHabitacion);
            this.Controls.Add(this.lblCodigoCategoriaHabitacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblIngresarNombre);
            this.Controls.Add(this.txtNombreCategoria);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmAltaCategoriaHabitacion";
            this.Text = "FrmAltaCategoriaHabitacion";
            this.Load += new System.EventHandler(this.FrmAltaCategoriaHabitacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblIngresarNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCodigoCategoriaHabitacion;
        private System.Windows.Forms.TextBox txtCodigoCategoriaHabitacion;
    }
}