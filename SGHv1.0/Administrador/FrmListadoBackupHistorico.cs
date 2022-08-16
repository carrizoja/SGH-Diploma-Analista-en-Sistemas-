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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SGHv1._0.Administrador
{
    /// <summary>
    /// Form que muestra el listado histórico de los backups
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// <seealso cref="SGH.BE.Observer.IObserver" />
    public partial class FrmListadoBackupHistorico : Form, IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmListadoBackupHistorico"/> class.
        /// </summary>
        public FrmListadoBackupHistorico()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Nombre Base", 150);
            listView1.Columns.Add("Nombre Backup", 150);
            listView1.Columns.Add("Ruta", 150);
            listView1.Columns.Add("Usuario", 150);
            listView1.Columns.Add("Fecha", 150);

            BLLBackupRestore bLLBackupRestore = new BLLBackupRestore();

            var datosBackup = bLLBackupRestore.TraerDatosBackup();

            foreach (var item2 in datosBackup)
            {
                String[] row = { item2.NombreBase, item2.NombreBackup, item2.Ruta, item2.Usuario, item2.Fecha.ToString() };

                ListViewItem item = new ListViewItem(row);

                listView1.Items.Add(item);
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
        /// Handles the Load event of the FrmListadoBackupHistorico control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmListadoBackupHistorico_Load(object sender, EventArgs e)
        {
            BLLIdioma _traduccion = new BLLIdioma();
            Idioma idioma = Idioma.InstanciaIdioma;
            Form form = this;
            _traduccion.Traducir(idioma.IdIdioma, form);
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
        /// Handles the Click event of the btnGenerarReporte control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = FromListView(listView1);


            string path = @"C:\test.pdf";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Backup History".ToUpper(), fntHead));


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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the 1 event of the btnGenerarReporte_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = FromListView(listView1);


            string path = @"C:\SGH\test.pdf";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Backup History".ToUpper(), fntHead));


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
