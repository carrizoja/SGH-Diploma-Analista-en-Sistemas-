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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGHv1._0
{
    /// <summary>
    /// Form para cambiar el idioma
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class CambiarIdioma : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CambiarIdioma"/> class.
        /// </summary>
        public CambiarIdioma()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the FrmCambiarIdioma control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmCambiarIdioma_Load(object sender, EventArgs e)
        {
            Usuario usuario = Usuario.Instancia; //manera de acceder a la unica instancia de usuario alf
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            BLLIdioma bllIdioma = new BLLIdioma();
            List<Idioma> _idiomas = new List<Idioma>();
            var _idiomasParaAgregar = bllIdioma.TraerTodosLosIdiomas();

            foreach (var item in _idiomasParaAgregar)
            {
                cmbIdiomas.Items.Add(item);
                cmbIdiomas.DisplayMember = "Nombre";
            }
        }
        /// <summary>
        /// Handles the Click event of the btnEspanol control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEspanol_Click(object sender, EventArgs e)
        {
            try
            {
                Idioma idioma = Idioma.InstanciaIdioma;
                idioma.IdIdioma = 1;
                idioma.Nombre = "Espanol";
                BLLIdioma cambiarIdioma = new BLLIdioma();
                var idiomaEspanol = cambiarIdioma.TraerControles(1);
                Form thisForm = this;
                SGH.Servicios.Traductor.CambiarIdioma(thisForm, idiomaEspanol);
                idioma.NotificarObservers();

                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = "Se cambio a español";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;
                MessageBox.Show("Se cambio a español ");
                BLLBitacora bitacoraIngles = new BLLBitacora();
                bitacoraIngles.GrabarBitacora(unaBitacora);

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
                    unaBitacora.formulario = this.Name;

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
        /// Handles the Click event of the btnIngles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnIngles_Click(object sender, EventArgs e)
        {
            try
            {
                Idioma idioma = Idioma.InstanciaIdioma;
                idioma.IdIdioma = 2;
                idioma.Nombre = "Ingles";
                BLLIdioma cambiarIdioma = new BLLIdioma();
                var idiomaIngles = cambiarIdioma.TraerControles(2);
                Form thisForm = this;
                SGH.Servicios.Traductor.CambiarIdioma(thisForm, idiomaIngles);
                idioma.NotificarObservers();

                Usuario _usuario = Usuario.Instancia;
                
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = "Se cambio a ingles";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;
                MessageBox.Show("Changed to english ");
                BLLBitacora bitacoraIngles = new BLLBitacora();
                bitacoraIngles.GrabarBitacora(unaBitacora);
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
                    unaBitacora.formulario = this.Name;

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
        /// Actualiza this instance.
        /// </summary>
        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }
        /// <summary>
        /// Cambia idioma usando observer.
        /// </summary>
        public void CambiarIdiomaUsandoObserver()

        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

        }
        /// <summary>
        /// Handles the Click event of the btnAplicar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Idioma idioma = Idioma.InstanciaIdioma;
                idioma.IdIdioma = Convert.ToInt32(lblCodIdioma.Text);
                idioma.Nombre = lblNombreDeIdioma.Text;
                BLLIdioma cambiarIdioma = new BLLIdioma();
                var idiomaAAplicar = cambiarIdioma.TraerControles(idioma.IdIdioma);
                Form thisForm = this;
                SGH.Servicios.Traductor.CambiarIdioma(thisForm, idiomaAAplicar);
                idioma.NotificarObservers();

                Usuario _usuario = Usuario.Instancia;

                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = "Se cambio a "+ lblNombreDeIdioma.Text;

                
                lblCodIdioma.Visible = false;
                lblCodigoDeIdioma.Visible = false;
                
                lblNombreDeIdioma.Visible = false;
                lblIdiomaSeleccionado.Visible = false;

                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;
                MessageBox.Show("Se cambio a " + lblNombreDeIdioma.Text);
                BLLBitacora bitacoraIngles = new BLLBitacora();
                bitacoraIngles.GrabarBitacora(unaBitacora);
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
                    unaBitacora.formulario = this.Name;

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
        /// Handles the SelectedIndexChanged event of the cmbIdiomas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idiomaSeleccionado = cmbIdiomas.Text;
            BLLIdioma bllIdioma = new BLLIdioma();
            List<Idioma> _idiomas = new List<Idioma>();
            List<Idioma> datosIdioma = bllIdioma.TraerIdiomaSeleccionado(idiomaSeleccionado);


            foreach (var item0 in datosIdioma)
            {
               
                lblCodIdioma.Text = item0.IdIdioma.ToString();
                lblCodIdioma.Visible = true;
                lblCodigoDeIdioma.Visible = true;
                lblNombreDeIdioma.Text = item0.Nombre;
                lblNombreDeIdioma.Visible = true;
                lblIdiomaSeleccionado.Visible = true;
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
