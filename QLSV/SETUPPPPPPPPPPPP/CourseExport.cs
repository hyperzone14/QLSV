using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Word;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace QLSV
{
    public class CourseExport
    {
        public void exportDataToPDF(DataGridView DGV, string filename)
        {
            PdfPTable pdfTable = new PdfPTable(DGV.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            foreach (DataGridViewColumn column in DGV.Columns)
            {
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 13, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK);
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times)) { BorderWidth = 1, VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                cell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in DGV.Rows)
            {
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 11, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                PdfPCell id = new PdfPCell(new Phrase(row.Cells[0].Value.ToString().Trim(), times)) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                pdfTable.AddCell(id);
                PdfPCell name = new PdfPCell(new Phrase(row.Cells[1].Value.ToString().Trim(), times)) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                pdfTable.AddCell(name);
                PdfPCell period = new PdfPCell(new Phrase(row.Cells[2].Value.ToString().Trim(), times)) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                pdfTable.AddCell(period);
                PdfPCell description = new PdfPCell(new Phrase(row.Cells[3].Value.ToString().Trim(), times)) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                pdfTable.AddCell(description);
                PdfPCell semester = new PdfPCell(new Phrase(row.Cells[4].Value.ToString().Trim(), times)) { VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_CENTER };
                pdfTable.AddCell(semester);
            }
            using (FileStream stream = new FileStream(filename, FileMode.Create))
            {
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 26, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK);
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream); pdfDoc.Open();
                string ok = "Course List" + "                                                                                                                                                                     ";
                iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph(ok, times);
                title.Font.SetFamily("Times New Roman");
                title.Font.SetStyle("bold");
                title.Alignment = 1;
                pdfDoc.Add(title);
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
        public void exportDataToExcel(System.Data.DataTable dt, string sheetName, string title, string filename)
        {

            //Tạo các đối tượng Excel
            Excel.Application oExcel = new Excel.Application();
            Excel.Workbooks oBooks;
            Excel.Sheets oSheets;
            Excel.Workbook oBook;
            Excel.Worksheet oSheet;
            Object oMissing = System.Reflection.Missing.Value;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn
            Excel.Range head = oSheet.get_Range("A1", "C1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Italic = true;
            head.Font.Name = "Comic Sans MS";
            head.Font.Size = "18";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Course ID";
            cl1.Font.Name = "Comic Sans MS";
            cl1.ColumnWidth = 13.5;

            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Course Name";
            cl2.Font.Name = "Comic Sans MS";
            cl2.ColumnWidth = 20.0;

            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Period";
            cl3.Font.Name = "Comic Sans MS";
            cl3.ColumnWidth = 10.0;

            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Description";
            cl4.Font.Name = "Comic Sans MS";
            cl4.ColumnWidth = 25.0;

            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Semester";
            cl5.Font.Name = "Comic Sans MS";
            cl5.ColumnWidth = 10.0;

            /*Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Phone";

            cl6.ColumnWidth = 25.0;

            Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Address";

            cl7.ColumnWidth = 35.0;

            Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Picture";

            cl8.ColumnWidth = 12.5;*/

            //Excel.Range c19 = oSheet.get_Range("H4", "H" + dt.Rows.Count);
            /*c19.ColumnWidth = 15.0;
            c19.RowHeight = 15.0;*/

            Excel.Range rowHead = oSheet.get_Range("A3", "E3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;
            // Ô bắt đầu điền dữ liệu
            Excel.Range c1 = (Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Excel.Range c2 = (Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Excel.Range range = oSheet.get_Range(c1, c2);
            range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            range.Font.Name = "Comic Sans MS";
            //range.RowHeight = 69.0;
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;
            // Kẻ viền
            range.Borders.LineStyle = Excel.Constants.xlSolid;

            // Căn giữa cột STT
            Excel.Range c3 = (Excel.Range)oSheet.Cells[rowEnd, columnStart];
            Excel.Range c4 = oSheet.get_Range(c1, c3);
            oSheet.get_Range(c3, c4).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            oBook.SaveAs(filename);
        }
        public void exportDataToWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                Word.Application word = new Word.Application();//make a new word object
                Word.Document doc = word.Documents.Add();//make a new document
                word.Visible = true;
                word.WindowState = Word.WdWindowState.wdWindowStateNormal;

                //Tittle
                Range range = doc.Range(0, 0);
                Word.Paragraph title;
                title = doc.Paragraphs.Add();
                title.Range.Text = "Course List";
                title.Range.Font.Size = 26;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                title.Range.Bold = 1;
                title.Range.Font.Name = "Comic Sans MS";
                Range rng = doc.Range(11, 11);

                Table wdTable = doc.Tables.Add(rng, DGV.Rows.Count+1, DGV.Columns.Count);//make a new table based on our data grid view
                wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;//make a thick outer border
                wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wdTable.Range.Bold = 0;
                wdTable.Range.Font.Size = 18;
                wdTable.Range.Font.Name = "Times New Roman";
                wdTable.AllowAutoFit = false;
                wdTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                doc.Application.Visible = true;
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
                Object oMissing = System.Reflection.Missing.Value;
                doc = word.ActiveDocument;
                  int next = 0;
                foreach (DataGridViewColumn column in DGV.Columns)
                {

                    wdTable.Cell(1, next + 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    wdTable.Cell(1, next + 1).Range.Bold = 1;
                    wdTable.Cell(1, next + 1).Range.Italic = 1;
                    wdTable.Cell(1, next + 1).Range.InsertAfter(column.HeaderText.Trim());
                    next++;
                }
                for (int r = 1; r <= RowCount; r++)
                {
                    //oTemp = "";
                    for (int c = 0; c < ColumnCount ; c++)
                    {
                        wdTable.Cell(r + 1, c + 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        wdTable.Cell(r + 1, c + 1).Range.InsertAfter(DGV.Rows[r-1].Cells[c].Value.ToString().Trim());
                    }
                    var oPara1 = doc.Content.Paragraphs.Add(ref oMissing);
                    var oPara2 = doc.Content.Paragraphs.Add(ref oMissing);
                }
                //save the file
                doc.SaveAs2(filename);
            }

        }
        public void exportDataToWord2(DataGridView DGV, string filename,string coursenameok)
        {
            if (DGV.Rows.Count != 0)
            {
                Word.Application word = new Word.Application();//make a new word object
                Word.Document doc = word.Documents.Add();//make a new document
                word.Visible = true;
                word.WindowState = Word.WdWindowState.wdWindowStateNormal;

                ////Tittle
                //Range range = doc.Range(0, 0);
                //Word.Paragraph title;
                //title = doc.Paragraphs.Add();
                //title.Range.Text = "Student List By Course";
                //title.Range.Font.Size = 26;
                //title.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                //title.Range.Bold = 1;
                //title.Range.Font.Name = "Comic Sans MS";
                //Range rng = doc.Range(22, 22);

                //Course Name

                Word.Paragraph coursename;
                coursename = doc.Paragraphs.Add();
                coursename.Range.Text = "List Student Of " + coursenameok.Trim();
                coursename.Range.Font.Size = 20;
                coursename.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                coursename.Range.Bold = 1;
                coursename.Range.Italic = 1;
                coursename.Range.Font.Name = "Comic Sans MS";
                Range rng = doc.Range(16 + coursenameok.Trim().Length, 16 + coursenameok.Trim().Length);

                Table wdTable = doc.Tables.Add(rng, DGV.Rows.Count+1, DGV.Columns.Count);//make a new table based on our data grid view
                wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;//make a thick outer border
                wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wdTable.Range.Bold = 0;
                wdTable.Range.Font.Size = 18;
                wdTable.Range.Font.Name = "Times New Roman";
                wdTable.AllowAutoFit = false;
                wdTable.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitContent);
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                doc.Application.Visible = true;
                doc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;

                Object oMissing = System.Reflection.Missing.Value;
                doc = word.ActiveDocument;
                 int next = 0;
                foreach (DataGridViewColumn column in DGV.Columns)
                {

                    wdTable.Cell(1, next + 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    wdTable.Cell(1, next + 1).Range.Bold = 1;
                    wdTable.Cell(1, next + 1).Range.Italic = 1;
                    wdTable.Cell(1, next + 1).Range.InsertAfter(column.HeaderText.Trim());
                    next++;
                }
                for (int r = 1; r <= RowCount; r++)
                {
                    //oTemp = "";
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        wdTable.Cell(r + 1, c + 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        wdTable.Cell(r + 1, c + 1).Range.InsertAfter(DGV.Rows[r-1].Cells[c].Value.ToString().Trim());
                    }
                    var oPara1 = doc.Content.Paragraphs.Add(ref oMissing);
                    var oPara2 = doc.Content.Paragraphs.Add(ref oMissing);
                }
                //save the file
                doc.SaveAs2(filename);
            }
        }

    }
}