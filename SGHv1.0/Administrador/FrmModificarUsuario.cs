using SGH.BE.CompositePermisos;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
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

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Formulario para modificar el Usuario
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmModificarUsuario : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmModificarUsuario"/> class.
        /// </summary>
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the FrmModificarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            btnModificarUsuario.Enabled = false;
        }
        /// <summary>
        /// Handles the Click event of the btnRecuperarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRecuperarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                BLLUsuario bLLUsuario = new BLLUsuario();
                List<Usuario> usuarioObtenido = bLLUsuario.TraerUsuarioParaLogin(txtDniUsuarioATraer.Text);

                foreach (var item in usuarioObtenido)
                {
                    txtNombre.Text = item.Nombre;
                    txtDni.Text = item.Dni;
                    txtEmail.Text = item.Email;
                }

                btnModificarUsuario.Enabled = true;
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
        /// Handles the TextChanged event of the txtDniUsuarioATraer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtDniUsuarioATraer_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnModificarUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificarUsuario_Click(object sender, EventArgs e)
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

            if (!regex.IsMatch(txtDni.Text))
            {
                MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                return;
            }

            BLLUsuario bLLUsuario = new BLLUsuario();
            Usuario unUsuarioModificado = new Usuario();
            unUsuarioModificado.Dni = txtDni.Text;
            unUsuarioModificado.Nombre = txtNombre.Text;
            unUsuarioModificado.Email = txtEmail.Text;
            int resultadoModificacion = bLLUsuario.ModificarUsuario(unUsuarioModificado, txtDniUsuarioATraer.Text);

            if (resultadoModificacion == 1)
            {
                MessageBox.Show("Se actualizó el usuario con éxito");
                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.UtcNow;
                unaBitacora.descripcion = "Usuario modificado exitosamente";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;

                BLLBitacora bitacoraIngles = new BLLBitacora();
                bitacoraIngles.GrabarBitacora(unaBitacora);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario");
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
    }
}
