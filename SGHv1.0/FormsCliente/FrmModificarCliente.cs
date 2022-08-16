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
using SGH.BE;
using SGH.BE.CompositePermisos;
using System.Text.RegularExpressions;

namespace SGHv1._0
{
    /// <summary>
    /// Formulario para modificar a un cliente
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmModificarCliente : Form, IObserver
    {
        Cliente nuevoCliente = new Cliente();
        Usuario usuarioSesion = Usuario.Instancia;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmModificarCliente"/> class.
        /// </summary>
        public FrmModificarCliente()
        {
            InitializeComponent();
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
        /// Handles the Load event of the FrmModificarCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "ModificarCliente1");
            helpProvider1.SetHelpKeyword(this, "ModificarCliente1");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }
        /// <summary>
        /// Handles the Click event of the btnTraerCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            try
            {
                BLLCliente bLLCliente = new BLLCliente();
                List<Cliente> clientesObtenidos = bLLCliente.TraerClientes(txtDni.Text);

                foreach (var item in clientesObtenidos)
                {
                    nuevoCliente.Dni = item.Dni;
                    nuevoCliente.Apellido = item.Apellido;
                    nuevoCliente.Nombre = item.Nombre;
                    nuevoCliente.Edad = item.Edad;
                    nuevoCliente.Email = item.Email;
                    nuevoCliente.Telefono = item.Telefono;

                    txtApellido.Text = item.Apellido;
                    txtNombre.Text = item.Nombre;
                    txtEdad.Text = item.Edad.ToString();
                    txtEmail.Text = item.Email;
                    txtTelefono.Text = item.Telefono.ToString();
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
        /// Handles the Click event of the btnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificar_Click(object sender, EventArgs e)
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

                if (!regex.IsMatch(txtTelefono.Text) || !regex.IsMatch(txtEdad.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }


                BLLCliente bLLCliente = new BLLCliente();
                Cliente unNuevoClienteModificado = new Cliente();
                unNuevoClienteModificado.Dni = Convert.ToInt32(txtDni.Text);
                unNuevoClienteModificado.Apellido = txtApellido.Text;
                unNuevoClienteModificado.Nombre = txtNombre.Text;
                unNuevoClienteModificado.Edad = Convert.ToInt32(txtEdad.Text);
                unNuevoClienteModificado.Email = txtEmail.Text;
                unNuevoClienteModificado.Telefono = Convert.ToInt32(txtTelefono.Text);
                int resultadoModificacion = bLLCliente.ModificarClientes(unNuevoClienteModificado, nuevoCliente.Dni.ToString(), usuarioSesion);

                if (resultadoModificacion == 1)
                {
                    MessageBox.Show("Se actualizó el cliente con éxito");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente");
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
