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
    public partial class FrmRoomService : Form, IObserver
    {
        public FrmRoomService()
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
        

        private void GestionDeBuffet_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "GestiondeRoomService");
            helpProvider1.SetHelpKeyword(this, "GestiondeRoomService");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            try
            {
                BLLServicios bLLServicios = new BLLServicios();

                dgvRoomService.DataSource = bLLServicios.TraerTodosLosRoomServices();
                dgvRoomService.Columns[0].Visible = false;
                
                dgvRoomService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                rbDisponibilidadSI.Checked = true;
                rbComida.Checked = true;
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
            rbComida.Checked = true;
            rbDisponibilidadSI.Checked = true;
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            btnEliminarRoomService.Enabled = false;
            btnModificarRoomService.Enabled = false;
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void dgvRoomService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDescripcion.Text = dgvRoomService.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvRoomService.CurrentRow.Cells[2].Value.ToString();
            btnModificarRoomService.Enabled = true;
            btnEliminarRoomService.Enabled = true;
        }

        private void btnAgregarRoomService_Click(object sender, EventArgs e)
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
                        if ((!radioButton.Checked == rbDisponibilidadNO.Checked) && (!radioButton.Checked == rbDisponibilidadSI.Checked))
                        {
                            MessageBox.Show("No ha seleccionado el estado de la disponibilidad");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                RoomService roomService = new RoomService();
                BLLServicios bLLServicios = new BLLServicios();

                roomService.Descripcion = txtDescripcion.Text;
                roomService.Precio = Convert.ToInt32(txtPrecio.Text);
                if (rbComida.Checked == true)
                {
                    roomService.Esbebida = false;
                }
                else roomService.Esbebida = true;

                if (rbDisponibilidadSI.Checked == true)
                {
                    roomService.Disponibilidad = "SI";
                }
                else roomService.Disponibilidad = "NO";

                roomService.IdServicio = 1;
                
               

                int resultadoAltaRoomService = bLLServicios.AltaRoomService(roomService);

                if (resultadoAltaRoomService == 1)
                {
                    MessageBox.Show("Room Service cargado exitosamente");
                }
                if (resultadoAltaRoomService == 0)
                {
                    MessageBox.Show("Ya existe ese Room Service en la base de datos");
                }
                dgvRoomService.DataSource = bLLServicios.TraerTodosLosRoomServices();
                dgvRoomService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarRoomService_Click(object sender, EventArgs e)
        {
            try
            {
                int IdRS = Convert.ToInt32(dgvRoomService.CurrentRow.Cells[0].Value);
                BLLServicios bLLServicios = new BLLServicios();
                
                int resultadoBorradoRS = bLLServicios.BorrarRoomService(IdRS);
                if (resultadoBorradoRS == 1)
                {
                    MessageBox.Show("Se ha borrado el Room Service de forma exitosa");
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Eliminación de Room Service";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);

                    dgvRoomService.DataSource = bLLServicios.TraerTodosLosRoomServices();
                    LimpiarFormulario();
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

        private void btnModificarRoomService_Click(object sender, EventArgs e)
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
                        if ((!radioButton.Checked == rbDisponibilidadSI.Checked) && (!radioButton.Checked == rbDisponibilidadNO.Checked))
                        {
                            MessageBox.Show("No ha seleccionado el estado del Room Service");
                            return;
                        }
                    }
                }

                if (!regex.IsMatch(txtPrecio.Text))
                {
                    MessageBox.Show("Por favor, hay campos que sólo pueden incluir datos numéricos");
                    return;
                }

                RoomService roomService = new RoomService();
                BLLServicios bLLServicios = new BLLServicios();

                roomService.IdRoomService = Convert.ToInt32(dgvRoomService.CurrentRow.Cells[0].Value);
                roomService.Descripcion = txtDescripcion.Text;
                roomService.Precio = Convert.ToInt32(txtPrecio.Text);
                if (rbBebida.Checked == true)
                {
                    roomService.Esbebida = true;
                }
                else roomService.Esbebida = false;

                if (rbDisponibilidadSI.Checked == true)
                {
                    roomService.Disponibilidad = "SI";
                }
                else roomService.Disponibilidad = "NO";

                int resultadoModificacionRS = bLLServicios.ModificarRoomService(roomService);

                if (resultadoModificacionRS == 1)
                {
                    MessageBox.Show("Room Service modificado exitosamente");
                    LimpiarFormulario();
                }
                if (resultadoModificacionRS == 0)
                {
                    MessageBox.Show("Hubo un problema al querer modificar el Room Service");
                }
                dgvRoomService.DataSource = bLLServicios.TraerTodosLosRoomServices();

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

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = " ";
            txtPrecio.Text = " ";
        }
    }
}
