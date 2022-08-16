namespace SGHv1._0.Administrador
{
    partial class FrmlistarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmlistarUsuarios));
            this.listUsuarios = new System.Windows.Forms.ListView();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUsuarios
            // 
            this.listUsuarios.HideSelection = false;
            this.listUsuarios.Location = new System.Drawing.Point(68, 60);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(518, 202);
            this.listUsuarios.TabIndex = 0;
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaUsuarios.Location = new System.Drawing.Point(255, 9);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(140, 18);
            this.lblListaUsuarios.TabIndex = 1;
            this.lblListaUsuarios.Tag = "Usuarios";
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // FrmlistarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(639, 286);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.listUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmlistarUsuarios";
            this.Text = "Listar Usuarios";
            this.Load += new System.EventHandler(this.FrmlistarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listUsuarios;
        private System.Windows.Forms.Label lblListaUsuarios;
    }
}