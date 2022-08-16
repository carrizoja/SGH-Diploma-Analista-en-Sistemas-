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
using SGH.BLL;
using SGH.BE;
using SGH.BE.CompositePermisos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace SGHv1._0.FormsReservas
{
    /// <summary>
    /// Formulario para realizar el Check-In
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class CheckIn : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        BLLIdioma bl = new BLLIdioma();
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckIn"/> class.
        /// </summary>
        public CheckIn()
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
        /// Handles the Load event of the CheckIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CheckIn_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "CheckIn");
            helpProvider1.SetHelpKeyword(this, "CheckIn");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);


            BLLReserva bLLReserva = new BLLReserva();

            dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
            dgvReservas.Columns[0].Visible = false;
            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Handles the CellContentClick event of the dataGridView1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNroReservaSeleccionada.Text = dgvReservas.CurrentRow.Cells[0].Value.ToString();
            lblNroReservaSeleccionada.Visible = true;
            lblNroHabitacion.Text = dgvReservas.CurrentRow.Cells[1].Value.ToString();
            lblNroHabitacion.Visible = true;
            lblNombre.Text = dgvReservas.CurrentRow.Cells[7].Value.ToString() +" "+ dgvReservas.CurrentRow.Cells[8].Value.ToString();
            lblNombre.Visible = true;
            lblNroDias.Text = dgvReservas.CurrentRow.Cells[6].Value.ToString();
            lblNroDias.Visible = true;
            btnRealizarCheckIn.Enabled = true;
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

        private void btnRealizarCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                
                /// <summary>
                /// Se dispara la reserva
                /// </summary>
                

                Reserva reservaACheckIn = new Reserva();
                BLLReserva bLLReserva = new BLLReserva();

                reservaACheckIn.CheckIn = "YES";
                reservaACheckIn.Activa = false;
                int resultadoCheckIn = bLLReserva.RealizarCheckIn(Convert.ToInt32(lblNroReservaSeleccionada.Text), reservaACheckIn);

                if (resultadoCheckIn == 1)
                {
                    MessageBox.Show("Check In Realizado");
                    dgvReservas.DataSource = bLLReserva.TraerTodasLasReservas();
                    BLLCuenta bllCuenta = new BLLCuenta();
                    
                    Reserva reservaObt = new Reserva();
                    Cuenta cuenta = new Cuenta();
                    List<SGH.BE.Vistas.VistaReservaCuenta> listaReservas = bLLReserva.ObtenerReserva(Convert.ToInt32(lblNroReservaSeleccionada.Text));
                    reservaObt.Cliente = new Cliente();
                    reservaObt.habitacion = new Habitacion();
                    foreach (var varReserva in listaReservas)
                    {
                        reservaObt.CantidadDias = varReserva.CantidadDias;
                        reservaObt.Cliente.idCliente = varReserva.idCliente;
                        reservaObt.habitacion.IdHabitacion = varReserva.idHabitacion;
                        reservaObt.IdReserva = varReserva.idReserva;
                        cuenta.Total = varReserva.Precio * varReserva.CantidadDias;

                    }

                  

                    int resultadoAltaCuenta = bllCuenta.CrearCuenta(reservaObt, cuenta);

                    if (resultadoAltaCuenta == 1)
                    {
                        MessageBox.Show("Se ha generado la cuenta para el cliente "+ lblNombre.Text);
                        
                    }
                    if (resultadoAltaCuenta == 0)
                    {
                        MessageBox.Show("Hubo un problema al generar la Cuenta del cliente. Vuelva a intentar más tarde");
                    }
                }
                if (resultadoCheckIn == 0)
                {
                    MessageBox.Show("Hubo un problema al realizar el Check In");
                }

                try
                {
                    Habitacion habitacion = new Habitacion();
                    BLLHabitacion bLLHabitacion = new BLLHabitacion();
                    habitacion.EstadoHabitacion = "Ocupada";
                    int resultadoCambioEstadoHab = bLLHabitacion.CambiarEstadoHabitacion(lblNroHabitacion.Text, habitacion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Data.ToString());
                }
               



                try
                {   

                    Usuario _usuario = Usuario.Instancia;
                    var unaBitacora = new SGH.BE.Bitacora();
                    unaBitacora.fecha = DateTime.Now;
                    unaBitacora.descripcion = "Se realizó un check-In de la reserva numero " + lblNroReservaSeleccionada.Text;
                    unaBitacora.usuario = _usuario;
                    unaBitacora.formulario = this.Name;//poner el nombre de formulario bien alf

                    var bllBitacora = new SGH.BLL.BLLBitacora();
                    bllBitacora.GrabarBitacora(unaBitacora);
                }
                catch (Exception ax)
                {
                    MessageBox.Show(ax.Data.ToString());
                }

                BLLServicios bLLServicios = new BLLServicios();


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

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }

        }
        /// <summary>
        /// Handles the Click event of the btnImprimirListadoReservas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnImprimirListadoReservas_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dgvReservas.ColumnCount);
            pdfTable.DefaultCell.Padding = 6;
            pdfTable.WidthPercentage = 80;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            //pdfTable.DefaultCell.Padding = 3;
            //pdfTable.WidthPercentage = 30;
            //pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            //pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dgvReservas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        pdfTable.AddCell(cell.Value.ToString());
            //    }
            //}
            int row = dgvReservas.Rows.Count;
            int cell2 = dgvReservas.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (dgvReservas.Rows[i].Cells[j].Value == null)
                    {
                        //return directly
                        //return;
                        //or set a value for the empty data
                        dgvReservas.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(dgvReservas.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\SGH\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ReservasExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Se generó el PDF correctamente");
        }
    }
}
