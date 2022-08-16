using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
using SGHv1._0.FormsHabitacion;
using SGH.BLL;
using SGH.BE;
using SGH.BE.CompositePermisos;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace SGHv1._0.FormsReservas
{
    /// <summary>
    /// Formulario para la administración de las Reservas
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmAdministracionDeReservas : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        BLLIdioma bl = new BLLIdioma();
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmAdministracionDeReservas"/> class.
        /// </summary>
        public FrmAdministracionDeReservas()
        {
            InitializeComponent();
            idioma.RegistrarObserver(this);
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

        private void LblHabitacion_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Load event of the FrmCargarReserva control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmCargarReserva_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "AdministraciondeReservas");
            helpProvider1.SetHelpKeyword(this, "AdministraciondeReservas");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
            try
            {
                LimpiarFormulario();
                BLLCliente bLLCliente = new BLLCliente();
                List<Cliente> _clientes = new List<Cliente>();
                var _clientesAgregar = bLLCliente.TraerTodosLosClientesApellido();

                foreach (var itemsCli in _clientesAgregar)
                {
                    cmbCliente.Items.Add(itemsCli.Apellido + " " + itemsCli.Nombre + "    DNI: - " + itemsCli.Dni);
                    cmbCliente.DisplayMember = "Apellido Cliente";


                }

                BLLHabitacion bllHabitacion = new BLLHabitacion();
                List<Habitacion> _habitaciones = new List<Habitacion>();
                var _habitacionesAgregar = bllHabitacion.TraerTodasLasHabitaciones();

                foreach (var itemshab in _habitacionesAgregar)
                {
                    cmbNumeroHabitacion.Items.Add(itemshab.Numero);
                    cmbNumeroHabitacion.DisplayMember = "Numero";
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

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCargarReserva.Enabled = true;
            BLLReserva bLLReserva = new BLLReserva();
            dtpFechaEgreso.Enabled = false;

            dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
            dgvReservas.Columns[0].Visible = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
        }


       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Handles the CloseUp event of the dtpFechaEgreso control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpFechaEgreso_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaDesde = Convert.ToDateTime(dtpFechaIngreso.Text);
            DateTime fechaHasta = Convert.ToDateTime(dtpFechaEgreso.Text);
            if (fechaDesde <= fechaHasta )
            {
                TimeSpan ts = fechaHasta.Subtract(fechaDesde);
                int dias = Convert.ToInt16(ts.Days);
                lblCantidad.Text = dias.ToString(); 

            }
            else
            {
                MessageBox.Show("La fecha de Egreso debe ser superior a la de Ingreso");
            }

           
          
        }

        private void dtpFechaEgreso_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the btnCargarReserva control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCargarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                

                foreach (Control con in this.Controls)
                {
                    if (con is DateTimePicker)
                    {
                        DateTimePicker dateTimePicker = con as DateTimePicker;
                        if (dateTimePicker.Checked == false)
                        {
                            MessageBox.Show("Por favor, elija una fecha");
                            return;
                        }
                    }
                    if (con is ComboBox)
                    {
                        ComboBox comboBox = con as ComboBox;
                        if (comboBox.SelectedItem == null)
                        {
                            MessageBox.Show("No ha elegido el Cliente y/o Habitación");
                            return;
                        }

                    }
                   
                }

                
                if (ComprobarOcupacion() == 0)
                {



                    MessageBox.Show("Disponibilidad de habitación OK");
                    Reserva nuevaReserva = new Reserva();
                    Cliente cliente = new Cliente();
                    Habitacion habitacion = new Habitacion();
                    nuevaReserva.Cliente = cliente;
                    nuevaReserva.habitacion = habitacion;
                    BLLReserva bLLReserva = new BLLReserva();



                    string str = cmbCliente.GetItemText(this.cmbCliente.SelectedItem);

                    string str2 = cmbCliente.GetItemText(this.cmbCliente.ValueMember);

                    string[] words = str.Split('-');
                    string apellido = words[0];
                    string nombre = words[1];




                    BLLCliente bllCliente = new BLLCliente();
                    List<Cliente> listaClientes = bllCliente.TraerClientes(words[1]);
                    foreach (var varCliente in listaClientes)
                    {
                        nuevaReserva.Cliente.idCliente = varCliente.idCliente;
                    }

                    nuevaReserva.habitacion.Numero = cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem);
                    BLLHabitacion bLLHabitacion = new BLLHabitacion();
                    List<Habitacion> listaHabitacion = bLLHabitacion.ObtenerIDHabitacion(nuevaReserva.habitacion.Numero);
                    foreach (var variable in listaHabitacion)
                    {
                        nuevaReserva.habitacion.IdHabitacion = variable.IdHabitacion;
                    }

                    nuevaReserva.FechaLlegada = dtpFechaIngreso.Value.Date;
                    nuevaReserva.FechaSalida = dtpFechaEgreso.Value.Date;
                    nuevaReserva.CantidadDias = Convert.ToInt32(lblCantidad.Text);
                    nuevaReserva.Activa = true;
                    nuevaReserva.CheckIn = "NO";
                    if (chbEsViajeLaboral.Checked)
                    {
                        nuevaReserva.EsViajeLaboral = true;
                    }
                    else nuevaReserva.EsViajeLaboral = false;

                    if (chbConNinios.Checked)
                    {
                        nuevaReserva.ConNinios = true;
                    }
                    else nuevaReserva.ConNinios = false;



                    int resultadoAltaReserva = bLLReserva.RegistrarReserva(nuevaReserva);

                    if (resultadoAltaReserva == 1)
                    {
                        MessageBox.Show("Reserva cargada exitosamente");
                        dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
                        LimpiarFormulario();
                    }
                    if (resultadoAltaReserva == 0)
                    {
                        MessageBox.Show("Hubo un problema al cargar la reserva. Vuelva a intentar más tarde");
                    }
                }
                else MessageBox.Show("La habitación " + cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem) + " se encuentra ocupada en ese rango de fechas");



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
        /// Handles the Click event of the btnEditar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control con in this.Controls)
                {
                    if (con is DateTimePicker)
                    {
                        DateTimePicker dateTimePicker = con as DateTimePicker;
                        if (dateTimePicker.Checked == false)
                        {
                            MessageBox.Show("Por favor, elija una fecha");
                            return;
                        }
                    }
                    if (con is ComboBox)
                    {
                        ComboBox comboBox = con as ComboBox;
                        if (comboBox.SelectedItem == null)
                        {
                            MessageBox.Show("No ha elegido el Cliente y/o Habitación");
                            return;
                        }

                    }

                }

                
                if (ComprobarOcupacionModificar()==0)
                {
                    MessageBox.Show("Disponibilidad de habitación OK");
                    Reserva reservaAModificar = new Reserva();
                    BLLReserva bLLReserva = new BLLReserva();


                    Cliente cliente = new Cliente();
                    Habitacion habitacion = new Habitacion();
                    reservaAModificar.Cliente = cliente;
                    reservaAModificar.habitacion = habitacion;



                    //   nuevaReserva.Cliente.Apellido = cmbCliente.GetItemText(this.cmbCliente.SelectedItem);
                    string str = cmbCliente.GetItemText(this.cmbCliente.SelectedItem);
                    string[] words = str.Split('-');
                    string apellido = words[0];
                    string dni = words[1];


                    BLLCliente bllCliente = new BLLCliente();
                    List<Cliente> listaClientes = bllCliente.TraerClientes(dni);
                    foreach (var varCliente in listaClientes)
                    {
                        reservaAModificar.Cliente.idCliente = varCliente.idCliente;
                    }

                    reservaAModificar.habitacion.Numero = cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem);
                    BLLHabitacion bLLHabitacion = new BLLHabitacion();
                    List<Habitacion> listaHabitacion = bLLHabitacion.ObtenerIDHabitacion(reservaAModificar.habitacion.Numero);
                    foreach (var variable in listaHabitacion)
                    {
                        reservaAModificar.habitacion.IdHabitacion = variable.IdHabitacion;
                    }

                    reservaAModificar.FechaLlegada = dtpFechaIngreso.Value.Date;
                    reservaAModificar.FechaSalida = dtpFechaEgreso.Value.Date;
                    reservaAModificar.CantidadDias = Convert.ToInt32(lblCantidad.Text);
                    if (chbEsViajeLaboral.Checked)
                    {
                        reservaAModificar.EsViajeLaboral = true;
                    }
                    else reservaAModificar.EsViajeLaboral = false;

                    if (chbConNinios.Checked)
                    {
                        reservaAModificar.ConNinios = true;
                    }
                    else reservaAModificar.ConNinios = false;
                    reservaAModificar.CheckIn = "NO";



                    int resultadoModificacionReserva = bLLReserva.ModificarReserva(Convert.ToInt32(lblNumeroReserva.Text), reservaAModificar);

                    if (resultadoModificacionReserva == 1)
                    {
                        MessageBox.Show("Reserva modificada exitosamente");
                        dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
                        LimpiarFormulario();
                    }
                    if (resultadoModificacionReserva == 0)
                    {
                        MessageBox.Show("Hubo un problema al querer modificar la reserva");
                    }
                }
                else MessageBox.Show("La habitación " + cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem) + " se encuentra ocupada en ese rango de fechas");



                try
                {
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Se modificó una reserva";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);
                }
                catch (Exception ax)
                {
                    MessageBox.Show(ax.Data.ToString());
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
        /// Handles the CellContentClick event of the dgvReservas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNumeroReserva.Text = dgvReservas.CurrentRow.Cells[0].Value.ToString();
            lblNumeroReserva.Visible = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCargarReserva.Enabled = false;
            
        }
        /// <summary>
        /// Handles the Click event of the btnEliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int IdReserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells[0].Value);
                BLLReserva bLLReserva = new BLLReserva();
                
                int resultadoBorradoHab = bLLReserva.BorrarReserva(IdReserva);
                if (resultadoBorradoHab == 1)
                {
                    MessageBox.Show("Se ha cancelado la Reserva de forma exitosa");
                    LimpiarFormulario();
                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Cancelación de Reserva";
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);

                    dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al querer borrar la Reserva");
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
        /// Comprobar ocupacion.
        /// </summary>
        /// <returns></returns>
        int ComprobarOcupacion()
        {
            string numHab = cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem);
            
            Cliente cliente = new Cliente();
                      
            string str = cmbCliente.GetItemText(this.cmbCliente.SelectedItem);
            string[] words = str.Split('-');
            string apellido = words[0];
            string dni = words[1];


            BLLCliente bllCliente = new BLLCliente();
            List<Cliente> listaClientes = bllCliente.TraerClientes(dni);
            foreach (var varCliente in listaClientes)
            {
                cliente.idCliente = varCliente.idCliente;
            }
            BLLHabitacion bLLHabitacion = new BLLHabitacion();
            Reserva unaReserva = new Reserva();
            List<SGH.BE.Vistas.ReservaObtenida> listaReservas = bLLHabitacion.ComprobarOcupacionHabitacion(Convert.ToDateTime(dtpFechaIngreso.Text), numHab, cliente.idCliente);
            int contadorRes = 0;
            foreach (var reserva in listaReservas)
            {
                unaReserva.IdReserva = reserva.idReserva;
                contadorRes = +1;
            }
          
            return contadorRes;
        }
        /// <summary>
        /// Comprobar ocupacion modificar.
        /// </summary>
        /// <returns></returns>
        int ComprobarOcupacionModificar()
        {
            string numHab = cmbNumeroHabitacion.GetItemText(this.cmbNumeroHabitacion.SelectedItem);

            Cliente cliente = new Cliente();

            string str = cmbCliente.GetItemText(this.cmbCliente.SelectedItem);
            string[] words = str.Split('-');
            string apellido = words[0];
            string dni = words[1];


            BLLCliente bllCliente = new BLLCliente();
            List<Cliente> listaClientes = bllCliente.TraerClientes(dni);
            foreach (var varCliente in listaClientes)
            {
                cliente.idCliente = varCliente.idCliente;
            }
            BLLHabitacion bLLHabitacion = new BLLHabitacion();
            Reserva unaReserva = new Reserva();
            List<SGH.BE.Vistas.ReservaObtenida> listaReservas = bLLHabitacion.ComprobarOcupacionHabitacionModificar(Convert.ToDateTime(dtpFechaIngreso.Text), numHab, cliente.idCliente);
            int contadorRes = 0;
            foreach (var reserva in listaReservas)
            {
                unaReserva.IdReserva = reserva.idReserva;
                contadorRes = +1;
            }

            return contadorRes;
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
        /// Handles the ValueChanged event of the dtpFechaIngreso control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaEgreso.Enabled = true;
            
        }
    }
}
