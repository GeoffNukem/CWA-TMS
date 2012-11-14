using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWATMS
{
    public partial class FormMain : Form
    {
        //public delegate void SaveDelegate(object sender, EventArgs e);
        //public event SaveDelegate Save;

        public FormMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();              // Declare the child form as a new one.
            childForm.MdiParent = this;                 // Set the main form as a parent form.
            childForm.Show();                           // Show the child form.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
            //--------------------------------------------------------------------------
             //{
            //This line of code creates a text file for the data export.

            //System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\TextFile.txt");
           // try
           // {                
                //string sLine = "";

                //This for loop loops through each row in the table
               // Form activeChild = this.ActiveMdiChild;
                
                //if( ActiveForm=Form3)
               // {
                    //for (int r = 0; r <= this.ActiveMdiChild.dataGridView1.Rows.Count - 1; r++)
                    //{
                        //This for loop loops through each column, and the row number
                        //is passed from the for loop above.
                        //for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        //{
                            //sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            //if (c != dataGridView1.Columns.Count - 1)
                        //{

                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            //sLine = sLine + ",";
                        //}
                    //}
                    //The exported text is written to the text file, one line at a time.
                    //file.WriteLine(sLine);                     
                    //sLine = "";
                //}

                //file.Close();
                //System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (System.Exception err)
            //{
                //System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //file.Close();
            //}
            //if (this.Save != null) this.Save(sender, e);
        //}
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 childForm = new Form3(); // Declare the child form as a new one.
            childForm.MdiParent = this;// Set the main form as a parent form.
            childForm.Show();// Show the child form.
        }

        private void lstTimetables_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        
    }
}
