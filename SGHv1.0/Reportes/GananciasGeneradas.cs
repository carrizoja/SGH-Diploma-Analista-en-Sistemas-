using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGH.BE;
using SGH.BE.CompositePermisos;
using SGH.BE.MultiIdioma;
using SGH.BE.Observer;
using SGH.BLL;
using SGH.BE.Vistas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SGHv1._0.Reportes
{
    /// <summary>
    /// Formulario para mostrar las ganancias generadas
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class GananciasGeneradas : Form, IObserver
    {
        Idioma idioma = Idioma.InstanciaIdioma;
        int totalCalculado = 0;
        /// <summary>
        /// Initializes a new instance of the <see cref="GananciasGeneradas"/> class.
        /// </summary>
        public GananciasGeneradas()
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
        /// Handles the Load event of the GananciasGeneradas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GananciasGeneradas_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = Application.StartupPath + "/SGH.chm";
            helpProvider1.SetHelpString(this, "GananciasGeneradas");
            helpProvider1.SetHelpKeyword(this, "GananciasGeneradas");
            helpProvider1.SetHelpNavigator(this, HelpNavigator.KeywordIndex);

            limpiarCombos();
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

        private void grbFiltroPorFecha_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the CloseUp event of the dateTimePicker2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            DateTime fechaDesde = Convert.ToDateTime(dtpDesde.Text);
            DateTime fechaHasta = Convert.ToDateTime(dtpHasta.Text);
            if (fechaDesde <= fechaHasta)
            {
                DateTime horaActual = DateTime.Now;
                if (fechaHasta <= horaActual)
                {
                    TimeSpan ts = fechaHasta.Subtract(fechaDesde);
                    int dias = Convert.ToInt16(ts.Days);
                    MessageBox.Show("Se ha seleccionado un filtro de fecha para " + ts.Days + " dias");
                }
                else MessageBox.Show("La fecha no puede ser mayor a la fecha actual");
            }


            else
            {
                MessageBox.Show("La fecha de Egreso debe ser superior a la de Ingreso");
            }
        }
        /// <summary>
        /// Traer combos.
        /// </summary>
        void traerCombos()
        {
            
            BLLTipoHabitacion bLLTipoHabitacion = new BLLTipoHabitacion();
            BLLCategoriaHabitacion bLLCategoriaHabitacion = new BLLCategoriaHabitacion();

            
           
            var _tiposAgregar = bLLTipoHabitacion.TraerTodosTiposhabitacion();
            foreach (var itemsTipos in _tiposAgregar)
            {
                cmbPorTipo.Items.Add(itemsTipos.Tipo);
                cmbPorTipo.DisplayMember = "Nombre Tipo";
            }

            var _categoriasAgregar = bLLCategoriaHabitacion.TraerTodasCategoriashabitacion();

            foreach (var itemsCategoria in _categoriasAgregar)
            {
                cmbPorCategoria.Items.Add(itemsCategoria.Categoria);
                cmbPorCategoria.DisplayMember = "Nombre Formulario";
            }
        }
        /// <summary>
        /// Handles the Click event of the btnGenerarPDF control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = FromListView(lstReservas);


            string path = @"C:\SGH\reporte.pdf";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Reporte Reservas".ToUpper(), fntHead));


            PdfPTable table = new PdfPTable(dataTable.Columns.Count);

            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i <= dataTable.Columns.Count - 1; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(dataTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    table.AddCell(dataTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("pdf hecho con exito");
        }
        /// <summary>
        /// Froms the ListView.
        /// </summary>
        /// <param name="lvw">The LVW.</param>
        /// <returns></returns>
        public static DataTable FromListView(ListView lvw)
        {
            DataTable table = new DataTable();

            var columns = lvw.Columns.Count;

            foreach (ColumnHeader column in lvw.Columns)
                table.Columns.Add(column.Text);

            foreach (ListViewItem item in lvw.Items)
            {
                var cells = new object[columns];
                for (var i = 0; i < columns; i++)
                    cells[i] = item.SubItems[i].Text;
                table.Rows.Add(cells);
            }

            return table;
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
                lstReservas.Clear();

                totalCalculado = 0;
                
                lstReservas.Clear();
                lstReservas.View = View.Details;
                lstReservas.FullRowSelect = true;
                lstReservas.MultiSelect = false;

                lstReservas.Columns.Add("Numero Habitación", 200);
                lstReservas.Columns.Add("Tipo Habitación", 200);
                lstReservas.Columns.Add("Categoría Habitación", 200);
                lstReservas.Columns.Add("Total Estadia", 200);
                lstReservas.Columns.Add("Fecha Llegada", 150);
                lstReservas.Columns.Add("Nombre Cliente", 200);

                if (cmbPorTipo.SelectedIndex >= 0)
                {
                    TipoHabitacion tipoHabitacion = new TipoHabitacion();
                    tipoHabitacion.Tipo = cmbPorTipo.GetItemText(this.cmbPorTipo.SelectedItem); 
                    if ((dtpDesde.Checked) && (dtpHasta.Checked) && (cmbPorTipo.SelectedIndex >= 0) && (cmbPorCategoria.SelectedIndex >= 0))
                    {
                        CategoriaHabitacion categoriaHabitacion = new CategoriaHabitacion();
                        categoriaHabitacion.Categoria = cmbPorCategoria.GetItemText(this.cmbPorCategoria.SelectedItem);
                        BLLReserva bLLReserva = new BLLReserva();
                        List<VistaReporteReserva> resultadoReservas = bLLReserva.TraerTodosLosReportesReservas(tipoHabitacion, categoriaHabitacion, dtpDesde.Value, dtpHasta.Value);
                        foreach (var vista in resultadoReservas)
                        {
                            totalCalculado = totalCalculado + vista.Total;
                        }

                        foreach (var item in resultadoReservas)
                        {
                            String[] row = { item.Numero, item.Tipo, item.Categoria, item.Total.ToString(), item.FechaLlegada.ToString(), item.Nombre + " " + item.Apellido };

                            ListViewItem item2 = new ListViewItem(row);

                            lstReservas.Items.Add(item2);

                        }
                        lblTotalCalculado.Text = totalCalculado.ToString();
                       
                    }
                    else 
                    {
                        BLLReserva bLLReserva = new BLLReserva();
                        

                        List<VistaReporteReserva> resultadoReservas = bLLReserva.TraerTodosLosReportesReservas(tipoHabitacion);
                        foreach (var vista in resultadoReservas)
                        {
                            totalCalculado = totalCalculado + vista.Total;
                        }

                        foreach (var item in resultadoReservas)
                        {
                            String[] row = { item.Numero, item.Tipo, item.Categoria, item.Total.ToString(), item.FechaLlegada.ToString(), item.Nombre + " " + item.Apellido };

                            ListViewItem item2 = new ListViewItem(row);

                            lstReservas.Items.Add(item2);

                        }
                        lblTotalCalculado.Text = totalCalculado.ToString();
                       
                    }
                    
                }


                else if ((cmbPorCategoria.SelectedIndex >= 0))
                {
                    BLLReserva bLLReserva = new BLLReserva();
                    CategoriaHabitacion categoriaHabitacion = new CategoriaHabitacion();
                    categoriaHabitacion.Categoria = cmbPorCategoria.GetItemText(this.cmbPorCategoria.SelectedItem);
                    List<VistaReporteReserva> resultadoReservas = bLLReserva.TraerTodosLosReportesReservas(categoriaHabitacion);
                    foreach (var vista in resultadoReservas)
                    {
                        totalCalculado = totalCalculado + vista.Total;
                    }

                    foreach (var item in resultadoReservas)
                    {
                        String[] row = { item.Numero, item.Tipo, item.Categoria, item.Total.ToString(), item.FechaLlegada.ToString(), item.Nombre + " " + item.Apellido };

                        ListViewItem item2 = new ListViewItem(row);

                        lstReservas.Items.Add(item2);

                    }
                    lblTotalCalculado.Text = totalCalculado.ToString();
                
                }
                else if ((dtpDesde.Checked) && (dtpHasta.Checked))
                {
                    BLLReserva bLLReserva = new BLLReserva();
                    List<VistaReporteReserva> resultadoReservas = bLLReserva.TraerTodosLosReportesReservas(dtpDesde.Value, dtpHasta.Value);
                    foreach (var vista in resultadoReservas)
                    {
                        totalCalculado = totalCalculado + vista.Total;
                    }

                    foreach (var item in resultadoReservas)
                    {
                        String[] row = { item.Numero, item.Tipo, item.Categoria, item.Total.ToString(), item.FechaLlegada.ToString(), item.Nombre + " " + item.Apellido };

                        ListViewItem item2 = new ListViewItem(row);

                        lstReservas.Items.Add(item2);

                    }
                    lblTotalCalculado.Text = totalCalculado.ToString();
                 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
            }


        }
        /// <summary>
        /// Limpiar combos.
        /// </summary>
        void limpiarCombos()
        {
            totalCalculado = 0;
            cmbPorTipo.Text = " ";
            cmbPorCategoria.Text = " ";
            cmbPorTipo.Items.Clear();
            cmbPorCategoria.Items.Clear();
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);

            traerCombos();

            lstReservas.View = View.Details;
            lstReservas.FullRowSelect = true;
            lstReservas.MultiSelect = false;

            lstReservas.Columns.Add("Numero Habitación", 200);
            lstReservas.Columns.Add("Tipo Habitación", 200);
            lstReservas.Columns.Add("Categoría Habitación", 200);
            lstReservas.Columns.Add("Total Estadia", 200);
            lstReservas.Columns.Add("Fecha Llegada", 150);
            lstReservas.Columns.Add("Nombre Cliente", 200);

            BLLReserva bLLReserva = new BLLReserva(); 
            List<VistaReporteReserva> resultadoReservas = bLLReserva.TraerTodosLosReportesReservas();
            foreach (var vista in resultadoReservas)
            {
                totalCalculado = totalCalculado + vista.Total;
            }

            foreach (var item in resultadoReservas)
            {
                String[] row = { item.Numero, item.Tipo, item.Categoria, item.Total.ToString(), item.FechaLlegada.ToString(), item.Nombre + " " + item.Apellido };

                ListViewItem item2 = new ListViewItem(row);

                lstReservas.Items.Add(item2);

            }
            lblTotalCalculado.Text = totalCalculado.ToString();

        }
        /// <summary>
        /// Handles the Click event of the btnLimpiar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            totalCalculado = 0;
            lstReservas.Clear();
            lblTotalCalculado.Text = " ";
            limpiarCombos();
            
            
           

            
            
        }

        private void lstReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
