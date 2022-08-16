namespace SGHv1._0.Administrador
{
    partial class FrmBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupRestore));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBackupFileRuta = new System.Windows.Forms.TextBox();
            this.txtNombreBackup = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbBaseDeDatos = new System.Windows.Forms.ComboBox();
            this.lblBasedeDatos = new System.Windows.Forms.Label();
            this.lblRutaParaGuardar = new System.Windows.Forms.Label();
            this.lblNombreBackup = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnHacerBackup = new System.Windows.Forms.Button();
            this.lblRestaurar = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBackupFileRuta
            // 
            this.txtBackupFileRuta.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupFileRuta.Location = new System.Drawing.Point(152, 77);
            this.txtBackupFileRuta.Name = "txtBackupFileRuta";
            this.txtBackupFileRuta.Size = new System.Drawing.Size(260, 26);
            this.txtBackupFileRuta.TabIndex = 1;
            this.txtBackupFileRuta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNombreBackup
            // 
            this.txtNombreBackup.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBackup.Location = new System.Drawing.Point(152, 129);
            this.txtNombreBackup.Name = "txtNombreBackup";
            this.txtNombreBackup.Size = new System.Drawing.Size(260, 26);
            this.txtNombreBackup.TabIndex = 2;
            this.txtNombreBackup.TextChanged += new System.EventHandler(this.txtNombreBackup_TextChanged);
            // 
            // cmbBaseDeDatos
            // 
            this.cmbBaseDeDatos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaseDeDatos.FormattingEnabled = true;
            this.cmbBaseDeDatos.Location = new System.Drawing.Point(152, 22);
            this.cmbBaseDeDatos.Name = "cmbBaseDeDatos";
            this.cmbBaseDeDatos.Size = new System.Drawing.Size(260, 26);
            this.cmbBaseDeDatos.TabIndex = 3;
            // 
            // lblBasedeDatos
            // 
            this.lblBasedeDatos.AutoSize = true;
            this.lblBasedeDatos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasedeDatos.Location = new System.Drawing.Point(12, 31);
            this.lblBasedeDatos.Name = "lblBasedeDatos";
            this.lblBasedeDatos.Size = new System.Drawing.Size(94, 18);
            this.lblBasedeDatos.TabIndex = 4;
            this.lblBasedeDatos.Tag = "BaseDeDatos";
            this.lblBasedeDatos.Text = "Base de Datos";
            this.lblBasedeDatos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRutaParaGuardar
            // 
            this.lblRutaParaGuardar.AutoSize = true;
            this.lblRutaParaGuardar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaParaGuardar.Location = new System.Drawing.Point(12, 84);
            this.lblRutaParaGuardar.Name = "lblRutaParaGuardar";
            this.lblRutaParaGuardar.Size = new System.Drawing.Size(120, 18);
            this.lblRutaParaGuardar.TabIndex = 5;
            this.lblRutaParaGuardar.Tag = "RutaParaGuardar";
            this.lblRutaParaGuardar.Text = "Ruta Para Guardar";
            // 
            // lblNombreBackup
            // 
            this.lblNombreBackup.AutoSize = true;
            this.lblNombreBackup.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBackup.Location = new System.Drawing.Point(12, 135);
            this.lblNombreBackup.Name = "lblNombreBackup";
            this.lblNombreBackup.Size = new System.Drawing.Size(107, 18);
            this.lblNombreBackup.TabIndex = 6;
            this.lblNombreBackup.Tag = "NombreBackup";
            this.lblNombreBackup.Text = "Nombre Backup";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(440, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 28);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Tag = "Buscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnHacerBackup
            // 
            this.btnHacerBackup.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerBackup.Location = new System.Drawing.Point(440, 126);
            this.btnHacerBackup.Name = "btnHacerBackup";
            this.btnHacerBackup.Size = new System.Drawing.Size(110, 33);
            this.btnHacerBackup.TabIndex = 8;
            this.btnHacerBackup.Tag = "HacerBackup";
            this.btnHacerBackup.Text = "Hacer Backup";
            this.btnHacerBackup.UseVisualStyleBackColor = true;
            this.btnHacerBackup.Click += new System.EventHandler(this.btnHacerBackup_Click);
            // 
            // lblRestaurar
            // 
            this.lblRestaurar.AutoSize = true;
            this.lblRestaurar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurar.Location = new System.Drawing.Point(12, 195);
            this.lblRestaurar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestaurar.Name = "lblRestaurar";
            this.lblRestaurar.Size = new System.Drawing.Size(55, 18);
            this.lblRestaurar.TabIndex = 9;
            this.lblRestaurar.Tag = "Restore";
            this.lblRestaurar.Text = "Restore";
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(152, 189);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(260, 26);
            this.txtRuta.TabIndex = 10;
            // 
            // btnRuta
            // 
            this.btnRuta.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuta.Location = new System.Drawing.Point(440, 185);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(110, 29);
            this.btnRuta.TabIndex = 11;
            this.btnRuta.Text = "Buscar";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(499, 250);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(110, 30);
            this.btnRestaurar.TabIndex = 12;
            this.btnRestaurar.Tag = "HacerRestore";
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.restore;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(584, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 153);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(624, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 31);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(746, 283);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRestaurar);
            this.Controls.Add(this.btnHacerBackup);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombreBackup);
            this.Controls.Add(this.lblRutaParaGuardar);
            this.Controls.Add(this.lblBasedeDatos);
            this.Controls.Add(this.cmbBaseDeDatos);
            this.Controls.Add(this.txtNombreBackup);
            this.Controls.Add(this.txtBackupFileRuta);
            this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBackupRestore";
            this.Text = "Backup Restore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBackupRestore_FormClosing);
            this.Load += new System.EventHandler(this.FrmBackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBackupFileRuta;
        private System.Windows.Forms.TextBox txtNombreBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbBaseDeDatos;
        private System.Windows.Forms.Label lblBasedeDatos;
        private System.Windows.Forms.Label lblRutaParaGuardar;
        private System.Windows.Forms.Label lblNombreBackup;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnHacerBackup;
        private System.Windows.Forms.Label lblRestaurar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}