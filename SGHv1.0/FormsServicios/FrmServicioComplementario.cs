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
using SGH.BE.Observer;
using SGH.BE.MultiIdioma;
using System.Text.RegularExpressions;
using SGH.BE;
using SGH.BE.CompositePermisos;

namespace SGHv1._0.FormsServicios
{
    public partial class FrmServicioComplementario : Form, IObserver
    {
        public FrmServicioComplementario()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            CambiarIdiomaUsandoObserver();
        }

        public void CambiarIdiomaUsandoObserver()

        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = dgvServicioComplementario.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvServicioComplementario.CurrentRow.Cells[2].Value.ToString();
            txtHorasAlquiler.Text = dgvServicioComplementario.CurrentRow.Cells[4].Value.ToString();
            btnModificarServicio.Enabled = true;
            btnEliminarServicio.Enabled = true;
        }

        private void FrmServicioComplementario_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "GestiondeServiciosComplementario");
            helpProvider1.SetHelpKeyword(this, "GestiondeServiciosComplementario");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
            try
            {
                LimpiarFormulario();
                BLLServicios bLLServicios = new BLLServicios();

                dgvServicioComplementario.DataSource = bLLServicios.TraerTodosLosServiciosComplementarios();
                dgvServicioComplementario.Columns[0].Visible = false;

                dgvServicioComplementario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                rbDisponibilidadSI.Checked = true;
                
                BLLIdioma _traduccion = new BLLIdioma();
                Idioma idioma = Idioma.InstanciaIdioma;
                Form form = this;
                _traduccion.Traducir(idioma.IdIdioma, form);
                LimpiarFormulario();



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

        public void LimpiarFormulario()
        {
            txtHorasAlquiler.Text = "";
            rbDisponibilidadSI.Checked = true;
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            btnModificarServicio.Enabled = false;
            btnEliminarServicio.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
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
                   
                    if (con is RadioButton)
                    {
                        RadioButton radioButton = con as RadioButton;
                        if ((!radioButton.Checked == rbDisponibilidadNO.Checked) && (!radioButton.Checked == rbDisponibilidadSI.Checked))
                        {
                            MessageBox.Show("No ha seleccionado el estado de la disponibilidad");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtPrecio.Text) && !regex.IsMatch(txtHorasAlquiler.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                ServicioComplementario servicioComplementario = new ServicioComplementario();
                BLLServicios bLLServicios = new BLLServicios();

                servicioComplementario.Descripcion = txtDescripcion.Text;
                servicioComplementario.Precio = Convert.ToInt32(txtPrecio.Text);
                servicioComplementario.HorasAlquiler = Convert.ToInt32(txtHorasAlquiler.Text);

                if (rbDisponibilidadSI.Checked == true)
                {
                    servicioComplementario.Disponibilidad = "SI";
                }
                else servicioComplementario.Disponibilidad = "NO";

                servicioComplementario.IdServicio = 2;



                int resultadoAltaServicioComplementario = bLLServicios.AltaServicioComplementario(servicioComplementario);

                if (resultadoAltaServicioComplementario == 1)
                {
                    MessageBox.Show("Servicio Complementario cargado exitosamente");
                }
                if (resultadoAltaServicioComplementario == 0)
                {
                    MessageBox.Show("Ya existe ese Servicio Complementario en la base de datos");
                }
                dgvServicioComplementario.DataSource = bLLServicios.TraerTodosLosServiciosComplementarios();
                dgvServicioComplementario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                LimpiarFormulario();

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

        private void btnModificarServicio_Click(object sender, EventArgs e)
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
                  
                    if (con is RadioButton)
                    {
                        RadioButton radioButton = con as RadioButton;
                        if ((!radioButton.Checked == rbDisponibilidadSI.Checked) && (!radioButton.Checked == rbDisponibilidadNO.Checked))
                        {
                            MessageBox.Show("No ha seleccionado el estado del Servicio Complementario");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtPrecio.Text) && !regex.IsMatch(txtHorasAlquiler.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                ServicioComplementario servicioComplementario = new ServicioComplementario();
                BLLServicios bLLServicios = new BLLServicios();

                servicioComplementario.IdServicioComplementario = Convert.ToInt32(dgvServicioComplementario.CurrentRow.Cells[0].Value);
                servicioComplementario.Descripcion = txtDescripcion.Text;
                servicioComplementario.Precio = Convert.ToInt32(txtPrecio.Text);
                servicioComplementario.HorasAlquiler = Convert.ToInt32(txtHorasAlquiler.Text);

                if (rbDisponibilidadSI.Checked == true)
                {
                    servicioComplementario.Disponibilidad = "SI";
                }
                else servicioComplementario.Disponibilidad = "NO";

                int resultadoModificacionSC = bLLServicios.ModificarServicioComplementario(servicioComplementario);

                if (resultadoModificacionSC == 1)
                {
                    MessageBox.Show("Servicio Complementario modificado exitosamente");
                    LimpiarFormulario();
                }
                if (resultadoModificacionSC == 0)
                {
                    MessageBox.Show("Hubo un problema al querer modificar el Servicio Complementario");
                }
                dgvServicioComplementario.DataSource = bLLServicios.TraerTodosLosServiciosComplementarios();

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

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                int IdSC = Convert.ToInt32(dgvServicioComplementario.CurrentRow.Cells[0].Value);
                BLLServicios bLLServicios = new BLLServicios();

                int resultadoBorradoSC = bLLServicios.BorrarServicioComplementario(IdSC);
                if (resultadoBorradoSC == 1)
                {
                    MessageBox.Show("Se ha borrado el Servicio Complementario de forma exitosa");
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Eliminación de Servicio Complementario";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);

                    dgvServicioComplementario.DataSource = bLLServicios.TraerTodosLosServiciosComplementarios();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al querer borrar el Servicio Complementario");
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
    }
}
