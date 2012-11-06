using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWATMS
{
    public class Room : Data
    {
        private int m_capacity;
        private List<Boolean> m_equipmentList;

        public Room(String name, String label, Color colour, int capacity)
            : base(name, label, colour)
        {
            m_capacity = capacity;
        }

        public int Capacity
        {
            get { return m_capacity; }
            set { m_capacity = value; }
        }
    }
}
