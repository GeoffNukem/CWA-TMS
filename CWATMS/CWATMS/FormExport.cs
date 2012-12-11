using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using CWATMS.Controls;

namespace CWATMS
{
    public partial class FormExport : Form
    {

        /// <summary>
        /// 
        /// </summary>
        static class Constants
        {
            public const string titleLec = "List_of_Lecturers";
            public const string titleMod = "List_of_Modules";
            public const string titleRoo = "List_of_Rooms";
            public const string titleGro = "List_of_Groups";
            public const string pdfFoter = " The A Team , Timetable Mangement System. Date and time produced ";
            public const string lisLoc = @"PDF\Lists\";
            public const string tempJpeg = @"PDF\temp.jpg";
            public const string error = "Error - ";
            public const string opdf = "Open ";
            public const string ppdf = "Print Dialog ";
            public const string pppdf = "Print Preview ";
        }

        static class ConstantsErrorCode
        {
            public const string ec0058 = "PC LOAD LETTER 0058";
        }


        public int expotchoice = 0;
        public int expotchoiceopen = 0;
        public int ameoffpdfss = 1;
        /// <summary>
        /// THe class constructor.
        /// </summary>
        public FormExport()
        {
            InitializeComponent();
            fill_dgv();
            populateTab();
        }

        // LIST HOME TAB
        /// <summary>
        /// Method which exports list's of lecturer, modules, rooms and groups to PDF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Export_All_To_PDF_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            string comple = Constants.titleLec + " " + Constants.titleMod + " " + Constants.titleRoo + " " + Constants.titleGro + " ";
            lecturer_List_Export();
            modules_List_Export();
            rooms_List_Export();
            Groups_List_Export();
            change_Cursor(1);
            export_Complete(comple);
        }
        /// <summary>
        /// Opens PDF lecturer, modules, rooms and groups.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_All_List_PDF_Click(object sender, EventArgs e)
        {

            string sourceName = Constants.lisLoc + Constants.titleLec + ".pdf " + Constants.lisLoc + Constants.titleMod + ".pdf " + Constants.lisLoc + Constants.titleRoo + ".pdf " + Constants.lisLoc + Constants.titleGro + ".pdf ";
            view_PDF(sourceName);
        }

// LIST LECTURER TAB


        /// <summary>
        /// Button code that exports list of lecturers to PDF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            change_Cursor(0);              // changes cursor to wait
            lecturer_List_Export();       // exports list to pdf
            change_Cursor(1);            // changes cursor back to default
            export_Complete(Constants.titleLec);  //acknowledgement of completion


        }

        /// <summary>
        /// sends parameters to create pdf method
        /// </summary>
        public void lecturer_List_Export()
        {
            string sfname = "Lecturer Name";
            string slabel = "Label";
            string shpw = "Hours Per Module";
            //string scolour = "Colour";

            create_PDF_5(Constants.titleLec, sfname, shpw, slabel);
        }

        /// <summary>
        /// BUtton that open PDF of list of lecturers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_PDF_List_Lecturers_Click(object sender, EventArgs e)
        {


            string sourceName = Constants.lisLoc + Constants.titleLec + ".pdf";
            does_File_Exist(sourceName, Constants.titleLec, 1);

        }

        /// <summary>
        /// Print list of lecturers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleLec + ".pdf";

            does_File_Exist(sourceName, Constants.titleLec, 2);
        }

        /// <summary>
        /// Print list of lecturers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Print_PDF_Lst_Lecturers_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleLec + ".pdf";

            does_File_Exist(sourceName, Constants.titleLec, 3);

        }

