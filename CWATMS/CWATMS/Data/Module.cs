using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Module : Data
    {
        private String m_courseLevel;

        /// <summary>
        /// Module constructor
        /// </summary>
        /// <param name="name">Name of Module</param>
        /// <param name="courseLevel">Course Level of the module</param>
        /// <param name="label">Shortened name for module</param>
        /// <param name="colour">Colour of module</param>
        public Module(String name, String courseLevel, String label, Color colour)
            : base(name, label, colour)
        {
            m_courseLevel = courseLevel;
        }

        /// <summary>
        /// Course Level of the module
        /// </summary>
        public String CourseLevel
        {
            get { return m_courseLevel; }
            set { m_courseLevel = value; }
        }
    }
}
