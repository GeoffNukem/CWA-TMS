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

        public void LoadTables()
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Creates a colour dialogue with swatches and wheel, saves RGB value to contained Cell
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If the selected colomn header equals "colour"
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgv.Columns[e.ColumnIndex].HeaderText.Equals("Colour"))
                {
                    colorDialog1.ShowDialog();                                                          //Shows colourDialogue window
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = colorDialog1.Color;     //selected cell changes to Dialogue RGB colour
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = colorDialog1.Color;     //selected text in cell hidden using Dialoge RGB colour
                    dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = " ";
                }
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
                            {
                                try
                                {
                                    DataCollection.Instance.Lecturers[e.RowIndex] = lect;
                                }
                                catch
                                {

                                    DataCollection.Instance.Insert(lect, e.RowIndex);
                                }

                            }
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
                            Module mod = new Module(subject, label, courseLevel, colour);
                            if (!loading)
                            {
                                try
                                {
                                    DataCollection.Instance.Modules[e.RowIndex] = mod;
                                }
                                catch
                                {

                                    DataCollection.Instance.Insert(mod, e.RowIndex);
                                }

                            }
                        }
                        break;

                    case 2:	//	Room DGV
                        dgv = dataRoomTable;
                        if (dgv.Rows[e.RowIndex].Cells[0].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[1].Value != null &&
                           dgv.Rows[e.RowIndex].Cells[2].Value != null &&
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
                            room.SetEquipment(0, dgv.Rows[e.RowIndex].Cells[3].Value != null ? true : false);
                            room.SetEquipment(1, dgv.Rows[e.RowIndex].Cells[4].Value != null ? true : false);
                            room.SetEquipment(2, dgv.Rows[e.RowIndex].Cells[5].Value != null ? true : false);
                            room.SetEquipment(3, dgv.Rows[e.RowIndex].Cells[6].Value != null ? true : false);
                            room.SetEquipment(4, dgv.Rows[e.RowIndex].Cells[7].Value != null ? true : false);
                            if (!loading)
                            {
                                try
                                {
                                    DataCollection.Instance.Rooms[e.RowIndex] = room;
                                }
                                catch
                                {

                                    DataCollection.Instance.Insert(room, e.RowIndex);
                                }

                            }
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
                            string sStudents = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                            Color colour = dgv.Rows[e.RowIndex].Cells[3].Style.BackColor;
                            int numStudents;
                            try
                            {
                                numStudents = int.Parse(sStudents);
                            }
                            catch
                            {
                                return;
                            }
                            Group grp = new Group(group, label, colour, numStudents);
                            if (!loading)
                            {
                                try
                                {
                                    DataCollection.Instance.Groups[e.RowIndex] = grp;
                                }
                                catch
                                {

                                    DataCollection.Instance.Insert(grp, e.RowIndex);
                                }

                            }
                        }
                        break;
                    default:
                        break;
                }
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
                main.populateViewMenu();
            }
        }

        private bool validate(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            int min = 0;
            int max = 0;
            bool validChar = false;
            bool isValid = true;
            bool allowNum = false;

            if (e.RowIndex > -1 && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string text = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                //tab control to decide table validation
                if (dgv == dataLecTable)
                {
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
                            allowNum = true;
                            break;
                        case 2:
                            min = 1;
                            max = 3;
                            validChar = false;
                            break;
                        case 3:
                            return true;
                    }
                }
                else if (dgv == dataSubTable)
                {
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
                            allowNum = true;
                            break;
                        case 2:
                            min = 1;
                            max = 35;
                            validChar = true;
                            allowNum = true;
                            break;
                        case 3:
                            return true;
                    }
                }
                else if (dgv == dataRoomTable)
                {
                    switch (e.ColumnIndex)
                    {
                        case 0:
                            min = 1;
                            max = 35;
                            validChar = true;
                            allowNum = true;
                            break;
                        case 1:
                            min = 1;
                            max = 3;
                            validChar = true;
                            allowNum = true;
                            break;
                        case 2:
                            min = 1;
                            max = 3;
                            validChar = false;
                            break;
                        case 3:
                            min = 1;
                            max = 5;
                            validChar = true;
                            break;
                        case 4:
                            min = 1;
                            max = 5;
                            validChar = true;
                            break;
                        case 5:
                            min = 1;
                            max = 5;
                            validChar = true;
                            break;
                        case 6:
                            min = 1;
                            max = 5;
                            validChar = true;
                            break;
                        case 7:
                            min = 1;
                            max = 5;
                            validChar = true;
                            break;
                        case 8:
                            return true;
                    }
                }
                else if (dgv == dataClassTable)
                {
                    switch (e.ColumnIndex)
                    {
                        case 0:
                            min = 1;
                            max = 35;
                            validChar = true;
                            allowNum = true;
                            break;
                        case 1:
                            min = 1;
                            max = 3;
                            validChar = false;
                            allowNum = true;
                            break;
                        case 2:
                            min = 1;
                            max = 3;
                            validChar = false;
                            break;
                        case 3:
                            return true;
                    }
                }
                if (!loading)
                {
                    if (!DataValidation.Instance.IsInRange(text.Length, min, max, true))
                    {
                        MessageBox.Show("ERROR: Invalid input must be " + min + " - " + max + " characters long.");
                        return false;
                    }

                    if (validChar && !allowNum)
                    {
                        if (DataValidation.Instance.ContainsNumbers(text))
                        {
                            MessageBox.Show("ERROR: Invalid input must be A-Z format.");
                            return false;
                        }
                    }
                    else if (!validChar)
                    {
                        if (!DataValidation.Instance.ContainsNumbers(text))
                        {
                            MessageBox.Show("ERROR: Invalid input must be 0-9 format.");
                            return false;
                        }
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
                return true;
            }
            return false;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is FormData && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void dataLecTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < DataCollection.Instance.Lecturers.Count && e.ColumnIndex == 4)
            {
                DataCollection.Instance.Lecturers.RemoveAt(e.RowIndex);
                LoadTables();
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
                main.populateViewMenu();
            }
        }

        private void dataSubTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < DataCollection.Instance.Modules.Count && e.ColumnIndex == 4)
            {
                DataCollection.Instance.Modules.RemoveAt(e.RowIndex);
                LoadTables();
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
                main.populateViewMenu();
            }
        }

        private void dataRoomTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < DataCollection.Instance.Rooms.Count && e.ColumnIndex == 9)
            {
                DataCollection.Instance.Rooms.RemoveAt(e.RowIndex);
                LoadTables();
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
                main.populateViewMenu();
            }
        }

        private void dataClassTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < DataCollection.Instance.Groups.Count && e.ColumnIndex == 4)
            {
                DataCollection.Instance.Groups.RemoveAt(e.RowIndex);
                LoadTables();
                FormMain main = (FormMain)(this.MdiParent);
                main.populateTab();
                main.populateViewMenu();
            }
        }

    }


}
