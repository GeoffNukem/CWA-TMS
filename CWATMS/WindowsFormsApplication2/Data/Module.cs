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

        public Module(String name, String courseLevel, String label, Color colour)
            : base(name, label, colour)
        {
            m_courseLevel = courseLevel;
        }

        public String CourseLevel
        {
            get { return m_courseLevel; }
            set { m_courseLevel = value; }
        }
    }
}
