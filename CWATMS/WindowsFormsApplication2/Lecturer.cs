using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace WindowsFormsApplication2
{
    public class Lecturer : Data
    {
        private String m_surname;
        private int m_hoursPerWeek;

        /// <summary>
        /// Lecturer Constructor
        /// </summary>
        /// <param name="firstName">Lecturer's First Name</param>
        /// <param name="lastName">Lecturer's Surname</param>
        /// <param name="hoursPerWeek">Total of hours to work per week</param>
        /// <param name="label">Abbriviation of name</param>
        /// <param name="colour">Colour of data for display</param>
        public Lecturer(String firstName, String lastName, int hoursPerWeek, String label, Color colour)
            : base(firstName, label, colour)
        {
            m_surname = lastName;
            m_hoursPerWeek = hoursPerWeek;
        }

        public String Surname
        {
            get { return m_surname; }
            set { m_surname = value; }
        }

        public String FullName
        {
            get
            {
                return m_name + " " + m_surname;
            }
        }

        public String Initials
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(m_name[0]).Append(m_surname[0]);
                return sb.ToString();
            }
        }

        public int HoursPerWeek
        {
            get { return m_hoursPerWeek; }
            set { m_hoursPerWeek = value; }
        }

    }
}
