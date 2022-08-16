using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BLL;
using SGH.BE;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
using SGH.BE.CompositePermisos;
using System.Security.AccessControl;
using Org.BouncyCastle.Asn1.Cmp;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto.Engines;

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Formulario para el ABM de idiomas
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class GUIIdiomas : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        BLLIdioma bl = new BLLIdioma();

        /// <summary>
        /// Initializes a new instance of the <see cref="GUIIdiomas"/> class.
        /// </summary>
        public GUIIdiomas()
        {
            InitializeComponent();
            idioma.RegistrarObserver(this);
        }
        /// <summary>
        /// Actualizars this instance.
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
        /// Handles the Click event of the btnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handles the Load event of the GUIIdiomas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GUIIdiomas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGHDataSet.Palabra' table. You can move, or remove it, as needed.
            this.palabraTableAdapter1.Fill(this.sGHDataSet.Palabra);
            // TODO: This line of code loads data into the 'sGHDataSetPalabra.Palabra' table. You can move, or remove it, as needed.
            this.palabraTableAdapter.Fill(this.sGHDataSetPalabra.Palabra);


            try
            {
                BLLIdioma _traduccion = new BLLIdioma();
                dgvPalabras.DataSource = _traduccion.TraerTodasLasPalabras();
                //dgvPalabras.AutoResizeColumns();
                dgvPalabras.Columns[0].Visible = false;
                dgvPalabras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                Idioma idioma = Idioma.InstanciaIdioma;
                Form form = this;
                _traduccion.Traducir(idioma.IdIdioma, form);

                BLLIdioma bllIdioma = new BLLIdioma();
                List<Idioma> _idiomas = new List<Idioma>();
                var _idiomasParaAgregar = bllIdioma.TraerTodosLosIdiomas();

                foreach (var item in _idiomasParaAgregar)
                {
                    cmbListarIdiomas.Items.Add(item);
                    cmbListarIdiomas.DisplayMember = "Nombre";
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
        /// Handles the SelectedIndexChanged event of the comboBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idiomaSeleccionado = cmbListarIdiomas.Text;
            BLLIdioma bllIdioma = new BLLIdioma();
          //  List<Idioma> _idiomas = new List<Idioma>();
            List<Idioma> datosIdioma = bllIdioma.TraerIdiomaSeleccionado(idiomaSeleccionado);

           
            foreach (var item0 in datosIdioma)
            {
                
                lblIdiomaSeleccionado.Text = item0.Nombre;
                lblIdiomaSeleccionado.Visible = true;
                lblIdiomaCodigoSeleccionado.Text = item0.IdIdioma.ToString();
                lblIdiomaCodigoSeleccionado.Visible = true;
            }
            int idIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
            dgvTraduccion.DataSource = bllIdioma.ObtenerTraduccionesIdioma(idIdioma);
            dgvTraduccion.AutoResizeColumns();
            dgvTraduccion.Columns[1].Visible = false;
            dgvTraduccion.Columns[0].Visible = false;
            dgvTraduccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnRefrescarDgvTraducciones.Enabled = true;
        }

        private void txtIdioma_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnAgregarIdioma control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            Idioma unNuevoIdioma = new Idioma();
            unNuevoIdioma.Nombre = txtNombreIdioma.Text;
            BLLIdioma bllIdioma = new BLLIdioma();
            int idiomaAgregado = bllIdioma.AgregarIdioma(unNuevoIdioma);

            if (idiomaAgregado == 1)
            {
                MessageBox.Show("Idioma agregado correctamente");
                txtNombreIdioma.Text = "";
                cmbListarIdiomas.Items.Clear();
                List<Idioma> _idiomas = new List<Idioma>();
                var _idiomasParaAgregar = bllIdioma.TraerTodosLosIdiomas();

                foreach (var item in _idiomasParaAgregar)
                {
                    cmbListarIdiomas.Items.Add(item);
                    cmbListarIdiomas.DisplayMember = "Nombre";
                }

                Usuario _usuario = Usuario.Instancia;
                var unaBitacora = new SGH.BE.Bitacora();
                unaBitacora.fecha = DateTime.Now;
                unaBitacora.descripcion = "Se agregó el idioma " +unNuevoIdioma.Nombre+ " al sistema";
                unaBitacora.usuario = _usuario;
                unaBitacora.formulario = this.Name;

                var bllBitacora = new SGH.BLL.BLLBitacora();
                bllBitacora.GrabarBitacora(unaBitacora);
            }
            if (idiomaAgregado == 0)
            {
                MessageBox.Show("Ya existe el idioma en la base");
            }
        }
        /// <summary>
        /// Handles the 1 event of the dataGridView1_CellContentClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtEdicionPalabra.Text = dgvPalabras.CurrentRow.Cells[1].Value.ToString();
            lblIdPalabra.Text = dgvPalabras.CurrentRow.Cells[0].Value.ToString();
            txtEdicionPalabra.Enabled = true;
            txtEdicionTraduccion.Enabled = true;
            btnModificarPalabra.Enabled = true;
            btnAgregarTraduccion.Enabled = true;
            btnEliminarPalabra.Enabled = true;
        }
        /// <summary>
        /// Handles the 2 event of the dataGridView1_CellContentClick control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            txtEdicionTraduccion.Text = dgvTraduccion.CurrentRow.Cells[2].Value.ToString();
            txtEdicionTraduccion.Enabled = true;
            btnModificarTraduccion.Enabled = true;
            btnEliminarTraduccion.Enabled = true;
        }
        /// <summary>
        /// Handles the Click event of the btnModificarTraduccion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTraduccion.SelectedRows.Count > 0)
                {
                    lblIdTraduccion.Text = dgvTraduccion.CurrentRow.Cells[1].Value.ToString();
                    lblIdiomaCodigoSeleccionado.Text = dgvTraduccion.CurrentRow.Cells[0].Value.ToString();
                    Regex regex = new Regex("^[0-9]*$");

                    if (txtEdicionTraduccion.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, completar el campo correspondiente ");
                        return;
                    }
                    var regexItem = new Regex("^[a-zA-Z]*$");

                    if (!regexItem.IsMatch(txtEdicionTraduccion.Text))
                    {
                        MessageBox.Show("Por favor, ingresar solo caracteres ");
                        return;
                    }
                    else
                    {
                        BLLIdioma bLLIdioma = new BLLIdioma();
                        Traduccion unaTraduccion = new Traduccion();
                        unaTraduccion.Descripcion = txtEdicionTraduccion.Text;
                        Guid guidPalabra = new Guid(lblIdTraduccion.Text);
                        unaTraduccion.IdPalabra = guidPalabra;
                        unaTraduccion.IdIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
                        int resultadoModificacion = bLLIdioma.ModificarTraduccion(unaTraduccion);

                        if (resultadoModificacion == 1)
                        {
                            MessageBox.Show(" Traduccion modificada con éxito ");
                            dgvTraduccion.DataSource = bLLIdioma.ObtenerTraduccionesIdioma(unaTraduccion.IdIdioma);
                            dgvTraduccion.AutoResizeColumns();
                            btnModificarTraduccion.Enabled = false;
                            btnEliminarTraduccion.Enabled = false;
                        }
                        else MessageBox.Show(" Hubo un problema al modificar la traducción ");

                    }
                }
                else MessageBox.Show("Debe seleccionar un registro");

               
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Handles the Click event of the btnModificarPalabra control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnModificarPalabra_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvPalabras.SelectedRows.Count > 0)
                {

                    Regex regex = new Regex("^[0-9]*$");

                    if (txtEdicionPalabra.Text == string.Empty)
                    {
                        MessageBox.Show("Por favor, completar el campo correspondiente ");
                        return;
                    }
                    var regexItem = new Regex("^[a-zA-Z]*$");

                    if (!regexItem.IsMatch(txtEdicionPalabra.Text))
                    {
                        MessageBox.Show("Por favor, ingresar solo caracteres ");
                        return;
                    }
                    else
                    {
                        BLLIdioma bLLIdioma = new BLLIdioma();
                        Palabra unaPalabra = new Palabra();
                        unaPalabra.Descripcion = txtEdicionPalabra.Text;
                        Guid guidPalabra = new Guid(lblIdPalabra.Text);
                        unaPalabra.IdPalabra = guidPalabra;

                        int resultadoModificacion = bLLIdioma.ModificarPalabra(unaPalabra);

                        if (resultadoModificacion == 1)
                        {
                            MessageBox.Show(" Palabra modificada con éxito ");
                            dgvPalabras.DataSource = bLLIdioma.TraerTodasLasPalabras();
                            dgvPalabras.AutoResizeColumns();
                            txtEdicionPalabra.Text = " ";
                            btnModificarPalabra.Enabled = false;
                            btnEliminarPalabra.Enabled = false;
                        }
                        else MessageBox.Show(" Hubo un problema al modificar la palabra ");

                    }

                }
                else MessageBox.Show(" Debe seleccionar un registro");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Handles the Click event of the btnAgregarTraduccion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAgregarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                lblIdPalabra.Text = dgvPalabras.CurrentRow.Cells[0].Value.ToString();
                Regex regex = new Regex("^[0-9]*$");

                if (txtEdicionTraduccion.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, completar el campo correspondiente ");
                    return;
                }
                var regexItem = new Regex("^[a-zA-Z- ]*$");

                if (!regexItem.IsMatch(txtEdicionTraduccion.Text))
                {
                    MessageBox.Show("Por favor, ingresar solo caracteres ");
                    return;
                }
                if (cmbListarIdiomas.SelectedIndex < 0)
                {
                    MessageBox.Show(" Por favor, elija un idioma de la lista");
                }
                else
                {
                    BLLIdioma bLLIdioma = new BLLIdioma();
                    Traduccion unaTraduccion = new Traduccion();
                    unaTraduccion.Descripcion = txtEdicionTraduccion.Text;
                    unaTraduccion.IdIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
                    Guid guidPalabra = new Guid(lblIdPalabra.Text);
                    unaTraduccion.IdPalabra = guidPalabra;
                    int resultadoAlta = bLLIdioma.CargarTraduccion(unaTraduccion);

                    if (resultadoAlta == 1)
                    {
                        MessageBox.Show(" Traduccion agregada con éxito ");
                        dgvTraduccion.DataSource = bLLIdioma.ObtenerTraduccionesIdioma(unaTraduccion.IdIdioma);
                        dgvTraduccion.AutoResizeColumns();
                        txtEdicionTraduccion.Text = " ";
                    }
                    else MessageBox.Show(" Ya existe una traducción para la palabra seleccionada ");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Handles the Click event of the btnEliminarTraduccion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminarTraduccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTraduccion.SelectedRows.Count > 0)
                {

                    lblIdTraduccion.Text = dgvTraduccion.CurrentRow.Cells[1].Value.ToString();


                    BLLIdioma bLLIdioma = new BLLIdioma();
                    Traduccion unaTraduccion = new Traduccion();
                    unaTraduccion.Descripcion = txtEdicionTraduccion.Text;
                    Guid guidPalabra = new Guid(lblIdTraduccion.Text);
                    unaTraduccion.IdPalabra = guidPalabra;
                    unaTraduccion.IdIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
                    int resultadoModificacion = bLLIdioma.EliminarTraduccion(unaTraduccion);

                    if (resultadoModificacion == 1)
                    {
                        MessageBox.Show(" Traduccion eliminada con éxito ");

                        dgvTraduccion.DataSource = bLLIdioma.ObtenerTraduccionesIdioma(unaTraduccion.IdIdioma);
                        dgvPalabras.AutoResizeColumns();
                        btnEliminarTraduccion.Enabled = false;
                        btnModificarTraduccion.Enabled = false;
                    }
                    else MessageBox.Show(" Hubo un problema al intentar borrar la traducción ");
                }
                else MessageBox.Show("Debe seleccionar un registro");

                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Handles the Click event of the btnBorrarIdioma control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBorrarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                
                BLLIdioma bLLIdioma = new BLLIdioma();
                Idioma unIdioma = new Idioma();
                unIdioma.IdIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
                
                
                int resultadoModificacion = bLLIdioma.EliminarIdioma(unIdioma);

                if (resultadoModificacion == 1)
                {
                    MessageBox.Show(" Idioma eliminado con éxito ");
                    cmbListarIdiomas.Text = " ";
                    cmbListarIdiomas.Items.Clear();
                    lblIdiomaCodigoSeleccionado.Text = " ";
                    lblIdiomaSeleccionado.Text = " ";
                    BLLIdioma gestorIdiomas = new BLLIdioma();
                    var _idiomasParaAgregar = gestorIdiomas.TraerTodosLosIdiomas();

                    foreach (var item in _idiomasParaAgregar)
                    {
                        cmbListarIdiomas.Items.Add(item);
                        cmbListarIdiomas.DisplayMember = "Nombre";
                    }
                }
                else MessageBox.Show(" Hubo un problema al intentar borrar el idioma ");





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
        /// <summary>
        /// Handles the Click event of the btnAgregarPalabra control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Regex regex = new Regex("^[0-9]*$");

                if (txtEdicionPalabra.Text == string.Empty)
                {
                    MessageBox.Show("Por favor, completar el campo correspondiente ");
                    return;
                }
                var regexItem = new Regex("^([a-zA-Za])[a-zA-Z]*$");

                if (!regexItem.IsMatch(txtEdicionPalabra.Text))
                {
                    MessageBox.Show("Por favor, ingresar solo caracteres ");
                    return;
                }
                else
                {
                    BLLIdioma bLLIdioma = new BLLIdioma();
                    Palabra nuevaPalabra = new Palabra();
                    nuevaPalabra.Descripcion = txtEdicionPalabra.Text;
                    
                    
                    int resultadoAlta = bLLIdioma.CargarPalabra(nuevaPalabra);

                    if (resultadoAlta == 1)
                    {
                        MessageBox.Show(" Palabra agregada con éxito ");
                        dgvPalabras.DataSource = bLLIdioma.TraerTodasLasPalabras();
                        dgvPalabras.AutoResizeColumns();
                        txtEdicionPalabra.Text = " ";
                    }
                    else MessageBox.Show(" Ya existe una palabra para la palabra seleccionada ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
           
        }
        /// <summary>
        /// Handles the Click event of the btnRefrescar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            BLLIdioma bLLIdioma = new BLLIdioma();
            dgvPalabras.DataSource = bLLIdioma.TraerTodasLasPalabras();
            dgvPalabras.AutoResizeColumns();

            
        }
        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int idIdioma = Convert.ToInt32(lblIdiomaCodigoSeleccionado.Text);
            BLLIdioma bllIdioma = new BLLIdioma();
            dgvTraduccion.DataSource = bllIdioma.ObtenerTraduccionesIdioma(idIdioma);
            dgvTraduccion.AutoResizeColumns();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnEliminarPalabra control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminarPalabra_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPalabras.SelectedRows.Count > 0)
                {
                    txtEdicionPalabra.Text = dgvPalabras.CurrentRow.Cells[1].Value.ToString();
                    lblIdPalabra.Text = dgvPalabras.CurrentRow.Cells[0].Value.ToString();


                    BLLIdioma bLLIdioma = new BLLIdioma();
                    Palabra unaPalabra = new Palabra();
                    unaPalabra.Descripcion = txtEdicionPalabra.Text;
                    Guid guidPalabra = new Guid(lblIdPalabra.Text);
                    unaPalabra.IdPalabra = guidPalabra;

                    int resultadoEliminacion = bLLIdioma.EliminarPalabra(unaPalabra);

                    if (resultadoEliminacion == 1)
                    {
                        MessageBox.Show(" Palabra eliminada con éxito ");

                        dgvPalabras.DataSource = bLLIdioma.TraerTodasLasPalabras();
                        dgvPalabras.AutoResizeColumns();
                        txtEdicionPalabra.Text = " ";
                        btnEliminarPalabra.Enabled = false;
                        btnModificarPalabra.Enabled = false;
                    }
                    else MessageBox.Show(" Hubo un problema al intentar borrar la palabra ");



                }
                else MessageBox.Show("Debe seleccionar un registro");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }
        }
    }
    
}
