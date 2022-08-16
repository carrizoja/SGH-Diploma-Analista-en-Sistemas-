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
using SGH.BE.MultiIdioma;
using System.Text.RegularExpressions;
using SGH.BE;
using DevExpress.XtraExport.Helpers;
using SGH.BE.CompositePermisos;

namespace SGHv1._0.FormsHabitacion
{
    /// <summary>
    /// Formulario para la Administración de las Habitaciones
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class AdministracionHabitaciones : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministracionHabitaciones"/> class.
        /// </summary>
        public AdministracionHabitaciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Load event of the AdministracionHabitaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AdministracionHabitaciones_Load(object sender, EventArgs e)
        {

            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "AdministraciondeHabitaciones");
            helpProvider1.SetHelpKeyword(this, "AdministraciondeHabitaciones");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            try
            {
                LimpiarFormulario();
                BLLHabitacion bLLHabitacion = new BLLHabitacion();
                
                dgvHabitaciones.DataSource = bLLHabitacion.TraerTodasLasHabitaciones();
                dgvHabitaciones.Columns[0].Visible = false;
                dgvHabitaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                rbSi.Checked = true;
                BLLIdioma _traduccion = new BLLIdioma();
                Idioma idioma = Idioma.InstanciaIdioma;
                Form form = this;
                _traduccion.Traducir(idioma.IdIdioma, form);

                BLLTipoHabitacion bLLTipoHabitacion = new BLLTipoHabitacion();
                List<TipoHabitacion> _tipoHabitaciones = new List<TipoHabitacion>();
                var _tipoHabsParaAgregar = bLLTipoHabitacion.TraerTodosTiposhabitacion();

                foreach (var item in _tipoHabsParaAgregar)
                {
                    cmbTipoHabitacion.Items.Add(item);
                    cmbTipoHabitacion.DisplayMember = "Tipo";
                }
                BLLCategoriaHabitacion bLLCategoriaHabitacion = new BLLCategoriaHabitacion();
                List<CategoriaHabitacion> _categoriaHabitaciones = new List<CategoriaHabitacion>();
                var _categoriaHabsParaAgregar = bLLCategoriaHabitacion.TraerTodasCategoriashabitacion();

                foreach (var item in _categoriaHabsParaAgregar)
                {
                    cmbCategoriaHabitacion.Items.Add(item);
                    cmbCategoriaHabitacion.DisplayMember = "Categoria";
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
        /// Limpia formulario.
        /// </summary>
        public void LimpiarFormulario()
        {
            txtNumeroHab.Text = "";
            rbSi.Checked = true;
            txtPrecio.Text = "";
            btnEditarHabitacion.Enabled = false;
            btnEliminarHabitacion.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }


        /// <summary>
        /// Actualiza this instance.
        /// </summary>
        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }
        /// <summary>
        /// Cambiar idioma usando observer.
        /// </summary>
        public void CambiarIdiomaUsandoObserver()

        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

        }
        /// <summary>
        /// Handles the Click event of the btnAgregarNuevaHabitacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAgregarNuevaHabitacion_Click(object sender, EventArgs e)
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
                    if (con is ComboBox)
                    {
                        ComboBox comboBox = con as ComboBox;
                        if (comboBox.SelectedItem == null)
                        {
                            MessageBox.Show("No ha elegido el Tipo y/o Categoría de Habitación");
                            return;
                        }

                    }
                    if (con is RadioButton)
                    {
                        RadioButton radioButton = con as RadioButton;
                        if ((!radioButton.Checked == rbNo.Checked) && (!radioButton.Checked == rbSi.Checked) )
                        {
                            MessageBox.Show("No ha seleccionado el estado de la habitación");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtNumeroHab.Text) || !regex.IsMatch(txtPrecio.Text) )
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                Habitacion nuevaHabitacion = new Habitacion();
                BLLHabitacion bLLHabitacion = new BLLHabitacion();
                nuevaHabitacion.Numero = txtNumeroHab.Text;
                nuevaHabitacion.Precio = Convert.ToInt32(txtPrecio.Text);

                nuevaHabitacion.Tipo = cmbTipoHabitacion.GetItemText(this.cmbTipoHabitacion.SelectedItem);

                nuevaHabitacion.Categoria = cmbCategoriaHabitacion.GetItemText(this.cmbCategoriaHabitacion.SelectedItem);

                if (rbSi.Checked == true)
                {
                    nuevaHabitacion.EstadoHabitacion = "libre";
                }
                else nuevaHabitacion.EstadoHabitacion = "ocupada";

                int resultadoAltaHab = bLLHabitacion.RegistrarHabitacion(nuevaHabitacion);

