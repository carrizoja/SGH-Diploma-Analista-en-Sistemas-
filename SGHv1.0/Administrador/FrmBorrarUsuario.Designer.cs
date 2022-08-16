namespace SGHv1._0.Administrador
{
    partial class FrmBorrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrarUsuario));
            this.listBorrarUsuario = new System.Windows.Forms.ListView();
            this.btnBorrarUsuario = new System.Windows.Forms.Button();
            this.lblListadoDeUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBorrarUsuario
            // 
            this.listBorrarUsuario.HideSelection = false;
            this.listBorrarUsuario.Location = new System.Drawing.Point(12, 57);
            this.listBorrarUsuario.Name = "listBorrarUsuario";
            this.listBorrarUsuario.Size = new System.Drawing.Size(484, 253);
            this.listBorrarUsuario.TabIndex = 0;
            this.listBorrarUsuario.UseCompatibleStateImageBehavior = false;
            this.listBorrarUsuario.SelectedIndexChanged += new System.EventHandler(this.listBorrarUsuario_SelectedIndexChanged);
            // 
            // btnBorrarUsuario
            // 
            this.btnBorrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUsuario.Location = new System.Drawing.Point(597, 213);
            this.btnBorrarUsuario.Name = "btnBorrarUsuario";
            this.btnBorrarUsuario.Size = new System.Drawing.Size(111, 33);
            this.btnBorrarUsuario.TabIndex = 1;
            this.btnBorrarUsuario.Tag = "Borrar";
            this.btnBorrarUsuario.Text = "Borrar";
            this.btnBorrarUsuario.UseVisualStyleBackColor = true;
            this.btnBorrarUsuario.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // lblListadoDeUsuarios
            // 
            this.lblListadoDeUsuarios.AutoSize = true;
            this.lblListadoDeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoDeUsuarios.Location = new System.Drawing.Point(171, 9);
            this.lblListadoDeUsuarios.Name = "lblListadoDeUsuarios";
            this.lblListadoDeUsuarios.Size = new System.Drawing.Size(159, 18);
            this.lblListadoDeUsuarios.TabIndex = 2;
            this.lblListadoDeUsuarios.Tag = "Usuarios";
            this.lblListadoDeUsuarios.Text = "Listado de Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SGHv1._0.Properties.Resources.borrarUsuario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(575, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(597, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Tag = "Salir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmBorrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(738, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblListadoDeUsuarios);
            this.Controls.Add(this.btnBorrarUsuario);
            this.Controls.Add(this.listBorrarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBorrarUsuario";
            this.Text = "Borrar Usuario";
            this.Load += new System.EventHandler(this.FrmBorrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listBorrarUsuario;
        private System.Windows.Forms.Button btnBorrarUsuario;
        private System.Windows.Forms.Label lblListadoDeUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}