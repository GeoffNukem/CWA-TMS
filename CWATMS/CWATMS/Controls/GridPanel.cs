using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CWATMS.Controls
{
    public class GridPanel : Panel
    {
        private int m_day;
        private int m_time;
        private int m_duration;

        private Lesson m_lessonData;
        private Label m_label;

        private ToolTip m_tooltip;

        private ContextMenu m_contextMenu;
        private MenuItem btnDelete;

        public GridPanel(int day, int time, Color color) : base() 
        {
            m_day = day;
            m_time = time;
            BackColor = color;
            m_lessonData = new Lesson();

            m_label = new Label();
            m_label.Location = this.Location;
            m_label.AutoSize = true;

            m_tooltip = new ToolTip();

            m_contextMenu = new ContextMenu();
            btnDelete = new MenuItem("Delete", Delete);
            m_contextMenu.MenuItems.Add(btnDelete);

            this.ContextMenu = m_contextMenu;

            this.AllowDrop = true;
            this.Dock = DockStyle.Fill;

            this.Controls.Add(m_label);
        }

        public void Delete(object sender, EventArgs e)
        {
            if (m_lessonData.Lecturer != null || m_lessonData.Module != null ||
                m_lessonData.Room != null || m_lessonData.Group != null)
            {
                DataCollection.Instance.Lessons.Remove(m_lessonData);
                m_lessonData.Lecturer = null;
                m_lessonData.Module = null;
                m_lessonData.Room = null;
                m_lessonData.Group = null;
                this.BackColor = Color.Empty;
                UpdateText();
            }
        }

        public void UpdateText()
        {
            m_label.Text = "";
            string tooltip = "";
            if (m_lessonData.Module != null)
            {
                m_label.Text += m_lessonData.Module.Label + "\n";
                tooltip += "Module: " + m_lessonData.Module.Name + "\n";
            }
            else
            {
                tooltip += "Module: N/A\n";
            }
            if (m_lessonData.Lecturer != null)
            {
                m_label.Text += m_lessonData.Lecturer.Label + "\n";
                tooltip += "Lecturer: " + m_lessonData.Lecturer.Name + "\n";
            }
            else
            {
                tooltip += "Lecturer: N/A\n";
            }
            if (m_lessonData.Group != null)
            {
                m_label.Text += m_lessonData.Group.Label + "\n";
                tooltip += "Group: " + m_lessonData.Group.Name + "\n";
            }
            else
            {
                tooltip += "Group: N/A\n";
            }
            if (m_lessonData.Room != null)
            {
                m_label.Text += m_lessonData.Room.Label;
                tooltip += "Room: " + m_lessonData.Room.Name;
            }
            else
            {
                tooltip += "Room: N/A\n";
            }
            m_tooltip.SetToolTip(this, tooltip);

        }

        public int Day
        {
            get { return m_day; }
            set { m_day = value; }
        }

        public int Time
        {
            get { return m_time; }
            set { m_time = value; }
        }

        public int Duration
        {
            get { return m_duration; }
            set { m_duration = value; }
        }

        public Lesson LessonData
        {
            get { return m_lessonData; }
            set { m_lessonData = value; }
        }

    }
}
