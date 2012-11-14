using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Timetable
    {
        private List<Lesson> m_lessonsList;
        private int m_semester;

        public Timetable(int semester)
        {
            m_lessonsList = new List<Lesson>();
            m_semester = semester;
        }

        public void AddLesson(Lesson lesson)
        {
            m_lessonsList.Add(lesson);
        }

        public void RemoveLesson(Lesson lesson)
        {
            if (m_lessonsList.Contains(lesson))
                m_lessonsList.Remove(lesson);
        }
    }
}
