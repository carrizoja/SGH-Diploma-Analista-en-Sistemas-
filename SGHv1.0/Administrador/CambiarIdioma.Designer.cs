namespace SGHv1._0
{
    partial class CambiarIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarIdioma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbIdiomas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblIdiomaSeleccionado = new System.Windows.Forms.Label();
            this.lblNombreDeIdioma = new System.Windows.Forms.Label();
            this.lblCodigoDeIdioma = new System.Windows.Forms.Label();
            this.lblCodIdioma = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.idioma;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 129);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdiomas.FormattingEnabled = true;
            this.cmbIdiomas.Location = new System.Drawing.Point(15, 44);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(121, 26);
            this.cmbIdiomas.TabIndex = 3;
            this.cmbIdiomas.Tag = "cmbIdiomas";
            this.cmbIdiomas.SelectedIndexChanged += new System.EventHandler(this.cmbIdiomas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione Idioma ";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(267, 169);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(117, 28);
            this.btnAplicar.TabIndex = 5;
            this.btnAplicar.Tag = "btnAplicar";
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblIdiomaSeleccionado
            // 
            this.lblIdiomaSeleccionado.AutoSize = true;
            this.lblIdiomaSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaSeleccionado.Location = new System.Drawing.Point(13, 157);
            this.lblIdiomaSeleccionado.Name = "lblIdiomaSeleccionado";
            this.lblIdiomaSeleccionado.Size = new System.Drawing.Size(154, 18);
            this.lblIdiomaSeleccionado.TabIndex = 6;
            this.lblIdiomaSeleccionado.Tag = "lblIdiomaSeleccionado";
            this.lblIdiomaSeleccionado.Text = "Idioma Seleccionado :";
            this.lblIdiomaSeleccionado.Visible = false;
            // 
            // lblNombreDeIdioma
            // 
            this.lblNombreDeIdioma.AutoSize = true;
            this.lblNombreDeIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeIdioma.Location = new System.Drawing.Point(13, 191);
            this.lblNombreDeIdioma.Name = "lblNombreDeIdioma";
            this.lblNombreDeIdioma.Size = new System.Drawing.Size(127, 18);
            this.lblNombreDeIdioma.TabIndex = 7;
            this.lblNombreDeIdioma.Tag = "lblNombreDeIdioma";
            this.lblNombreDeIdioma.Text = "nombre de idioma";
            this.lblNombreDeIdioma.Visible = false;
            // 
            // lblCodigoDeIdioma
            // 
            this.lblCodigoDeIdioma.AutoSize = true;
            this.lblCodigoDeIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeIdioma.Location = new System.Drawing.Point(13, 87);
            this.lblCodigoDeIdioma.Name = "lblCodigoDeIdioma";
            this.lblCodigoDeIdioma.Size = new System.Drawing.Size(132, 18);
            this.lblCodigoDeIdioma.TabIndex = 8;
            this.lblCodigoDeIdioma.Tag = "lblCodigoDeIdioma";
            this.lblCodigoDeIdioma.Text = "Codigo de Idioma :";
            this.lblCodigoDeIdioma.Visible = false;
            // 
            // lblCodIdioma
            // 
            this.lblCodIdioma.AutoSize = true;
            this.lblCodIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodIdioma.Location = new System.Drawing.Point(12, 123);
            this.lblCodIdioma.Name = "lblCodIdioma";
            this.lblCodIdioma.Size = new System.Drawing.Size(81, 18);
            this.lblCodIdioma.TabIndex = 9;
            this.lblCodIdioma.Tag = "lblCodIdioma";
            this.lblCodIdioma.Text = "cod idioma";
            this.lblCodIdioma.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(267, 251);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 28);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Tag = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(401, 282);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCodIdioma);
            this.Controls.Add(this.lblCodigoDeIdioma);
            this.Controls.Add(this.lblNombreDeIdioma);
            this.Controls.Add(this.lblIdiomaSeleccionado);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdiomas);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarIdioma";
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.FrmCambiarIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbIdiomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblIdiomaSeleccionado;
        private System.Windows.Forms.Label lblNombreDeIdioma;
        private System.Windows.Forms.Label lblCodigoDeIdioma;
        private System.Windows.Forms.Label lblCodIdioma;
        private System.Windows.Forms.Button btnSalir;
    }
}