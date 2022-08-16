namespace SGHv1._0.Administrador
{
    partial class Roles
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.bntAceptar = new System.Windows.Forms.Button();
            this.txtAgregarPermisoSimple = new System.Windows.Forms.Button();
            this.lstPermisosSimples2 = new System.Windows.Forms.ListView();
            this.lstPermisosAsignados = new System.Windows.Forms.ListView();
            this.lstPermisosSimples = new System.Windows.Forms.ListView();
            this.comboBoxPermisosCompuestos = new System.Windows.Forms.ComboBox();
            this.btnCambioRolusuario = new System.Windows.Forms.Button();
            this.lblIngreseDniusuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPermisosSimplesParaAgregar = new System.Windows.Forms.Label();
            this.lblRolesConPermisosCmpuestos = new System.Windows.Forms.Label();
            this.lblListaPermisosRolSelect = new System.Windows.Forms.Label();
            this.lblPermisosAsignados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(32, 48);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(124, 24);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextChanged += new System.EventHandler(this.TxtDni_TextChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(387, 48);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(145, 24);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.TxtNombreUsuario_TextChanged);
            // 
            // bntAceptar
            // 
            this.bntAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAceptar.Location = new System.Drawing.Point(32, 90);
            this.bntAceptar.Name = "bntAceptar";
            this.bntAceptar.Size = new System.Drawing.Size(100, 35);
            this.bntAceptar.TabIndex = 2;
            this.bntAceptar.Tag = "Aceptar";
            this.bntAceptar.Text = "Aceptar";
            this.bntAceptar.UseVisualStyleBackColor = true;
            this.bntAceptar.Click += new System.EventHandler(this.bntAceptar_Click);
            // 
            // txtAgregarPermisoSimple
            // 
            this.txtAgregarPermisoSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarPermisoSimple.Location = new System.Drawing.Point(32, 153);
            this.txtAgregarPermisoSimple.Name = "txtAgregarPermisoSimple";
            this.txtAgregarPermisoSimple.Size = new System.Drawing.Size(124, 55);
            this.txtAgregarPermisoSimple.TabIndex = 3;
            this.txtAgregarPermisoSimple.Tag = "AgregarPermisoSimple";
            this.txtAgregarPermisoSimple.Text = "Agregar Permiso Simple";
            this.txtAgregarPermisoSimple.UseVisualStyleBackColor = true;
            this.txtAgregarPermisoSimple.Click += new System.EventHandler(this.txtAgregarPermisoSimple_Click);
            // 
            // lstPermisosSimples2
            // 
            this.lstPermisosSimples2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPermisosSimples2.HideSelection = false;
            this.lstPermisosSimples2.Location = new System.Drawing.Point(285, 128);
            this.lstPermisosSimples2.Name = "lstPermisosSimples2";
            this.lstPermisosSimples2.Size = new System.Drawing.Size(350, 114);
            this.lstPermisosSimples2.TabIndex = 4;
            this.lstPermisosSimples2.UseCompatibleStateImageBehavior = false;
            // 
            // lstPermisosAsignados
            // 
            this.lstPermisosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPermisosAsignados.HideSelection = false;
            this.lstPermisosAsignados.Location = new System.Drawing.Point(700, 48);
            this.lstPermisosAsignados.Name = "lstPermisosAsignados";
            this.lstPermisosAsignados.Size = new System.Drawing.Size(357, 402);
            this.lstPermisosAsignados.TabIndex = 5;
            this.lstPermisosAsignados.UseCompatibleStateImageBehavior = false;
            this.lstPermisosAsignados.SelectedIndexChanged += new System.EventHandler(this.LstPermisosAsignados_SelectedIndexChanged);
            // 
            // lstPermisosSimples
            // 
            this.lstPermisosSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPermisosSimples.HideSelection = false;
            this.lstPermisosSimples.Location = new System.Drawing.Point(285, 285);
            this.lstPermisosSimples.Name = "lstPermisosSimples";
            this.lstPermisosSimples.Size = new System.Drawing.Size(350, 154);
            this.lstPermisosSimples.TabIndex = 5;
            this.lstPermisosSimples.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxPermisosCompuestos
            // 
            this.comboBoxPermisosCompuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPermisosCompuestos.FormattingEnabled = true;
            this.comboBoxPermisosCompuestos.Location = new System.Drawing.Point(32, 295);
            this.comboBoxPermisosCompuestos.Name = "comboBoxPermisosCompuestos";
            this.comboBoxPermisosCompuestos.Size = new System.Drawing.Size(158, 26);
            this.comboBoxPermisosCompuestos.TabIndex = 7;
            this.comboBoxPermisosCompuestos.SelectedIndexChanged += new System.EventHandler(this.comboBoxPermisosCompuestos_SelectedIndexChanged);
            // 
            // btnCambioRolusuario
            // 
            this.btnCambioRolusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioRolusuario.Location = new System.Drawing.Point(32, 375);
            this.btnCambioRolusuario.Name = "btnCambioRolusuario";
            this.btnCambioRolusuario.Size = new System.Drawing.Size(121, 54);
            this.btnCambioRolusuario.TabIndex = 8;
            this.btnCambioRolusuario.Tag = "CambioRolUsuario";
            this.btnCambioRolusuario.Text = "Cambio Rol Usuario";
            this.btnCambioRolusuario.UseVisualStyleBackColor = true;
            this.btnCambioRolusuario.Click += new System.EventHandler(this.btnCambioRolusuario_Click);
            // 
            // lblIngreseDniusuario
            // 
            this.lblIngreseDniusuario.AutoSize = true;
            this.lblIngreseDniusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseDniusuario.Location = new System.Drawing.Point(32, 13);
            this.lblIngreseDniusuario.Name = "lblIngreseDniusuario";
            this.lblIngreseDniusuario.Size = new System.Drawing.Size(141, 18);
            this.lblIngreseDniusuario.TabIndex = 9;
            this.lblIngreseDniusuario.Tag = "IngresarDniUsuario";
            this.lblIngreseDniusuario.Text = "Ingrese DNI Usuario";
            this.lblIngreseDniusuario.Click += new System.EventHandler(this.LblIngreseDniusuario_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(422, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Tag = "Usuario";
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            // 
            // lblPermisosSimplesParaAgregar
            // 
            this.lblPermisosSimplesParaAgregar.AutoSize = true;
            this.lblPermisosSimplesParaAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisosSimplesParaAgregar.Location = new System.Drawing.Point(351, 90);
            this.lblPermisosSimplesParaAgregar.Name = "lblPermisosSimplesParaAgregar";
            this.lblPermisosSimplesParaAgregar.Size = new System.Drawing.Size(211, 18);
            this.lblPermisosSimplesParaAgregar.TabIndex = 11;
            this.lblPermisosSimplesParaAgregar.Tag = "PermisosSimplesParaAgregar";
            this.lblPermisosSimplesParaAgregar.Text = "Permisos Simple Para Agregar";
            // 
            // lblRolesConPermisosCmpuestos
            // 
            this.lblRolesConPermisosCmpuestos.AutoSize = true;
            this.lblRolesConPermisosCmpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolesConPermisosCmpuestos.Location = new System.Drawing.Point(32, 254);
            this.lblRolesConPermisosCmpuestos.Name = "lblRolesConPermisosCmpuestos";
            this.lblRolesConPermisosCmpuestos.Size = new System.Drawing.Size(234, 18);
            this.lblRolesConPermisosCmpuestos.TabIndex = 12;
            this.lblRolesConPermisosCmpuestos.Tag = "RolesConPermisosCompuestos";
            this.lblRolesConPermisosCmpuestos.Text = "Roles con Permisos Compuestos";
            // 
            // lblListaPermisosRolSelect
            // 
            this.lblListaPermisosRolSelect.AutoSize = true;
            this.lblListaPermisosRolSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPermisosRolSelect.Location = new System.Drawing.Point(282, 254);
            this.lblListaPermisosRolSelect.Name = "lblListaPermisosRolSelect";
            this.lblListaPermisosRolSelect.Size = new System.Drawing.Size(368, 18);
            this.lblListaPermisosRolSelect.TabIndex = 13;
            this.lblListaPermisosRolSelect.Tag = "ListaDePermisosQuePertenecenAlRolSeleccionado";
            this.lblListaPermisosRolSelect.Text = "Lista de Permisos que Pertenecen al Rol seleccionado";
            // 
            // lblPermisosAsignados
            // 
            this.lblPermisosAsignados.AutoSize = true;
            this.lblPermisosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisosAsignados.Location = new System.Drawing.Point(796, 13);
            this.lblPermisosAsignados.Name = "lblPermisosAsignados";
            this.lblPermisosAsignados.Size = new System.Drawing.Size(145, 18);
            this.lblPermisosAsignados.TabIndex = 14;
            this.lblPermisosAsignados.Tag = "PermisosAsignados";
            this.lblPermisosAsignados.Text = "Permisos Asignados";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1084, 493);
            this.Controls.Add(this.lblPermisosAsignados);
            this.Controls.Add(this.lblListaPermisosRolSelect);
            this.Controls.Add(this.lblRolesConPermisosCmpuestos);
            this.Controls.Add(this.lblPermisosSimplesParaAgregar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIngreseDniusuario);
            this.Controls.Add(this.btnCambioRolusuario);
            this.Controls.Add(this.comboBoxPermisosCompuestos);
            this.Controls.Add(this.lstPermisosSimples);
            this.Controls.Add(this.lstPermisosAsignados);
            this.Controls.Add(this.lstPermisosSimples2);
            this.Controls.Add(this.txtAgregarPermisoSimple);
            this.Controls.Add(this.bntAceptar);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtDni);
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button bntAceptar;
        private System.Windows.Forms.Button txtAgregarPermisoSimple;
        private System.Windows.Forms.ListView lstPermisosSimples2;
        private System.Windows.Forms.ListView lstPermisosAsignados;
        private System.Windows.Forms.ListView lstPermisosSimples;
        private System.Windows.Forms.ComboBox comboBoxPermisosCompuestos;
        private System.Windows.Forms.Button btnCambioRolusuario;
        private System.Windows.Forms.Label lblIngreseDniusuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPermisosSimplesParaAgregar;
        private System.Windows.Forms.Label lblRolesConPermisosCmpuestos;
        private System.Windows.Forms.Label lblListaPermisosRolSelect;
        private System.Windows.Forms.Label lblPermisosAsignados;
    }
}