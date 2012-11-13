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
using System.Xml;


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
            OpenFileDialog open = new OpenFileDialog(); //new open instance

            //Open Dialogue configuration

            open.DefaultExt = ".txt";
            open.AddExtension = true;
            open.RestoreDirectory = true;
            open.InitialDirectory = @"C:\";
            open.Filter = "Xml File (*.xml)|*.xml";
            open.Title = "Save File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Save Dialogue corresponds to file location
                openXML(open.FileName);
            }
        }

        private void openXML(String file)
        {
            try
            {
                XmlTextReader xml = new XmlTextReader(file);

                String nodeName = "";
                DataGridViewRow row = new DataGridViewRow();

                while (xml.Read())
                {
                    switch (xml.NodeType)
                    {
                        case XmlNodeType.Element:
                            nodeName = xml.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (nodeName)
                            {
                                case "Lecturer":
                                    row = new DataGridViewRow();
                                    row.CreateCells(dataLecTable);
                                    row.Cells[0].Value = xml.Value;
                                    break;
                                case "Label":
                                    row = new DataGridViewRow();
                                    row.CreateCells(dataSubTable);
                                    row.Cells[1].Value = xml.Value;

                                    break;
                                case "ContractedHours":
                                    row = new DataGridViewRow();
                                    row.CreateCells(dataRoomTable);
                                    row.Cells[2].Value = xml.Value;
                                    break;
                                case "Colour":
                                    row = new DataGridViewRow();
                                    row.CreateCells(dataClassTable);
                                    row.Cells[3].Value = xml.Value;

                                    break;
                            }
                            break;
                    }
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
            if (save.ShowDialog() == DialogResult.OK)
            {
                //Save Dialogue corresponds to file location
                saveToXML(save.FileName);
            }
        }

        private void saveToXML(String file)
        {
            DataGridView dgv = dataLecTable;
            int tn = 0;


            // Create XML File.
            XmlTextWriter xml = new XmlTextWriter(file, null);

            // Set XML writer in indent elements.
            xml.Formatting = Formatting.Indented;

            // Write in the XML document.
            xml.WriteStartDocument();
            xml.WriteStartElement("DataTables");
            xml.WriteAttributeString("Count", dgv.RowCount.ToString());
            do
            {
                switch (tn)
                {
                    case 0:
                        dgv = dataLecTable;

                        // For each attribute, write each property into the XML document.
                        for (int i = 0; i < dgv.RowCount - 1; i++)
                        {
                            xml.WriteStartElement("LecturerTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Lecturer");
                            xml.WriteString(dgv.Rows[i].Cells[0].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(dgv.Rows[i].Cells[1].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("ContractedHours");
                            xml.WriteString(dgv.Rows[i].Cells[2].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                        }
                        break;

                    case 1:
                        dgv = dataSubTable;
                        for (int i = 0; i < dgv.RowCount - 1; i++)
                        {
                            xml.WriteStartElement("SubjectTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Subject");
                            xml.WriteString(dgv.Rows[i].Cells[0].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(dgv.Rows[i].Cells[1].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                        }
                        break;

                    case 2:

                        dgv = dataRoomTable;
                        for (int i = 0; i < dgv.RowCount - 1; i++)
                        {
                            xml.WriteStartElement("RoomTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Room No");
                            xml.WriteString(dgv.Rows[i].Cells[0].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Smartboard");
                            xml.WriteString(dgv.Rows[i].Cells[1].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("TV");
                            xml.WriteString(dgv.Rows[i].Cells[2].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Projector");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Network Lab");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                        }
                        break;

                    case 3:

                        dgv = dataClassTable;
                        for (int i = 0; i < dgv.RowCount - 1; i++)
                        {
                            xml.WriteStartElement("ClassTable");
                            xml.WriteAttributeString("ID", i.ToString());
                            xml.WriteStartElement("Class");
                            xml.WriteString(dgv.Rows[i].Cells[0].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Label");
                            xml.WriteString(dgv.Rows[i].Cells[1].Value.ToString());
                            xml.WriteEndElement();
                            xml.WriteStartElement("Colour");
                            xml.WriteString(dgv.Rows[i].Cells[3].Value.ToString());
                        }
                        break;

                    default:

                        MessageBox.Show("Error saving data, please try again!");

                        break;
                }

                tn++;
            } while (tn < 4);

            xml.WriteEndElement();
            xml.WriteEndDocument();
            xml.Flush();
            xml.Close();
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
