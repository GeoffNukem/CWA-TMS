using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CWATMS
{
    public class Lecturer : Data
    {
        private int m_hoursPerWeek;

        /// <summary>
        /// Lecturer Constructor
        /// </summary>
        /// <param name="firstName">Lecturer's First Name</param>
        /// <param name="lastName">Lecturer's Surname</param>
        /// <param name="hoursPerWeek">Total of hours to work per week</param>
        /// <param name="label">Abbriviation of name</param>
        /// <param name="colour">Colour of data for display</param>
        public Lecturer(String name, int hoursPerWeek, String label, Color colour)
            : base(name, label, colour)
        {
            m_hoursPerWeek = hoursPerWeek;
        }

        /// <summary>
        /// Number of hours required per week.
        /// </summary>
        public int HoursPerWeek
        {
            get { return m_hoursPerWeek; }
            set { m_hoursPerWeek = value; }
        }

    }
}
