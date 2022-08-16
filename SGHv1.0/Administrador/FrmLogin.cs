using SGH.BE.CompositePermisos;
using SGH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE.MultiIdioma;

namespace SGHv1._0
{
    /// <summary>
    /// Form para el Login
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmLogin : Form
    {
        private TextBox TxtDNI;
        private TextBox TxtPassword;
        private Label LblDNI;
        private Label LblPassword;
        private Button BtnIngresar;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmLogin"/> class.
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        /*  private void InitializeComponent()
          {
              System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
              this.TxtDNI = new System.Windows.Forms.TextBox();
              this.TxtPassword = new System.Windows.Forms.TextBox();
              this.LblDNI = new System.Windows.Forms.Label();
              this.LblPassword = new System.Windows.Forms.Label();
              this.BtnIngresar = new System.Windows.Forms.Button();
              this.SuspendLayout();
              // 
              // textBox1
              // 
              this.TxtDNI.Location = new System.Drawing.Point(382, 58);
              this.TxtDNI.Name = "textBox1";
              this.TxtDNI.Size = new System.Drawing.Size(100, 20);
              this.TxtDNI.TabIndex = 0;
              // 
              // textBox2
              // 
              this.TxtPassword.Location = new System.Drawing.Point(588, 58);
              this.TxtPassword.Name = "textBox2";
              this.TxtPassword.Size = new System.Drawing.Size(100, 20);
              this.TxtPassword.TabIndex = 1;
              // 
              // LblDNI
              // 
              this.LblDNI.AutoSize = true;
              this.LblDNI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
              this.LblDNI.Location = new System.Drawing.Point(379, 19);
              this.LblDNI.Name = "LblDNI";
              this.LblDNI.Size = new System.Drawing.Size(26, 13);
              this.LblDNI.TabIndex = 2;
              this.LblDNI.Text = "DNI";
              // 
              // LblPassword
              // 
              this.LblPassword.AutoSize = true;
              this.LblPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
              this.LblPassword.Location = new System.Drawing.Point(585, 19);
              this.LblPassword.Name = "LblPassword";
              this.LblPassword.Size = new System.Drawing.Size(53, 13);
              this.LblPassword.TabIndex = 3;
              this.LblPassword.Text = "Password";
              // 
              // BtnIngresar
              // 
              this.BtnIngresar.Location = new System.Drawing.Point(588, 132);
              this.BtnIngresar.Name = "BtnIngresar";
              this.BtnIngresar.Size = new System.Drawing.Size(88, 28);
              this.BtnIngresar.TabIndex = 4;
              this.BtnIngresar.Text = "Ingresar";
              this.BtnIngresar.UseVisualStyleBackColor = true;
              this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
              // 
              // FrmLogin
              // 
              this.BackColor = System.Drawing.SystemColors.ButtonShadow;
              this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
              this.ClientSize = new System.Drawing.Size(719, 423);
              this.Controls.Add(this.BtnIngresar);
              this.Controls.Add(this.LblPassword);
              this.Controls.Add(this.LblDNI);
              this.Controls.Add(this.TxtPassword);
              this.Controls.Add(this.TxtDNI);
              this.Name = "FrmLogin";
              this.ResumeLayout(false);
              this.PerformLayout();

          }
          */

        /// <summary>
        /// Handles the Click event of the BtnIngresar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                BLLUsuario bLLUsuario = new BLLUsuario();

                Boolean resultado;

                usuario.Dni = TxtDNI.Text;
                usuario.Clave = TxtPassword.Text;

                resultado = bLLUsuario.IniciarSesion(usuario);

                if (resultado)
                {
                    var permisos = bLLUsuario.TraerPermisoSimplesPorDni(usuario.Dni);
                    foreach (var item in permisos)
                    {
                        usuario = Usuario.Instancia;
                        usuario.Permisos.Add(item);
                    }

                    List<Usuario> datosUsuario = bLLUsuario.TraerUsuarioParaLogin(TxtDNI.Text);

                    foreach (var item0 in datosUsuario)
                    {
                        usuario.Dni = item0.Dni;
                        usuario.Email = item0.Email;
                        usuario.IdUsuario = item0.IdUsuario;
                        usuario.Nombre = item0.Nombre;
                    }

                    Idioma idioma = new Idioma();
                    idioma = Idioma.InstanciaIdioma;
                    idioma.IdIdioma = 1;
                    idioma.Nombre = "Espanol";

                    BLLDv dvIntegridadUsuario = new BLLDv();
                    List<Usuario> resultadoUsuarios = bLLUsuario.TraerTodosLosUsuarios();
                    foreach (var item in resultadoUsuarios)
                    {
                        if (!dvIntegridadUsuario.CalcularDigitoVerificadorHorizontalUsuario(item))
                        {
                            MessageBox.Show("Un dato fue modificado desde la base");
                            return;
                        }
                        else if (!dvIntegridadUsuario.CalcularDigitoVerificadorVertical())
                        {
                            MessageBox.Show("Un registro fue borrado de la base");
                            return;
                        }
                    }

                    MessageBox.Show("Bienvenido a SGH ",usuario.Nombre); //aca se agregan los permisos
                    FrmMenuPrincipal frm = new FrmMenuPrincipal();
                    frm.Show();
                    this.Hide();

               //    BLLBitacora bitacora = new BLLBitacora();
                //   bitacora.GrabarBitacora();
                }
                else
                {
                    MessageBox.Show("Ingreso incorrecto de Contraseña o Dni"); 
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Load event of the FrmLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = '*';
        }
        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Environment.Exit(0);
        }
        /// <summary>
        /// Handles the Click event of the sbtnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sbtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Environment.Exit(0);
        }
    }
}
