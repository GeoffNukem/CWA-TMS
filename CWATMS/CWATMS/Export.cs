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

        public Export()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(titleLec + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(titleLec + System.Environment.NewLine + "\n");
            PdfPTable t1 = new PdfPTable(5);

            PdfPCell cfname = new PdfPCell(new Phrase("First Name"));
            PdfPCell clname = new PdfPCell(new Phrase("Last Name"));
            PdfPCell chpw = new PdfPCell(new Phrase("Hours Per Week"));
            PdfPCell clabel = new PdfPCell(new Phrase("Label"));
            PdfPCell ccolour = new PdfPCell(new Phrase("Colour"));

            t1.AddCell(cfname);
            t1.AddCell(clname);
            t1.AddCell(chpw);
            t1.AddCell(clabel);
            t1.AddCell(ccolour);

            foreach (DataGridViewRow rows in dataGridView_List_Lecturers.Rows)
            {
                if (Convert.ToBoolean(dataGridView_List_Lecturers.Rows[rows.Index].Cells[2].Value))
                {
                    string fname = dataGridView_List_Lecturers.Rows[rows.Index].Cells["First Name"].Value.ToString();
                    string lname = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Last Name"].Value.ToString();
                    string hpw = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Hours Per Week"].Value.ToString();
                    string label = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Label"].Value.ToString();
                    string colour = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Colour"].Value.ToString();

                    PdfPCell c1 = new PdfPCell(new Phrase(fname));
                    PdfPCell c2 = new PdfPCell(new Phrase(lname));
                    PdfPCell c3 = new PdfPCell(new Phrase(hpw));
                    PdfPCell c4 = new PdfPCell(new Phrase(label));
                    PdfPCell c5 = new PdfPCell(new Phrase(colour));

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
            document.Add(new Paragraph(document.BottomMargin, " The A Team , Timetable Mangement System. Date and time produced " + now ));
            document.Close();

            this.Cursor = Cursors.Default;

            export_Complete(titleLec);


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(titleMod + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(titleMod + System.Environment.NewLine);
            PdfPTable t1 = new PdfPTable(4);

            PdfPCell cname = new PdfPCell(new Phrase("Name"));
            PdfPCell ccourselevel = new PdfPCell(new Phrase("Course Level"));
            PdfPCell clabel = new PdfPCell(new Phrase("Label"));
            PdfPCell ccolour = new PdfPCell(new Phrase("Colour"));

            t1.AddCell(cname);
            t1.AddCell(ccourselevel);
            t1.AddCell(clabel);
            t1.AddCell(ccolour);

        foreach (DataGridViewRow rows in dataGridView_List_Lecturers.Rows)
            {
                if (Convert.ToBoolean(dataGridView_List_Lecturers.Rows[rows.Index].Cells[2].Value))
                {
                    string fname = dataGridView_List_Lecturers.Rows[rows.Index].Cells["First Name"].Value.ToString();
                    string lname = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Last Name"].Value.ToString();
                    string hpw = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Hours Per Week"].Value.ToString();
                    string label = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Label"].Value.ToString();
                    string colour = dataGridView_List_Lecturers.Rows[rows.Index].Cells["Colour"].Value.ToString();

                    PdfPCell c1 = new PdfPCell(new Phrase(fname));
                    PdfPCell c2 = new PdfPCell(new Phrase(lname));
                    PdfPCell c3 = new PdfPCell(new Phrase(hpw));
                    PdfPCell c4 = new PdfPCell(new Phrase(label));
                    PdfPCell c5 = new PdfPCell(new Phrase(colour));

                    t1.AddCell(c1);
                    t1.AddCell(c2);
                    t1.AddCell(c3);
                    t1.AddCell(c4);
                    t1.AddCell(c5);
                }
            }
            document.Add(paragraph);
            document.Add(t1);
            document.Close();

            export_Complete(titleMod);
        }



        private void List_Room_Export_Click(object sender, EventArgs e)
        {
            string name1 = "List of Rooms";
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream( name1 + ".pdf", FileMode.Create));
            document.Open();
            Paragraph paragraph = new Paragraph(name1 + System.Environment.NewLine);
            PdfPTable t1 = new PdfPTable(4);

            PdfPCell cname = new PdfPCell(new Phrase("Name"));
            PdfPCell ccapacity = new PdfPCell(new Phrase("Capacity"));
            PdfPCell clabel = new PdfPCell(new Phrase("Label"));
            PdfPCell ccolour = new PdfPCell(new Phrase("Colour"));

            t1.AddCell(cname);
            t1.AddCell(ccapacity);
            t1.AddCell(clabel);
            t1.AddCell(ccolour);
        }

        private void List_Groups_Export_Click(object sender, EventArgs e)
        {

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

    }
}
