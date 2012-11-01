using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public abstract class Data
    {
        protected String m_name;
        protected String m_label;
        protected Color m_colour;

        /// <summary>
        /// Data Constructor
        /// </summary>
        /// <param name="name">Name of data</param>
        /// <param name="label">Abbriviation of name</param>
        /// <param name="colour">Colour of data for display</param>
        public Data(String name, String label, Color colour)
        {
            m_name = name;
            m_label = label;
            m_colour = colour;
            
        }

        /// <summary>
        /// Name of data
        /// </summary>
        public String Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// Abbriviation of Name
        /// </summary>
        public String Label
        {
            get { return m_label; }
            set { m_label = value; }
        }

        /// <summary>
        /// Colour of data for display
        /// </summary>
        public Color Colour
        {
            get { return m_colour; }
            set { m_colour = value; }
        }
    }
}