// MODULES TAB


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            modules_List_Export();
            change_Cursor(1);
            export_Complete(Constants.titleMod);
        }

        /// <summary>
        /// Open PDF of list of modules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Mod_Open_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleMod + ".pdf";
            does_File_Exist(sourceName, Constants.titleMod, 1);
        }

        /// <summary>
        /// Export List of modules to PDF
        /// </summary>
        public void modules_List_Export()
        {
            string sname = "Subject";
            string scourselevel = "Course Level";
            string slabel = "Label";
            string scolour = "Colour";
            int dgv = 0;

            create_PDF_4(Constants.titleMod, dgv, sname, scourselevel, slabel, scolour);
        }

        /// <summary>
        /// Open PDF (list of modules)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_PDF_List_Modules_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleMod + ".pdf";
            does_File_Exist(sourceName, Constants.titleMod, 1);
        }

        /// <summary>
        /// PRint PDF(List of modules) show print dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Mod_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleMod + ".pdf";

            does_File_Exist(sourceName, Constants.titleMod, 2);
        }

        /// <summary>
        ///  PRint PDF(List of modules) show print dialog and PDF preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Mod_Print_Pre_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleMod + ".pdf";

            does_File_Exist(sourceName, Constants.titleLec, 3);
        }

 // ROOM TAB

        /// <summary>
        /// Export PDF(List of Rooms).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Room_Export_Click(object sender, EventArgs e)
        {

            change_Cursor(0);
            rooms_List_Export();
            change_Cursor(1);
            export_Complete(Constants.titleRoo);
        }

        /// <summary>
        /// Export PDF(List of Rooms).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void rooms_List_Export()
        {
            string sname = "Room No";
            string scapacity = "Capacity";
            string slabel = "Label";
            string scolour = "Colour";
            int dgv = 1;

            create_PDF_4(Constants.titleRoo, dgv, sname, scapacity, slabel, scolour);
        }

        private void List_Rooms_Open_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleRoo + ".pdf";
            does_File_Exist(sourceName, Constants.titleRoo, 1);
        }

        private void List_Rooms_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleRoo + ".pdf";

            does_File_Exist(sourceName, Constants.titleRoo, 2);
        }

        private void List_Rooms_Print_pre_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleRoo + ".pdf";

            does_File_Exist(sourceName, Constants.titleRoo, 3);
        }


        // GROUPS TAB


        private void List_Groups_Export_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            Groups_List_Export();
            change_Cursor(1);
            export_Complete(Constants.titleGro);
        }

        public void Groups_List_Export()
        {
            string sname = "Class";
            string slabel = "Label";
            string scolour = "Colour";
            string scapacity = "Capacity";
            int dgv = 2;

            create_PDF_4(Constants.titleGro, dgv, sname, scapacity, slabel, scolour);
        }

        private void List_Groups_Open_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleGro + ".pdf";
            does_File_Exist(sourceName, Constants.titleGro, 1);
        }

        private void List_Groups_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleGro + ".pdf";

            print_Dialog(sourceName);
        }

        private void List_Groups_Print_Pre_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleGro + ".pdf";

            print_PDF(sourceName);
        }


        // TIMETABLE LECTURER

        


        // ROOM TIMETABLES


       

        private void Timetable_Rooms_Export_Click(object sender, EventArgs e)
        {

        }

        // GROUP TIMETABLE

        private void Timetable_Groups_Export_Click(object sender, EventArgs e)
        {

        }

        private void Open_List_Modules_Location_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_List_Lecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void View_PDF_List_All_Click(object sender, EventArgs e)
        {
            string sourceName = Constants.lisLoc + Constants.titleLec + ".pdf";

            view_PDF(sourceName);
        }


        // RESOURCES

        /// <summary>
        /// Opens PDF
        /// </summary>
        /// <remarks>starts a new instance of SumatraPDF(running in restrict mode), which will open a PDF file according to the source address</remarks>
        /// <param name="source">File location as a string</param>
        /// <seealso cref="System.String">
        public void view_PDF(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-restrict " + source;

            Process x = Process.Start(p);
        }

        /// <summary>
        /// Prints PDF via dialog and with preview
        /// </summary>
        /// <remarks>starts a new instance of SumatraPDF which will open a PDF file according to the source address and a print dialog </remarks>
        /// <param name="source">File location as a string</param>
        /// <seealso cref="System.String">
        public void print_PDF(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-print-dialog " + source;

            Process x = Process.Start(p);
        }

        /// <summary>
        /// Prints PDF via dialog
        /// </summary>
        /// <remarks>starts a new instance of SumatraPDF(Only the print dialog is shown), which will open a PDF file according to the source address(PDF not shown)</remarks>
        /// <param name="source">File location as a string</param>
        /// <seealso cref="System.String">
        public void print_Dialog(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-print-dialog " + source + " -exit-on-print";

            Process x = Process.Start(p);
        }


        /// <summary>
        /// Modal dialog, acknowledgment of export.
        /// </summary>
        /// <param name="title">title information</param>
        /// <seealso cref="System.String">
        public void export_Complete(string title)
        {
            MessageBox.Show(title + " has successfully been exported",
    "Export",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// changes cursor to wait or default
        /// </summary>
        /// <param name="num">number used for if statement</param>
        /// <seealso cref="System.Int">
        public void change_Cursor(int num)
        {
            if (num == 0)
            {
                this.Cursor = Cursors.WaitCursor;
            }

            else
            {
                this.Cursor = Cursors.Default;
            }

        }

        /// <summary>
        /// Create PDF with 5 columns.
        /// </summary>
        /// <param name="title">file name</param>
        /// <param name="cN1">column 1 name</param>
        /// <param name="cN2">column 2 name</param>
        /// <param name="cN3">column 3 name</param>
        /// <param name="cN4">column 4 name</param>
        /// <param name="cN5">column 5 name</param>
        public void create_PDF_5(string title, string cN1, string cN2, string cN3)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"PDF\Lists\" + title + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(Constants.titleLec + System.Environment.NewLine + "\n");
            PdfPTable t1 = new PdfPTable(3);

            PdfPCell ccell1 = new PdfPCell(new Phrase(cN1));
            PdfPCell ccell2 = new PdfPCell(new Phrase(cN2));
            PdfPCell ccell3 = new PdfPCell(new Phrase(cN3));
            //PdfPCell ccell4 = new PdfPCell(new Phrase(cN4));

            t1.AddCell(ccell1);
            t1.AddCell(ccell2);
            t1.AddCell(ccell3);
            //t1.AddCell(ccell4);

            foreach (DataGridViewRow rows in dataLecTable.Rows)
            {
                if (Convert.ToBoolean(dataLecTable.Rows[rows.Index].Cells[2].Value))
                {
                    string cell1 = dataLecTable.Rows[rows.Index].Cells[0].Value.ToString();
                    string cell2 = dataLecTable.Rows[rows.Index].Cells[1].Value.ToString();
                    string cell3 = dataLecTable.Rows[rows.Index].Cells[2].Value.ToString();
                    //string cell4 = dataLecTable.Rows[rows.Index].Cells[cN4].Value.ToString();

                    PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                    PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                    PdfPCell c3 = new PdfPCell(new Phrase(cell3));
                    //PdfPCell c4 = new PdfPCell(new Phrase(cell4));

                    t1.AddCell(c1);
                    t1.AddCell(c2);
                    t1.AddCell(c3);
                    //t1.AddCell(c4);
                }
            }
            document.Add(paragraph);
            document.Add(t1);
            DateTime now = DateTime.Now;
            document.Add(new Paragraph(document.BottomMargin, Constants.pdfFoter + now));
            document.Close();
        }

        /// <summary>
        /// Create PDF with 4 columns.
        /// </summary>
        /// <param name="title">File Name</param>
        /// <param name="dgvc">number used for if statement to determine which data view grid to use.</param>
        /// <param name="cN1">column 1 name</param>
        /// <param name="cN2">column 2 name</param>
        /// <param name="cN3">column 3 name</param>
        /// <param name="cN4">column 4 name</param>
        public void create_PDF_4(string title, int dgvc, string cN1, string cN2, string cN3, string cN4)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"PDF\Lists\" + title + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(title + System.Environment.NewLine + "\n");
            PdfPTable t1 = new PdfPTable(3);

            PdfPCell ccell1 = new PdfPCell(new Phrase(cN1));
            PdfPCell ccell2 = new PdfPCell(new Phrase(cN2));
            PdfPCell ccell3 = new PdfPCell(new Phrase(cN3));

            t1.AddCell(ccell1);
            t1.AddCell(ccell2);
            t1.AddCell(ccell3);

            if (dgvc == 0)
            {
                foreach (DataGridViewRow rows in dataSubTable.Rows)
                {
                    if (dataSubTable.Rows[rows.Index].Cells[2].Value != null)
                    {
                        string cell1 = dataSubTable.Rows[rows.Index].Cells[0].Value.ToString();
                        string cell2 = dataSubTable.Rows[rows.Index].Cells[1].Value.ToString();
                        string cell3 = dataSubTable.Rows[rows.Index].Cells[2].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                    }
                }
            }

            if (dgvc == 1)
            {
                foreach (DataGridViewRow rows in dataRoomTable.Rows)
                {
                    if (Convert.ToBoolean(dataRoomTable.Rows[rows.Index].Cells[2].Value))
                    {
                        string cell1 = dataRoomTable.Rows[rows.Index].Cells[0].Value.ToString();
                        string cell2 = dataRoomTable.Rows[rows.Index].Cells[1].Value.ToString();
                        string cell3 = dataRoomTable.Rows[rows.Index].Cells[2].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                    }
                }
            }

            if (dgvc == 2)
            {
                foreach (DataGridViewRow rows in dataClassTable.Rows)
                {
                    if (Convert.ToBoolean(dataClassTable.Rows[rows.Index].Cells[2].Value))
                    {
                        string cell1 = dataClassTable.Rows[rows.Index].Cells[0].Value.ToString();
                        string cell2 = dataClassTable.Rows[rows.Index].Cells[1].Value.ToString();
                        string cell3 = dataClassTable.Rows[rows.Index].Cells[2].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                    }
                }

            }
            document.Add(paragraph);
            document.Add(t1);
            DateTime now = DateTime.Now;
            document.Add(new Paragraph(document.BottomMargin, Constants.pdfFoter + now));
            document.Close();
        }


        /// <summary>
        /// create PDF of a timetable
        /// </summary>
        /// <param name="location">file location</param>
        public void Create_PDF_Timetabless(string location, String fileName)
        {
            string title = "temp";
            string nameOfPDf = fileName;
            Document document = new Document(PageSize.A4.Rotate());  // creates new pdf file A4 landscape
            PdfWriter.GetInstance(document, new FileStream(location + nameOfPDf + ".pdf", FileMode.Create));  // writes the pdf to file
            document.Open();
            Paragraph paragraph = new Paragraph(title + System.Environment.NewLine + "\n");
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(Constants.tempJpeg);
            jpg.ScalePercent(45f);  // scales the image file to fit on to page.
            document.Add(jpg);
            document.Close();
        }

        /// <summary>
        /// take screenshot.
        /// </summary>
        public void capture_Image()
        {
            System.Drawing.Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save(Constants.tempJpeg, ImageFormat.Jpeg);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        // ERROR HANDLING

        /// <summary>
        /// checks to see if a file exists
        /// </summary>
        /// <param name="source">file location</param>
        /// <param name="title">name of the file</param>
        /// <param name="num">number used for if statement to determine 
        /// </param>
        /// <remarks>
        /// num '1' = Open PDF error
        /// num '2' = Print dialog error
        /// num '3' = Print preview error
        /// </remarks>
        public void does_File_Exist(string source, string title, int num)
        {

            if (File.Exists(source))
            {
                if (num == 1)
                { 
                    view_PDF(source);
                }

                if (num == 2)
                {
                    print_Dialog(source);
                }

                if (num == 3)
                {
                    print_PDF(source);
                }

            }
            else

            if (num == 1)
            {
                Error_Open_PDF_Box(title, Constants.opdf,"0056");
            }

            if (num == 2)
            {
                Error_Open_PDF_Box(title, Constants.ppdf, "PC LOAD LETTER 0057");
            }

            if (num == 3)
            {
                Error_Open_PDF_Box(title, Constants.pppdf, ConstantsErrorCode.ec0058);
            }
        }


        /// <summary>
        /// Fills the data view grids (lecturer, class, room) with data from the data store.
        /// </summary>
        public void fill_dgv()
        {
            dataLecTable.Rows.Clear();
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                dataLecTable.Rows.Add(1);
                dataLecTable.Rows[DataCollection.Instance.Lecturers.IndexOf(lect)].Cells[0].Value = lect.Name;
                dataLecTable.Rows[DataCollection.Instance.Lecturers.IndexOf(lect)].Cells[1].Value = lect.Label;
                dataLecTable.Rows[DataCollection.Instance.Lecturers.IndexOf(lect)].Cells[2].Value = lect.HoursPerWeek;
                dataLecTable.Rows[DataCollection.Instance.Lecturers.IndexOf(lect)].Cells[3].Value = " ";
                dataLecTable.Rows[DataCollection.Instance.Lecturers.IndexOf(lect)].Cells[3].Style.BackColor = lect.Colour;
            }

            dataSubTable.Rows.Clear();
            foreach (Module mod in DataCollection.Instance.Modules)
            {
                dataSubTable.Rows.Add(1);
                dataSubTable.Rows[DataCollection.Instance.Modules.IndexOf(mod)].Cells[0].Value = mod.Name;
                dataSubTable.Rows[DataCollection.Instance.Modules.IndexOf(mod)].Cells[1].Value = mod.Label;
                dataSubTable.Rows[DataCollection.Instance.Modules.IndexOf(mod)].Cells[2].Value = mod.CourseLevel;
                dataSubTable.Rows[DataCollection.Instance.Modules.IndexOf(mod)].Cells[3].Value = " ";
                dataSubTable.Rows[DataCollection.Instance.Modules.IndexOf(mod)].Cells[3].Style.BackColor = mod.Colour;
            }
            dataRoomTable.Rows.Clear();
            foreach (Room room in DataCollection.Instance.Rooms)
            {
                dataRoomTable.Rows.Add(1);
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[0].Value = room.Name;
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[1].Value = room.Label;
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[2].Value = room.Capacity;
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[3].Value = room.HasLecturerPC();
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[4].Value = room.HasSmartboard();
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[5].Value = room.HasTelevision();
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[6].Value = room.HasProjector();
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[7].Value = room.IsNetworkLab();
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[8].Value = " ";
                dataRoomTable.Rows[DataCollection.Instance.Rooms.IndexOf(room)].Cells[8].Style.BackColor = room.Colour;
            }
            dataClassTable.Rows.Clear();
            foreach (Group group in DataCollection.Instance.Groups)
            {
                dataClassTable.Rows.Add(1);
                dataClassTable.Rows[DataCollection.Instance.Groups.IndexOf(group)].Cells[0].Value = group.Name;
                dataClassTable.Rows[DataCollection.Instance.Groups.IndexOf(group)].Cells[1].Value = group.Label;
                dataClassTable.Rows[DataCollection.Instance.Groups.IndexOf(group)].Cells[2].Value = group.TotalStudents;
                dataClassTable.Rows[DataCollection.Instance.Groups.IndexOf(group)].Cells[3].Value = " ";
                dataClassTable.Rows[DataCollection.Instance.Groups.IndexOf(group)].Cells[3].Style.BackColor = group.Colour;
            }
        }

        /// <summary>
        /// opens up an error box. 
        /// </summary>
        /// <param name="title">File name</param>
        /// <param name="error">error</param>
        /// <param name="errortitle">error location</param>
        /// <param name="errorCode">error code</param>
        public void Error_Open_PDF_Box(string title, string errortitle, string errorCode)
        {
            // message box dialog, File Not Found
            MessageBox.Show(Constants.error + title + " Can Not Be Found \nHave you exported the PDF? \nError Code : " + errorCode,
    errortitle,
    MessageBoxButtons.OK,
    MessageBoxIcon.Error,
    MessageBoxDefaultButton.Button1);
        }

        public void populateTab()
        {

            timetable_subject_export.Controls.Clear();
            Export_Timetable_Rooms.Controls.Clear();
            Exprt_Timetable_class.Controls.Clear();
            Export_Timetable_Lecturers.Controls.Clear();

            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Lecturer = lect;
                button.Text = button.Lecturer.Name;
                button.BackColor = button.Lecturer.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.Export_Timetable_Lecturers.Controls.Add(button);
            }

            foreach (Module mod in DataCollection.Instance.Modules)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Module = mod;
                button.Text = button.Module.Name;
                button.BackColor = button.Module.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.timetable_subject_export.Controls.Add(button);
            }

            foreach (Room room in DataCollection.Instance.Rooms)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Room = room;
                button.Text = button.Room.Name;
                button.BackColor = button.Room.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.Export_Timetable_Rooms.Controls.Add(button);
            }
            foreach (Group grp in DataCollection.Instance.Groups)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Group = grp;
                button.Text = button.Group.Name;
                button.BackColor = button.Group.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.Exprt_Timetable_class.Controls.Add(button);
            }
        }

        private void dataRoomTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is DataButton)
            {
                DataButton button = (DataButton)sender;
                if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    if (button.Lecturer != null)
                    {
                        OpenTimetable(button.Lecturer, 1);
                    }
                    else if (button.Module != null)
                    {
                        OpenTimetable(button.Module, 2);
                    }
                    else if (button.Room != null)
                    {
                        OpenTimetable(button.Room, 3);
                    }
                    else if (button.Group != null)
                    {
                        OpenTimetable(button.Group, 4);
                    }
                }
            }
        }

        private void OpenTimetable(Data data, int ot)
        {
            FormTimetable childForm = new FormTimetable(data);
            //childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
            ask_to_export();
            System.Threading.Thread.Sleep(500);

            if (expotchoice == 1)
            {
                capture_Image();
                childForm.Close();
                exportingtimetables(ot, data.Name);
                ask_to_open();
                if (expotchoiceopen == 1)
                {
                    opendirectorytimetables(ot);

                }
            }

            childForm.Close();
            
        }

        private void exportingtimetables(int ott, String fileName)
        {
            if (ott == 1)
            {
                Create_PDF_Timetabless(@"PDF\Timetables\Lecturers\", fileName);
            }
            if (ott == 2)
            {
                Create_PDF_Timetabless(@"PDF\Timetables\Module\", fileName);
            }
            if (ott == 3)
            {
                Create_PDF_Timetabless(@"PDF\Timetables\Room\", fileName);
            }
            if (ott == 4)
            {
                Create_PDF_Timetabless(@"PDF\Timetables\Class\", fileName);
            }
        }


        private void opendirectorytimetables(int ott)
        {
            if (ott == 1)
            {
              
                Process.Start(@"PDF\Timetables\Lecturers\");
            }
            if (ott == 2)
            {
             
                Process.Start(@"PDF\Timetables\Module\");
            }
            if (ott == 3)
            {
            
                Process.Start(@"PDF\Timetables\Room\");
            }
            if (ott == 4)
            {
             
                Process.Start(@"PDF\Timetables\Class\");
            }
        }

        private void ask_to_export()
        {
            DialogResult dialogResult = MessageBox.Show("Export This Timetable \nYes To Export    |    No to Cancel",
        "Export Timetable",
        MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                expotchoice = 1;
            }
            else if (dialogResult == DialogResult.No)
            {
                expotchoice = 2;
            }
        }

        private void ask_to_open()
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to view the PDF folder?\nYes To View PDF folder    |    No to View PDF folder",
        "View PDF folder",
        MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                expotchoiceopen = 1;
            }
            else if (dialogResult == DialogResult.No)
            {
                expotchoiceopen = 2;
            }
        }
    }
}
