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
    public partial class FormTimetable : Form
    {
        private Data m_data;
        private int m_colour;

        public FormTimetable(Data data)
        {
            m_data = data;
            InitializeComponent();
            UpdateGrids();
        }

        private void FormTimetable_Load(object sender, EventArgs e)
        {
            if (m_data is Lecturer)
            {
                this.Text = "Lecturer: ";
                ChangeColours(1);
            }
            else if (m_data is Module)
            {
                this.Text = "Subject: ";
                ChangeColours(0);
            }
            else if (m_data is Group)
            {
                this.Text = "Class: ";
                ChangeColours(1);
            }
            else if (m_data is Room)
            {
                this.Text = "Room: ";
                ChangeColours(1);
            }
            this.Text += m_data.Name;
        }

        public void UpdateGrids()
        {
            this.tlpTimetable.Controls.Clear();
            for (int i = 0; i < this.tlpTimetable.RowCount; i++)
            {
                for (int j = 0; j < this.tlpTimetable.ColumnCount; j++)
                {
                    GridPanel g = new GridPanel(i, j, Color.Empty);
                    g.Name = "G" + i.ToString() + j.ToString();
                    g.Text = g.Name;
                    g.MouseDown += Panel_MouseDown;
                    g.DragOver += Panel_DragOver;
                    g.DragDrop += Panel_DragDrop;
                    Lesson lesson = DataCollection.Instance.FindLesson(m_data, j, i);
                    if (lesson != null)
                    {
                        g.LessonData = lesson;
                        g.UpdateText();
                    }
                    g.LessonData.Day = i;
                    g.LessonData.Time = j;
                    this.tlpTimetable.Controls.Add(g, j, i);
                }
            }
            ChangeColours(m_colour);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                if (sender is GridPanel)
                {
                    GridPanel curLesson = sender as GridPanel;
                    if (curLesson.LessonData.Lecturer != null || curLesson.LessonData.Module != null ||
                        curLesson.LessonData.Room != null || curLesson.LessonData.Group != null)
                    {
                        curLesson.DoDragDrop(curLesson.LessonData, DragDropEffects.All);
                    }
                }
            }
        }

        private void Panel_DragOver(object sender, DragEventArgs e)
        {
            if ((e.KeyState & 8) == 8 &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.Move;

        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            GridPanel gPanel = (GridPanel)sender;
            Lesson lesson = new Lesson();

            /*****************************************************************************************************************/
            if (e.Data.GetData(typeof(Lesson)) is Lesson)
            {
                Lesson oldLesson = (Lesson)e.Data.GetData(typeof(Lesson));
                //  Move
                if (e.Effect == DragDropEffects.Move)
                {
                    GridPanel gp = (GridPanel)tlpTimetable.GetControlFromPosition(oldLesson.Time, oldLesson.Day);
                    if (gp.LessonData != oldLesson)
                    {
                        DataCollection.Instance.Remove(oldLesson);
                        gp.LessonData.Lecturer = null;
                        gp.LessonData.Module = null;
                        gp.LessonData.Room = null;
                        gp.LessonData.Group = null;
                        gp.UpdateText();
                    }
                }
                gPanel.LessonData = oldLesson;
            }
            else
            {
                if (e.Data.GetData(typeof(Lecturer)) is Lecturer && m_data is Lecturer)
                {
                    MessageBox.Show("Cannot add Lecturer to a Lecturer's Timetable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (e.Data.GetData(typeof(Module)) is Module && m_data is Module)
                {
                    MessageBox.Show("Cannot add Module to a Module's Timetable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (e.Data.GetData(typeof(Room)) is Room && m_data is Room)
                {
                    MessageBox.Show("Cannot add Room to a Room's Timetable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (e.Data.GetData(typeof(Group)) is Group && m_data is Group)
                {
                    MessageBox.Show("Cannot add Group to a Group's Timetable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (e.Data.GetData(typeof(Lecturer)) is Lecturer)
                {
                    Lecturer lect = (Lecturer)e.Data.GetData(typeof(Lecturer));
                    gPanel.LessonData.Lecturer = lect;
                }
                else if (e.Data.GetData(typeof(Module)) is Module)
                {
                    Module mod = (Module)e.Data.GetData(typeof(Module));
                    gPanel.LessonData.Module = mod;
                }
                else if (e.Data.GetData(typeof(Room)) is Room)
                {
                    Room room = (Room)e.Data.GetData(typeof(Room));
                    gPanel.LessonData.Room = room;
                }
                else if (e.Data.GetData(typeof(Group)) is Group)
                {
                    Group group = (Group)e.Data.GetData(typeof(Group));
                    gPanel.LessonData.Group = group;
                }

                if (m_data is Lecturer)
                {
                    gPanel.LessonData.Lecturer = (Lecturer)m_data;
                }
                else if (m_data is Module)
                {
                    gPanel.LessonData.Module = (Module)m_data;
                }
                else if (m_data is Room)
                {
                    gPanel.LessonData.Room = (Room)m_data;
                }
                else if (m_data is Group)
                {
                    gPanel.LessonData.Group = (Group)m_data;
                }
            }

            lesson = gPanel.LessonData;
            if(DataCollection.Instance.DoesLessonClash(lesson))
            {
                MessageBox.Show("Unable to add lesson. Make sure nothing is timetabled for the same lesson.\nE.g. Lecturers booked for the same room at the same time.", "ERROR: DOUBLE BOOKING DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DataCollection.Instance.FindLesson(lesson, lesson.Time, lesson.Day) == null)
            {
                DataCollection.Instance.Add(lesson);
            }
            else
            {
                int i = DataCollection.Instance.Lessons.IndexOf(lesson);
                DataCollection.Instance.Lessons[i] = lesson;
            }
            gPanel.UpdateText();
            ChangeColours(m_colour);
        }

        private void ChangeColours(int i)
        {
            m_colour = i;
            switch (i)
            {
                case 0:
                    foreach (Control c in tlpTimetable.Controls)
                    {
                        if (c is GridPanel)
                        {
                            GridPanel gp = (GridPanel)c;
                            if (gp.LessonData.Lecturer != null)
                                gp.BackColor = gp.LessonData.Lecturer.Colour;
                            else
                                gp.BackColor = Color.Empty;
                        }
                    }
                    break;
                case 1:
                    foreach (Control c in tlpTimetable.Controls)
                    {
                        if (c is GridPanel)
                        {
                            GridPanel gp = (GridPanel)c;
                            if (gp.LessonData.Module != null)
                                gp.BackColor = gp.LessonData.Module.Colour;
                            else
                                gp.BackColor = Color.Empty;

                        }
                    }
                    break;
                case 2:
                    foreach (Control c in tlpTimetable.Controls)
                    {
                        if (c is GridPanel)
                        {
                            GridPanel gp = (GridPanel)c;
                            if (gp.LessonData.Room != null)
                                gp.BackColor = gp.LessonData.Room.Colour;
                            else
                                gp.BackColor = Color.Empty;
                        }
                    }
                    break;
                case 3:
                    foreach (Control c in tlpTimetable.Controls)
                    {
                        if (c is GridPanel)
                        {
                            GridPanel gp = (GridPanel)c;
                            if (gp.LessonData.Group != null)
                                gp.BackColor = gp.LessonData.Group.Colour;
                            else
                                gp.BackColor = Color.Empty;
                        }
                    }
                    break;
                default:
                    foreach (Control c in tlpTimetable.Controls)
                    {
                        if (c is GridPanel)
                        {
                            GridPanel gp = (GridPanel)c;
                            gp.BackColor = Color.Empty;
                        }
                    }
                    break;

            }
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            ChangeColours(0);
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            ChangeColours(1);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            ChangeColours(2);
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            ChangeColours(3);
        }

    }

}
