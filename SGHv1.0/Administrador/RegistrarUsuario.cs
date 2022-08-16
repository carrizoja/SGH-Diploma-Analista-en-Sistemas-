using SGH.BE.MultiIdioma;
using SGH.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SGH.BE.Observer;
using SGH.BE.CompositePermisos;


namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Formulario que permite registrar un Usuario
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class RegistrarUsuario : Form, IObserver
    {
        private Usuario nuevoUsuario = new Usuario();
        Idioma idioma = Idioma.InstanciaIdioma;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrarUsuario"/> class.
        /// </summary>
        public RegistrarUsuario()
        {
            InitializeComponent();
            idioma.RegistrarObserver(this);
        }
        /// <summary>
        /// Handles the Load event of the RegistrarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
            txtPassword.PasswordChar = '*';
            txtRepPassword.PasswordChar = '*';
        }
        /// <summary>
        /// Handles the Click event of the btnAceptar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                Regex regex = new Regex("^[0-9]*$");

                foreach (Control con in this.Controls)
                {
                    if (con is TextBox)
                    {
                        TextBox textBox = con as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            MessageBox.Show("Por favor, completar todos los campos");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtDNI.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("El formato del mail ingresado no es válido");
                    return;
                }

                nuevoUsuario.IdUsuario = Guid.NewGuid();
                nuevoUsuario.Nombre = txtNombre.Text;
                nuevoUsuario.Dni = txtDNI.Text;
                nuevoUsuario.Email = txtEmail.Text;

                MD5 md5Hash = MD5.Create();
                nuevoUsuario.Clave = Framework.Carrizo.Encriptadores.Encriptador.RealizarMd5Hash(md5Hash, txtPassword.Text);

                if (txtPassword.Text != txtRepPassword.Text)
                {
                    MessageBox.Show("No se registro el Usuario.Las dos contraseñas ingresadas deben ser iguales");
                    return;
                }

                SGH.BLL.BLLUsuario registrarUsuario = new SGH.BLL.BLLUsuario();

                int resultadoAlta = registrarUsuario.RegistrarUsuario(nuevoUsuario);

                if (resultadoAlta == 1)
                {
                    MessageBox.Show("Se registró el Usuario con éxito");

                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.UtcNow;
                    unaBitacora.descripcion = "Usuario dado de alta";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;
                    
                    BLLBitacora bitacoraIngles = new BLLBitacora();
                    bitacoraIngles.GrabarBitacora(unaBitacora);
                }
                if (resultadoAlta == 0)
                {
                    MessageBox.Show("Ya hay un usuario con ése Dni.");
                }
                if (resultadoAlta == 2)
                {
                    MessageBox.Show("Ya hay un usuario con ése Mail");
                }

            }
            catch (Exception ex)
            {
                try
                {
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = ex.Message;
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);
                }
                catch (Exception ax)
                {
                    MessageBox.Show(ax.Data.ToString());
                }


                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Determines whether [is valid email] [the specified string in].
        /// </summary>
        /// <param name="strIn">The string in.</param>
        /// <returns>
        ///   <c>true</c> if [is valid email] [the specified string in]; otherwise, <c>false</c>.
        /// </returns>
        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        /// <summary>
        /// Actualizars this instance.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Actualizar()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Handles the FormClosing event of the FrmRegistrarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void FrmRegistrarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            idioma.SacarRegistroObserver(this);
        }
        /// <summary>
        /// Handles the Click event of the btnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

