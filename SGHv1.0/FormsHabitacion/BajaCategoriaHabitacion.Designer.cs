namespace SGHv1._0.Habitacion
{
    partial class BajaCategoriaHabitacion
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnTraerCodigo = new System.Windows.Forms.Button();
            this.txtCodigoCat = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCodigo = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(49, 24);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Tag = "Codigo";
            this.lblCodigo.Text = "Codigo";
            // 
            // btnTraerCodigo
            // 
            this.btnTraerCodigo.Location = new System.Drawing.Point(37, 101);
            this.btnTraerCodigo.Name = "btnTraerCodigo";
            this.btnTraerCodigo.Size = new System.Drawing.Size(79, 37);
            this.btnTraerCodigo.TabIndex = 1;
            this.btnTraerCodigo.Tag = "TraerCodigo";
            this.btnTraerCodigo.Text = "Traer Codigo";
            this.btnTraerCodigo.UseVisualStyleBackColor = true;
            // 
            // txtCodigoCat
            // 
            this.txtCodigoCat.Location = new System.Drawing.Point(27, 61);
            this.txtCodigoCat.Name = "txtCodigoCat";
            this.txtCodigoCat.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCat.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(211, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Tag = "Nombre";
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreCodigo
            // 
            this.txtNombreCodigo.Location = new System.Drawing.Point(189, 61);
            this.txtNombreCodigo.Name = "txtNombreCodigo";
            this.txtNombreCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCodigo.TabIndex = 4;
            this.txtNombreCodigo.Tag = "NombreCodigo";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(200, 101);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 37);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Tag = "Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // BajaCategoriaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 182);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigoCat);
            this.Controls.Add(this.btnTraerCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "BajaCategoriaHabitacion";
            this.Text = "BajaCategoriaHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnTraerCodigo;
        private System.Windows.Forms.TextBox txtCodigoCat;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCodigo;
        private System.Windows.Forms.Button btnModificar;
    }
}