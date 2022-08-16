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
using System.Security.Cryptography.X509Certificates;

namespace SGHv1._0.FormsCuentas
{
    /// <summary>
    ///  Formulario para ver el estado de la cuenta de cada Habitación
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmVerEstadoCuentaHabitaciones : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmVerEstadoCuentaHabitaciones"/> class.
        /// </summary>
        public FrmVerEstadoCuentaHabitaciones()
        {
            InitializeComponent();
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
        /// Handles the Click event of the btnSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handles the Load event of the FrmVerEstadoCuentaHabitaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmVerEstadoCuentaHabitaciones_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "VerEstadodeCuentasHabitaciones");
            helpProvider1.SetHelpKeyword(this, "VerEstadodeCuentasHabitaciones");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
            try
            {
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

        private void dgvConsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbHabitaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConsultarConsumos.Enabled = true;
            btnRealizarCheckOut.Enabled = true;
        }
        /// <summary>
        /// Handles the Click event of the btnConsultarConsumos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnConsultarConsumos_Click(object sender, EventArgs e)
        {
            lblTotalCalculado.Visible = false;
            lblNombreHuesped.Visible = false;
            
            BLLConsumo bLLConsumo = new BLLConsumo();
            ;
            dgvConsumos.DataSource = bLLConsumo.ListarConsumosPorHabitacion(cmbHabitaciones.GetItemText(this.cmbHabitaciones.SelectedItem));

            dgvConsumos.Columns[2].Visible = false;
            dgvConsumos.Columns[3].Visible = false;
            dgvConsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            if (dgvConsumos.Rows.Count !=0)
            {
               lblNombreHuesped.Text = dgvConsumos.CurrentRow.Cells[2].Value.ToString() + " " + dgvConsumos.CurrentRow.Cells[3].Value.ToString();
               lblNombreHuesped.Visible = true;
               CalcularTotal();
            }
             else MessageBox.Show("La habitación " + cmbHabitaciones.SelectedItem.ToString() + " aún no ha generado consumos");

            

            void CalcularTotal()
            {
                int sum = 0;
                for (int i = 0; i < dgvConsumos.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dgvConsumos.Rows[i].Cells[1].Value);
                }
                lblTotalCalculado.Visible = true;
                lblTotalCalculado.Text = sum.ToString();
            }


            



        }
        /// <summary>
        /// Handles the Click event of the btnRealizarCheckOut control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRealizarCheckOut_Click(object sender, EventArgs e)
        {
            BLLCuenta bLLCuenta = new BLLCuenta();

            Cuenta unaCuenta = new Cuenta();
            
            List<CuentaObtenida> listaCuentaObtenidas = bLLCuenta.ObtenerCuentaFinal(dgvConsumos.CurrentRow.Cells[3].Value.ToString(), cmbHabitaciones.GetItemText(this.cmbHabitaciones.SelectedItem));
            unaCuenta.Habitacion = new Habitacion();
            unaCuenta.Cliente = new Cliente();
            unaCuenta.Reserva = new Reserva();
            foreach (var cuenta in listaCuentaObtenidas)
            {
                unaCuenta.IdCuenta = cuenta.IdCuenta;
                unaCuenta.Habitacion.IdHabitacion = cuenta.IdHabitacion;
                unaCuenta.Total = cuenta.Total;
                unaCuenta.Cliente.idCliente = cuenta.idCliente;
                unaCuenta.Reserva.IdReserva = cuenta.IdReserva;
            }
            int resultadoCerrarCuenta = bLLCuenta.CerrarCuenta(unaCuenta.IdCuenta);
            if (resultadoCerrarCuenta == 1)
            {
                MessageBox.Show("Se ha cerrado correctamente la cuenta de la habitación " + cmbHabitaciones.GetItemText(this.cmbHabitaciones.SelectedItem));
                MessageBox.Show("Total a pagar: " + unaCuenta.Total.ToString() + " pesos");
            }
            else MessageBox.Show("Hubo un problema al cerrar la cuenta");

            BLLConsumo bLLConsumo = new BLLConsumo();
            int resultadoCerrarConsumos = bLLConsumo.CerrarConsumos(unaCuenta);
            if (resultadoCerrarConsumos == 1)
            {
                MessageBox.Show("Consumos cerrados correctamente ");
            }
            else MessageBox.Show("Hubo un problema al cerrar los consumos");

            BLLHabitacion bLLHabitacion = new BLLHabitacion();
            Habitacion habitacion = new Habitacion();
            habitacion.EstadoHabitacion = "libre";

            int resultadoLiberacionHab = bLLHabitacion.LiberarHabitacion(unaCuenta.Habitacion.IdHabitacion);
            if (resultadoLiberacionHab == 1)
            {
                MessageBox.Show("La habitación " + this.cmbHabitaciones.SelectedItem + " fue liberada correctamente");
            }
            else MessageBox.Show("Hubo un problema al liberar la habitación");
          
            BLLReserva bLLReserva = new BLLReserva();
            int resultadoReservaInactiva = bLLReserva.CambiarEstadoReserva(unaCuenta);
            if (resultadoReservaInactiva == 1)
            {
                MessageBox.Show("La reserva a pasado a estado inactivo");
            }
            else MessageBox.Show("Hubo un problema al desactivar la reserva");
            cmbHabitaciones.Items.Clear();
            LimpiarFormulario();

        }
        /// <summary>
        /// Limpia formulario.
        /// </summary>
        void LimpiarFormulario()
        {
            dgvConsumos.Columns.Clear();

            BLLHabitacion bllHabitacion = new BLLHabitacion();
            List<Habitacion> _habitaciones = new List<Habitacion>();
            var _habitacionesAgregar = bllHabitacion.TraerTodasLasHabitacionesDesocupadas();

            foreach (var itemshab in _habitacionesAgregar)
            {
                cmbHabitaciones.Items.Add(itemshab.Numero);
                cmbHabitaciones.DisplayMember = "Numero";
            }

            btnConsultarConsumos.Enabled = false;
            lblTotalCalculado.Visible = false;
            lblNombreHuesped.Visible = false;
            btnRealizarCheckOut.Enabled = false;
        }
        /// <summary>
        /// Handles the Click event of the btnLimpiar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblNombreHuesped.Visible = false;
            lblTotalCalculado.Visible = false;
            
        }
    }
}
