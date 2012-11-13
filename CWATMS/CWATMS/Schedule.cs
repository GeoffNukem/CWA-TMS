using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Schedule
    {
        private List<Timetable> m_timetablesList;

        public Schedule() { }

        public List<Timetable> Timetables
        {
            get { return m_timetablesList; }
            set { m_timetablesList = value; }
        }
    }
}
