using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWATMS.Controls
{
    public class DataButton : Button
    {
        private Lecturer m_lecturer;
        private Room m_room;
        private Module m_module;
        private Group m_group;

        public DataButton(){}

        public Lecturer Lecturer
        {
            get { return m_lecturer; }
            set { m_lecturer = value; }
        }

        public Room Room
        {
            get { return m_room; }
            set { m_room = value; }
        }

        public Module Module
        {
            get { return m_module; }
            set { m_module = value; }
        }

        public Group Group
        {
            get { return m_group; }
            set { m_group = value; }
        }


    }
}
