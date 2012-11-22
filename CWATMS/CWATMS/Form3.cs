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
        private static readonly Form3 instance = new Form3();

        public Form3()
        {
            InitializeComponent();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); //new open instance

            //Open Dialogue configuration

            open.DefaultExt = ".txt";
            open.AddExtension = true;
            open.RestoreDirectory = true;
            open.InitialDirectory = @"C:\";
            open.Filter = "Xml File (*.xml)|*.xml";
            open.Title = "Save File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Save Dialogue corresponds to file location
                    //DataFile.Instance.openAllXML(open.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); //new save instance

            //Save Dialogue configuration

            save.DefaultExt = ".txt";
            save.AddExtension = true;
            save.RestoreDirectory = true;
            save.InitialDirectory = @"C:\";
            save.Filter = "Xml File (*.xml)|*.xml";
            save.Title = "Save File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    //Save Dialogue corresponds to file location
                    //DataFile.Instance.saveAllXML(save.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       


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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveMdiChild.Close();
        }

        //Creates a colour dialogue with swatches and wheel, saves RGB value to contained Cell
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the selected colomn header equals "colour"
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Colour") && e.RowIndex > -1)
            {
                colorDialog1.ShowDialog();                                                          //Shows colourDialogue window
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = colorDialog1.Color;     //selected cell changes to Dialogue RGB colour
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = colorDialog1.Color;     //selected text in cell hidden using Dialoge RGB colour
                dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " ";
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

        private void dataLecTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            
            //  Input for row will 
            if (validate(dgv, e))
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:	//	Lecturer DGV
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string lecturer = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            int hours;
                            if (!int.TryParse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString(), out hours)) //converts int to bool, if invalid then return false
                            {
                                return;
                            }
                            Color colour = (Color)dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;

                            DataCollection.Instance.Add(new Lecturer(lecturer, label, hours, colour));
                        }
                        break;

                    case 1:	//	Module DGV
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string subject = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            string courseLvl = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                            Color colour = (Color)dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;

                            DataCollection.Instance.Add(new Module(subject, label, courseLvl, colour));
                        }
                        break;

                    case 2:	//	Room DGV
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            Color colour = (Color)dgv.Rows[e.RowIndex].Cells[2].Style.BackColor;
                            int capacity;
                            if (!int.TryParse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString(), out capacity)) //converts int to bool, if invalid then return false
                            {
                                return;
                            }
                            DataCollection.Instance.Add(new Room(name, label, Color.Empty, capacity));
                        }
                        break;

                    case 3:	//	Group DGV
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string group = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            Color colour = (Color)dgv.Rows[e.RowIndex].Cells[2].Style.BackColor;
                            int numStudents;
                            if (!int.TryParse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString(), out numStudents)) //converts int to bool, if invalid then return false
                            {
                                return;
                            }
                            DataCollection.Instance.Add(new Group(group, label, colour, numStudents));
                            
                        }
                        break;
                }
            }
        }

        private bool validate(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            int min = 0;
            int max = 0;
            bool validChar = false;
            bool isValid = true;

            if (e.RowIndex > -1 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string text = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                
               
                
                //tab control to decide table validation
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                        switch (e.ColumnIndex)  //column value to decide cell validation
                        {
                            case 0:
                                min = 1;
                                max = 35;
                                validChar = true;
                                break;
                            case 1:
                                min = 1;
                                max = 3;
                                validChar = true;
                                break;
                            case 2:
                                min = 1;
                                max = 3;
                                validChar = false;
                                break;
                            case 3:
                                min = 1;
                                max = 6;
                                validChar = false;
                                break;
                        }
                        break;
                case 1:
                        switch (e.ColumnIndex)
                        {
                            case 0:
                                min = 1;
                                max = 35;
                                validChar = true;
                                break;
                            case 1:
                                min = 1;
                                max = 3;
                                validChar = true;
                                break;
                            case 2:
                                min = 1;
                                max = 9;
                                validChar = false;
                                break;
                            case 3:
                                min = 1;
                                max = 6;
                                validChar = false;
                                break;
                        }
                        break;
                case 2:
                        switch (e.ColumnIndex)
                        {
                            case 0:
                                min = 1;
                                max = 35;
                                validChar = true;
                                break;
                            case 1:
                                min = 1;
                                max = 3;
                                validChar = true;
                                break;
                            case 2:
                                min = 1;
                                max = 5;
                                validChar = false;
                                break;
                            case 3:
                                min = 1;
                                max = 5;
                                validChar = false;
                                break;
                            case 4:
                                min = 1;
                                max = 5;
                                validChar = false;
                                break;
                            case 5:
                                min = 1;
                                max = 5;
                                validChar = false;
                                break;
                            case 6:
                                min = 1;
                                max = 6;
                                validChar = false;
                                break;
                        }
                        break;
                case 3:
                        switch (e.ColumnIndex)
                        {
                            case 0:
                                min = 1;
                                max = 35;
                                validChar = true;
                                break;
                            case 1:
                                min = 1;
                                max = 3;
                                validChar = true;
                                break;
                            case 2:
                                min = 1;
                                max = 3;
                                validChar = false;
                                break;
                            case 3:
                                min = 1;
                                max = 6;
                                validChar = false;
                                break;
                        }
                        break;
                }
                if (!DataValidation.Instance.IsInRange(text.Length, min, max, true))
                {
                    //  Error
                    MessageBox.Show("ERROR: Invalid input must be " + min +" - " + max + " characters long.");
                    isValid = false;
                }
                
                if (validChar == true)
                {
                    if (DataValidation.Instance.ContainsNumbers(text))
                    {
                        MessageBox.Show("ERROR: Invalid input must be A-Z format.");
                        isValid = false;
                    }
                }
                else
                {
                    if (!DataValidation.Instance.ContainsNumbers(text))
                    {
                        MessageBox.Show("ERROR: Invalid input must be 0-9 format.");
                        isValid = false;
                    }  
                }

                if (isValid == false)
                {
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                }
                else
                {
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                }
                return isValid;
            }
            return false;
        }

        public static Form3 Instance
        {
            get { return instance; }
        }
           
    }


}
