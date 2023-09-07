using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;


namespace QLSV
{
    internal class ResultExport
    {
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
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Student ID";
            cl1.ColumnWidth = 13.5;

            Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "First Name";
            cl2.ColumnWidth = 25.0;

            Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Last Name";
            cl3.ColumnWidth = 10.0;

            Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "PRTE";
            cl4.ColumnWidth = 25.0;

            Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "WDPR";
            cl5.ColumnWidth = 10.0;

            Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "DBMS";
            cl6.ColumnWidth = 25.0;

            Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "CLDCOMP";
            cl7.ColumnWidth = 35.0;

            Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "CAAL";
            cl8.ColumnWidth = 15.0;

            Excel.Range cl9 = oSheet.get_Range("I3", "i3");
            cl9.Value2 = "Aerage Grade";
            cl9.ColumnWidth = 15.0;

            Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Result";
            cl10.ColumnWidth = 15.0;

            Excel.Range c19 = oSheet.get_Range("J4", "J" + dt.Rows.Count);           
            c19.ColumnWidth = 15.0;
            c19.RowHeight = 15.0;

            Excel.Range rowHead = oSheet.get_Range("A3", "J3");

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
        //version1
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
                title.Range.Text = "Student Score Report";
                title.Range.Font.Size = 26;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.Bold = 1;
                title.Range.Font.Name = "Comic Sans MS";

                Range rng = doc.Range(20, 20);
                Table wdTable = doc.Tables.Add(rng, DGV.Rows.Count+1, DGV.Columns.Count);//make a new table based on our data grid view
                wdTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleDouble;//make a thick outer border
                wdTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wdTable.Range.Bold = 0;
                wdTable.Range.Font.Size = 14;
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
                for (int r = 1; r <= RowCount ; r++)
                {
                    //oTemp = "";
                    for (int c = 0; c < ColumnCount; c++)
                    {
                        wdTable.Cell(r + 1, c + 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        wdTable.Cell(r + 1, c + 1).Range.InsertAfter(DGV.Rows[r-1].Cells[c].Value.ToString().Trim());
                    }
                    var oPara1 = doc.Content.Paragraphs.Add(ref oMissing);
                    var oPara2 = doc.Content.Paragraphs.Add(ref oMissing);
                    //wdTable.Cell(r + 1, 8).Range.Paste();
                }
                //save the file
                doc.SaveAs2(filename);
            }
        }
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }
        //version2
        public void CreateWordDocument(object filename, object savaAs, string studentid, string fullname, string prte, string wdpr, string dbms, string cldcomp, string caal, string score, string result, string rating)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            //string tempPath = null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();

                //Find and replace:
                this.FindAndReplace(wordApp, "<studentid>", studentid);
                this.FindAndReplace(wordApp, "<fullname>", fullname);
                this.FindAndReplace(wordApp, "<prte>", prte);
                this.FindAndReplace(wordApp, "<wdpr>", wdpr);
                this.FindAndReplace(wordApp, "<dbms>", dbms);
                this.FindAndReplace(wordApp, "<cldcomp>", cldcomp);
                this.FindAndReplace(wordApp, "<caal>", caal);
                this.FindAndReplace(wordApp, "<score>", score);
                this.FindAndReplace(wordApp, "<result>", result);
                this.FindAndReplace(wordApp, "<rating>", rating);

                //insert the picture:
                //Image img = resizeImage(pathImage, new Size(200, 90));
                //tempPath = System.Windows.Forms.Application.StartupPath + "\\Images\\~Temp\\temp.jpg";
                //img.Save(tempPath);

                Object oMissed = aDoc.Paragraphs[1].Range; //the position you want to insert
                Object oLinkToFile = false;  //default
                Object oSaveWithDocument = true;//default
                //aDoc.InlineShapes.AddPicture(tempPath, ref oLinkToFile, ref oSaveWithDocument, ref oMissed);

                #region Print Document :
                /*object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document document = aDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    document.PrintOut(
                    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                */
                #endregion

            }
            else
            {
                MessageBox.Show("Template path is corrupted!", "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            //File.Delete(tempPath);
            MessageBox.Show("File created successfully!", "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }
        //Change Picture Size :
        private static Image resizeImage(string filename, Size size)
        {
            Image imgToResize = Image.FromFile(filename);
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }
    }
}
