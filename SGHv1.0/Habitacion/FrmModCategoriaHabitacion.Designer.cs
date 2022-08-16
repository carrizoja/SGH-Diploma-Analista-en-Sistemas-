namespace SGHv1._0.Habitacion
{
    partial class FrmModCategoriaHabitacion
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
            this.lblCodigo.Location = new System.Drawing.Point(98, 46);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Tag = "Codigo";
            this.lblCodigo.Text = "Codigo";
            // 
            // btnTraerCodigo
            // 
            this.btnTraerCodigo.Location = new System.Drawing.Point(74, 194);
            this.btnTraerCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTraerCodigo.Name = "btnTraerCodigo";
            this.btnTraerCodigo.Size = new System.Drawing.Size(158, 71);
            this.btnTraerCodigo.TabIndex = 1;
            this.btnTraerCodigo.Tag = "TraerCodigo";
            this.btnTraerCodigo.Text = "Traer Codigo";
            this.btnTraerCodigo.UseVisualStyleBackColor = true;
            this.btnTraerCodigo.Click += new System.EventHandler(this.btnTraerCodigo_Click);
            // 
            // txtCodigoCat
            // 
            this.txtCodigoCat.Location = new System.Drawing.Point(54, 117);
            this.txtCodigoCat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCodigoCat.Name = "txtCodigoCat";
            this.txtCodigoCat.Size = new System.Drawing.Size(196, 31);
            this.txtCodigoCat.TabIndex = 2;
            this.txtCodigoCat.TextChanged += new System.EventHandler(this.txtCodigoCat_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(422, 46);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Tag = "Nombre";
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreCodigo
            // 
            this.txtNombreCodigo.Location = new System.Drawing.Point(378, 117);
            this.txtNombreCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombreCodigo.Name = "txtNombreCodigo";
            this.txtNombreCodigo.Size = new System.Drawing.Size(196, 31);
            this.txtNombreCodigo.TabIndex = 4;
            this.txtNombreCodigo.Tag = "NombreCodigo";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(400, 194);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(158, 71);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Tag = "Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmModCategoriaHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 350);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombreCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigoCat);
            this.Controls.Add(this.btnTraerCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmModCategoriaHabitacion";
            this.Text = "BajaCategoriaHabitacion";
            this.Load += new System.EventHandler(this.FrmModCategoriaHabitacion_Load);
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