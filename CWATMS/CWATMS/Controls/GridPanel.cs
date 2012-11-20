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

        public GridPanel(int day, int time, Color color) : base() 
        {
            m_day = day;
            m_time = time;
            BackColor = color;
            m_lessonData = new Lesson();

            m_label = new Label();
            m_label.Location = this.Location;
            m_label.AutoSize = true;

            this.AllowDrop = true;
            this.Dock = DockStyle.Fill;

            this.Controls.Add(m_label);
        }

        public void UpdateText()
        {
            m_label.Text = "";
            if (m_lessonData.Module != null)
            {
                m_label.Text += m_lessonData.Module.Name + "\n";
            }
            if (m_lessonData.Lecturer != null)
            {
                m_label.Text += m_lessonData.Lecturer.Name + "\n";
            }
            if (m_lessonData.Group != null)
            {
                 m_label.Text += m_lessonData.Group.Name + "\n";
            }
            if (m_lessonData.Room != null)
            {
                 m_label.Text += m_lessonData.Room.Name;
            }

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
