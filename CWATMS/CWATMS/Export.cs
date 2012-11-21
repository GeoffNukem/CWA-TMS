using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        string titleLec = "List_of_Lecturers";
        string titleMod = "List_of_Modules";
        string titleRoo = "List_of_Rooms";
        string titleGro = "List_of_Groups";
        string pdfFoter = " The A Team , Timetable Mangement System. Date and time produced ";

        public Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            change_Cursor(0);
            lecturer_List_Export();
            change_Cursor(1);
            export_Complete(titleLec);


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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            change_Cursor(0);
            modules_List_Export();
            change_Cursor(1);
            export_Complete(titleMod);
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


        private void Timetable_Groups_Export_Click(object sender, EventArgs e)
        {

        }

        private void Open_PDF_List_Modules_Click(object sender, EventArgs e)
        {

        }

        private void Open_List_Modules_Location_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_List_Lecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Open_PDF_List_Lecturers_Click(object sender, EventArgs e)
        {

            string sourceName = titleLec + ".pdf";

            view_PDF(sourceName);

        }

        private void Print_PDF_Lst_Lecturers_Click(object sender, EventArgs e)
        {
            string sourceName = "List_of_Lecturers.pdf";

            print_PDF(sourceName);

        }

        private void View_PDF_List_All_Click(object sender, EventArgs e)
        {
            string sourceName = "List_of_Lecturers.pdf";

            view_PDF(sourceName);
        }

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sourceName = "List_of_Lecturers.pdf";

            print_Dialog(sourceName);
        }

        public void export_Complete(string title)
        {
            MessageBox.Show(title + " has successfully been exported",
    "Export",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1);
        }

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

        public void create_PDF_5(string title, string cN1, string cN2, string cN3, string cN4, string cN5)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(title + ".pdf", FileMode.Create));
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

            foreach (DataGridViewRow rows in dataGridView_List_Lecturers.Rows)
            {
                if (Convert.ToBoolean(dataGridView_List_Lecturers.Rows[rows.Index].Cells[2].Value))
                {
                    string cell1 = dataGridView_List_Lecturers.Rows[rows.Index].Cells[cN1].Value.ToString();
                    string cell2 = dataGridView_List_Lecturers.Rows[rows.Index].Cells[cN2].Value.ToString();
                    string cell3 = dataGridView_List_Lecturers.Rows[rows.Index].Cells[cN3].Value.ToString();
                    string cell4 = dataGridView_List_Lecturers.Rows[rows.Index].Cells[cN4].Value.ToString();
                    string cell5 = dataGridView_List_Lecturers.Rows[rows.Index].Cells[cN5].Value.ToString();

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
            PdfWriter.GetInstance(document, new FileStream(title + ".pdf", FileMode.Create));
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


    }
}
