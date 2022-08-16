using SGH.BE;
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

namespace SGHv1._0
{
    /// <summary>
    /// Formulario para dar de baja a un cliente
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmRegistrarBaja : Form, IObserver
    {
        Usuario usuarioSesion = Usuario.Instancia;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmRegistrarBaja"/> class.
        /// </summary>
        public FrmRegistrarBaja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Load event of the FrmRegistrarBaja control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmRegistrarBaja_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "BorrarCliente");
            helpProvider1.SetHelpKeyword(this, "BorrarCliente");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

        }
        /// <summary>
        /// Handles the Click event of the bntTraerCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void bntTraerCliente_Click(object sender, EventArgs e)
        {
            BLLCliente bLLCliente = new BLLCliente();
            List<Cliente> clientesObtenidos = bLLCliente.TraerClientes(txtDni.Text);

            foreach (var item in clientesObtenidos)
            {
                txtApellido.Text = item.Apellido;
                txtNombre.Text = item.Nombre;
                txtEdad.Text = item.Edad.ToString();
                txtEmail.Text = item.Email;
                txtTelefono.Text = item.Telefono.ToString();
            }
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
        /// Handles the Click event of the btnBorrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BLLCliente bLLCliente = new BLLCliente();
            int resultadoBaja = bLLCliente.BorrarClientes(txtDni.Text, usuarioSesion);

            if (resultadoBaja == 1)
            {
                MessageBox.Show("Se registro la baja con éxito");
            }
            else
            {
                MessageBox.Show("No se pudo registrar la baja");
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
