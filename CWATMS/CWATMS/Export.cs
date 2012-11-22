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

namespace CWATMS
{
    public partial class Export : Form
    {
        // list of commonly used strings.
        string titleLec = "List_of_Lecturers";
        string titleMod = "List_of_Modules";
        string titleRoo = "List_of_Rooms";
        string titleGro = "List_of_Groups";
        string pdfFoter = " The A Team , Timetable Mangement System. Date and time produced ";
        string lisLoc = @"PDF\Lists\";


        public Export()
        {
            InitializeComponent();
        }

        /// <summary>
        /// LIST HOME TAB.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Export_All_To_PDF_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            string comple = titleLec + " " + titleMod + " " + titleRoo + " " + titleGro + " ";
            lecturer_List_Export();
            modules_List_Export();
            rooms_List_Export();
            Groups_List_Export();
            change_Cursor(1);
            export_Complete(comple);
        }

        private void Open_All_List_PDF_Click(object sender, EventArgs e)
        {

            string sourceName = lisLoc + titleLec + ".pdf " + lisLoc + titleMod + ".pdf " + lisLoc + titleRoo + ".pdf " + lisLoc + titleGro + ".pdf ";
            view_PDF(sourceName);
        }

        /// <summary>
        /// List Lecturer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {

            change_Cursor(0);              // changes cursor to wait
            lecturer_List_Export();       // exports list to pdf
            change_Cursor(1);            // changes cursor back to default
            export_Complete(titleLec);  //acknowledgement of completion


        }

        public void lecturer_List_Export()
        {
            string sfname = "First Name";
            string slname = "Last Name";
            string shpw = "Hours Per Week";
            string slabel = "Label";
            string scolour = "Colour";

            create_PDF_5(titleLec, sfname, slname, shpw, slabel, scolour);
        }

        private void Open_PDF_List_Lecturers_Click(object sender, EventArgs e)
        {


            string sourceName = lisLoc + titleLec + ".pdf";
            does_File_Exist(sourceName, titleLec, 1);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleLec + ".pdf";

            does_File_Exist(sourceName, titleLec, 2);
        }

        private void Print_PDF_Lst_Lecturers_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleLec + ".pdf";

            does_File_Exist(sourceName, titleLec, 3);

        }

        /// <summary>
        /// MODULES TAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void button2_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            modules_List_Export();
            change_Cursor(1);
            export_Complete(titleMod);
        }

        private void List_Mod_Open_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleMod + ".pdf";
            does_File_Exist(sourceName, titleMod, 1);
        }

        public void modules_List_Export()
        {
            string sname = "Name";
            string scourselevel = "Course Level";
            string slabel = "Label";
            string scolour = "Colour";
            int dgv = 0;

            create_PDF_4(titleMod, dgv, sname, scourselevel, slabel, scolour);
        }

        private void Open_PDF_List_Modules_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleMod + ".pdf";
            does_File_Exist(sourceName, titleMod, 1);
        }

        private void List_Mod_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleMod + ".pdf";

            does_File_Exist(sourceName, titleMod, 2);
        }

        private void List_Mod_Print_Pre_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleMod + ".pdf";

            does_File_Exist(sourceName, titleLec, 3);
        }

        /// <summary>
        /// ROOM TAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void List_Room_Export_Click(object sender, EventArgs e)
        {

            change_Cursor(0);
            rooms_List_Export();
            change_Cursor(1);
            export_Complete(titleRoo);
        }

        public void rooms_List_Export()
        {
            string sname = "Name";
            string scapacity = "Capacity";
            string slabel = "Label";
            string scolour = "Colour";
            int dgv = 1;

            create_PDF_4(titleRoo, dgv, sname, scapacity, slabel, scolour);
        }

        private void List_Rooms_Open_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleRoo + ".pdf";
            does_File_Exist(sourceName, titleRoo, 1);
        }

        private void List_Rooms_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleRoo + ".pdf";

            does_File_Exist(sourceName, titleRoo, 2);
        }

        private void List_Rooms_Print_pre_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleRoo + ".pdf";

            does_File_Exist(sourceName, titleRoo, 3);
        }

        /// <summary>
        /// GROUPS TAB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void List_Groups_Export_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            Groups_List_Export();
            change_Cursor(1);
            export_Complete(titleGro);
        }

        public void Groups_List_Export()
        {
            string sname = "Name";
            string slabel = "Label";
            string scolour = "Colour";
            string scapacity = "Capacity";
            int dgv = 2;

            create_PDF_4(titleGro, dgv, sname, scapacity, slabel, scolour);
        }

        private void List_Groups_Open_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleGro + ".pdf";
            does_File_Exist(sourceName, titleGro, 1);
        }

        private void List_Groups_Print_Dia_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleGro + ".pdf";

            print_Dialog(sourceName);
        }

        private void List_Groups_Print_Pre_Click(object sender, EventArgs e)
        {
            string sourceName = lisLoc + titleGro + ".pdf";

            print_PDF(sourceName);
        }

        /// <summary>
        /// TIMETABLE LECTURER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void Timetable_Lecturers_Export_Click(object sender, EventArgs e)
        {
            //calculate_ETA_Timetable_Export();
            //FormTimetable r = new FormTimetable(Lecturer);
            //r.FormBorderStyle = FormBorderStyle.None;
            //r.WindowState = FormWindowState.Maximized;
            //r.Show();
            //capture_Image();
            //r.Close();
            //Create_PDF_Timetabless(@"PDF\Timetables\Lecturers\");

        }

        /// <summary>
        /// ROOM TIMETABLES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


       

        private void Timetable_Rooms_Export_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// GROUP TIMETABLE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

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
            string sourceName = lisLoc + titleLec + ".pdf";

            view_PDF(sourceName);
        }


        /// <summary>
        /// RESOURCES
        /// </summary>
        /// <param name="source"></param>
        public void view_PDF(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-restrict " + source;

            Process x = Process.Start(p);
        }

        public void print_PDF(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-print-dialog " + source;

            Process x = Process.Start(p);
        }

        public void print_Dialog(string source)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = "-print-dialog " + source + " -exit-on-print";

            Process x = Process.Start(p);
        }



        public void export_Complete(string title)
        {
            // message box dialog, acknowledgment n successful exportation 
            MessageBox.Show(title + " has successfully been exported",
    "Export",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1);
        }

        public void change_Cursor(int num)
        {
            // if statement to change the cursor, wait cursor or default cursor.
            if (num == 0)
            {
                this.Cursor = Cursors.WaitCursor;
            }

            else
            {
                this.Cursor = Cursors.Default;
            }

        }

        public void create_PDF_5(string title, string cN1, string cN2, string cN3, string cN4, string cN5)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"PDF\Lists\" + title + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(titleLec + System.Environment.NewLine + "\n");
            PdfPTable t1 = new PdfPTable(5);

            PdfPCell ccell1 = new PdfPCell(new Phrase(cN1));
            PdfPCell ccell2 = new PdfPCell(new Phrase(cN2));
            PdfPCell ccell3 = new PdfPCell(new Phrase(cN3));
            PdfPCell ccell4 = new PdfPCell(new Phrase(cN4));
            PdfPCell ccell5 = new PdfPCell(new Phrase(cN5));

            t1.AddCell(ccell1);
            t1.AddCell(ccell2);
            t1.AddCell(ccell3);
            t1.AddCell(ccell4);
            t1.AddCell(ccell5);

            foreach (DataGridViewRow rows in dataLecTable.Rows)
            {
                if (Convert.ToBoolean(dataLecTable.Rows[rows.Index].Cells[2].Value))
                {
                    string cell1 = dataLecTable.Rows[rows.Index].Cells[cN1].Value.ToString();
                    string cell2 = dataLecTable.Rows[rows.Index].Cells[cN2].Value.ToString();
                    string cell3 = dataLecTable.Rows[rows.Index].Cells[cN3].Value.ToString();
                    string cell4 = dataLecTable.Rows[rows.Index].Cells[cN4].Value.ToString();
                    string cell5 = dataLecTable.Rows[rows.Index].Cells[cN5].Value.ToString();

                    PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                    PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                    PdfPCell c3 = new PdfPCell(new Phrase(cell3));
                    PdfPCell c4 = new PdfPCell(new Phrase(cell4));
                    PdfPCell c5 = new PdfPCell(new Phrase(cell5));

                    t1.AddCell(c1);
                    t1.AddCell(c2);
                    t1.AddCell(c3);
                    t1.AddCell(c4);
                    t1.AddCell(c5);
                }
            }
            document.Add(paragraph);
            document.Add(t1);
            DateTime now = DateTime.Now;
            document.Add(new Paragraph(document.BottomMargin, pdfFoter  + now ));
            document.Close();
        }

        public void create_PDF_4(string title, int dgvc, string cN1, string cN2, string cN3, string cN4)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(@"PDF\Lists\" + title + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(title + System.Environment.NewLine + "\n");
            PdfPTable t1 = new PdfPTable(4);

            PdfPCell ccell1 = new PdfPCell(new Phrase(cN1));
            PdfPCell ccell2 = new PdfPCell(new Phrase(cN2));
            PdfPCell ccell3 = new PdfPCell(new Phrase(cN3));
            PdfPCell ccell4 = new PdfPCell(new Phrase(cN4));

            t1.AddCell(ccell1);
            t1.AddCell(ccell2);
            t1.AddCell(ccell3);
            t1.AddCell(ccell4);

            if (dgvc == 0)
            {
                foreach (DataGridViewRow rows in dataGridView_List_Modules.Rows)
                {
                    if (Convert.ToBoolean(dataGridView_List_Modules.Rows[rows.Index].Cells[2].Value))
                    {
                        string cell1 = dataGridView_List_Modules.Rows[rows.Index].Cells[cN1].Value.ToString();
                        string cell2 = dataGridView_List_Modules.Rows[rows.Index].Cells[cN2].Value.ToString();
                        string cell3 = dataGridView_List_Modules.Rows[rows.Index].Cells[cN3].Value.ToString();
                        string cell4 = dataGridView_List_Modules.Rows[rows.Index].Cells[cN4].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));
                        PdfPCell c4 = new PdfPCell(new Phrase(cell4));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                        t1.AddCell(c4);
                    }
                }
            }

            if (dgvc == 1)
            {
                foreach (DataGridViewRow rows in dataGridView_List_Rooms.Rows)
                {
                    if (Convert.ToBoolean(dataGridView_List_Rooms.Rows[rows.Index].Cells[2].Value))
                    {
                        string cell1 = dataGridView_List_Rooms.Rows[rows.Index].Cells[cN1].Value.ToString();
                        string cell2 = dataGridView_List_Rooms.Rows[rows.Index].Cells[cN2].Value.ToString();
                        string cell3 = dataGridView_List_Rooms.Rows[rows.Index].Cells[cN3].Value.ToString();
                        string cell4 = dataGridView_List_Rooms.Rows[rows.Index].Cells[cN4].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));
                        PdfPCell c4 = new PdfPCell(new Phrase(cell4));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                        t1.AddCell(c4);
                    }
                }
            }

            if (dgvc == 2)
            {
                foreach (DataGridViewRow rows in dataGridView_List_Groups.Rows)
                {
                    if (Convert.ToBoolean(dataGridView_List_Groups.Rows[rows.Index].Cells[2].Value))
                    {
                        string cell1 = dataGridView_List_Groups.Rows[rows.Index].Cells[cN1].Value.ToString();
                        string cell2 = dataGridView_List_Groups.Rows[rows.Index].Cells[cN2].Value.ToString();
                        string cell3 = dataGridView_List_Groups.Rows[rows.Index].Cells[cN3].Value.ToString();
                        string cell4 = dataGridView_List_Groups.Rows[rows.Index].Cells[cN4].Value.ToString();

                        PdfPCell c1 = new PdfPCell(new Phrase(cell1));
                        PdfPCell c2 = new PdfPCell(new Phrase(cell2));
                        PdfPCell c3 = new PdfPCell(new Phrase(cell3));
                        PdfPCell c4 = new PdfPCell(new Phrase(cell4));

                        t1.AddCell(c1);
                        t1.AddCell(c2);
                        t1.AddCell(c3);
                        t1.AddCell(c4);
                    }
                }

            }
            document.Add(paragraph);
            document.Add(t1);
            DateTime now = DateTime.Now;
            document.Add(new Paragraph(document.BottomMargin, pdfFoter + now));
            document.Close();
        }


        public void Create_PDF_Timetabless(string location)
        {
            string title = "test";
            Document document = new Document(PageSize.A4.Rotate());  // creates new pdf file A4 landscape
            PdfWriter.GetInstance(document, new FileStream(location + ".pdf", FileMode.Create));  // writes the pdf to file
            document.Open();
            Paragraph paragraph = new Paragraph(title + System.Environment.NewLine + "\n");
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance("temp.jpg");
            jpg.ScalePercent(45f);  // scales the image file to fit on to page.
            document.Add(jpg);
            document.Close();
        }

        public void capture_Image()
        {
            // takes a screenshot and saves the file.
            System.Drawing.Rectangle bounds = Screen.GetBounds(Point.Empty);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save(@"PDF\temp\temp.jpg", ImageFormat.Jpeg);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void calculate_ETA_Timetable_Export()
        {

        }

        /// <summary>
        /// ERROR HANDLING
        /// </summary>



        public void does_File_Exist(string source, string title, int num)
        {
            string opdf = "Error - Open ";
            string ppdf = "Error - Print Dialog ";
            string pppdf = "Error - Print Preview ";
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

            if (num == 1)
            {
                Error_Open_PDF_Box(title, opdf);
            }

            if (num == 2)
            {
                Error_Open_PDF_Box(title, ppdf);
            }

            if (num == 3)
            {
                Error_Open_PDF_Box(title, pppdf);
            }
        }

        public void Error_Open_PDF_Box(string title, string errortitle)
        {
            // message box dialog, File Not Found
            MessageBox.Show(title + " Can Not Be Found \nHave you exported the PDF? \nError Code : 0058" ,
    errortitle,
    MessageBoxButtons.OK,
    MessageBoxIcon.Error,
    MessageBoxDefaultButton.Button1);
        }









    }
}
