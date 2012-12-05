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
using CWATMS.Controls;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace CWATMS
{
    public partial class FormMain : Form
    {
        //public delegate void SaveDelegate(object sender, EventArgs e);
        //public event SaveDelegate Save;

        private FormData m_dataForm;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Loading...";
            m_dataForm = new FormData();
            m_dataForm.MdiParent = this;
            populateViewMenu();
            populateTab();
            lblStatus.Text = "Load Complete";
            Directory.CreateDirectory(@".\PDF\Lists\");
            Directory.CreateDirectory(@".\PDF\Timetables\Class\");
            Directory.CreateDirectory(@".\PDF\Timetables\Lecturers\");
            Directory.CreateDirectory(@".\PDF\Timetables\Module\");
            Directory.CreateDirectory(@".\PDF\Timetables\Room\");
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (PromptSave())
            {
                case DialogResult.Yes:
                    Save();
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    return;
            }
            DataCollection.Instance.Lecturers.Clear();
            DataCollection.Instance.Modules.Clear();
            DataCollection.Instance.Rooms.Clear();
            DataCollection.Instance.Groups.Clear();
            DataCollection.Instance.Lessons.Clear();
            DataFile.Instance.FileName = null;
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormTimetable)
                    child.Close();
            }
            m_dataForm.LoadTables();
            populateViewMenu();
            populateTab();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog(); //new open instance

            //Open Dialogue configuration
            open.DefaultExt = ".tms";
            open.AddExtension = true;
            open.RestoreDirectory = true;
            open.InitialDirectory = @"C:\";
            open.Filter = "TMS File (*.tms)|*.tms";
            open.Title = "Open File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            try
            {
                lblStatus.Text = "Opening File...";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    DataFile.Instance.FileName = open.FileName;
                    DataFile.Instance.LoadAll();
                    m_dataForm.LoadTables();
                    lblStatus.Text = "Open Complete";
                }
                else
                {
                    lblStatus.Text = "Open Cancelled";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                lblStatus.Text = "Open Failed";
                return;
            }
            this.Cursor = Cursors.Default;
        }



        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private DialogResult PromptSave()
        {
            return MessageBox.Show("Would you like to save before exiting?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        private void Save()
        {
            if (File.Exists(DataFile.Instance.FileName))
            {
                this.Cursor = Cursors.WaitCursor;
                lblStatus.Text = "Saving...";
                DataFile.Instance.SaveAll();
                lblStatus.Text = "Save Complete";
            }
            else
            {
                ShowSaveDialog();
            }
            this.Cursor = Cursors.Default;
        }

        private void ShowSaveDialog()
        {
            SaveFileDialog save = new SaveFileDialog(); //new save instance

            //Save Dialogue configuration

            save.DefaultExt = ".tms";
            save.AddExtension = true;
            save.RestoreDirectory = true;
            save.InitialDirectory = @"C:\";
            save.Filter = "TMS File (*.tms)|*.tms";
            save.Title = "Save File";

            // Dialogue accessed then loops thro each row and cell. Data added to file
            try
            {
                lblStatus.Text = "Saving...";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    DataFile.Instance.FileName = save.FileName;
                    DataFile.Instance.SaveAll();
                    lblStatus.Text = "Save Complete";
                }
                else
                {
                    lblStatus.Text = "Save Cancelled";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Save Failed";
                MessageBox.Show(ex.ToString());
            }
            this.Cursor = Cursors.Default;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_dataForm.Show();  // Show the child form.
        }

        public void UpdateTimetables()
        {
            this.Cursor = Cursors.WaitCursor;
            lblStatus.Text = "Updating Timetables...";
            foreach (Form child in MdiChildren)
            {
                if (child is FormTimetable)
                {
                    FormTimetable timetable = (FormTimetable)child;
                    timetable.UpdateGrids();
                }
            }
            lblStatus.Text = "Updating Complete";
            this.Cursor = Cursors.Default;
        }

        public void populateViewMenu()
        {
            btnViewLect.DropDownItems.Clear();
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                ButtonView bv = new ButtonView(lect);
                bv.Name = "btn" + lect.Name + btnViewLect.DropDownItems.Count.ToString();
                bv.Text = lect.Name;
                bv.Click += OnMenuItemClick;
                bv.Available = true;
                bv.Size = new System.Drawing.Size(152, 22);
                btnViewLect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {bv});
            }
            btnViewMod.DropDownItems.Clear();
            foreach (Module mod in DataCollection.Instance.Modules)
            {
                ButtonView bv = new ButtonView(mod);
                bv.Name = "btn" + mod.Name + btnViewLect.DropDownItems.Count.ToString();
                bv.Text = mod.Name;
                bv.Click += OnMenuItemClick;
                bv.Available = true;
                bv.Size = new System.Drawing.Size(152, 22);
                btnViewMod.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bv });
            }
            btnViewRoom.DropDownItems.Clear();
            foreach (Room room in DataCollection.Instance.Rooms)
            {
                ButtonView bv = new ButtonView(room);
                bv.Name = "btn" + room.Name + btnViewLect.DropDownItems.Count.ToString();
                bv.Text = room.Name;
                bv.Click += OnMenuItemClick;
                bv.Available = true;
                bv.Size = new System.Drawing.Size(152, 22);
                btnViewRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bv });
            }
            btnViewGrp.DropDownItems.Clear();
            foreach (Group grp in DataCollection.Instance.Groups)
            {
                ButtonView bv = new ButtonView(grp);
                bv.Name = "btn" + grp.Name + btnViewLect.DropDownItems.Count.ToString();
                bv.Text = grp.Name;
                bv.Click += OnMenuItemClick;
                bv.Available = true;
                bv.Size = new System.Drawing.Size(152, 22);
                btnViewGrp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { bv });
            }
        }

        public void populateTab()
        {
            tabLecturer.Controls.Clear();
            tabSubject.Controls.Clear();
            tabRoom.Controls.Clear();
            tabClass.Controls.Clear();
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.MouseHover += Button_MouseHover;
                button.Lecturer = lect;
                button.Text = button.Lecturer.Name;
                button.BackColor = button.Lecturer.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabLecturer.Controls.Add(button);
            }
            foreach (Module mod in DataCollection.Instance.Modules)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.MouseHover += Button_MouseHover;
                button.Module = mod;
                button.Text = button.Module.Name;
                button.BackColor = button.Module.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabSubject.Controls.Add(button);
            }
            foreach (Room room in DataCollection.Instance.Rooms)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.MouseHover += Button_MouseHover;
                button.Room = room;
                button.Text = button.Room.Name;
                button.BackColor = button.Room.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabRoom.Controls.Add(button);
            }
            foreach (Group grp in DataCollection.Instance.Groups)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.MouseHover += Button_MouseHover;
                button.Group = grp;
                button.Text = button.Group.Name;
                button.BackColor = button.Group.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabClass.Controls.Add(button);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is DataButton)
            {
                DataButton button = (DataButton)sender;
                if (e.Button == MouseButtons.Left && e.Clicks == 1)
                {
                    if (button.Lecturer != null)
                        button.DoDragDrop(button.Lecturer, DragDropEffects.Move);
                    else if (button.Module != null)
                        button.DoDragDrop(button.Module, DragDropEffects.Move);
                    else if (button.Room != null)
                        button.DoDragDrop(button.Room, DragDropEffects.Move);
                    else if (button.Group != null)
                        button.DoDragDrop(button.Group, DragDropEffects.Move);
                }
                else if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    if (button.Lecturer != null)
                    {
                        OpenTimetable(button.Lecturer);
                    }
                    else if (button.Module != null)
                    {
                        OpenTimetable(button.Module);
                    }
                    else if (button.Room != null)
                    {
                        OpenTimetable(button.Room);
                    }
                    else if (button.Group != null)
                    {
                        OpenTimetable(button.Group);
                    }
                }
            }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            if (sender is DataButton)
            {
                DataButton button = (DataButton)sender;
                if (button.Lecturer != null)
                {
                    lblHover.Text = "Lecturer: " + button.Text;
                }
                else if (button.Module != null)
                {
                    lblHover.Text = "Module: " + button.Text;
                }
                else if (button.Room != null)
                {
                    lblHover.Text = "Room: " + button.Text;
                }
                else if (button.Group != null)
                {
                    lblHover.Text = "Group: " + button.Text;
                }
            }
            else
            {
                lblHover.Text = "";
            }
        }

        private void OnMenuItemClick(object sender, EventArgs e)
        {
            ButtonView bv = (ButtonView)sender;
            OpenTimetable(bv.Data);
        }

        private void OpenTimetable(Data data)
        {
            this.Cursor = Cursors.WaitCursor;
            FormTimetable childForm = new FormTimetable(data);
            childForm.MdiParent = this;
            childForm.Show();
            this.Cursor = Cursors.Default;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FormExport childForm = new FormExport();
            childForm.MdiParent = this;
            childForm.Show();
            this.Cursor = Cursors.Default;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (PromptSave())
            {
                case DialogResult.Yes:
                    Save();
                    return;
                case DialogResult.No:
                    return;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    return;
            }
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.LayoutMdi(MdiLayout.TileVertical);
            this.Cursor = Cursors.Default;
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.LayoutMdi(MdiLayout.TileHorizontal);
            this.Cursor = Cursors.Default;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.LayoutMdi(MdiLayout.Cascade);
            this.Cursor = Cursors.Default;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTimetables();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = "SumatraPDF.exe";

            p.Arguments = @"./UserGuide.pdf";

            Process x = Process.Start(p);
        }
        
    }
}
