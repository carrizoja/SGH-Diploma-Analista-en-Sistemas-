using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using iTextSharp.text; pendiente colocar referencia a Framework

/*
namespace SGH.Servicios
{
    public class ExportadorDePdf : IExportadorDeArchivos<ListView>
    {
        public void ExportarArchivo(ListView TablaExportar, string NombrePdfAExportar)
        {
            DataTable dataTable = new DataTable();

            var columns = TablaExportar.Columns.Count;

            foreach (ColumnHeader column in TablaExportar.Columns)
                dataTable.Columns.Add(column.Text);

            foreach (ListViewItem item in TablaExportar.Items)
            {
                var cells = new object[columns];
                for (var i = 0; i < columns; i++)
                    cells[i] = item.SubItems[i].Text;
                dataTable.Rows.Add(cells);
            }


            string path = @"C:\" + NombrePdfAExportar + Guid.NewGuid() + ".pdf";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 12, 1, iTextSharp.text.BaseColor.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Backup History".ToUpper(), fntHead));


            PdfPTable table = new PdfPTable(dataTable.Columns.Count) { WidthPercentage = 100 };

            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 8, 1, iTextSharp.text.BaseColor.WHITE);
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.GRAY;
                cell.AddElement(new Chunk(dataTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }


            BaseFont btnColumnHeader2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader2 = new iTextSharp.text.Font(btnColumnHeader2, 10, 1, iTextSharp.text.BaseColor.BLACK);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    PdfPCell cell2 = new PdfPCell();
                    cell2.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
                    cell2.AddElement(new Chunk(dataTable.Rows[i][j].ToString(), fntColumnHeader2));
                    table.AddCell(cell2);
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();

            MessageBox.Show("pdf hecho con exito");
        }
    }
}
*/