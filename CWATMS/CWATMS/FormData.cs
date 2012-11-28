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
    public partial class FormData : Form
    {
        private static readonly FormData instance = new FormData();
        private bool loading = false;

        public FormData()
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

            open.DefaultExt = ".xml";
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
                    //MessageBox.Show("Opening File... " + open.FileName + "\n" + DataCollection.Instance.Lecturers.ToString());
                    DataFile.Instance.FileName = open.FileName;
                    DataFile.Instance.LoadAll();
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void LoadTables()
        {
            loading = true;
            dataLecTable.Rows.Clear();
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                dataLecTable.Rows.Add(1);
                dataLecTable.Rows[dataLecTable.Rows.Count - 2].Cells[0].Value = lect.Name;
                dataLecTable.Rows[dataLecTable.Rows.Count - 2].Cells[1].Value = lect.Label;
                dataLecTable.Rows[dataLecTable.Rows.Count - 2].Cells[2].Value = lect.HoursPerWeek;
                dataLecTable.Rows[dataLecTable.Rows.Count - 2].Cells[3].Value = " ";
                dataLecTable.Rows[dataLecTable.Rows.Count - 2].Cells[3].Style.BackColor = lect.Colour;
            }
            dataSubTable.Rows.Clear();
            foreach (Module mod in DataCollection.Instance.Modules)
            {
                dataSubTable.Rows.Add(1);
                dataSubTable.Rows[dataSubTable.Rows.Count - 2].Cells[0].Value = mod.Name;
                dataSubTable.Rows[dataSubTable.Rows.Count - 2].Cells[1].Value = mod.Label;
                dataSubTable.Rows[dataSubTable.Rows.Count - 2].Cells[2].Value = mod.CourseLevel;
                dataSubTable.Rows[dataSubTable.Rows.Count - 2].Cells[3].Value = " ";
                dataSubTable.Rows[dataSubTable.Rows.Count - 2].Cells[3].Style.BackColor = mod.Colour;
            }
            dataRoomTable.Rows.Clear();
            foreach (Room room in DataCollection.Instance.Rooms)
            {
                dataRoomTable.Rows.Add(1);
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[0].Value = room.Name;
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[1].Value = room.Label;
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[2].Value = room.Capacity;
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[3].Value = room.HasLecturerPC();
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[4].Value = room.HasSmartboard();
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[5].Value = room.HasTelevision();
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[6].Value = room.HasProjector();
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[7].Value = room.IsNetworkLab();
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[8].Value = " ";
                dataRoomTable.Rows[dataRoomTable.Rows.Count - 2].Cells[8].Style.BackColor = room.Colour;
            }
            dataClassTable.Rows.Clear();
            foreach (Group group in DataCollection.Instance.Groups)
            {
                dataClassTable.Rows.Add(1);
                dataClassTable.Rows[dataClassTable.Rows.Count - 2].Cells[0].Value = group.Name;
                dataClassTable.Rows[dataClassTable.Rows.Count - 2].Cells[1].Value = group.Label;
                dataClassTable.Rows[dataClassTable.Rows.Count - 2].Cells[2].Value = group.TotalStudents;
                dataClassTable.Rows[dataClassTable.Rows.Count - 2].Cells[3].Value = " ";
                dataClassTable.Rows[dataClassTable.Rows.Count - 2].Cells[3].Style.BackColor = group.Colour;
            }
            loading = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); //new save instance

            //Save Dialogue configuration

            save.DefaultExt = ".xml";
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
                    //MessageBox.Show("Saving File... " + save.FileName + "\n" + DataCollection.Instance.Lecturers.ToString());
                    DataFile.Instance.FileName = save.FileName;
                    DataFile.Instance.SaveLecturers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            }

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
                        dgv = dataLecTable;
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            int hours;
                            if (!int.TryParse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString(), out hours)) //converts int to bool, if invalid then return false
                            {
                                return;
                            }
                            Color colour = dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;

                            Lecturer lect = new Lecturer(name, hours, label, colour);
                            if (!loading)
                                DataCollection.Instance.Add(lect);
                        }
                        break;

                    case 1:	//	Module DGV
                        dgv = dataSubTable;
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                            dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            String subject = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            String label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            String courseLevel = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                            Color colour = dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;

                            DataCollection.Instance.Add(new Module(subject, label, courseLevel, colour));
                        }
                        break;

                    case 2:	//	Room DGV
                        dgv = dataRoomTable;
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[8].Value != null)
                        {
                            String name = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            String label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            String sCap = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                            Color colour = dgv.Rows[e.RowIndex].Cells[8].Style.BackColor;
                            int capacity;
                            try
                            {
                                capacity = int.Parse(sCap);
                            }
                            catch
                            {
                                return;
                            }
                            Room room = new Room(name, label, colour, capacity);
                            room.SetEquipment(0, (bool)dgv.Rows[e.RowIndex].Cells[3].Value);
                            room.SetEquipment(1, (bool)dgv.Rows[e.RowIndex].Cells[4].Value);
                            room.SetEquipment(2, (bool)dgv.Rows[e.RowIndex].Cells[5].Value);
                            room.SetEquipment(3, (bool)dgv.Rows[e.RowIndex].Cells[6].Value);
                            room.SetEquipment(4, (bool)dgv.Rows[e.RowIndex].Cells[7].Value);
                            DataCollection.Instance.Add(room);
                        }
                        break;

                    case 3:	//	Group DGV
                        dgv = dataClassTable;
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[2].Value != null &&
                          dgv.Rows[e.RowIndex].Cells[3].Value != null)
                        {
                            string group = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                            string label = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                            Color colour = dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;
                            int numStudents;
                            if (!int.TryParse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString(), out numStudents)) //converts int to bool, if invalid then return false
                            {
                                return;
                            }
                            DataCollection.Instance.Add(new Group(group, label, colour, numStudents));
                        }
                        break;
                }
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
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
                                return true;
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
                                max = 35;
                                validChar = true;
                                break;
                            case 3:
                                return true;
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
                            case 5:
                                return true;
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
                                validChar = false;
                                break;
                            case 2:
                                return true;
                        }
                        break;
                }
                if (!DataValidation.Instance.IsInRange(text.Length, min, max, true))
                {
                    MessageBox.Show("ERROR: Invalid input must be " + min + " - " + max + " characters long.");
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }


}
