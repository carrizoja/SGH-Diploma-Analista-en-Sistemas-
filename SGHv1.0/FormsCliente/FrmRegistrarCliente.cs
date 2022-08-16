using SGH.BE.MultiIdioma;
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
using SGH.BE.Observer;
using SGH.BE.CompositePermisos;
using System.Text.RegularExpressions;
using SGH.BE;

namespace SGHv1._0
{
    /// <summary>
    /// Formulario para registrar a un cliente
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmRegistrarCliente : Form, IObserver
    {
        Usuario usuario = Usuario.Instancia; //manera de acceder a la unica instancia de usuario alf        
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmRegistrarCliente"/> class.
        /// </summary>
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Load event of the FrmRegistrarCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);



            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "RegistrarCliente");
            helpProvider1.SetHelpKeyword(this, "RegistrarCliente");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

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
        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }
        /// <summary>
        /// Cambiars the idioma usando observer.
        /// </summary>
        public void CambiarIdiomaUsandoObserver()
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
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

                if (!regex.IsMatch(txtDni.Text) || !regex.IsMatch(txtTelefono.Text) || !regex.IsMatch(txtEdad.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("El formato del mail ingresado no es válido");
                    return;
                }

                Cliente nuevoCliente = new Cliente();
                BLLCliente bLLCliente = new BLLCliente();

                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Apellido = txtApellido.Text;
                nuevoCliente.Dni = Convert.ToInt32(txtDni.Text);
                nuevoCliente.Edad = Convert.ToInt32(txtEdad.Text);
                nuevoCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
                nuevoCliente.Email = txtEmail.Text; ;


                int resultadoAlta = bLLCliente.RegistrarCliente(nuevoCliente, usuario);

                if (resultadoAlta == 1)
                {
                    MessageBox.Show("Se registro el cliente con éxito!");
                }
                if (resultadoAlta == 0)
                {
                    MessageBox.Show("Ya existe un cliente con ese Dni");
                }
                if (resultadoAlta == 2)
                {
                    MessageBox.Show("Ya existe un cliente con ese Email");
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
