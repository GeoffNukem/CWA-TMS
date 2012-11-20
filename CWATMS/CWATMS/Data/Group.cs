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

        /// <summary>
        /// Group constructor.
        /// </summary>
        /// <param name="name">Name of the Group</param>
        /// <param name="label">Shortened name for the group</param>
        /// <param name="colour">Colour of group.</param>
        /// <param name="numStudents">Total number of students in the group</param>
        public Group(String name, String label, Color colour, int numStudents)
            : base(name, label, colour)
        {
            m_numStudents = numStudents;
        }

        /// <summary>
        /// Total number of students in the group
        /// </summary>
        public int TotalStudents
        {
            get { return m_numStudents; }
            set { m_numStudents = value; }
        }

    }
}
