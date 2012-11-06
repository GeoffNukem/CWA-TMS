using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Group : Data
    {
        private int m_numStudents;

        public Group(String name, String label, Color colour, int numStudents)
            : base(name, label, colour)
        {
            m_numStudents = numStudents;
        }

        public int TotalStudents
        {
            get { return m_numStudents; }
            set { m_numStudents = value; }
        }

    }
}
