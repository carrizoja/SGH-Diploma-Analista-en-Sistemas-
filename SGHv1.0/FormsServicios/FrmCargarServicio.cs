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
using SGH.BE.Vistas;

namespace SGHv1._0.FormsServicios
{
    /// <summary>
    /// Formulario para la carga del Servicio
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmCargarServicio : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCargarServicio"/> class.
        /// </summary>
        public FrmCargarServicio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Actualiza this instance.
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
        /// Handles the Load event of the FrmCargarServicio control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmCargarServicio_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "CargarServicio");
            helpProvider1.SetHelpKeyword(this, "CargarServicio");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            try
            {


                LimpiarFormulario();
                BLLHabitacion bllHabitacion = new BLLHabitacion();
                List<Habitacion> _habitaciones = new List<Habitacion>();
                var _habitacionesAgregar = bllHabitacion.TraerTodasLasHabitacionesDesocupadas();

                foreach (var itemshab in _habitacionesAgregar)
                {
                    cmbHabitaciones.Items.Add(itemshab.Numero);
                    cmbHabitaciones.DisplayMember = "Numero";
                }

                BLLServicios bLLServicios = new BLLServicios();
                List<SGH.BE.Vistas.TipoServicio> listaTipoServicios = new List<SGH.BE.Vistas.TipoServicio>();
                var _serviciosAgregar = bLLServicios.TraerTiposServicios();

                foreach (var itemsServicios in _serviciosAgregar)
                {
                    cmbTipoServicio.Items.Add(itemsServicios.Nombre);
                    cmbTipoServicio.DisplayMember = "Nombre";
                }

                //dgvServicios.DataSource = bLLServicios.TraerTodasLasHabitaciones();
                //dgvReservas.Columns[0].Visible = false;
                //dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

              

              

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
        /// Limpiar formulario.
        /// </summary>
        void LimpiarFormulario()
        {
            btnCargarServicio.Enabled = false;
        }
        /// <summary>
        /// Handles the CellContentClick event of the dgvServicios control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCargarServicio.Enabled = true;

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
        /// Handles the SelectedIndexChanged event of the cmbTipoServicio control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicioSeleccionado = cmbTipoServicio.Text;
            BLLServicios BLLServicios = new BLLServicios();
            List<SGH.BE.Vistas.TipoServicio> datosTipoServicio = BLLServicios.TraerServicioSeleccionado(servicioSeleccionado);


            foreach (var item0 in datosTipoServicio)
            {
                
                lblServicioSeleccionado.Text = item0.IdServicio.ToString();
                
             
            }
            if (lblServicioSeleccionado.Text == "1")
            {
                dgvServicios.DataSource = BLLServicios.TraerTodosLosRoomServices();
                dgvServicios.Columns[0].Visible = false;
                dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                dgvServicios.DataSource = BLLServicios.TraerTodosLosServiciosComplementarios();
                dgvServicios.Columns[0].Visible = false;
                dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            

            
        }
        /// <summary>
        /// Handles the Click event of the btnCargarServicio control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            Reserva unaReserva = new Reserva();
            BLLReserva bLLReserva = new BLLReserva();
            List<SGH.BE.Vistas.ReservaObtenida> listaReservas = bLLReserva.BuscarReservaPorHabitacion(cmbHabitaciones.GetItemText(this.cmbHabitaciones.SelectedItem));
            unaReserva.Cliente = new Cliente();
            unaReserva.habitacion = new Habitacion();
            foreach (var reserva in listaReservas)
            {
                
                unaReserva.Cliente.idCliente = reserva.idCliente;
                unaReserva.IdReserva= reserva.idReserva;
                unaReserva.habitacion.IdHabitacion = reserva.idHabitacion;
                unaReserva.IdReserva = reserva.idReserva;
                           
            }
            Cuenta unaCuenta = new Cuenta();
            BLLCuenta bLLCuenta = new BLLCuenta();
            List<CuentaObtenida> listaCuentaObtenidas = bLLCuenta.ObtenerCuenta(unaReserva);
            unaCuenta.Habitacion = new Habitacion();
            unaCuenta.Cliente = new Cliente();
            unaCuenta.Reserva = new Reserva();
            foreach (var cuenta in listaCuentaObtenidas)
            {
                unaCuenta.IdCuenta = cuenta.IdCuenta;
                unaCuenta.Habitacion.IdHabitacion = cuenta.IdHabitacion;
                unaCuenta.Cliente.idCliente = cuenta.idCliente;
                unaCuenta.Total = cuenta.Total;
                unaCuenta.Reserva.IdReserva = cuenta.IdReserva;
                
            }
            unaCuenta.Total = unaCuenta.Total + Convert.ToInt32(dgvServicios.CurrentRow.Cells[2].Value);
           

            int resultadoActualizarCuenta = bLLCuenta.CargarConsumoCuenta(unaCuenta);

            if (resultadoActualizarCuenta == 1)
            {
                MessageBox.Show("Se ha encargado el servicio correctamente");
            }
            else MessageBox.Show("Hubo un problema al cargar el servicio");

            Consumo consumo = new Consumo();
            consumo.Cliente = new Cliente();
            consumo.Habitacion = new Habitacion();
            consumo.Servicio = new Servicio();
            consumo.Reserva = new Reserva();
            consumo.Reserva.IdReserva = unaCuenta.Reserva.IdReserva;
            consumo.Cliente.idCliente = unaCuenta.Cliente.idCliente;
            consumo.Habitacion.IdHabitacion = unaCuenta.Habitacion.IdHabitacion;
            consumo.Precio = Convert.ToInt32(dgvServicios.CurrentRow.Cells[2].Value);
            consumo.Descripcion= dgvServicios.CurrentRow.Cells[1].Value.ToString();
            BLLConsumo bLLConsumo = new BLLConsumo();
            string servicioSeleccionado = cmbTipoServicio.Text;
            BLLServicios BLLServicios = new BLLServicios();
            List<SGH.BE.Vistas.TipoServicio> datosTipoServicio = BLLServicios.TraerServicioSeleccionado(servicioSeleccionado);
            foreach (var tipoServicio in datosTipoServicio)
            {
                consumo.Servicio.IdServicio = tipoServicio.IdServicio;
            }

            int resultadoCargarConsumo = bLLConsumo.CargarConsumo(consumo);

            if (resultadoCargarConsumo == 1)
            {
                MessageBox.Show("Se ha encargado el consumo de la habitación " + cmbHabitaciones.GetItemText(this.cmbHabitaciones.SelectedItem));
            }
            else MessageBox.Show("Hubo un problema al cargar el servicio");

        }
    }
}
