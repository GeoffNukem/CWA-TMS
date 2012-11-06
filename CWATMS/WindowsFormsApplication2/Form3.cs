using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWATMS
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();     //new save instance
            DataGridView dgv = dataLecTable;    
            int tn=0;
            string message = ("Save Error! Please try again");

            //Save Dialogue configuration

            save.DefaultExt = ".txt";
            save.AddExtension = true;
            save.RestoreDirectory = true;
            save.InitialDirectory = @"C:\";
            save.Filter = "Text File (*.txt)|*.txt|Batch File (*.bat)|*.bat|VB Script (*.vbs)|*.vbs|All Files (*.*)|\"*.*\"";
            save.Title = "Save File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            if (save.ShowDialog() == DialogResult.OK)
            {
                do
                {
                    for (int i = 0; i <= dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j <= dgv.Rows[i].Cells.Count; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Value != null) //If a value is stored in a cell then
                                File.AppendAllText(save.FileName, dgv.Rows[i].Cells[j].Value.ToString());
                            //saves the dataGridView cells value to string format
                            File.AppendAllText(save.FileName, dgv.Rows[i].Cells[j].Style.BackColor.ToString());
                            //saves the RGB values for background colour
                            tn++;
                        }
                    }
                    switch (tn)
                    {
                        case 0:
                            {
                                dgv = dataLecTable;
                            }
                            break;

                        case 1:
                            {
                                dgv = dataSubTable;
                            }
                            break;

                        case 2:
                            {
                                dgv = dataRoomTable;
                            }
                            break;

                        case 3:
                            {
                                dgv = dataClassTable;
                            }
                            break;

                        default:
                            {
                                MessageBox.Show("message");
                            }
                            break;
                    }

                } while (tn < 4);


                //for (int i = 0; i <= dataSubTable.Rows.Count; i++)
                //{
                //    for (int j = 0; j <= dataSubTable.Rows[i].Cells.Count; j++)
                //    {
                //        if (dataSubTable.Rows[i].Cells[j].Value != null)                                                 //If a value is stored in a cell then
                //            File.AppendAllText(save.FileName, dataSubTable.Rows[i].Cells[j].Value.ToString());             //saves the dataGridView cells value to string format
                //        File.AppendAllText(save.FileName, dataSubTable.Rows[i].Cells[j].Style.BackColor.ToString());   //saves the RGB values for background colour
                //    }
                //}

                //for (int i = 0; i <= dataRoomTable.Rows.Count; i++)
                //{
                //    for (int j = 0; j <= dataRoomTable.Rows[i].Cells.Count; j++)
                //    {
                //        if (dataRoomTable.Rows[i].Cells[j].Value != null)                                                 //If a value is stored in a cell then
                //            File.AppendAllText(save.FileName, dataRoomTable.Rows[i].Cells[j].Value.ToString());             //saves the dataGridView cells value to string format
                //        File.AppendAllText(save.FileName, dataRoomTable.Rows[i].Cells[j].Style.BackColor.ToString());   //saves the RGB values for background colour
                //    }
                //}

                //for (int i = 0; i <= dataClassTable.Rows.Count; i++)
                //{
                //    for (int j = 0; j <= dataClassTable.Rows[i].Cells.Count; j++)
                //    {
                //        if (dataClassTable.Rows[i].Cells[j].Value != null)                                                 //If a value is stored in a cell then
                //            File.AppendAllText(save.FileName, dataClassTable.Rows[i].Cells[j].Value.ToString());             //saves the dataGridView cells value to string format
                //        File.AppendAllText(save.FileName, dataClassTable.Rows[i].Cells[j].Style.BackColor.ToString());   //saves the RGB values for background colour
                //    }
            
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the selected colomn header equals "colour"
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Colour") && e.RowIndex > -1)
            {
                colorDialog1.ShowDialog();                                                          //Shows colourDialogue window
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = colorDialog1.Color;     //selected cell changes to Dialogue RGB colour
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = colorDialog1.Color;     //selected text in cell hidden using Dialoge RGB colour

                //dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionBackColor = colorDialog1.Color;
                //dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.SelectionForeColor = colorDialog1.Color;
                //dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = colorDialog1.Color.R.ToString() + ", " + colorDialog1.Color.G.ToString() + ", " +  colorDialog1.Color.B.ToString();   

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            dataLecTable.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
        }

        void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        //    string allowedNumberSet = ("1234567890\b\n");
        //    string allowedCharacterSet = (@"a-zA-Z+");
        //    string message;

        //    // you can obtain current editing value like this:
        //    string value = null;
        //    var ctl = dataLecTable.EditingControl as DataGridViewTextBoxEditingControl;

        //    if (ctl != null)
        //        value = ctl.Text;

        //    // you can obtain the current commited value
        //    String current = dataLecTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            

        //    switch (e.ColumnIndex)
        //    {
        //        case 0:
        //            // bound to integer field
        //            validChar();
        //            break;
        //        case 1:
        //            // bound to date time field
        //            if (current.Contains(allowedCharacterSet))
        //            {
        //                message = "the value should be a character!";
        //            }
        //            if (current.Length < 3)
        //            {
        //                message = "the label should be no more than 3 characters!";
        //            }
        //            break;
        //        case 2:

        //        // other columns
        //        default:
        //            {
        //                message = "Invalid data";
        //            }
        //            break;
        //    }

        //    MessageBox.Show(message);
        //}
        //private void ValidChar()
        //{
        //    if (current.Contains(allowedCharacterSet))
        //    {
        //        message = "the value should be a character!";
        //    }
        }
    }


}
