namespace SGHv1._0.Administrador
{
    partial class FrmModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarUsuario));
            this.txtDniUsuarioATraer = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnRecuperarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lblIngresarDNIUsuario = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDniUsuarioATraer
            // 
            this.txtDniUsuarioATraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniUsuarioATraer.Location = new System.Drawing.Point(15, 80);
            this.txtDniUsuarioATraer.Name = "txtDniUsuarioATraer";
            this.txtDniUsuarioATraer.Size = new System.Drawing.Size(158, 24);
            this.txtDniUsuarioATraer.TabIndex = 0;
            this.txtDniUsuarioATraer.TextChanged += new System.EventHandler(this.txtDniUsuarioATraer_TextChanged);
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(292, 58);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(164, 24);
            this.txtDni.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(292, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 24);
            this.txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(292, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // btnRecuperarUsuario
            // 
            this.btnRecuperarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarUsuario.Location = new System.Drawing.Point(15, 133);
            this.btnRecuperarUsuario.Name = "btnRecuperarUsuario";
            this.btnRecuperarUsuario.Size = new System.Drawing.Size(158, 30);
            this.btnRecuperarUsuario.TabIndex = 4;
            this.btnRecuperarUsuario.Tag = "TraerUsuario";
            this.btnRecuperarUsuario.Text = "Recuperar Usuario";
            this.btnRecuperarUsuario.UseVisualStyleBackColor = true;
            this.btnRecuperarUsuario.Click += new System.EventHandler(this.btnRecuperarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(519, 164);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(137, 31);
            this.btnModificarUsuario.TabIndex = 5;
            this.btnModificarUsuario.Tag = "ModificarUsuario";
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lblIngresarDNIUsuario
            // 
            this.lblIngresarDNIUsuario.AutoSize = true;
            this.lblIngresarDNIUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarDNIUsuario.Location = new System.Drawing.Point(12, 40);
            this.lblIngresarDNIUsuario.Name = "lblIngresarDNIUsuario";
            this.lblIngresarDNIUsuario.Size = new System.Drawing.Size(161, 18);
            this.lblIngresarDNIUsuario.TabIndex = 6;
            this.lblIngresarDNIUsuario.Tag = "IngresarDniDeUsuarioAModificar";
            this.lblIngresarDNIUsuario.Text = "Ingrese DNI de Usuario";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(211, 64);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 18);
            this.lblDNI.TabIndex = 7;
            this.lblDNI.Tag = "Dni";
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(211, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 18);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Tag = "Nombre";
            this.lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(211, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Tag = "Email";
            this.lblEmail.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.modifyUser;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(519, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 130);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(519, 218);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(668, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblIngresarDNIUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnRecuperarUsuario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDniUsuarioATraer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarUsuario";
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.FrmModificarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDniUsuarioATraer;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnRecuperarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lblIngresarDNIUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}