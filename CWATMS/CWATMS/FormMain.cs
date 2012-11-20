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

        public FormMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimetable childForm = new FormTimetable();              // Declare the child form as a new one.
            childForm.MdiParent = this;                 // Set the main form as a parent form.
            childForm.Show();                           // Show the child form.
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
            Form3 childForm = new Form3(); // Declare the child form as a new one.
            childForm.MdiParent = this;// Set the main form as a parent form.
            childForm.Show();// Show the child form.
        }

        private void populateTab()
        {
            foreach (Lecturer lect in DataCollection.Instance.Lecturers)
            {
                DataButton button = new DataButton();
                button.Dock = DockStyle.Left;
                button.MouseDown += Button_MouseDown;
                button.Lecturer = lect;
                button.Text = button.Lecturer.Name;
                button.BackColor = button.Lecturer.Colour;
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
                button.CreateControl();
                this.tabSubject.Controls.Add(button);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                if (sender is DataButton)
                {
                    DataButton button = (DataButton)sender;
                    if (button.Lecturer != null)
                        button.DoDragDrop(button.Lecturer, DragDropEffects.Copy);
                    else if (button.Module != null)
                        button.DoDragDrop(button.Module, DragDropEffects.Copy);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            populateTab();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export childForm = new Export();
            childForm.MdiParent = this;
            childForm.Show();
        }
        
    }
}