                if (resultadoAltaHab == 1)
                {
                    MessageBox.Show("Habitación cargada exitosamente");
                    LimpiarFormulario();
                }
                if (resultadoAltaHab == 0)
                {
                    MessageBox.Show("Ya existe una habitación con ese número");
                }
                dgvHabitaciones.DataSource = bLLHabitacion.TraerTodasLasHabitaciones();

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
        /// Handles the SelectedIndexChanged event of the cmbTipoHabitacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoHabitacionSeleccionada = cmbTipoHabitacion.Text;
            BLLHabitacion bllHabitacion = new BLLHabitacion();
            List<TipoHabitacion> _tipoHab = new List<TipoHabitacion>();
        //    List<TipoHabitacion> datosTipoHab = bllHabitacion.TraerTodosLosTiposHabitacion(tipoHabitacionSeleccionada);
        }
        /// <summary>
        /// Handles the Click event of the btnLimpiarCampos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNumeroHab.Text = "";
            txtPrecio.Text = "";
            cmbCategoriaHabitacion.SelectedIndex = 0;
            cmbTipoHabitacion.SelectedIndex = 0;
            rbSi.Checked = false;
            rbNo.Checked = false;
        }
        /// <summary>
        /// Handles the Click event of the btnEditar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditar_Click(object sender, EventArgs e)
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
                    if (con is ComboBox)
                    {
                        ComboBox comboBox = con as ComboBox;
                        if (comboBox.SelectedItem == null)
                        {
                            MessageBox.Show("No ha elegido el Tipo y/o Categoría de Habitación");
                            return;
                        }

                    }
                    if (con is RadioButton)
                    {
                        RadioButton radioButton = con as RadioButton;
                        if ((!radioButton.Checked == rbNo.Checked) && (!radioButton.Checked == rbSi.Checked))
                        {
                            MessageBox.Show("No ha seleccionado el estado de la habitación");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtNumeroHab.Text) || !regex.IsMatch(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                Habitacion nuevaHabitacion = new Habitacion();
                BLLHabitacion bLLHabitacion = new BLLHabitacion();
                
                nuevaHabitacion.IdHabitacion = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells[0].Value);
                nuevaHabitacion.Numero = txtNumeroHab.Text;
                nuevaHabitacion.Precio = Convert.ToInt32(txtPrecio.Text);

                nuevaHabitacion.Tipo = cmbTipoHabitacion.GetItemText(this.cmbTipoHabitacion.SelectedItem);

                nuevaHabitacion.Categoria = cmbCategoriaHabitacion.GetItemText(this.cmbCategoriaHabitacion.SelectedItem);

                if (rbSi.Checked == true)
                {
                    nuevaHabitacion.EstadoHabitacion = "libre";
                }
                else nuevaHabitacion.EstadoHabitacion = "ocupada";

                int resultadoAltaHab = bLLHabitacion.ModificarHabitacion(nuevaHabitacion);

                if (resultadoAltaHab == 1)
                {
                    MessageBox.Show("Habitación modificada exitosamente");
                    LimpiarFormulario();
                }
                if (resultadoAltaHab == 0)
                {
                    MessageBox.Show("Hubo un problema al querer modificar la habitación");
                }
                dgvHabitaciones.DataSource = bLLHabitacion.TraerTodasLasHabitaciones();

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
        /// Handles the Click event of the btnEliminarHabitacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminarHabitacion_Click(object sender, EventArgs e)
        {   
            try
            {
                int IdHab = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells[0].Value);
                BLLHabitacion bLLHabitacion = new BLLHabitacion();
                int resultadoBorradoHab = bLLHabitacion.BorrarHabitacion(IdHab);
                if (resultadoBorradoHab == 1)
                {
                    MessageBox.Show("Se ha borrado la Habitación de forma exitosa");
                    LimpiarFormulario();
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Eliminación de Habitación";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);

                    dgvHabitaciones.DataSource = bLLHabitacion.TraerTodasLasHabitaciones();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al querer borrar la Habitación");
                }

            }
            catch (Exception ex)

            {
                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = ex.Message;
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                var bllBitacora = new SGH.BLL.BLLBitacora();
                bllBitacora.GrabarBitacora(unaBitacora);
                MessageBox.Show(ex.Data.ToString());

            }
          
            
        }
        /// <summary>
        /// Handles the CellContentClick event of the dgvHabitaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumeroHab.Text = dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvHabitaciones.CurrentRow.Cells[4].Value.ToString();
            btnEditarHabitacion.Enabled = true;
            btnEliminarHabitacion.Enabled = true;
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
