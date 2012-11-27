using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWATMS.Controls;

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
            m_dataForm = new FormData();
            m_dataForm.MdiParent = this;
            m_dataForm.LoadData();
            populateTab();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {                         // Show the child form.
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
            
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
            m_dataForm.Show();// Show the child form.
        }

        public void populateTab()
        {
            tabLecturer.Controls.Clear();
            tabSubject.Controls.Clear();
            tabRoom.Controls.Clear();
            tabClass.Controls.Clear();
            tabLesson.Controls.Clear();
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
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
                button.Room = room;
                button.Text = button.Room.Name;
                button.BackColor = button.Room.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabSubject.Controls.Add(button);
            }
            foreach (Group grp in DataCollection.Instance.Groups)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Group = grp;
                button.Text = button.Group.Name;
                button.BackColor = button.Group.Colour;
                button.Size = new Size(98, 50);
                button.CreateControl();
                this.tabSubject.Controls.Add(button);
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
                        button.DoDragDrop(button.Lecturer, DragDropEffects.Copy);
                    else if (button.Module != null)
                        button.DoDragDrop(button.Module, DragDropEffects.Copy);
                    else if (button.Room != null)
                        button.DoDragDrop(button.Room, DragDropEffects.Copy);
                    else if (button.Group != null)
                        button.DoDragDrop(button.Group, DragDropEffects.Copy);
                }
                else if (e.Button == MouseButtons.Left && e.Clicks == 2)
                {
                    if (button.Lecturer != null)
                    {
                        FormTimetable childForm = new FormTimetable(button.Lecturer);
                        childForm.MdiParent = this;
                        childForm.Show();
                    }
                    else if (button.Module != null)
                    {
                        FormTimetable childForm = new FormTimetable(button.Module);
                        childForm.MdiParent = this;
                        childForm.Show();
                    }
                    else if (button.Room != null)
                    {
                        FormTimetable childForm = new FormTimetable(button.Room);
                        childForm.MdiParent = this;
                        childForm.Show();
                    }
                    else if (button.Group != null)
                    {
                        FormTimetable childForm = new FormTimetable(button.Group);
                        childForm.MdiParent = this;
                        childForm.Show();
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export childForm = new Export();
            childForm.MdiParent = this;
            childForm.Show();
        }
        
    }
}
